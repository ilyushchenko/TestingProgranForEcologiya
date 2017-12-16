using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingProgramBusinessLogic;
using System.IO;
using TestingProgram.Data;

namespace GUI_testing
{
    public partial class TestingEcologya : Form
    {
        private TestManager test_manager;

        public TestingEcologya()
        {
            test_manager = new TestManager(new Variants());
            test_manager.Messaging += test_manager_Messaging;
            InitializeComponent();
            panelTester.Location = new Point(
             this.ClientSize.Width / 2 - panelTester.Size.Width / 2,
             this.ClientSize.Height / 2 - panelTester.Size.Height / 2);
            panelTester.Anchor = AnchorStyles.None;
        }

        private void TestingEcologya_Load(object sender, EventArgs e)
        {
            ElectronickTextBook electronic_book = new ElectronickTextBook();
            BuildTabelVariant(new Variant());
            BuildContentBook(electronic_book.ReadTextBook());
            webBrowserEcologya.Url = new Uri(Path.GetFullPath("html\\start.html"));
        }

        private void test_manager_Messaging(object sendler, TestingEventArgs e)
        {
            switch (e.TestStatus)
            {
                case TestStatus.EndOfTime:
                case TestStatus.EndOfTryCount:
                    {
                        ResetFormState();
                        MessageBox.Show(e.Message, "Ошибка!");
                        labelAttemptHint.Text = e.Message;
                        break;
                    }
                case TestStatus.WrongAnswer:
                    {
                        MessageBox.Show(e.Message, "Ошибка!");
                        labelAttemptHint.Text = e.Message;
                        break;
                    }
                case TestStatus.Complete:
                    {
                        ResetFormState();
                        MessageBox.Show(e.Message, "Поздравляем!");
                        labelAttemptHint.Text = e.Message;
                        break;
                    }

                default:
                    break;
            }
        }
        private void ResetFormState()
        {
            timerTest.Stop();
            butResult.Enabled = false;
            textResult.Enabled = false;
        }

        private void BuildContentBook(List<ContentsElectronickBook> contents_electronic_book)
        {
            int[] list = new int[] { 2, 5, 12, 14, 21, 28 };
            foreach (var content_book in contents_electronic_book)
            {
                int index = 2;
                CreateCatalog(content_book);
                CreateDirectory(content_book, index, list);
            }
        }

        private void CreateCatalog(ContentsElectronickBook content_book)
        {
            if (content_book.number_subsections == 0)
            {
                treeViewEcologya.Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                treeViewEcologya.Tag = content_book.link_site;
            }
        }
        private void CreateDirectory(ContentsElectronickBook content_book, int index, int[] list)
        {
            for (int k = 0; k < 6; k++)
            {
                if (content_book.number_subsections == list[k])
                {
                    treeViewEcologya.Nodes[index].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                }
                index++;
            }
        }
        private void butStart_Click(object sender, EventArgs e)
        {
            textResult.Enabled = true;
            textResult.Clear();
            textResult.Focus();
            butResult.Enabled = true;
            timerTest.Enabled = true;
            timerTest.Start();
            butStart.Enabled = false;
            IVariant variantTemp = test_manager.StartTest(3, 45);
            if (variantTemp is Variant )
            {
                Variant variant = variantTemp as Variant;
                BuildTabelVariant(variant);
            }
        }

        private void BuildTabelVariant(Variant variant)
        {
            dataGridViewEcologya.Rows.Clear();
            this.dataGridViewEcologya.Rows.Add("№ Варианта", variant.VariantNuimber);
            this.dataGridViewEcologya.Rows.Add("Вещество", variant.Material);
            this.dataGridViewEcologya.Rows.Add("ПДК, мг/м^3", variant.PDK);
            this.dataGridViewEcologya.Rows.Add("Cф, мг/м^3", variant.C_f);
            this.dataGridViewEcologya.Rows.Add("Н, м", variant.H);
            this.dataGridViewEcologya.Rows.Add("Температура", variant.Temperature);
            this.dataGridViewEcologya.Rows.Add("F", variant.F);
            this.dataGridViewEcologya.Rows.Add("m", variant.M);
            this.dataGridViewEcologya.Rows.Add("n", variant.N);
            this.dataGridViewEcologya.Rows.Add("Mx, % от ПДВ", variant.Mx);
            this.dataGridViewEcologya.Rows.Add("Температура среды", variant.TemperatureAvg);
            this.dataGridViewEcologya.Rows.Add("Диаметр трубы", variant.Diameter);
            this.dataGridViewEcologya.Rows.Add("a", variant.SideA);
            this.dataGridViewEcologya.Rows.Add("b", variant.SideB);
            this.dataGridViewEcologya.Rows.Add("w0, м/с", variant.W0);
        }
        private void timerTest_Tick(object sender, EventArgs e)
        {
            labelTime.Text = test_manager.Countdown.ToString();
            test_manager.Tick();
        }

        private void butResult_Click(object sender, EventArgs e)
        {
            double result;
            string text = textResult.Text;
            if (double.TryParse(text.Replace('.', ','), out result))
            {
                test_manager.CheckAnwser(result);
            }
            else
            {
                MessageBox.Show("Данные введенны неправильно!\nВвод числа производится через запятую! \nПример ввода: 1,75", "Ошибка!");
            }
        }

        #region События для WebBrowser
        private void ZoomPlusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowserEcologya.Document.Body.Style = "zoom:125%;";
        }

        private void ZoomMinusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowserEcologya.Document.Body.Style = "zoom:90%;";
        }

        private void ZoomNormalРазмерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowserEcologya.Document.Body.Style = "zoom:100%;";
        }

        private void CloseCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                splitContainer1.Panel1Collapsed = false;
                CloseCatalogToolStripMenuItem.Text = "Свернуть деерево каталога";
                CloseCatalogToolStripMenuItem.Image = GUI_testing.Properties.Resources.Button_First;
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;
                CloseCatalogToolStripMenuItem.Text = "Развернуть деерево каталога";
                CloseCatalogToolStripMenuItem.Image = GUI_testing.Properties.Resources.Button_End;
            }
        }
        private void treeViewEcologya_AfterSelect(object sender, TreeViewEventArgs e)
        {
            webBrowserEcologya.Url = new Uri(Path.GetFullPath("html\\" + Convert.ToString(e.Node.Tag)));
        }
        private void webBrowserEcologya_NewWindow(object sender, CancelEventArgs e)
        {
            ((WebBrowser)sender).Url = new Uri(((WebBrowser)sender).StatusText);
            e.Cancel = true;
        }
        #endregion


    }
}
