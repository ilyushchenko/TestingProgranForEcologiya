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
        private void TestingEcologya_Load(object sender, EventArgs e)
        {
            //Пример использования по циклу можно построить таблицк с вариантом
            this.dataGridViewEcologya.Rows.Add("№ Варианта");
            this.dataGridViewEcologya.Rows.Add("Вещество");
            this.dataGridViewEcologya.Rows.Add("ПДК, мг/м^3");
            this.dataGridViewEcologya.Rows.Add("Cф, мг/м^3");
            this.dataGridViewEcologya.Rows.Add("Н, м");
            this.dataGridViewEcologya.Rows.Add("F");
            this.dataGridViewEcologya.Rows.Add("m");
            this.dataGridViewEcologya.Rows.Add("n");
            this.dataGridViewEcologya.Rows.Add("Mx, % от ПДВ");
            this.dataGridViewEcologya.Rows.Add("Температура среды");
            this.dataGridViewEcologya.Rows.Add("Диаметр трубы");
            this.dataGridViewEcologya.Rows.Add("a");
            this.dataGridViewEcologya.Rows.Add("b");
            this.dataGridViewEcologya.Rows.Add("Mx, % от ПДВ");
            this.dataGridViewEcologya.Rows.Add("w0, м/с", "1.5");
            //for (int k = 0; k < 10; k++ )
            //{
            //    this.dataGridViewEcologya.Rows.Add();
            //}
               // dataGridViewEcologya.Rows[1].Cells[1].ReadOnly = true;

           // electronic_book.ReadTextBook();
            BuildContentBook(electronic_book.ReadTextBook());
        }

        private void BuildContentBook(List<ContentsElectronickBook> contents_electronic_book)
        {
            int[] list = new int[] { 2,5, 12, 14, 21, 28 };
            
            foreach (var content_book in contents_electronic_book)
            {
                int z = 2;
                if (content_book.number_subsections == 0)
                {
                    treeViewEcologya.Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                    treeViewEcologya.Tag = content_book.link_site;
                }
                for (int k = 0; k < 6; k++)
                {
                    if (content_book.number_subsections == list[k])
                    {
                        treeViewEcologya.Nodes[z].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                    }
                    z++;
                }
                //for (int k = 2; k < 6; k++)
                //{

                //if (content_book.number_subsections == content_book.number_sections && content_book.number_subsections != 0)
                //{
                //    treeViewEcologya.Nodes[z].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                //}
                //z++;
                //}
                
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

        private void butStart_Click(object sender, EventArgs e)
        {
            timerTest.Enabled = true;
            timerTest.Start();
            start = DateTime.Now;
            stop = DateTime.Parse("00:45:00");
        }
       
        private void timerTest_Tick(object sender, EventArgs e)
        {
            TimeSpan time = (DateTime.Now - start).Duration();
            labelTime.Text = time.ToString("hh\\:mm\\:ss");
            if (time.Minutes  == stop.Minute)
            {
                timerTest.Stop();
                MessageBox.Show("Тест не решен!");
                butStart.Enabled = false;
                butResult.Enabled = false;
            }
        }
        
    }
}
