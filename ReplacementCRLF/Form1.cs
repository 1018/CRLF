using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;


namespace ReplacementCRLF
{
    public partial class Form1 : Form
    {
        #region コンストラクタ
        public Form1()
        {
            InitializeComponent();
        }
        #endregion


        #region ｸﾗｽ・定義
        public class FilePath
        {
            public string InFile        { get; set; }
            public string InFileName    { get; set; }
            public string OutDir        { get; set; }
            public string SelectedPath  { get; set; }
        } 

        public class ConvertedData
        {
            public List<string> AddData { get; set; }
            public bool IsError { get; set; }
        }

        public class Log
        {
            public int ConvertedCount { get; set; }
        }

        abstract class myConstants
        {
            public const string HeaderIn = " [IN       ] ";
            public const string HeaderOut = " [OUT      ] ";
            public const string HeaderDirection = " [DIRECTION] ";
            public const string HeaderCount = " [COUNT    ] ";
            public const string LogFilePath = @"\log\ReplacementCRLF.log";
        }

        private char[] trims = { '\r', '\n' };
        #endregion

        FilePath CurrentFile = new FilePath();
        ConvertedData NewLine = new ConvertedData();
        Timer timer = new Timer();
        Log ConvertedLog = new Log();        


        #region フォーム
        #region Drag & Drop
        /// <summary>
        /// InputFilePath内にﾄﾞﾗｯｸﾞしたときの動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputFile_DragEnter(object sender, DragEventArgs e)
        {
            string[] fileNameArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (!e.Data.GetDataPresent(System.Windows.Forms.DataFormats.FileDrop))
            {
                // ファイル以外のドラッグは受け入れない
                e.Effect = DragDropEffects.None;
                return;
            }

            if (fileNameArray.Length > 1)
            {
                // 複数ファイルのドラッグは受け入れない
                e.Effect = DragDropEffects.None;
                return;
            }
            if (Path.GetExtension(fileNameArray[0]) != ".txt")
            {
                // 拡張子が.txt以外は受け入れない
                e.Effect = DragDropEffects.None;
                return;
            }

            // 上記以外は受け入れる
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// InputFilePath内にﾄﾞﾛｯﾌﾟしたときの動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNameArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string fileName = fileNameArray[0];

            this.InputFile.Text = fileName;

            // ﾌｧｲﾙ名取得
            CurrentFile.InFileName = Path.GetFileNameWithoutExtension(fileName);
            this.OutputDir.Text = Path.GetDirectoryName(fileName);
        }
        #endregion

        #region Select
        /// <summary>
        /// "参照"ﾎﾞﾀﾝｸﾘｯｸ時の動作です
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void InputFileSelect_Click(object sender, EventArgs e)
        {
            // OpenFileDialogｸﾗｽのｲﾝｽﾀﾝｽ作成
            OpenFileDialog ofd = new OpenFileDialog();

            // はじめのﾌｧｲﾙ名指定
            //            ofd.FileName = Constants.LogFileName;
            // はじめに表示されるDir指定(ｶﾚﾝﾄDir)            
            ofd.InitialDirectory = @"C\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter =
                "TXTファイル(*.text;*.txt)|*.text;*.txt";
            // [ﾌｧｲﾙの種類]ではじめに
            //「すべてのﾌｧｲﾙ」が選択されているようにする
            ofd.FilterIndex = 2;
            // ﾀｲﾄﾙ設定
            ofd.Title = "開くファイルを選択してください";
            // ﾀﾞｲｱﾛｸﾞﾎﾞｯｸｽを閉じる前に現在のDirを復元するようにする
            ofd.RestoreDirectory = true;
            // 存在しないﾌｧｲﾙの名前が指定されたとき警告を表示する
            ofd.CheckFileExists = true;
            // 存在しないﾊﾟｽが指定されたとき警告を表示する
            ofd.CheckPathExists = true;

            // ﾀﾞｲｱﾛｸﾞ表示
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CurrentFile.InFile = ofd.FileName;
                this.InputFile.Text = CurrentFile.InFile;
                // ﾌｧｲﾙ名取得
                CurrentFile.InFileName = Path.GetFileNameWithoutExtension(CurrentFile.InFile);
                this.OutputDir.Text = Path.GetDirectoryName(CurrentFile.InFile);
            }

        }

        /// <summary>
        /// 出力先ﾃﾞｨﾚｸﾄﾘを指定します
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void OutputDirSelect_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            //デフォルトでDesktop
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //最初に選択するフォルダを指定する
            //RootFolder以下にあるフォルダである必要がある
            fbd.SelectedPath = System.IO.Directory.GetCurrentDirectory();
            //ユーザーが新しいフォルダを作成できるようにする
            //デフォルトでTrue
            fbd.ShowNewFolderButton = true;

            //ダイアログを表示する
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                CurrentFile.SelectedPath = fbd.SelectedPath;
                //選択されたフォルダを表示する
                this.OutputDir.Text = CurrentFile.SelectedPath;
            }


        }
        #endregion

        /// <summary>
        /// 変換開始ﾎﾞﾀﾝｸﾘｯｸ時の動作です。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConvertStartBtn_Click(object sender, EventArgs e)
        {

            // OpenFileDialogｸﾗｽのｲﾝｽﾀﾝｽ作成
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = this.InputFile.Text;

            System.IO.Stream stream = ofd.OpenFile();
            //内容を読み込む
            System.IO.StreamReader sr =
                new System.IO.StreamReader(
                    stream,
                    System.Text.Encoding.GetEncoding("shift-jis"));


            if (this.OutputDir.Text == "")
            {
                this.OutputDir.Text = Directory.GetCurrentDirectory();
            }

            // ﾌｧｲﾙ作成
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                this.OutputDir.Text + @"\" + CurrentFile.InFileName + "new.txt",
                true,
                System.Text.Encoding.GetEncoding("shift-jis"));

            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                NewLine.AddData = new List<string>();

                string buf = line.Replace("\r", "").Replace("\n", "");
                NewLine.AddData.Add(buf);
                
                if (this.CRLF2LF.Checked)
                {
                    NewLine.AddData.Add("\r");
                    NewLine.IsError = true;
                }
                else if (this.LF2CRLF.Checked)
                {
                    NewLine.AddData.Add("\r\n");
                    NewLine.IsError = true;
                }
                else
                {
                    MessageBox.Show("変換方法を選択してください",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    NewLine.IsError = false;
                    break;
                }

                NewLine.AddData.ForEach((string str) => sw.Write(str));
                ConvertedLog.ConvertedCount++;
            }
            sr.Close();
            sw.Close();
            stream.Close();

            if (NewLine.IsError == true)
            {
                MessageBox.Show("変換が完了しました！",
                                "完了",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            UpdateLog();
        }
        #endregion


        /// <summary>
        /// ログ更新
        /// </summary>
        private void UpdateLog()
        {
            // ﾌｧｲﾙ作成
            System.IO.StreamWriter logFile = new System.IO.StreamWriter(
                Directory.GetCurrentDirectory() + myConstants.LogFilePath,
                true,
                System.Text.Encoding.GetEncoding("shift-jis"));
 
            logFile.Write(System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff"));
            logFile.Write(myConstants.HeaderIn);
            logFile.WriteLine(this.InputFile.Text);


            logFile.Write(System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff"));
            logFile.Write(myConstants.HeaderOut);
            logFile.WriteLine(this.OutputDir.Text + @"\" + 
                CurrentFile.InFileName + "new.txt");


            logFile.Write(System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff"));
            logFile.Write(myConstants.HeaderDirection);
            if (this.CRLF2LF.Checked)
            {
                logFile.WriteLine("CRLF→LF");
            }
            else if (this.LF2CRLF.Checked)
            {
                logFile.WriteLine("LF→CRLF");
            }
            else
            {
                logFile.WriteLine("ERROR");
            }


            logFile.Write(System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff"));
            logFile.Write(myConstants.HeaderCount);
            logFile.WriteLine(ConvertedLog.ConvertedCount);
            logFile.Close();

        }


    }
}
// EOF