using System.Diagnostics;
using System.Text;

namespace SimpleConvertJarToExe
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 標準出力
        /// </summary>
        private string Output { get; set; } = string.Empty;

        /// <summary>
        /// 標準エラー
        /// </summary>
        private string OutputError { get; set; } = string.Empty;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exe変換ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void ExeConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Exe変換ボタンを非活性にする。
                ExeConvertButton.Enabled = false;

                DialogResult result = MessageBox.Show(
                "Exeに変換しますか？",
                "Exe変換確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                if (result != DialogResult.Yes)
                {
                    return;
                }

                Output = string.Empty;

                // チェック処理
                // 作業フォルダパス
                if (string.IsNullOrEmpty(WorkFolderPathTextBox.Text))
                {
                    MessageBox.Show(
                        "作業フォルダパスが未入力です。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (!Directory.Exists(WorkFolderPathTextBox.Text))
                {
                    MessageBox.Show(
                        "作業フォルダパスが存在しません。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }

                // 対象Jarファイルパス
                if (string.IsNullOrEmpty(JarFilePathTextBox.Text))
                {
                    MessageBox.Show(
                        "対象Jarファイルパスが未入力です。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (!File.Exists(JarFilePathTextBox.Text))
                {
                    MessageBox.Show(
                        "対象Jarファイルが存在しません。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }

                // JREパス
                if (string.IsNullOrEmpty(JrePathTextBox.Text))
                {
                    MessageBox.Show(
                        "JREパスが未入力です。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (!Directory.Exists(JrePathTextBox.Text))
                {
                    MessageBox.Show(
                        "JREパスが存在しません。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }

                // メインクラス
                if (string.IsNullOrEmpty(MainClassTextBox.Text))
                {
                    MessageBox.Show(
                        "メインクラスが未入力です。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }

                // 名称
                if (string.IsNullOrEmpty(NameTextBox.Text))
                {
                    MessageBox.Show(
                        "名称が未入力です。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }

                // バージョン
                if (string.IsNullOrEmpty(VersionTextBox.Text))
                {
                    MessageBox.Show(
                        "バージョンが未入力です。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }
                else if (!decimal.TryParse(VersionTextBox.Text, out _))
                {
                    MessageBox.Show(
                        "バージョンには、数値を入力して下さい。",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    return;
                }

                // アイコンパス
                string iconPath = string.Empty;
                if (!string.IsNullOrEmpty(IconPathTextBox.Text))
                {
                    // ドライブを、大文字に変換し、保持する。
                    iconPath = string.Concat(IconPathTextBox.Text[0].ToString().ToUpper(), IconPathTextBox.Text.Substring(1));

                    if (!File.Exists(iconPath))
                    {
                        MessageBox.Show(
                            "アイコンが存在しません。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                        return;
                    }
                }

                // モジュールパス
                string modulePath = string.Empty;
                if (!string.IsNullOrEmpty(ModulePathTextBox.Text))
                {
                    // ドライブを、大文字に変換し、保持する。
                    modulePath = string.Concat(ModulePathTextBox.Text[0].ToString().ToUpper(), ModulePathTextBox.Text.Substring(1));

                    if (!Directory.Exists(modulePath))
                    {
                        MessageBox.Show(
                            "モジュールパスが存在しません。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                        return;
                    }
                }

                // ドライブ文字を、大文字に変換し、保持する。
                string workFolderPath = string.Concat(WorkFolderPathTextBox.Text[0].ToString().ToUpper(), WorkFolderPathTextBox.Text.Substring(1));

                LogTextBox.Text = "◆依存モジュール一覧";

                string jdepsCommand = string.Concat(@"jdeps --list-deps --ignore-missing-deps """, JarFilePathTextBox.Text, @"""");
                if (!string.IsNullOrEmpty(modulePath))
                {
                    jdepsCommand = string.Concat(@"jdeps --list-deps --ignore-missing-deps --module-path """, modulePath, @""" """, JarFilePathTextBox.Text, @"""");
                }

                // 依存モジュールを確認する。
                ExeCommand(jdepsCommand);

                // 依存モジュールを配列にする。
                string[] lineAr = Output.Replace(" ", string.Empty).Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                // カスタムJREフォルダの有無を判定する。
                string runtimeFolderPath = string.Concat(WorkFolderPathTextBox.Text, @"\runtime");
                if (Directory.Exists(runtimeFolderPath))
                {
                    // 存在する場合、カスタムJREフォルダを削除する。
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(
                        runtimeFolderPath,
                        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                        Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin,
                        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
                }

                LogTextBox.AppendText(
                    string.Concat(
                        Environment.NewLine,
                        "◆カスタムJRE生成"));

                // カスタムJERを生成する。
                ExeCommand(string.Concat(@"jlink --module-path """, JrePathTextBox.Text, @""" --add-modules ", string.Join(",", lineAr), @" --output """, runtimeFolderPath, @""""));

                // Jarファイル名を取得・保持する。
                string jarFileName = Path.GetFileName(JarFilePathTextBox.Text);

                // input用のフォルダを生成し、Jarファイルをコピーする。
                string inputFolderPath = Path.Combine(WorkFolderPathTextBox.Text, "input");
                Directory.CreateDirectory(inputFolderPath);
                File.Copy(JarFilePathTextBox.Text, Path.Combine(inputFolderPath, jarFileName), true);

                string command = string.Concat(
                    @"jpackage --input """, inputFolderPath,
                    @""" --main-jar """, jarFileName,
                    @""" --runtime-image """, runtimeFolderPath,
                    @""" --main-class """, MainClassTextBox.Text,
                    @""" --name """, NameTextBox.Text,
                    @""" --app-version """, VersionTextBox.Text,
                    @""" --type app-image");

                // 任意項目
                if (!string.IsNullOrEmpty(iconPath))
                {
                    command = string.Concat(command, @" --icon """, iconPath, @"""");
                }

                if (!string.IsNullOrEmpty(DescriptionTextBox.Text))
                {
                    command = string.Concat(command, @" --description """, DescriptionTextBox.Text, @"""");
                }

                if (!string.IsNullOrEmpty(CopyrightTextBox.Text))
                {
                    command = string.Concat(command, @" --copyright """, CopyrightTextBox.Text, @"""");
                }

                if (!string.IsNullOrEmpty(VendorTextBox.Text))
                {
                    command = string.Concat(command, @" --vendor """, VendorTextBox.Text, @"""");
                }

                if (ConsoleCheckBox.Checked)
                {
                    command = string.Concat(command, " --win-console");
                }

                if (VerboseCheckBox.Checked)
                {
                    command = string.Concat(command, " --verbose");
                }

                string distFolderPath = Path.Combine(workFolderPath, "dist");
                if (Directory.Exists(distFolderPath))
                {
                    // 存在する場合、出力フォルダを削除する。
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(
                        distFolderPath,
                        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                        Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin,
                        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
                }

                command = string.Concat(command, @" --dest """, distFolderPath, @"""");

                LogTextBox.AppendText(
                    string.Concat(
                        Environment.NewLine,
                        "◆Exe生成"));

                // Exeを生成する。
                ExeCommand(command);

                LogTextBox.AppendText(
                    string.Concat(
                        Environment.NewLine,
                        "◆出力フォルダパス：",
                        distFolderPath));

                MessageBox.Show(
                    "Exeに変換が完了しました。",
                    "Exe変換完了",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                // Exe変換ボタンを活性にする。
                ExeConvertButton.Enabled = true;
            }
        }

        /// <summary>
        /// コマンド実行処理
        /// </summary>
        /// <param name="command">コマンド</param>
        private void ExeCommand(string command)
        {
            try
            {
                using (Process process = new Process())
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c {command}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    // プロセスを開始する。
                    process.Start();

                    // 標準出力を設定する。
                    Output = process.StandardOutput.ReadToEnd();

                    // 標準エラーを設定する。
                    OutputError = process.StandardError.ReadToEnd();

                    // プロセル終了まで待機する。
                    process.WaitForExit();
                }

                // ログを設定する。
                // （AppendTextメソッドで、一番下までスクロールもさせる。）
                string setLog = string.Concat($@"実行コマンド：{command}", Environment.NewLine);
                setLog = string.Concat(setLog, string.IsNullOrEmpty(Output) ? OutputError : Output);
                if (string.IsNullOrEmpty(LogTextBox.Text))
                {
                    LogTextBox.AppendText(setLog);
                }
                else
                {
                    LogTextBox.AppendText(string.Concat(Environment.NewLine, setLog));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    e.ToString(),
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// 設定読み込みボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SettingReadButton_Click(object sender, EventArgs e)
        {
            if (Equals(SettingOpenFileDialog.ShowDialog(this), DialogResult.OK))
            {
                // 各項目を初期化する。
                WorkFolderPathTextBox.Text = string.Empty;
                JarFilePathTextBox.Text = string.Empty;
                JrePathTextBox.Text = string.Empty;
                MainClassTextBox.Text = string.Empty;
                NameTextBox.Text = string.Empty;
                VersionTextBox.Text = string.Empty;
                IconPathTextBox.Text = string.Empty;
                DescriptionTextBox.Text = string.Empty;
                CopyrightTextBox.Text = string.Empty;
                VendorTextBox.Text = string.Empty;
                ModulePathTextBox.Text = string.Empty;
                ConsoleCheckBox.Checked = false;
                VerboseCheckBox.Checked = false;

                int index = 0;

                foreach (var line in File.ReadAllLines(SettingOpenFileDialog.FileName, Encoding.UTF8))
                {
                    switch (index)
                    {
                        case 0:
                            // 作業フォルダパステキストボックス
                            WorkFolderPathTextBox.Text = line;
                            break;

                        case 1:
                            // 対象Jarファイルパステキストボックス
                            JarFilePathTextBox.Text = line;
                            break;

                        case 2:
                            // JREパステキストボックス
                            JrePathTextBox.Text = line;
                            break;

                        case 3:
                            // メインクラステキストボックス
                            MainClassTextBox.Text = line;
                            break;

                        case 4:
                            // 名称テキストボックス
                            NameTextBox.Text = line;
                            break;

                        case 5:
                            // バージョンテキストボックス
                            VersionTextBox.Text = line;
                            break;

                        case 6:
                            // アイコンパステキストボックス
                            IconPathTextBox.Text = line;
                            break;

                        case 7:
                            // 説明テキストボックス
                            DescriptionTextBox.Text = line;
                            break;

                        case 8:
                            // 著作権テキストボックス
                            CopyrightTextBox.Text = line;
                            break;

                        case 9:
                            // ベンダーテキストボックス
                            VendorTextBox.Text = line;
                            break;

                        case 10:
                            // モジュールパステキストボックス
                            ModulePathTextBox.Text = line;
                            break;

                        case 11:
                            // コンソール表示チェックボックス
                            if (!string.IsNullOrWhiteSpace(line) && line == "1")
                            {
                                ConsoleCheckBox.Checked = true;
                            }
                            break;

                        case 12:
                            // 冗長な出力を有効チェックボックス
                            if (!string.IsNullOrWhiteSpace(line) && line == "1")
                            {
                                VerboseCheckBox.Checked = true;
                            }
                            break;
                    }

                    index++;
                }

                MessageBox.Show(
                    "設定ファイルの読み込みが完了しました。",
                    "設定ファイル読み込み完了",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// 設定保存ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SettingSaveButton_Click(object sender, EventArgs e)
        {
            if (Equals(SettingSaveFileDialog.ShowDialog(this), DialogResult.OK))
            {
                string outputText = string.Join(
                    Environment.NewLine,
                    WorkFolderPathTextBox.Text,
                    JarFilePathTextBox.Text,
                    JrePathTextBox.Text,
                    MainClassTextBox.Text,
                    NameTextBox.Text,
                    VersionTextBox.Text,
                    IconPathTextBox.Text,
                    DescriptionTextBox.Text,
                    CopyrightTextBox.Text,
                    VendorTextBox.Text,
                    ModulePathTextBox.Text,
                    ConsoleCheckBox.Checked ? "1" : "0",
                    VerboseCheckBox.Checked ? "1" : "0");
                File.WriteAllText(SettingSaveFileDialog.FileName, outputText, Encoding.UTF8);

                MessageBox.Show(
                    "設定ファイルの保存が完了しました。",
                    "設定ファイル保存完了",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}
