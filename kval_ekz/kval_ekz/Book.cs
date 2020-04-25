using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kval_ekz
{
    public class Book
    {
        private string name;
        private string author;
        private string genre;

        public Book()
        {
            this.name = "";
            this.author = "";
            this.genre = "";
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public string Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }
    }
}
