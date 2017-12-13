using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace GUI_testing
{
    public struct ContentsElectronickBook
    {
        public int number_sections {  set; get; }
        public int number_subsections { set; get; }
        public string title_division {  set; get; }
        public string link_site {  set; get; }
    }
    class ElectronickTextBook
    {
       ContentsElectronickBook contents_books = new ContentsElectronickBook();
        List<ContentsElectronickBook> list_contents_books = new List<ContentsElectronickBook>();
        
        public List<ContentsElectronickBook> ReadTextBook()
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
                } 
            }
            return list_contents_books;
        }

    }
}
