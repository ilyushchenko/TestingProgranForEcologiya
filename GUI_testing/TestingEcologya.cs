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
           // int[] list = new int[] { 5, 12, 14, 21, 28 };

            foreach (var content_book in contents_electronic_book)
            {
               // int z = 2;
                //if (content_book.number_subsections == 0)
                //{
                //    treeViewEcologya.Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                //    treeViewEcologya.Tag = content_book.link_site;
                //}
                CheckContent(content_book);
                    //if (content_book.number_subsections == list[k])
                    //{
                    //    treeViewEcologya.Nodes[z].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                    //    // treeViewEcologya.Nodes[z].Nodes[0].Tag = content_book.link_site;
                    //}
                //  z++;
            }
        }
        private void CheckContent(ContentsElectronickBook content_book)
        {
             switch (content_book.number_subsections)
                {
                    case 0:
                        {
                            treeViewEcologya.Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                            treeViewEcologya.Tag = content_book.link_site; break;
                        }
                    case 2:
                        {
                            treeViewEcologya.Nodes[2].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                            break;
                        }
                    case 5:
                        {
                            treeViewEcologya.Nodes[3].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                            break;
                        }
                    case 12:
                        {
                            treeViewEcologya.Nodes[4].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                            break;
                        }
                    case 14:
                        {
                            treeViewEcologya.Nodes[5].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                            break;
                        }
                    case 21:
                        {
                            treeViewEcologya.Nodes[6].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                            break;
                        }
                    case 28:
                        {
                            treeViewEcologya.Nodes[7].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                            break;
                        }
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
        
    }
}
