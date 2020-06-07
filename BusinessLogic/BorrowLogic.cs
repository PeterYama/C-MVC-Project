using DataAccess;
using System;
using System.Data;

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
        public DataSet getBooksAvailableToBorrow()
        {
                data = myDbManager.booksAvailablToBorrow();
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
                    //If not reserved return null
                    //IF reserved return the ReservedDate
                    string ReservedDate = myDbManager.checkReservedDate(bookISBN);

                    if (ReservedDate != "")
                    {
                        //book has being reserved, check if reserved date is lower than user selection
                        if(DateTime.Parse(ReservedDate) <= DateTime.Parse(borrowDate))
                        {
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
                    }
                    else
                    {
                        //book has not being Reserved and can be borrowed
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
