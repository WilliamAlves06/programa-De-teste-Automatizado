namespace projeto_autoteste
{
    partial class Form1
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
            lblTitle = new Label();
            label2 = new Label();
            cmbEnvironment = new ComboBox();
            lstSuites = new ListBox();
            grpSuites = new GroupBox();
            grpTests = new GroupBox();
            lstTests = new ListBox();
            grpLog = new GroupBox();
            txtLog = new RichTextBox();
            btnRunSuite = new Button();
            btnRunTest = new Button();
            button1 = new Button();
            TxtDiretorio = new TextBox();
            label1 = new Label();
            btnSelecionarDiretorio = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            grpSuites.SuspendLayout();
            grpTests.SuspendLayout();
            grpLog.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.FlatStyle = FlatStyle.System;
            lblTitle.Font = new Font("Segoe UI", 13F);
            lblTitle.ImageAlign = ContentAlignment.TopCenter;
            lblTitle.Location = new Point(169, 16);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Central de Automação de Teste";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 60);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Ambiente";
            // 
            // cmbEnvironment
            // 
            cmbEnvironment.FormattingEnabled = true;
            cmbEnvironment.Location = new Point(89, 58);
            cmbEnvironment.Margin = new Padding(3, 2, 3, 2);
            cmbEnvironment.Name = "cmbEnvironment";
            cmbEnvironment.Size = new Size(204, 23);
            cmbEnvironment.TabIndex = 3;
            // 
            // lstSuites
            // 
            lstSuites.BorderStyle = BorderStyle.None;
            lstSuites.FormattingEnabled = true;
            lstSuites.Location = new Point(5, 16);
            lstSuites.Margin = new Padding(3, 2, 3, 2);
            lstSuites.Name = "lstSuites";
            lstSuites.Size = new Size(263, 135);
            lstSuites.TabIndex = 4;
            lstSuites.SelectedIndexChanged += lstSuites_SelectedIndexChanged;
            // 
            // grpSuites
            // 
            grpSuites.Controls.Add(lstSuites);
            grpSuites.Location = new Point(19, 94);
            grpSuites.Margin = new Padding(3, 2, 3, 2);
            grpSuites.Name = "grpSuites";
            grpSuites.Padding = new Padding(3, 2, 3, 2);
            grpSuites.Size = new Size(274, 154);
            grpSuites.TabIndex = 5;
            grpSuites.TabStop = false;
            grpSuites.Text = "Suite de teste";
            // 
            // grpTests
            // 
            grpTests.Controls.Add(lstTests);
            grpTests.Location = new Point(324, 94);
            grpTests.Margin = new Padding(3, 2, 3, 2);
            grpTests.Name = "grpTests";
            grpTests.Padding = new Padding(3, 2, 3, 2);
            grpTests.Size = new Size(274, 154);
            grpTests.TabIndex = 6;
            grpTests.TabStop = false;
            grpTests.Text = "Caso de Teste";
            grpTests.Enter += groupBox2_Enter;
            // 
            // lstTests
            // 
            lstTests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstTests.BorderStyle = BorderStyle.None;
            lstTests.FormattingEnabled = true;
            lstTests.Location = new Point(5, 16);
            lstTests.Margin = new Padding(3, 2, 3, 2);
            lstTests.Name = "lstTests";
            lstTests.Size = new Size(263, 135);
            lstTests.TabIndex = 4;
            lstTests.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // grpLog
            // 
            grpLog.Controls.Add(txtLog);
            grpLog.Location = new Point(19, 299);
            grpLog.Margin = new Padding(3, 2, 3, 2);
            grpLog.Name = "grpLog";
            grpLog.Padding = new Padding(3, 2, 3, 2);
            grpLog.Size = new Size(578, 219);
            grpLog.TabIndex = 7;
            grpLog.TabStop = false;
            grpLog.Text = "Logs de Execução";
            // 
            // txtLog
            // 
            txtLog.BackColor = SystemColors.ActiveCaptionText;
            txtLog.BorderStyle = BorderStyle.None;
            txtLog.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLog.ForeColor = SystemColors.Window;
            txtLog.Location = new Point(5, 20);
            txtLog.Margin = new Padding(3, 2, 3, 2);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(568, 195);
            txtLog.TabIndex = 0;
            txtLog.Text = "";
            // 
            // btnRunSuite
            // 
            btnRunSuite.Location = new Point(188, 266);
            btnRunSuite.Margin = new Padding(3, 2, 3, 2);
            btnRunSuite.Name = "btnRunSuite";
            btnRunSuite.Size = new Size(105, 22);
            btnRunSuite.TabIndex = 8;
            btnRunSuite.Text = "Selecionar";
            btnRunSuite.UseVisualStyleBackColor = true;
            btnRunSuite.Click += btnRunSuite_Click;
            // 
            // btnRunTest
            // 
            btnRunTest.Location = new Point(356, 266);
            btnRunTest.Margin = new Padding(3, 2, 3, 2);
            btnRunTest.Name = "btnRunTest";
            btnRunTest.Size = new Size(204, 22);
            btnRunTest.TabIndex = 9;
            btnRunTest.Text = "testar caso de teste";
            btnRunTest.UseVisualStyleBackColor = true;
            btnRunTest.Click += btnRunTest_Click;
            // 
            // button1
            // 
            button1.Location = new Point(19, 266);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(153, 22);
            button1.TabIndex = 10;
            button1.Text = "testar Suite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRunAll_Click;
            // 
            // TxtDiretorio
            // 
            TxtDiretorio.Location = new Point(382, 57);
            TxtDiretorio.Name = "TxtDiretorio";
            TxtDiretorio.Size = new Size(191, 23);
            TxtDiretorio.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 60);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 12;
            label1.Text = "Diretorio";
            // 
            // btnSelecionarDiretorio
            // 
            btnSelecionarDiretorio.BackColor = SystemColors.ButtonHighlight;
            btnSelecionarDiretorio.BackgroundImageLayout = ImageLayout.Center;
            btnSelecionarDiretorio.Cursor = Cursors.Hand;
            btnSelecionarDiretorio.ForeColor = Color.Chocolate;
            btnSelecionarDiretorio.Location = new Point(579, 57);
            btnSelecionarDiretorio.Name = "btnSelecionarDiretorio";
            btnSelecionarDiretorio.Size = new Size(19, 25);
            btnSelecionarDiretorio.TabIndex = 13;
            btnSelecionarDiretorio.Text = "✅";
            btnSelecionarDiretorio.UseVisualStyleBackColor = false;
            btnSelecionarDiretorio.Click += btnSelecionarDiretorio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(622, 529);
            Controls.Add(btnSelecionarDiretorio);
            Controls.Add(label1);
            Controls.Add(TxtDiretorio);
            Controls.Add(button1);
            Controls.Add(btnRunTest);
            Controls.Add(btnRunSuite);
            Controls.Add(grpLog);
            Controls.Add(grpTests);
            Controls.Add(grpSuites);
            Controls.Add(cmbEnvironment);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Central de Teste Automatizado";
            Load += Form1_Load;
            grpSuites.ResumeLayout(false);
            grpTests.ResumeLayout(false);
            grpLog.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label2;
        private ComboBox cmbEnvironment;
        private ListBox lstSuites;
        private GroupBox grpSuites;
        private GroupBox grpTests;
        private ListBox lstTests;
        private GroupBox grpLog;
        private Button btnRunSuite;
        private Button btnRunTest;
        private RichTextBox txtLog;
        private Button button1;
        private TextBox TxtDiretorio;
        private Label label1;
        private Button btnSelecionarDiretorio;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
