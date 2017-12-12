﻿using System;
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
            this.dataGridViewEcologya.Rows.Add("w0, м/с");
            dataGridViewEcologya.Rows[1].Cells[1].ReadOnly = true;

            //treeViewEcologya.Nodes.Add(new TreeNode("Загаловок"));
            //treeViewEcologya.Nodes.Add(new TreeNode("Введение"));
            //treeViewEcologya.Nodes[0].Nodes.Add("dddd");
            
            electronic_book.ReadTextBook();
            //electronic_book.BuildCatalog(treeViewEcologya);
            BuildContentBook();
        }

        private void BuildContentBook()
        {
            int[] list = new int [7] { 0, 2, 5, 12, 14, 21, 28 };
            
            foreach (var content_book in electronic_book.ContentBook)
            {
                
                //if (content_book.number_subsections == 0)
                //{
                //    treeViewEcologya.Nodes.Add(content_book.title_division);
                //    //treeViewEcologya.Tag = content_book.link_site;
                //    treeViewEcologya.Nodes[0].Tag = content_book.link_site;
                //}
                //if (content_book.number_subsections == 2)
                //{
                //    treeViewEcologya.Nodes[2].Nodes.Add(content_book.title_division);
                //    treeViewEcologya.Tag = content_book.link_site;
                //}
                //if (content_book.number_subsections == 5)
                //{
                //    treeViewEcologya.Nodes[3].Nodes.Add(content_book.title_division);
                //    treeViewEcologya.Tag = content_book.link_site;
                //}
                //if (content_book.number_subsections == 12)
                //{
                //    treeViewEcologya.Nodes[4].Nodes.Add(content_book.title_division);
                //    treeViewEcologya.Tag = content_book.link_site;
                //}
                //if (content_book.number_subsections == 14)
                //{
                //    treeViewEcologya.Nodes[5].Nodes.Add(content_book.title_division);
                //    treeViewEcologya.Tag = content_book.link_site;
                //}
                //if (content_book.number_subsections == 21)
                //{
                //    treeViewEcologya.Nodes[6].Nodes.Add(content_book.title_division);
                //    treeViewEcologya.Tag = content_book.link_site;
                //}
                //if (content_book.number_subsections == 28)
                //{
                //    treeViewEcologya.Nodes[7].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                //   // treeViewEcologya.Nodes[7].Nodes[0].Tag = content_book.link_site;
                //    treeViewEcologya.Nodes[7].Tag = content_book.link_site;
                //}
                for (int k=0; k<= list.Length; k++)
                {
                    if (content_book.number_subsections == list[k])
                    {
                        treeViewEcologya.Nodes[0].Nodes.Add(content_book.title_division).Tag = content_book.link_site;
                        // treeViewEcologya.Nodes[7].Nodes[0].Tag = content_book.link_site;
                        treeViewEcologya.Nodes[k].Tag = content_book.link_site;
                    }
                }

            }
        }

        private void treeViewEcologya_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(treeViewEcologya.SelectedNode.Text));
        }

        private void treeViewEcologya_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(Convert.ToString(e.Node.Tag));
                // MessageBox.Show(  Path.GetFullPath("html\\"+    Convert.ToString(e.Node.Tag)));
                 webBrowserEcologya.Url = new Uri(Path.GetFullPath("html\\" + Convert.ToString(e.Node.Tag)));
        }
        
    }
}
