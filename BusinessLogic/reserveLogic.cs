using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
namespace BusinessLogic
{
    public class ReserveLogic
    {
        dbManager myDbManager;
        string message;
        DataSet data;
        public ReserveLogic()
        {
            myDbManager = new dbManager();
        }
        public string saveNewRecordToReserved(string bookISBN, string borrowDate, int userID)
        {
            //Check if the book is already reserved
            myDbManager = new dbManager();
            string query = "select * from tabborrow where ISBN = " + bookISBN;

            //Check if the user has selected a book
            if (bookISBN != null)
            {
                //save new record
                int userSaved = myDbManager.createNewReservedRecord(userID, bookISBN, borrowDate);
                if (userSaved == 1)
                {
                    message = "Book Reserved";
                }
                else
                {
                    message = "Could not reserve this book";
                }
            }
            else
            {
                message = "Please select a book";
            }

            return message;

            //Get the user selection, compare with the returned value from This query
            //Request dbManager to save a new record
        }

        public DataSet getAllBooks()
        {
            data = myDbManager.QueryDatabase("SELECT * FROM TabBook");
            return data;
        }
    }
}
