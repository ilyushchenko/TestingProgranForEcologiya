using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GUI_testing
{
    class ElectronickTextBook
    {
        private List<int> number_sections = new List<int>();
        private List<int> number_subsections = new List<int>();
        private List<string> title_division = new List<string>();
        private List<string> link_site = new List<string>();

        public void ReadTextBook()
        {
            using(StreamReader read_text_book = new StreamReader("html\\index.txt"))
            {
                while(!read_text_book.EndOfStream)
                {
                    string[] str = read_text_book.ReadLine().Split(new[] { "#" }, StringSplitOptions.RemoveEmptyEntries);
                    number_sections.Add(int.Parse(str[0]));
                    number_subsections.Add(int.Parse(str[1]));
                    title_division.Add(str[2]);
                    link_site.Add(str[3]);
                } 
            }
        }


        public void BuildCatalog(TreeView treeView)
        {
            
        }
    }
}
