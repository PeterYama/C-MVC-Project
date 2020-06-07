using System.Data;
using DataAccess;
namespace BusinessLogic
{
    public class ReturnLogic
    {
        dbManager myDbManager;
        public ReturnLogic()
        {
            myDbManager = new dbManager();
        }

        public DataSet getUserBoorrowedByTheUser(int userID)
        {
            //should remove the user selection from the table
            //should return an updatad table and set to the grid view
            DataSet userBooks = myDbManager.booksBorrowedBy(userID);
            return userBooks;
        }

        //should Update not delete
        public string updateSelectedBook(string bookISBN, string currentDate)
        {
            int rowsAffected = myDbManager.updateActualReturnDate(bookISBN, currentDate);
            if (rowsAffected >= 1)
            {
                return "Returned Successfully";
            }else{
                return "Return Failed";
            }
        }
    }
}
