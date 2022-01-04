using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Resources;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Debug_Translator
{
    public partial class Debug_Translator : Form
    {
        //A dictionary that holds all the JP->EN pairs from the external Excel file
        public Dictionary<string, string> Dict = new Dictionary<string, string>();

        //The filename of the Excel dictionary
        public string DictionaryFilename;
        public string DBGFilename;

        //Two things here to help in parsing & checking for remaining Japanese
        public string[] COMMA = new string[] { "COMMA" };
        public Encoding ASCII = Encoding.ASCII;
        
        //To speed up reading of data from the Excel dictionary file,
        //I found a method online to store all values from excel in an object.
        //This is the variable for that object, which holds the values from excel.
        public object[,] values;

        public ResourceManager resourceManager = new ResourceManager("Debug_Translator.Languages", Assembly.GetExecutingAssembly());

        public string currentLanguage = "_jp";

        public Debug_Translator()
        {
            InitializeComponent();
        }

                
        //This is the little function that is the backbone of the program.  It replaces Japanese characters with English.
        public string ReplaceJP(string line)
        {
            foreach (var item in Dict)
            {
                line = line.Replace(item.Key, item.Value);
            }
            return line;
        }

               
        //This turns spaces into tabs, in the lines from the DBG file.  It is necessary for parsing.
        private string TurnSpacesToTabs(string line)
        {
            string a = line.Replace("    ", "\t");
            string b = a.Replace("   ", "\t");
            string c = b.Replace("\t  ", "\t");
            string d = c.Replace("  \t", "\t");
            string e = d.Replace("  ", "\t");
            return e;
        }
               
        
        //This checks if the string (after translation) actually contains all English characters
        public bool IsAllEng(string str)
        {
            string crazy_chars = "┌└└┌↓↑⇒→⇔｜│★①②③④⑤＋×－Δ～■＞≧∞●℃☆Φ≠２";
            foreach (var c in crazy_chars.ToCharArray())
            {
                str = str.Replace(c, ' ');
            }
            Byte[] encodedBytes = ASCII.GetBytes(str);
            foreach (Byte b in encodedBytes)
            {
                if (b == 63) { return false; } ;
            }
            return true;
        }
        

        private void TranslateDBG_Click(object sender, EventArgs e)
        {
            string ResultFile = "";
            bool foundError = false;
            List<string> alreadyAdded = new List<string>();
            List<string[]> additionalRows = new List<string[]>();

            List<string> Results = new List<string>();


            PutSortedChartContentsIntoArray();
            ResultFile = ChooseDbgDialog.FileName.Replace(".dbg", "_EN.dbg");
            var DBG = File.ReadAllLines(ChooseDbgDialog.FileName, Encoding.Default);

            TranslationProgress.Maximum = DBG.Length;
            foreach (var line in DBG)
            {
                var noSpaces = TurnSpacesToTabs(line);
                var splitLine = noSpaces.Split('\t');
                for (var segment = 0; segment < splitLine.Length; segment++)
                {
                    splitLine[segment] = ReplaceJP(splitLine[segment]);
                }
                Results.Add(string.Join("\t", splitLine));

                TranslationProgress.Value += 1;
            }
            File.WriteAllLines(ResultFile, Results, Encoding.Default);

            var DBG_Translated = File.ReadAllLines(ResultFile);
            int linecount = 0;
            foreach (var line in DBG_Translated)
            {
                try
                {
                    string EClean = TurnSpacesToTabs(line);
                    string JClean = TurnSpacesToTabs(DBG[linecount]);
                    var ESplit = EClean.Split('\t');
                    var JSplit = JClean.Split('\t');
                    for (var segment = 0; segment < ESplit.Length; segment++)
                    {
                        if (IsAllEng(ESplit[segment]) != true)
                        {
                            if ((JSplit[segment].Length > 1) && (alreadyAdded.IndexOf(JSplit[segment]) < 0) && (!Dict.ContainsKey(JSplit[segment].Trim(' '))))
                            {
                                string data = "";
                                for (var p = 4; p < JSplit.Length; p++)
                                // JSplit is an array that contains the whole line from the debug file.  Generally, after the 4th place in the array, the variable information starts
                                // This "p" variable used to be 12, but I changed it to 4, as the customer said that sometimes variable information was being captured and sometimes it wasn't
                                {
                                    data += JSplit[p] + "  ";
                                }
                                string[] additionalRow = { JSplit[segment].Trim(' '), "", data.Trim(' '), "", "" };
                                additionalRows.Add(additionalRow);
                                foundError = true;
                                alreadyAdded.Add(JSplit[segment]);
                            }
                        }
                    }
                    linecount += 1;
                }
                catch { }
            }
            if (foundError)
            {
                ReadWriteExcel("write", additionalRows);
                Close();
            }
            else 
            { 
                MessageBox.Show(resourceManager.GetString(String.Format("{0}{1}", "Complete", currentLanguage)));
                Close();
            }
            
        }




        //Once we have all the Excel file dictionary contents in the hidden chart in the app window, we sort them, then put that 
        //sorted information into the list "Dict".  This list (Dict) will be what we actually use when translating.
        public void PutSortedChartContentsIntoArray()
        {
            //put the length of each japanese string itno column 1 in the chart
            for (var r = 0; r < DictChart.Rows.Count - 1; r++)
            {
                DictChart.Rows[r].Cells[0].Value = DictChart.Rows[r].Cells[1].Value.ToString().Length;
                // And while we're at it...
                // In late July, the customer suddenly said "If the dictionary contains a Japanese entry with a blank English counterpart, we just want
                // the Japanese entry to be placed into the debug file as-is."
                // This means that, here, we have to check all the pairs in column 1 and 2 of the chart (the ja and en columns) 
                // If column 1 is not blank and column 2 is blank, we copy it.
                if ((DictChart.Rows[r].Cells[1].Value.ToString().Length > 0) && (DictChart.Rows[r].Cells[2].Value.ToString().Length < 1))
                {
                    DictChart.Rows[r].Cells[2].Value = DictChart.Rows[r].Cells[1].Value;
                }
                // There.  It's copied.
            }
            //sort by that length just input into column 1
            DictChart.Sort(DictChart.Columns[0], System.ComponentModel.ListSortDirection.Descending);
            //add each chart value to the KEY-VALUE dictionary called "Dict"
            for (var r = 0; r < DictChart.Rows.Count - 1; r++)
            {
                if (Dict.ContainsKey(DictChart.Rows[r].Cells[1].Value.ToString())) { continue; }
                if (DictChart.Rows[r].Cells[2].Value != null)
                { 
                    Dict.Add(DictChart.Rows[r].Cells[1].Value.ToString(), DictChart.Rows[r].Cells[2].Value.ToString());
                }
            }
        }


        //Here, we choose the Excel file, and put the contents into the hidden chart in the app window.
        private void ChooseDictionary_Click(object sender, EventArgs e)
        {
            ChooseDictionaryDialog.Filter = "*.xlsx|*.xlsx|All files(*.*)|*.*";
            if (ChooseDictionaryDialog.ShowDialog() == DialogResult.OK)
            {
                DictionaryFilename = ChooseDictionaryDialog.FileName;
                DictionaryLabel.Text = ChooseDictionaryDialog.SafeFileName;
                ReadingDictionary.Visible = true;
                ReadingDictionaryProgress.Visible = true;
                ReadWriteExcel("read", null);
                ChooseDBG.Enabled = true;
                ChooseDictionary.Enabled = false;
            }
        }

        private void ChooseDBG_Click(object sender, EventArgs e)
        {
            ChooseDbgDialog.Filter = "*.dbg|*.dbg|All files(*.*)|*.*";
            if (ChooseDbgDialog.ShowDialog() == DialogResult.OK)
            {
                DBGFilename = ChooseDbgDialog.FileName;
                DBGLabel.Text = ChooseDbgDialog.SafeFileName;
                ChooseDBG.Enabled = false;
                TranslateDBG.Enabled = true;
            }
        }

        //Here is the function that will either read or write to the existing Excel dictionary file
        public void ReadWriteExcel(string readOrWrite, List<string[]> rowsToWrite)
        {



            var oXL = new Microsoft.Office.Interop.Excel.Application()
            {
                Visible = false,
                DisplayAlerts = false
            };

            var ExcelDictionary = oXL.Workbooks.Open(DictionaryFilename, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            var ExcelDictionaryWorksheets = ExcelDictionary.Worksheets;
            var DictionarySheet = (Microsoft.Office.Interop.Excel.Worksheet) ExcelDictionaryWorksheets.get_Item("Sheet1");


            Microsoft.Office.Interop.Excel.Range range = DictionarySheet.get_Range("A1", "E10000");
            values = (object[,])range.Value2;

            int rowCount = 0;
            for (int index = 2; index < 10000; index++)
            {
                if (Convert.ToString(values[index, 1]) == "")
                {
                    rowCount = index;
                    break;
                }
            }
            if (readOrWrite == "read")
            {
                ReadingDictionaryProgress.Maximum = rowCount;
                //Before translation is carried out, we need to get all the word pairs from the external Excel file, and
                //put them into a hidden chart in the app window.  Why do we do this?  Because, using the hidden chart, we can 
                //sort the word pairs by length (of the Japanese segment), before actually trying translation.
                for (int index = 2; index <= rowCount-1; index++)
                {
                    string j = "";
                    string e = "";
                    string v = "";
                    string je = "";
                    string ee = "";
                    string jLength = "";

                    jLength = getValue(index, 1).Length.ToString();
                    j = getValue(index, 1);
                    e = getValue(index, 2);
                    v = getValue(index, 3);
                    je = getValue(index, 4);
                    ee = getValue(index, 5);

                    string[] objectsForRow = { jLength, j, e, v, je, ee };
                    DictChart.Rows.Add(objectsForRow);
                    ReadingDictionaryProgress.Value = index;
                }
                ReadingDictionary.Visible = false;
                ReadingDictionaryProgress.Visible = false;
            }
            else
            {
                ErrorProgress.Maximum = rowsToWrite.Count;
                int nowWriting = 0;
                for (int index = rowCount; index < rowCount + rowsToWrite.Count; index++)
                {
                    string[] thisRow = rowsToWrite[nowWriting];

                    DictionarySheet.Cells[1][index].Value = ChangeEqualHead(thisRow[0]);
                    DictionarySheet.Cells[2][index].Value = ChangeEqualHead(thisRow[1]);
                    DictionarySheet.Cells[3][index].Value = ChangeEqualHead(thisRow[2]);
                    DictionarySheet.Cells[4][index].Value = ChangeEqualHead(thisRow[3]);
                    DictionarySheet.Cells[5][index].Value = ChangeEqualHead(thisRow[4]);

                    nowWriting += 1;
                    ErrorProgress.Value = nowWriting;
                }
                MessageBox.Show(resourceManager.GetString(String.Format("{0}{1}", "Problem", currentLanguage)));
            }

            ExcelDictionary.Save();
            ExcelDictionary.Close(Missing.Value, Missing.Value, Missing.Value);
            DictionarySheet = null;
            ExcelDictionary = null;
            oXL.Quit();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            if (readOrWrite == "write")
            {
                Process.Start(DictionaryFilename);
            }
        }

        // This gets the value from the "values" object (which holds all the excel sheet information)
        public string getValue(int index, int number)
        {
            try
            {
                return Convert.ToString(values[index, number]);
            }
            catch
            {
                return "";
            }
        }

        public string ChangeEqualHead(string s)
        {
            if (s.Length > 0)
            {
                if (s.ToCharArray()[0] == '=')
                {
                    var regex = new Regex(Regex.Escape("="));
                    string f = regex.Replace(s, "'=", 1);
                    return f;
                }
            }
            return s;
        }


        public void ChangeLanguage(string which)
        {
            foreach (Control group in this.Controls)
            {
                if ((group.Name != "DictionaryLabel") && (group.Name != "DBGLabel"))
                {
                    group.Text = resourceManager.GetString(String.Format("{0}{1}", group.Name, which));
                }
            }
        }

        private void languageSelector_Click(object sender, EventArgs e)
        {
            if (currentLanguage == "_en")
            {
                ChangeLanguage("_jp");
                currentLanguage = "_jp";
            }
            else
            {
                ChangeLanguage("_en");
                currentLanguage = "_en";
            }
        }


    }
}
