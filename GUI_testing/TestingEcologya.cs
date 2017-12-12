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
            electronic_book.BuildCatalog(treeViewEcologya);
        }
        
    }
}
