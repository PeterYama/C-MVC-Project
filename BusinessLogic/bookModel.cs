using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BookModel
    {
        private string _ISBN;

        public string ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        private string _bookName;

        public string bookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        private int _author;

        public int author
        {
            get { return _author; }
            set { _author = value; }
        }

        private int _category;

        public int category
        {
            get { return _category; }
            set { _category = value; }
        }

        private int _language;

        public int language
        {
            get { return _language; }
            set { _language = value; }
        }

        private int _publishYear;

        public int publishYear
        {
            get { return _publishYear; }
            set { _publishYear = value; }
        }

        private int _pages;

        public int pages
        {
            get { return _pages; }
            set { _pages = value; }
        }

        private string _publisher;

        public string publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
    }
}
