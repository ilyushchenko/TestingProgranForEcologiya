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
        //private List<int> number_sections = new List<int>();
        //private List<int> number_subsections = new List<int>();
        //private List<string> title_division = new List<string>();
        //private List<string> link_site = new List<string>();

        ContentsElectronickBook contents_books = new ContentsElectronickBook();
        List<ContentsElectronickBook> list_contents_books = new List<ContentsElectronickBook>();
        public struct ContentsElectronickBook
        {
           public int number_sections {set; get;}
           public int number_subsections {set; get;}
           public string title_division {set; get;}
           public string link_site {set; get;}
        }
        public void ReadTextBook()
        {
            using (StreamReader read_text_book = new StreamReader("html\\index.txt", encoding: Encoding.GetEncoding(1251)))
            {
                while(!read_text_book.EndOfStream)
                {
                    string[] str = read_text_book.ReadLine().Split(new[] { "#" }, StringSplitOptions.RemoveEmptyEntries);
                    contents_books.number_sections = int.Parse(str[0]);
                    contents_books.number_subsections = int.Parse(str[1]);
                    contents_books.title_division = str[2];
                    contents_books.link_site = str[3];
                    list_contents_books.Add(contents_books);
                    
                    //number_sections.Add(int.Parse(str[0]));
                    //number_subsections.Add(int.Parse(str[1]));
                    //title_division.Add(str[2]);
                    //link_site.Add(str[3]);
                } 
            }
        }


        public void BuildCatalog(TreeView treeView)
        {
            foreach (var content_book in list_contents_books)
            {
               // treeView.Nodes[content_book.number_sections].Nodes[content_book.number_subsections].Nodes.Add(new TreeNode(content_book.title_division));
                if (content_book.number_subsections == 0)
                {
                    treeView.Nodes.Add(content_book.title_division);
                }
                if (content_book.number_subsections == 2)
                {
                    treeView.Nodes[2].Nodes.Add(content_book.title_division);
                }
                if (content_book.number_subsections == 5)
                {
                    treeView.Nodes[3].Nodes.Add(content_book.title_division);
                }
                if (content_book.number_subsections == 12)
                {
                    treeView.Nodes[4].Nodes.Add(content_book.title_division);
                }
                if (content_book.number_subsections == 14)
                {
                    treeView.Nodes[5].Nodes.Add(content_book.title_division);
                }
                if (content_book.number_subsections == 21)
                {
                    treeView.Nodes[6].Nodes.Add(content_book.title_division);
                }
                if (content_book.number_subsections == 28)
                {
                    treeView.Nodes[7].Nodes.Add(content_book.title_division);
                }

                //for (int k = 0; k < 10; k++)
                //{
                //    if (content_book.number_subsections == content_book.number_sections)
                //    {
                //        treeView.Nodes[4].Nodes.Add(content_book.title_division);
                //    }
                //}
               
            }
          //  treeView.Nodes.Add("Загаловок");
            //treeView.Nodes.Add("Введение");
            //treeView.Nodes[0].Nodes.Add("dddd");
        }
    }
}
