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
            lblTitle.Location = new Point(193, 21);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(316, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Central de Automação de Teste";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 80);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Ambiente";
            // 
            // cmbEnvironment
            // 
            cmbEnvironment.FormattingEnabled = true;
            cmbEnvironment.Location = new Point(102, 77);
            cmbEnvironment.Name = "cmbEnvironment";
            cmbEnvironment.Size = new Size(233, 28);
            cmbEnvironment.TabIndex = 3;
            // 
            // lstSuites
            // 
            lstSuites.BorderStyle = BorderStyle.None;
            lstSuites.FormattingEnabled = true;
            lstSuites.Location = new Point(6, 21);
            lstSuites.Name = "lstSuites";
            lstSuites.Size = new Size(301, 180);
            lstSuites.TabIndex = 4;
            lstSuites.SelectedIndexChanged += lstSuites_SelectedIndexChanged;
            // 
            // grpSuites
            // 
            grpSuites.Controls.Add(lstSuites);
            grpSuites.Location = new Point(22, 125);
            grpSuites.Name = "grpSuites";
            grpSuites.Size = new Size(313, 205);
            grpSuites.TabIndex = 5;
            grpSuites.TabStop = false;
            grpSuites.Text = "Suite de teste";
            // 
            // grpTests
            // 
            grpTests.Controls.Add(lstTests);
            grpTests.Location = new Point(370, 125);
            grpTests.Name = "grpTests";
            grpTests.Size = new Size(313, 205);
            grpTests.TabIndex = 6;
            grpTests.TabStop = false;
            grpTests.Text = "Case Test";
            grpTests.Enter += groupBox2_Enter;
            // 
            // lstTests
            // 
            lstTests.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstTests.BorderStyle = BorderStyle.None;
            lstTests.FormattingEnabled = true;
            lstTests.Location = new Point(6, 21);
            lstTests.Name = "lstTests";
            lstTests.Size = new Size(301, 180);
            lstTests.TabIndex = 4;
            lstTests.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // grpLog
            // 
            grpLog.Controls.Add(txtLog);
            grpLog.Location = new Point(22, 399);
            grpLog.Name = "grpLog";
            grpLog.Size = new Size(661, 116);
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
            txtLog.Location = new Point(6, 26);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(649, 84);
            txtLog.TabIndex = 0;
            txtLog.Text = "";
            // 
            // btnRunSuite
            // 
            btnRunSuite.Location = new Point(215, 354);
            btnRunSuite.Name = "btnRunSuite";
            btnRunSuite.Size = new Size(120, 29);
            btnRunSuite.TabIndex = 8;
            btnRunSuite.Text = "Selecionar";
            btnRunSuite.UseVisualStyleBackColor = true;
            btnRunSuite.Click += btnRunSuite_Click;
            // 
            // btnRunTest
            // 
            btnRunTest.Location = new Point(407, 354);
            btnRunTest.Name = "btnRunTest";
            btnRunTest.Size = new Size(233, 29);
            btnRunTest.TabIndex = 9;
            btnRunTest.Text = "testar caso de teste";
            btnRunTest.UseVisualStyleBackColor = true;
            btnRunTest.Click += btnRunTest_Click;
            // 
            // button1
            // 
            button1.Location = new Point(22, 354);
            button1.Name = "button1";
            button1.Size = new Size(175, 29);
            button1.TabIndex = 10;
            button1.Text = "testar Suite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRunAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(711, 527);
            Controls.Add(button1);
            Controls.Add(btnRunTest);
            Controls.Add(btnRunSuite);
            Controls.Add(grpLog);
            Controls.Add(grpTests);
            Controls.Add(grpSuites);
            Controls.Add(cmbEnvironment);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Central de Teste Automartizado";
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
    }
}
