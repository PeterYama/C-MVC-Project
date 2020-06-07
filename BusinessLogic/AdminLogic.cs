using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BusinessLogic
{
    public class AdminLogic
    {
        dbManager myDbManager;
        object[] temp;
        int count = 0;
        public AdminLogic()
        {
            myDbManager = new dbManager();
        }

        public object[] getCategory()
        {
            DataSet tempDataSet = myDbManager.getCurrentCategories();
            temp = new object[30];
            foreach (DataRow row in tempDataSet.Tables["categories"].Rows)
            {
                temp.SetValue(row[1],count);
                count++;
            }
            //remove null values
            return temp.Where(c => c != null).ToArray();
        }

        public object[] getAuthor()
        {
            DataSet tempDataSet = myDbManager.getCurrentAuthor();
            temp = new object[30];
            foreach (DataRow row in tempDataSet.Tables["author"].Rows)
            {
                temp.SetValue(row[1], count);
                count++;
            }
            //remove null values
            return temp.Where(c => c != null).ToArray();
        }

        public object[] getLanguage()
        {
            DataSet tempDataSet = myDbManager.getCurrentLanguage();
            temp = new object[30];
            foreach (DataRow row in tempDataSet.Tables["language"].Rows)
            {
                temp.SetValue(row[1], count);
                count++;
            }
            //remove null values
            return temp.Where(c => c != null).ToArray();
        }

        public int handleNewBookInsertion(BookModel book)
        {
            //get the book obj then pass to the DataAccess
            int affectedrows = myDbManager.insertNewBook(book.ISBN, book.bookName, book.author, book.category, book.language, book.publishYear,book.pages, book.publisher);
            return affectedrows;
        }
    }
}
