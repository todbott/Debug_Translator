namespace Debug_Translator
{
    partial class Debug_Translator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debug_Translator));
            this.ChooseDbgDialog = new System.Windows.Forms.OpenFileDialog();
            this.TranslateDBG = new System.Windows.Forms.Button();
            this.ChooseDictionary = new System.Windows.Forms.Button();
            this.ChooseDictionaryDialog = new System.Windows.Forms.OpenFileDialog();
            this.ChosenDictionary = new System.Windows.Forms.Label();
            this.DictionaryLabel = new System.Windows.Forms.Label();
            this.TranslationProgress = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.ListupProgress = new System.Windows.Forms.Label();
            this.ErrorProgress = new System.Windows.Forms.ProgressBar();
            this.DictChart = new System.Windows.Forms.DataGridView();
            this.len = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FJM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageSelector = new System.Windows.Forms.Button();
            this.ReadingDictionary = new System.Windows.Forms.Label();
            this.ReadingDictionaryProgress = new System.Windows.Forms.ProgressBar();
            this.languageLabel = new System.Windows.Forms.Label();
            this.ChooseDBG = new System.Windows.Forms.Button();
            this.ChosenDBG = new System.Windows.Forms.Label();
            this.DBGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DictChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseDbgDialog
            // 
            this.ChooseDbgDialog.FileName = "DBGFile";
            // 
            // TranslateDBG
            // 
            this.TranslateDBG.Enabled = false;
            this.TranslateDBG.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TranslateDBG.Location = new System.Drawing.Point(13, 113);
            this.TranslateDBG.Name = "TranslateDBG";
            this.TranslateDBG.Size = new System.Drawing.Size(209, 82);
            this.TranslateDBG.TabIndex = 0;
            this.TranslateDBG.Text = "翻訳開始";
            this.TranslateDBG.UseVisualStyleBackColor = true;
            this.TranslateDBG.Click += new System.EventHandler(this.TranslateDBG_Click);
            // 
            // ChooseDictionary
            // 
            this.ChooseDictionary.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChooseDictionary.Location = new System.Drawing.Point(13, 12);
            this.ChooseDictionary.Name = "ChooseDictionary";
            this.ChooseDictionary.Size = new System.Drawing.Size(209, 35);
            this.ChooseDictionary.TabIndex = 1;
            this.ChooseDictionary.Text = "辞書ファイルを選択する";
            this.ChooseDictionary.UseVisualStyleBackColor = true;
            this.ChooseDictionary.Click += new System.EventHandler(this.ChooseDictionary_Click);
            // 
            // ChooseDictionaryDialog
            // 
            this.ChooseDictionaryDialog.FileName = "DictionaryFile";
            // 
            // ChosenDictionary
            // 
            this.ChosenDictionary.AutoSize = true;
            this.ChosenDictionary.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChosenDictionary.Location = new System.Drawing.Point(231, 12);
            this.ChosenDictionary.Name = "ChosenDictionary";
            this.ChosenDictionary.Size = new System.Drawing.Size(91, 16);
            this.ChosenDictionary.TabIndex = 2;
            this.ChosenDictionary.Text = "辞書ファイル";
            // 
            // DictionaryLabel
            // 
            this.DictionaryLabel.AutoSize = true;
            this.DictionaryLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DictionaryLabel.Location = new System.Drawing.Point(231, 31);
            this.DictionaryLabel.Name = "DictionaryLabel";
            this.DictionaryLabel.Size = new System.Drawing.Size(24, 16);
            this.DictionaryLabel.TabIndex = 3;
            this.DictionaryLabel.Text = "--";
            // 
            // TranslationProgress
            // 
            this.TranslationProgress.Location = new System.Drawing.Point(233, 137);
            this.TranslationProgress.Name = "TranslationProgress";
            this.TranslationProgress.Size = new System.Drawing.Size(443, 10);
            this.TranslationProgress.TabIndex = 6;
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProgressLabel.Location = new System.Drawing.Point(231, 113);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(85, 16);
            this.ProgressLabel.TabIndex = 7;
            this.ProgressLabel.Text = "翻訳の進行";
            // 
            // ListupProgress
            // 
            this.ListupProgress.AutoSize = true;
            this.ListupProgress.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ListupProgress.Location = new System.Drawing.Point(228, 158);
            this.ListupProgress.Name = "ListupProgress";
            this.ListupProgress.Size = new System.Drawing.Size(150, 16);
            this.ListupProgress.TabIndex = 8;
            this.ListupProgress.Text = "未翻訳文のリストアップ";
            // 
            // ErrorProgress
            // 
            this.ErrorProgress.Location = new System.Drawing.Point(231, 185);
            this.ErrorProgress.Name = "ErrorProgress";
            this.ErrorProgress.Size = new System.Drawing.Size(443, 10);
            this.ErrorProgress.TabIndex = 9;
            // 
            // DictChart
            // 
            this.DictChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DictChart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.len,
            this.JA,
            this.English,
            this.Data,
            this.FJM,
            this.FEM});
            this.DictChart.Location = new System.Drawing.Point(652, 67);
            this.DictChart.Name = "DictChart";
            this.DictChart.RowTemplate.Height = 21;
            this.DictChart.Size = new System.Drawing.Size(24, 21);
            this.DictChart.TabIndex = 10;
            this.DictChart.Visible = false;
            // 
            // len
            // 
            this.len.HeaderText = "Len.";
            this.len.Name = "len";
            this.len.Visible = false;
            this.len.Width = 50;
            // 
            // JA
            // 
            this.JA.HeaderText = "日本語";
            this.JA.Name = "JA";
            this.JA.Width = 150;
            // 
            // English
            // 
            this.English.HeaderText = "英語";
            this.English.Name = "English";
            this.English.Width = 150;
            // 
            // Data
            // 
            this.Data.HeaderText = "関数";
            this.Data.Name = "Data";
            this.Data.Width = 250;
            // 
            // FJM
            // 
            this.FJM.HeaderText = "日本語の意味の説明";
            this.FJM.Name = "FJM";
            this.FJM.Width = 275;
            // 
            // FEM
            // 
            this.FEM.HeaderText = "英語の意味の説明";
            this.FEM.Name = "FEM";
            this.FEM.Width = 275;
            // 
            // languageSelector
            // 
            this.languageSelector.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.languageSelector.Location = new System.Drawing.Point(590, 31);
            this.languageSelector.Name = "languageSelector";
            this.languageSelector.Size = new System.Drawing.Size(92, 30);
            this.languageSelector.TabIndex = 11;
            this.languageSelector.Text = "English";
            this.languageSelector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.languageSelector.UseVisualStyleBackColor = true;
            this.languageSelector.Click += new System.EventHandler(this.languageSelector_Click);
            // 
            // ReadingDictionary
            // 
            this.ReadingDictionary.AutoSize = true;
            this.ReadingDictionary.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReadingDictionary.Location = new System.Drawing.Point(409, 12);
            this.ReadingDictionary.Name = "ReadingDictionary";
            this.ReadingDictionary.Size = new System.Drawing.Size(174, 16);
            this.ReadingDictionary.TabIndex = 12;
            this.ReadingDictionary.Text = "辞書の内容の読み込み中";
            this.ReadingDictionary.Visible = false;
            // 
            // ReadingDictionaryProgress
            // 
            this.ReadingDictionaryProgress.Location = new System.Drawing.Point(409, 37);
            this.ReadingDictionaryProgress.Name = "ReadingDictionaryProgress";
            this.ReadingDictionaryProgress.Size = new System.Drawing.Size(169, 10);
            this.ReadingDictionaryProgress.TabIndex = 13;
            this.ReadingDictionaryProgress.Visible = false;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.languageLabel.Location = new System.Drawing.Point(599, 12);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(72, 16);
            this.languageLabel.TabIndex = 14;
            this.languageLabel.Text = "言語設定";
            // 
            // ChooseDBG
            // 
            this.ChooseDBG.Enabled = false;
            this.ChooseDBG.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChooseDBG.Location = new System.Drawing.Point(12, 62);
            this.ChooseDBG.Name = "ChooseDBG";
            this.ChooseDBG.Size = new System.Drawing.Size(209, 35);
            this.ChooseDBG.TabIndex = 15;
            this.ChooseDBG.Text = "DBGファイルを選択する";
            this.ChooseDBG.UseVisualStyleBackColor = true;
            this.ChooseDBG.Click += new System.EventHandler(this.ChooseDBG_Click);
            // 
            // ChosenDBG
            // 
            this.ChosenDBG.AutoSize = true;
            this.ChosenDBG.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChosenDBG.Location = new System.Drawing.Point(231, 62);
            this.ChosenDBG.Name = "ChosenDBG";
            this.ChosenDBG.Size = new System.Drawing.Size(91, 16);
            this.ChosenDBG.TabIndex = 16;
            this.ChosenDBG.Text = "DBGファイル";
            // 
            // DBGLabel
            // 
            this.DBGLabel.AutoSize = true;
            this.DBGLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DBGLabel.Location = new System.Drawing.Point(231, 81);
            this.DBGLabel.Name = "DBGLabel";
            this.DBGLabel.Size = new System.Drawing.Size(24, 16);
            this.DBGLabel.TabIndex = 17;
            this.DBGLabel.Text = "--";
            // 
            // Debug_Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 209);
            this.Controls.Add(this.DBGLabel);
            this.Controls.Add(this.ChosenDBG);
            this.Controls.Add(this.ChooseDBG);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.ReadingDictionaryProgress);
            this.Controls.Add(this.ReadingDictionary);
            this.Controls.Add(this.languageSelector);
            this.Controls.Add(this.DictChart);
            this.Controls.Add(this.ErrorProgress);
            this.Controls.Add(this.ListupProgress);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.TranslationProgress);
            this.Controls.Add(this.DictionaryLabel);
            this.Controls.Add(this.ChosenDictionary);
            this.Controls.Add(this.ChooseDictionary);
            this.Controls.Add(this.TranslateDBG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Debug_Translator";
            this.Text = "Debug_Translator_v1.0.2";
            ((System.ComponentModel.ISupportInitialize)(this.DictChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ChooseDbgDialog;
        private System.Windows.Forms.Button TranslateDBG;
        private System.Windows.Forms.Button ChooseDictionary;
        private System.Windows.Forms.OpenFileDialog ChooseDictionaryDialog;
        private System.Windows.Forms.Label ChosenDictionary;
        private System.Windows.Forms.Label DictionaryLabel;
        private System.Windows.Forms.ProgressBar TranslationProgress;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.Label ListupProgress;
        private System.Windows.Forms.ProgressBar ErrorProgress;
        private System.Windows.Forms.DataGridView DictChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn len;
        private System.Windows.Forms.DataGridViewTextBoxColumn JA;
        private System.Windows.Forms.DataGridViewTextBoxColumn English;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn FJM;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEM;
        private System.Windows.Forms.Button languageSelector;
        private System.Windows.Forms.Label ReadingDictionary;
        private System.Windows.Forms.ProgressBar ReadingDictionaryProgress;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Button ChooseDBG;
        private System.Windows.Forms.Label ChosenDBG;
        private System.Windows.Forms.Label DBGLabel;
    }
}

