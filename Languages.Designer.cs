﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debug_Translator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Languages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Languages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Debug_Translator.Languages", typeof(Languages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose *.dbg file.
        /// </summary>
        internal static string ChooseDBG_en {
            get {
                return ResourceManager.GetString("ChooseDBG_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DBGファイルを選択する.
        /// </summary>
        internal static string ChooseDBG_jp {
            get {
                return ResourceManager.GetString("ChooseDBG_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose dictionary.
        /// </summary>
        internal static string ChooseDictionary_en {
            get {
                return ResourceManager.GetString("ChooseDictionary_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 辞書ファイルを選択する.
        /// </summary>
        internal static string ChooseDictionary_jp {
            get {
                return ResourceManager.GetString("ChooseDictionary_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Chosen *.dbg file:.
        /// </summary>
        internal static string ChosenDBG_en {
            get {
                return ResourceManager.GetString("ChosenDBG_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DBGファイル.
        /// </summary>
        internal static string ChosenDBG_jp {
            get {
                return ResourceManager.GetString("ChosenDBG_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Chosen dictionary:.
        /// </summary>
        internal static string ChosenDictionary_en {
            get {
                return ResourceManager.GetString("ChosenDictionary_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 辞書ファイル.
        /// </summary>
        internal static string ChosenDictionary_jp {
            get {
                return ResourceManager.GetString("ChosenDictionary_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Translation is complete.  The translated file has been saved in the original location with the same name as the original debug file + &quot;_en.dbg&quot;..
        /// </summary>
        internal static string Complete_en {
            get {
                return ResourceManager.GetString("Complete_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 翻訳が終了です。デバグファイルは元のファイル名 + _EN.dbg として元のところに保存しております。.
        /// </summary>
        internal static string Complete_jp {
            get {
                return ResourceManager.GetString("Complete_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Language:.
        /// </summary>
        internal static string languageLabel_en {
            get {
                return ResourceManager.GetString("languageLabel_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 言語設定.
        /// </summary>
        internal static string languageLabel_jp {
            get {
                return ResourceManager.GetString("languageLabel_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 日本語.
        /// </summary>
        internal static string languageSelector_en {
            get {
                return ResourceManager.GetString("languageSelector_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to English.
        /// </summary>
        internal static string languageSelector_jp {
            get {
                return ResourceManager.GetString("languageSelector_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Detecting untranslated segments and writing to Excel file.
        /// </summary>
        internal static string ListupProgress_en {
            get {
                return ResourceManager.GetString("ListupProgress_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 未翻訳文のリストアップ.
        /// </summary>
        internal static string ListupProgress_jp {
            get {
                return ResourceManager.GetString("ListupProgress_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Some parts of the debug file could not be translated, because the words did not exist in the dictionary.  Please open the dictionary file in Excel and add the missing words, then try translation again..
        /// </summary>
        internal static string Problem_en {
            get {
                return ResourceManager.GetString("Problem_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DBG ファイルで辞書に存在しないため、翻訳できないところがありました。エクセルで辞書を開いて、対訳を入力し、もう一回DBGファイルを翻訳してください。.
        /// </summary>
        internal static string Problem_jp {
            get {
                return ResourceManager.GetString("Problem_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Translation progress:.
        /// </summary>
        internal static string ProgressLabel_en {
            get {
                return ResourceManager.GetString("ProgressLabel_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 翻訳の進行.
        /// </summary>
        internal static string ProgressLabel_jp {
            get {
                return ResourceManager.GetString("ProgressLabel_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reading dictionary....
        /// </summary>
        internal static string ReadingDictionary_en {
            get {
                return ResourceManager.GetString("ReadingDictionary_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 辞書の内容の読み込み中.
        /// </summary>
        internal static string ReadingDictionary_jp {
            get {
                return ResourceManager.GetString("ReadingDictionary_jp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Translate.
        /// </summary>
        internal static string TranslateDBG_en {
            get {
                return ResourceManager.GetString("TranslateDBG_en", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 翻訳開始.
        /// </summary>
        internal static string TranslateDBG_jp {
            get {
                return ResourceManager.GetString("TranslateDBG_jp", resourceCulture);
            }
        }
    }
}
