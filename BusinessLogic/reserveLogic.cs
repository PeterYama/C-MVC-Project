using System;
using System.Data;
using DataAccess;

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
                string ReservedDate = myDbManager.checkReservedDate(bookISBN);

                if (ReservedDate != "")
                {
                    //Book is borrowed
                    //check if the ReservedDate is lower than user selection
                    if (DateTime.Parse(ReservedDate) <= DateTime.Parse(borrowDate))
                    {
                        //Book can be reserved
                        int userSaved = myDbManager.createNewReservedRecord(userID, bookISBN, borrowDate);
                        if (userSaved == 1)
                        {
                            message = "Book Reserved";
                        }
                        else
                        {
                            message = "Could not save the user";
                        }
                    }
                    else
                    {
                        message = "This book has already been booked on: " + ReservedDate;
                    }
                }
                else
                {
                    //book bas not being reserved, user can reserve
                    int userSaved = myDbManager.createNewReservedRecord(userID, bookISBN, borrowDate);
                    if (userSaved == 1)
                    {
                        message = "Book Reserved";
                    }
                    else
                    {
                        message = "Could not save the user";
                    }
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

        public DataSet getBooksReservable()
        {
            data = myDbManager.booksAvailablToBorrow();
            return data;
        }
    }
}
