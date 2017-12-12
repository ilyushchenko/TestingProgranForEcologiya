namespace GUI_testing
{
    partial class TestingEcologya
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.tabControlEcologya = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.tabPageTester = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowserEcologya = new System.Windows.Forms.WebBrowser();
            this.treeViewEcologya = new System.Windows.Forms.TreeView();
            this.dataGridViewEcologya = new System.Windows.Forms.DataGridView();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.groupBoxDataVariant = new System.Windows.Forms.GroupBox();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.butStart = new System.Windows.Forms.Button();
            this.labelTimeHint = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelAttemptHint = new System.Windows.Forms.Label();
            this.tabControlEcologya.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            this.tabPageTester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEcologya)).BeginInit();
            this.groupBoxDataVariant.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEcologya
            // 
            this.tabControlEcologya.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlEcologya.Controls.Add(this.tabPageBook);
            this.tabControlEcologya.Controls.Add(this.tabPageTester);
            this.tabControlEcologya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEcologya.Location = new System.Drawing.Point(0, 0);
            this.tabControlEcologya.Multiline = true;
            this.tabControlEcologya.Name = "tabControlEcologya";
            this.tabControlEcologya.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlEcologya.SelectedIndex = 0;
            this.tabControlEcologya.Size = new System.Drawing.Size(771, 638);
            this.tabControlEcologya.TabIndex = 0;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.splitContainer1);
            this.tabPageBook.Location = new System.Drawing.Point(23, 4);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(744, 518);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Электронный учебник";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // tabPageTester
            // 
            this.tabPageTester.Controls.Add(this.groupBoxControl);
            this.tabPageTester.Controls.Add(this.groupBoxDataVariant);
            this.tabPageTester.Controls.Add(this.groupBoxTask);
            this.tabPageTester.Location = new System.Drawing.Point(23, 4);
            this.tabPageTester.Name = "tabPageTester";
            this.tabPageTester.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTester.Size = new System.Drawing.Size(744, 630);
            this.tabPageTester.TabIndex = 1;
            this.tabPageTester.Text = "Тестирование";
            this.tabPageTester.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewEcologya);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserEcologya);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(738, 512);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowserEcologya
            // 
            this.webBrowserEcologya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserEcologya.Location = new System.Drawing.Point(0, 0);
            this.webBrowserEcologya.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserEcologya.Name = "webBrowserEcologya";
            this.webBrowserEcologya.ScriptErrorsSuppressed = true;
            this.webBrowserEcologya.Size = new System.Drawing.Size(555, 512);
            this.webBrowserEcologya.TabIndex = 0;
            this.webBrowserEcologya.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            // 
            // treeViewEcologya
            // 
            this.treeViewEcologya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewEcologya.Location = new System.Drawing.Point(0, 0);
            this.treeViewEcologya.Name = "treeViewEcologya";
            this.treeViewEcologya.Size = new System.Drawing.Size(179, 512);
            this.treeViewEcologya.TabIndex = 0;
            // 
            // dataGridViewEcologya
            // 
            this.dataGridViewEcologya.AllowUserToAddRows = false;
            this.dataGridViewEcologya.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amount,
            this.Value});
            this.dataGridViewEcologya.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewEcologya.Name = "dataGridViewEcologya";
            this.dataGridViewEcologya.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewEcologya.Size = new System.Drawing.Size(344, 355);
            this.dataGridViewEcologya.TabIndex = 1;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Величина";
            this.Amount.Name = "Amount";
            this.Amount.Width = 150;
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            this.Value.Width = 150;
            // 
            // groupBoxTask
            // 
            this.groupBoxTask.Location = new System.Drawing.Point(6, 8);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(370, 145);
            this.groupBoxTask.TabIndex = 2;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Задание по варианту";
            // 
            // groupBoxDataVariant
            // 
            this.groupBoxDataVariant.Controls.Add(this.dataGridViewEcologya);
            this.groupBoxDataVariant.Location = new System.Drawing.Point(6, 159);
            this.groupBoxDataVariant.Name = "groupBoxDataVariant";
            this.groupBoxDataVariant.Size = new System.Drawing.Size(370, 392);
            this.groupBoxDataVariant.TabIndex = 3;
            this.groupBoxDataVariant.TabStop = false;
            this.groupBoxDataVariant.Text = "Исходнные данные по варианту";
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.labelAttemptHint);
            this.groupBoxControl.Controls.Add(this.labelTime);
            this.groupBoxControl.Controls.Add(this.labelTimeHint);
            this.groupBoxControl.Controls.Add(this.butStart);
            this.groupBoxControl.Location = new System.Drawing.Point(382, 8);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(354, 297);
            this.groupBoxControl.TabIndex = 4;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Управление";
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(251, 19);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(97, 35);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Начать тест";
            this.butStart.UseVisualStyleBackColor = true;
            // 
            // labelTimeHint
            // 
            this.labelTimeHint.AutoSize = true;
            this.labelTimeHint.Location = new System.Drawing.Point(16, 19);
            this.labelTimeHint.Name = "labelTimeHint";
            this.labelTimeHint.Size = new System.Drawing.Size(74, 13);
            this.labelTimeHint.TabIndex = 1;
            this.labelTimeHint.Text = "Время теста:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(19, 40);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 13);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "0:00:00";
            // 
            // labelAttemptHint
            // 
            this.labelAttemptHint.AutoSize = true;
            this.labelAttemptHint.Location = new System.Drawing.Point(40, 77);
            this.labelAttemptHint.Name = "labelAttemptHint";
            this.labelAttemptHint.Size = new System.Drawing.Size(85, 13);
            this.labelAttemptHint.TabIndex = 3;
            this.labelAttemptHint.Text = "Попытка 0 из 3";
            // 
            // TestingEcologya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 638);
            this.Controls.Add(this.tabControlEcologya);
            this.Name = "TestingEcologya";
            this.Text = "Тестирование по Экологии";
            this.Load += new System.EventHandler(this.TestingEcologya_Load);
            this.tabControlEcologya.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageTester.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEcologya)).EndInit();
            this.groupBoxDataVariant.ResumeLayout(false);
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.TabControl tabControlEcologya;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPageTester;
        private System.Windows.Forms.TreeView treeViewEcologya;
        private System.Windows.Forms.WebBrowser webBrowserEcologya;
        private System.Windows.Forms.DataGridView dataGridViewEcologya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.GroupBox groupBoxDataVariant;
        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTimeHint;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Label labelAttemptHint;
    }
}

