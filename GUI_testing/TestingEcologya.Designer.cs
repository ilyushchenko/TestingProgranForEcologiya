﻿namespace GUI_testing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestingEcologya));
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.tabControlEcologya = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewEcologya = new System.Windows.Forms.TreeView();
            this.webBrowserEcologya = new System.Windows.Forms.WebBrowser();
            this.contextMenuWebBrowser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPageTester = new System.Windows.Forms.TabPage();
            this.groupBoxWarning = new System.Windows.Forms.GroupBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.butResult = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.labelAttemptHint = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTimeHint = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.groupBoxDataVariant = new System.Windows.Forms.GroupBox();
            this.dataGridViewEcologya = new System.Windows.Forms.DataGridView();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.ZoomPlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomMinusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomNormalРазмерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.tabControlEcologya.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuWebBrowser.SuspendLayout();
            this.tabPageTester.SuspendLayout();
            this.groupBoxWarning.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            this.groupBoxDataVariant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEcologya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTest
            // 
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
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
            this.tabControlEcologya.Size = new System.Drawing.Size(771, 588);
            this.tabControlEcologya.TabIndex = 0;
            this.tabControlEcologya.Tag = "XC";
            // 
            // tabPageBook
            // 
            this.tabPageBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageBook.Controls.Add(this.splitContainer1);
            this.tabPageBook.Location = new System.Drawing.Point(23, 4);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(744, 580);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Tag = "IC";
            this.tabPageBook.Text = "Электронный учебник";
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
            this.splitContainer1.Size = new System.Drawing.Size(738, 574);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewEcologya
            // 
            this.treeViewEcologya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.treeViewEcologya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewEcologya.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.treeViewEcologya.Location = new System.Drawing.Point(0, 0);
            this.treeViewEcologya.Name = "treeViewEcologya";
            this.treeViewEcologya.Size = new System.Drawing.Size(179, 574);
            this.treeViewEcologya.TabIndex = 0;
            this.treeViewEcologya.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEcologya_AfterSelect);
            // 
            // webBrowserEcologya
            // 
            this.webBrowserEcologya.ContextMenuStrip = this.contextMenuWebBrowser;
            this.webBrowserEcologya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserEcologya.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserEcologya.Location = new System.Drawing.Point(0, 0);
            this.webBrowserEcologya.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserEcologya.Name = "webBrowserEcologya";
            this.webBrowserEcologya.ScriptErrorsSuppressed = true;
            this.webBrowserEcologya.Size = new System.Drawing.Size(555, 574);
            this.webBrowserEcologya.TabIndex = 0;
            this.webBrowserEcologya.Url = new System.Uri("C:\\Users\\Андрей\\Source\\Repos\\TestingProgranForEcologiya\\GUI_testing\\bin\\Debug\\htm" +
        "l\\vved.html", System.UriKind.Absolute);
            this.webBrowserEcologya.WebBrowserShortcutsEnabled = false;
            this.webBrowserEcologya.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowserEcologya_NewWindow);
            // 
            // contextMenuWebBrowser
            // 
            this.contextMenuWebBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomPlusToolStripMenuItem,
            this.ZoomMinusToolStripMenuItem,
            this.ZoomNormalРазмерToolStripMenuItem,
            this.CloseCatalogToolStripMenuItem});
            this.contextMenuWebBrowser.Name = "contextMenuWebBrowser";
            this.contextMenuWebBrowser.Size = new System.Drawing.Size(217, 108);
            // 
            // tabPageTester
            // 
            this.tabPageTester.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageTester.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageTester.Controls.Add(this.groupBoxWarning);
            this.tabPageTester.Controls.Add(this.groupBoxControl);
            this.tabPageTester.Controls.Add(this.groupBoxDataVariant);
            this.tabPageTester.Controls.Add(this.groupBoxTask);
            this.tabPageTester.Location = new System.Drawing.Point(23, 4);
            this.tabPageTester.Name = "tabPageTester";
            this.tabPageTester.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTester.Size = new System.Drawing.Size(744, 580);
            this.tabPageTester.TabIndex = 1;
            this.tabPageTester.Tag = "IC";
            this.tabPageTester.Text = "Тестирование";
            // 
            // groupBoxWarning
            // 
            this.groupBoxWarning.Controls.Add(this.labelTask);
            this.groupBoxWarning.Location = new System.Drawing.Point(382, 8);
            this.groupBoxWarning.Name = "groupBoxWarning";
            this.groupBoxWarning.Size = new System.Drawing.Size(353, 202);
            this.groupBoxWarning.TabIndex = 5;
            this.groupBoxWarning.TabStop = false;
            this.groupBoxWarning.Text = "Внимание";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(5, 23);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(342, 135);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = resources.GetString("labelTask.Text");
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.labelResult);
            this.groupBoxControl.Controls.Add(this.butResult);
            this.groupBoxControl.Controls.Add(this.textResult);
            this.groupBoxControl.Controls.Add(this.labelAttemptHint);
            this.groupBoxControl.Controls.Add(this.labelTime);
            this.groupBoxControl.Controls.Add(this.labelTimeHint);
            this.groupBoxControl.Controls.Add(this.butStart);
            this.groupBoxControl.Location = new System.Drawing.Point(384, 216);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(354, 231);
            this.groupBoxControl.TabIndex = 4;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Управление";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(16, 119);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Результат:";
            // 
            // butResult
            // 
            this.butResult.Location = new System.Drawing.Point(258, 113);
            this.butResult.Name = "butResult";
            this.butResult.Size = new System.Drawing.Size(75, 23);
            this.butResult.TabIndex = 5;
            this.butResult.Text = "Ответ";
            this.butResult.UseVisualStyleBackColor = true;
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(84, 116);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(168, 20);
            this.textResult.TabIndex = 4;
            // 
            // labelAttemptHint
            // 
            this.labelAttemptHint.AutoSize = true;
            this.labelAttemptHint.Location = new System.Drawing.Point(16, 40);
            this.labelAttemptHint.Name = "labelAttemptHint";
            this.labelAttemptHint.Size = new System.Drawing.Size(85, 13);
            this.labelAttemptHint.TabIndex = 3;
            this.labelAttemptHint.Text = "Попытка 0 из 3";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(96, 19);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 13);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "0:00:00";
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
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(236, 18);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(97, 35);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Начать тест";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
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
            // dataGridViewEcologya
            // 
            this.dataGridViewEcologya.AllowUserToAddRows = false;
            this.dataGridViewEcologya.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Amount,
            this.Value});
            this.dataGridViewEcologya.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewEcologya.Name = "dataGridViewEcologya";
            this.dataGridViewEcologya.ReadOnly = true;
            this.dataGridViewEcologya.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewEcologya.Size = new System.Drawing.Size(344, 355);
            this.dataGridViewEcologya.TabIndex = 1;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Величина";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 150;
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
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
            // ZoomPlusToolStripMenuItem
            // 
            this.ZoomPlusToolStripMenuItem.Image = global::GUI_testing.Properties.Resources.Zoom_In;
            this.ZoomPlusToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ZoomPlusToolStripMenuItem.Name = "ZoomPlusToolStripMenuItem";
            this.ZoomPlusToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ZoomPlusToolStripMenuItem.Text = "Увеличить";
            this.ZoomPlusToolStripMenuItem.Click += new System.EventHandler(this.ZoomPlusToolStripMenuItem_Click);
            // 
            // ZoomMinusToolStripMenuItem
            // 
            this.ZoomMinusToolStripMenuItem.Image = global::GUI_testing.Properties.Resources.Zoom_Out;
            this.ZoomMinusToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ZoomMinusToolStripMenuItem.Name = "ZoomMinusToolStripMenuItem";
            this.ZoomMinusToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ZoomMinusToolStripMenuItem.Text = "Уменьшить";
            this.ZoomMinusToolStripMenuItem.Click += new System.EventHandler(this.ZoomMinusToolStripMenuItem_Click);
            // 
            // ZoomNormalРазмерToolStripMenuItem
            // 
            this.ZoomNormalРазмерToolStripMenuItem.Image = global::GUI_testing.Properties.Resources.Search__1_;
            this.ZoomNormalРазмерToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ZoomNormalРазмерToolStripMenuItem.Name = "ZoomNormalРазмерToolStripMenuItem";
            this.ZoomNormalРазмерToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ZoomNormalРазмерToolStripMenuItem.Text = "Обычный размер";
            this.ZoomNormalРазмерToolStripMenuItem.Click += new System.EventHandler(this.ZoomNormalРазмерToolStripMenuItem_Click);
            // 
            // CloseCatalogToolStripMenuItem
            // 
            this.CloseCatalogToolStripMenuItem.Image = global::GUI_testing.Properties.Resources.Button_First;
            this.CloseCatalogToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CloseCatalogToolStripMenuItem.Name = "CloseCatalogToolStripMenuItem";
            this.CloseCatalogToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.CloseCatalogToolStripMenuItem.Text = "Закрыть дерево каталога";
            this.CloseCatalogToolStripMenuItem.Click += new System.EventHandler(this.CloseCatalogToolStripMenuItem_Click);
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "Gel XP 2.2 (gel).vssf");
            // 
            // TestingEcologya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 588);
            this.Controls.Add(this.tabControlEcologya);
            this.Name = "TestingEcologya";
            this.Text = "Тестирование по Экологии";
            this.Load += new System.EventHandler(this.TestingEcologya_Load);
            this.tabControlEcologya.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuWebBrowser.ResumeLayout(false);
            this.tabPageTester.ResumeLayout(false);
            this.groupBoxWarning.ResumeLayout(false);
            this.groupBoxWarning.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            this.groupBoxDataVariant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEcologya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxWarning;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button butResult;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.ContextMenuStrip contextMenuWebBrowser;
        private System.Windows.Forms.ToolStripMenuItem ZoomPlusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomMinusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomNormalРазмерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseCatalogToolStripMenuItem;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
    }
}

