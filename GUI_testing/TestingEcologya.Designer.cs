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
            this.tabControlEcologya.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            this.tabPageTester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEcologya)).BeginInit();
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
            this.tabControlEcologya.Size = new System.Drawing.Size(771, 383);
            this.tabControlEcologya.TabIndex = 0;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.splitContainer1);
            this.tabPageBook.Location = new System.Drawing.Point(23, 4);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(744, 375);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Электронный учебник";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // tabPageTester
            // 
            this.tabPageTester.Controls.Add(this.dataGridViewEcologya);
            this.tabPageTester.Location = new System.Drawing.Point(23, 4);
            this.tabPageTester.Name = "tabPageTester";
            this.tabPageTester.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTester.Size = new System.Drawing.Size(744, 375);
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
            this.splitContainer1.Size = new System.Drawing.Size(738, 369);
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
            this.webBrowserEcologya.Size = new System.Drawing.Size(555, 369);
            this.webBrowserEcologya.TabIndex = 0;
            this.webBrowserEcologya.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            // 
            // treeViewEcologya
            // 
            this.treeViewEcologya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewEcologya.Location = new System.Drawing.Point(0, 0);
            this.treeViewEcologya.Name = "treeViewEcologya";
            this.treeViewEcologya.Size = new System.Drawing.Size(179, 369);
            this.treeViewEcologya.TabIndex = 0;
            // 
            // dataGridViewEcologya
            // 
            this.dataGridViewEcologya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEcologya.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amount,
            this.Value});
            this.dataGridViewEcologya.Location = new System.Drawing.Point(27, 52);
            this.dataGridViewEcologya.Name = "dataGridViewEcologya";
            this.dataGridViewEcologya.Size = new System.Drawing.Size(344, 275);
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
            // TestingEcologya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 383);
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
    }
}

