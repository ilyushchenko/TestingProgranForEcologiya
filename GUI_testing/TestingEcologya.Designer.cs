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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlEcologya = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.tabPageTester = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlEcologya.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(738, 369);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 0;
            // 
            // TestingEcologya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 383);
            this.Controls.Add(this.tabControlEcologya);
            this.Name = "TestingEcologya";
            this.Text = "Тестирование по Экологии";
            this.tabControlEcologya.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControlEcologya;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPageTester;
    }
}

