using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BorrowLogic
    {
        dbManager myDbManager;
        DataSet data;
        string message;
        public BorrowLogic()
        {
            myDbManager = new dbManager();
        }
        public DataSet getAllBooks()
        {
                data = myDbManager.QueryDatabase("SELECT TabBook.ISBN, TabBook.BookName, TabBook.PublishYear , TabBook.Publisher " +
                "FROM TabBook ");
                return data;
        }
        public string checkBorrowableBook(int userID, string bookISBN, string borrowDate, string estimatedReturnDate)
        {
            string actualReturnDate = myDbManager.checkActualReturnDate(bookISBN);
            if (actualReturnDate != "")
            {
                if (DateTime.Parse(actualReturnDate) <= DateTime.Parse(borrowDate))
                {
                    //book is borrowed
                    int rows = myDbManager.saveBookBorrowed(userID, bookISBN, borrowDate, estimatedReturnDate);
                    if (rows > 0)
                    {
                        //Success
                        message = "Book was borrowed successfully";
                    }
                    else
                    {
                        //fail
                        message = "Fail saving book to the database";
                    }
                }
                else
                {
                    message = "book is alread borrowed";
                }
            }
            else
            {
                message = "could not get the actual return date";
            }
            return message;
        }

    }
}
