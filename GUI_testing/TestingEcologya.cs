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

namespace GUI_testing
{
    public partial class TestingEcologya : Form
    {
        public TestingEcologya()
        {
            InitializeComponent();
        }
        ElectronickTextBook electronic_book = new ElectronickTextBook();
        DateTime start, stop;

        private TestManager test_manager = new TestManager();
        private void TestingEcologya_Load(object sender, EventArgs e)
        {
            //test_manager.Messaging += test_manager_Messaging;
            Variant variant = new Variant();
            BuildTabelVariant(variant);

            BuildContentBook(electronic_book.ReadTextBook());
            webBrowserEcologya.Url = new Uri(Path.GetFullPath("html\\start.html"));
            Variants variants = new Variants();
            test_manager.Load(variants);
        }

        private void test_manager_Messaging(object sendler, TestingEventArgs e)
        {
            switch (e.TestStatus)
            {
                case TestStatus.Start:  
                    break; 
                case TestStatus.EndOfTime:
                    break;
                case TestStatus.EndOfTryCount:
                    break;
                case TestStatus.WrongAnswer:
                    break;
                case TestStatus.Complete:
                    break;
                default:
                    break;
            }
               // MessageBox.Showe.TestStatus);
        }

        private void BuildContentBook(List<ContentsElectronickBook> contents_electronic_book)
        {
            int[] list = new int[] { 2, 5, 12, 14, 21, 28 };
            //int[] list = electronic_book.ListDirectory();
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
        private void CreateDirectory(ContentsElectronickBook content_book, int index, int [] list)
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
            start = DateTime.Now;
            stop = DateTime.Parse("00:45:00");

            Variant variant = test_manager.StartTest(3, 45);
            BuildTabelVariant(variant);
        }

        private void BuildTabelVariant(Variant variant)
        {
            dataGridViewEcologya.Rows.Clear();
            this.dataGridViewEcologya.Rows.Add("№ Варианта", variant.VariantNuimber);
            this.dataGridViewEcologya.Rows.Add("Вещество", variant.Material);
            this.dataGridViewEcologya.Rows.Add("ПДК, мг/м^3", variant.PDK);
            this.dataGridViewEcologya.Rows.Add("Cф, мг/м^3", variant.C_f);
            this.dataGridViewEcologya.Rows.Add("Н, м", variant.H);
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
            TimeSpan time = (DateTime.Now - start).Duration();
            labelTime.Text = time.ToString("hh\\:mm\\:ss");
            
            test_manager.Tick();
            if (test_manager.IsTestFinished())
            {
                timerTest.Stop();
                MessageBox.Show("Тест остановлен!");
                butStart.Enabled = false;
                butResult.Enabled = false;
            }
            
            //if (time.Minutes  == stop.Minute)
            //{
            //    timerTest.Stop();
            //    MessageBox.Show("Тест не решен!");
            //    butStart.Enabled = false;
            //    butResult.Enabled = false;
            //}
        }

        private void butResult_Click(object sender, EventArgs e)
        {
           if ( test_manager.CheckAnwser(double.Parse(textResult.Text)) == true)
           {
               timerTest.Stop();
               butStart.Enabled = false;
               butResult.Enabled = false;
               textResult.Enabled = false;
               MessageBox.Show("Тест выполнен успешно!");
               
           } else if (test_manager.TryCount >0)
           {
               MessageBox.Show(string.Format("Ответ неправильный! \nОставшиеся количество попыток {0}", test_manager.TryCount.ToString()));
               labelAttemptHint.Text = string.Format("Оставшиеся количество попыток {0} из 3", test_manager.TryCount.ToString());
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
