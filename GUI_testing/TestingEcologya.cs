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

        private void TestingEcologya_Load(object sender, EventArgs e)
        {
         
           this.dataGridViewEcologya.Rows.Add("№ Варианта");
           this.dataGridViewEcologya.Rows.Add("Вещество");
           this.dataGridViewEcologya.Rows.Add("ПДК, мг/м^3");

          
        }
        
    }
}
