namespace SimpleConvertJarToExe
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ExeConvertButton = new Button();
            SettingReadButton = new Button();
            SettingSaveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            WorkFolderPathTextBox = new TextBox();
            JarFilePathTextBox = new TextBox();
            JrePathTextBox = new TextBox();
            MainClassTextBox = new TextBox();
            NameTextBox = new TextBox();
            VersionTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            IconPathTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            CopyrightTextBox = new TextBox();
            VendorTextBox = new TextBox();
            ModulePathTextBox = new TextBox();
            ConsoleCheckBox = new CheckBox();
            VerboseCheckBox = new CheckBox();
            label16 = new Label();
            LogTextBox = new TextBox();
            ToolTip1 = new ToolTip(components);
            SettingOpenFileDialog = new OpenFileDialog();
            SettingSaveFileDialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // ExeConvertButton
            // 
            ExeConvertButton.Location = new Point(12, 12);
            ExeConvertButton.Name = "ExeConvertButton";
            ExeConvertButton.Size = new Size(140, 50);
            ExeConvertButton.TabIndex = 0;
            ExeConvertButton.Text = "Exe変換";
            ExeConvertButton.UseVisualStyleBackColor = true;
            ExeConvertButton.Click += ExeConvertButton_Click;
            // 
            // SettingReadButton
            // 
            SettingReadButton.Location = new Point(178, 12);
            SettingReadButton.Name = "SettingReadButton";
            SettingReadButton.Size = new Size(140, 50);
            SettingReadButton.TabIndex = 1;
            SettingReadButton.Text = "設定読み込み";
            SettingReadButton.UseVisualStyleBackColor = true;
            SettingReadButton.Click += SettingReadButton_Click;
            // 
            // SettingSaveButton
            // 
            SettingSaveButton.Location = new Point(344, 12);
            SettingSaveButton.Name = "SettingSaveButton";
            SettingSaveButton.Size = new Size(140, 50);
            SettingSaveButton.TabIndex = 2;
            SettingSaveButton.Text = "設定保存";
            SettingSaveButton.UseVisualStyleBackColor = true;
            SettingSaveButton.Click += SettingSaveButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(840, 252);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 4;
            label2.Text = "◆必須項目";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 112);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 5;
            label3.Text = "作業フォルダパス";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 147);
            label4.Name = "label4";
            label4.Size = new Size(132, 21);
            label4.TabIndex = 6;
            label4.Text = "対象Jarファイルパス";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 182);
            label5.Name = "label5";
            label5.Size = new Size(226, 21);
            label5.TabIndex = 7;
            label5.Text = "JREパス（jmodsフォルダを指定）";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 217);
            label6.Name = "label6";
            label6.Size = new Size(208, 21);
            label6.TabIndex = 8;
            label6.Text = "メインクラス（パッケージ.クラス）";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 252);
            label7.Name = "label7";
            label7.Size = new Size(42, 21);
            label7.TabIndex = 9;
            label7.Text = "名称";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 287);
            label8.Name = "label8";
            label8.Size = new Size(68, 21);
            label8.TabIndex = 10;
            label8.Text = "バージョン";
            // 
            // WorkFolderPathTextBox
            // 
            WorkFolderPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WorkFolderPathTextBox.Location = new Point(252, 109);
            WorkFolderPathTextBox.MaxLength = 0;
            WorkFolderPathTextBox.Name = "WorkFolderPathTextBox";
            WorkFolderPathTextBox.Size = new Size(580, 29);
            WorkFolderPathTextBox.TabIndex = 11;
            WorkFolderPathTextBox.WordWrap = false;
            // 
            // JarFilePathTextBox
            // 
            JarFilePathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            JarFilePathTextBox.Location = new Point(252, 144);
            JarFilePathTextBox.MaxLength = 0;
            JarFilePathTextBox.Name = "JarFilePathTextBox";
            JarFilePathTextBox.Size = new Size(580, 29);
            JarFilePathTextBox.TabIndex = 12;
            JarFilePathTextBox.WordWrap = false;
            // 
            // JrePathTextBox
            // 
            JrePathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            JrePathTextBox.Location = new Point(252, 179);
            JrePathTextBox.MaxLength = 0;
            JrePathTextBox.Name = "JrePathTextBox";
            JrePathTextBox.Size = new Size(580, 29);
            JrePathTextBox.TabIndex = 13;
            JrePathTextBox.WordWrap = false;
            // 
            // MainClassTextBox
            // 
            MainClassTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MainClassTextBox.Location = new Point(252, 214);
            MainClassTextBox.MaxLength = 0;
            MainClassTextBox.Name = "MainClassTextBox";
            MainClassTextBox.Size = new Size(580, 29);
            MainClassTextBox.TabIndex = 14;
            MainClassTextBox.WordWrap = false;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(252, 249);
            NameTextBox.MaxLength = 0;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(580, 29);
            NameTextBox.TabIndex = 15;
            ToolTip1.SetToolTip(NameTextBox, "【名称】に日本語を含む場合、動かない場合があります。");
            NameTextBox.WordWrap = false;
            // 
            // VersionTextBox
            // 
            VersionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VersionTextBox.Location = new Point(252, 284);
            VersionTextBox.MaxLength = 0;
            VersionTextBox.Name = "VersionTextBox";
            VersionTextBox.Size = new Size(580, 29);
            VersionTextBox.TabIndex = 16;
            VersionTextBox.WordWrap = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(12, 365);
            label9.Name = "label9";
            label9.Size = new Size(840, 248);
            label9.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 355);
            label10.Name = "label10";
            label10.Size = new Size(90, 21);
            label10.TabIndex = 18;
            label10.Text = "◆任意項目";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 392);
            label11.Name = "label11";
            label11.Size = new Size(81, 21);
            label11.TabIndex = 19;
            label11.Text = "アイコンパス";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 427);
            label12.Name = "label12";
            label12.Size = new Size(42, 21);
            label12.TabIndex = 20;
            label12.Text = "説明";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 462);
            label13.Name = "label13";
            label13.Size = new Size(58, 21);
            label13.TabIndex = 21;
            label13.Text = "著作権";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 497);
            label14.Name = "label14";
            label14.Size = new Size(58, 21);
            label14.TabIndex = 22;
            label14.Text = "ベンダー";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 532);
            label15.Name = "label15";
            label15.Size = new Size(93, 21);
            label15.TabIndex = 23;
            label15.Text = "モジュールパス";
            // 
            // IconPathTextBox
            // 
            IconPathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IconPathTextBox.Location = new Point(119, 389);
            IconPathTextBox.MaxLength = 0;
            IconPathTextBox.Name = "IconPathTextBox";
            IconPathTextBox.Size = new Size(713, 29);
            IconPathTextBox.TabIndex = 24;
            IconPathTextBox.WordWrap = false;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(119, 424);
            DescriptionTextBox.MaxLength = 0;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(713, 29);
            DescriptionTextBox.TabIndex = 25;
            DescriptionTextBox.WordWrap = false;
            // 
            // CopyrightTextBox
            // 
            CopyrightTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CopyrightTextBox.Location = new Point(119, 459);
            CopyrightTextBox.MaxLength = 0;
            CopyrightTextBox.Name = "CopyrightTextBox";
            CopyrightTextBox.Size = new Size(713, 29);
            CopyrightTextBox.TabIndex = 26;
            CopyrightTextBox.WordWrap = false;
            // 
            // VendorTextBox
            // 
            VendorTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            VendorTextBox.Location = new Point(119, 494);
            VendorTextBox.MaxLength = 0;
            VendorTextBox.Name = "VendorTextBox";
            VendorTextBox.Size = new Size(713, 29);
            VendorTextBox.TabIndex = 27;
            VendorTextBox.WordWrap = false;
            // 
            // ModulePathTextBox
            // 
            ModulePathTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ModulePathTextBox.Location = new Point(119, 529);
            ModulePathTextBox.MaxLength = 0;
            ModulePathTextBox.Name = "ModulePathTextBox";
            ModulePathTextBox.Size = new Size(713, 29);
            ModulePathTextBox.TabIndex = 28;
            ModulePathTextBox.WordWrap = false;
            // 
            // ConsoleCheckBox
            // 
            ConsoleCheckBox.AutoSize = true;
            ConsoleCheckBox.Location = new Point(119, 564);
            ConsoleCheckBox.Name = "ConsoleCheckBox";
            ConsoleCheckBox.Size = new Size(119, 25);
            ConsoleCheckBox.TabIndex = 29;
            ConsoleCheckBox.Text = "コンソール表示";
            ConsoleCheckBox.UseVisualStyleBackColor = true;
            // 
            // VerboseCheckBox
            // 
            VerboseCheckBox.AutoSize = true;
            VerboseCheckBox.Location = new Point(244, 564);
            VerboseCheckBox.Name = "VerboseCheckBox";
            VerboseCheckBox.Size = new Size(151, 25);
            VerboseCheckBox.TabIndex = 30;
            VerboseCheckBox.Text = "冗長な出力を有効";
            VerboseCheckBox.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 627);
            label16.Name = "label16";
            label16.Size = new Size(83, 21);
            label16.TabIndex = 31;
            label16.Text = "◆ログ出力";
            // 
            // LogTextBox
            // 
            LogTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogTextBox.BorderStyle = BorderStyle.FixedSingle;
            LogTextBox.Location = new Point(12, 651);
            LogTextBox.MaxLength = 0;
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            LogTextBox.ScrollBars = ScrollBars.Both;
            LogTextBox.Size = new Size(840, 118);
            LogTextBox.TabIndex = 32;
            LogTextBox.WordWrap = false;
            // 
            // SettingOpenFileDialog
            // 
            SettingOpenFileDialog.DefaultExt = "txt";
            SettingOpenFileDialog.FileName = "Jar変換設定ファイル.txt";
            SettingOpenFileDialog.Filter = "テキストファイル (*.txt)|*.txt";
            SettingOpenFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
            SettingOpenFileDialog.RestoreDirectory = true;
            SettingOpenFileDialog.Title = "設定ファイルを開く";
            // 
            // SettingSaveFileDialog
            // 
            SettingSaveFileDialog.DefaultExt = "txt";
            SettingSaveFileDialog.FileName = "Jar変換設定ファイル.txt";
            SettingSaveFileDialog.Filter = "テキストファイル (*.txt)|*.txt";
            SettingSaveFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
            SettingSaveFileDialog.RestoreDirectory = true;
            SettingSaveFileDialog.Title = "設定ファイル保存";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(864, 781);
            Controls.Add(LogTextBox);
            Controls.Add(label16);
            Controls.Add(VerboseCheckBox);
            Controls.Add(ConsoleCheckBox);
            Controls.Add(ModulePathTextBox);
            Controls.Add(VendorTextBox);
            Controls.Add(CopyrightTextBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(IconPathTextBox);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(VersionTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(MainClassTextBox);
            Controls.Add(JrePathTextBox);
            Controls.Add(JarFilePathTextBox);
            Controls.Add(WorkFolderPathTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SettingSaveButton);
            Controls.Add(SettingReadButton);
            Controls.Add(ExeConvertButton);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "簡易Jarファイル→Exeコンバーター";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExeConvertButton;
        private Button SettingReadButton;
        private Button SettingSaveButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox WorkFolderPathTextBox;
        private TextBox JarFilePathTextBox;
        private TextBox JrePathTextBox;
        private TextBox MainClassTextBox;
        private TextBox NameTextBox;
        private TextBox VersionTextBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox IconPathTextBox;
        private TextBox DescriptionTextBox;
        private TextBox CopyrightTextBox;
        private TextBox VendorTextBox;
        private TextBox ModulePathTextBox;
        private CheckBox ConsoleCheckBox;
        private CheckBox VerboseCheckBox;
        private Label label16;
        private TextBox LogTextBox;
        private ToolTip ToolTip1;
        private OpenFileDialog SettingOpenFileDialog;
        private SaveFileDialog SettingSaveFileDialog;
    }
}
