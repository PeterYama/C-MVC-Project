using System;
using System.Data;
using System.Linq;
using DataAccess;
namespace BusinessLogic
{
    public class AdminLogic
    {
        dbManager myDbManager;
        object[] temp;
        int count = 0;
        string message;
        public AdminLogic()
        {
            myDbManager = new dbManager();
        }

        public object[] getCategory()
        {
            DataSet tempDataSet = new DataSet();
            tempDataSet = myDbManager.getCurrentCategories();
            temp = new object[30];
            foreach (DataRow row in tempDataSet.Tables["categories"].Rows)
            {
                temp.SetValue(row[1],count);
                count++;
            }
            count = 0;
            //remove null values
            return temp.Where(c => c != null).ToArray();
        }

        public object[] getAuthor()
        {
            DataSet tempDataSet = new DataSet();
            tempDataSet = myDbManager.getCurrentAuthor();
            temp = new object[30];
            foreach (DataRow row in tempDataSet.Tables["author"].Rows)
            {
                temp.SetValue(row[1], count);
                count++;
            }
            count = 0;
            //remove null values
            return temp.Where(c => c != null).ToArray();
        }

        public object[] getLanguage()
        {
            DataSet tempDataSet = new DataSet();
            tempDataSet = myDbManager.getCurrentLanguage();
            temp = new object[30];
            foreach (DataRow row in tempDataSet.Tables["language"].Rows)
            {
                temp.SetValue(row[1], count);
                count++;
            }
            count = 0;
            //remove null values
            return temp.Where(c => c != null).ToArray();
        }

        public int handleNewBookInsertion(BookModel book)
        {
            //get the book obj then pass to the DataAccess
            int affectedrows = myDbManager.insertNewBook(book.ISBN, book.bookName, book.author, book.category, book.language, book.publishYear,book.pages, book.publisher);
            return affectedrows;
        }

        public string insertNewField(string text, string v)
        {
            if (v == "new category")
            {
                int rows = myDbManager.insertNewCategory(text);
                if (rows > 0)
                {
                    message = "New Category was added";
                }
            }
            else if (v == "new author")
            {
                int rows = myDbManager.insertNewAuthor(text);
                if (rows > 0)
                {
                    message = "New Author was added";
                }
            }
            else if (v == "new language")
            {
                int rows = myDbManager.insertNewlanguage(text);
                if (rows > 0)
                {
                    message = "New Laguage was added";
                }
            }

          return message;
        }

        public string requestBookUpdate(BookModel book)
        {
            int rows = myDbManager.updateBook(book.ISBN, book.bookName, book.author, book.category, book.language, book.publishYear, book.pages, book.publisher);
            if (rows > 0)
            {
                message = "Success";
            }
            else
            {
                message = "failed when trying to save";
            }
            return message;
        }

        public string requestBookDelete(string bookISBN)
        {
            int rows = myDbManager.deleteBook(bookISBN);
            if (rows > 0)
            {
                message = "Book was deleted";
            }
            else
            {
                message = "Book could not be deleted";
            }

            return message;
        }

        public string requestNewUserRegistration(UserModel user)
        {
            int rows = myDbManager.saveNewUser(user.userName, user.password, user.userLevel, user.email);
            if (rows > 0)
            {
                message = "New User Added Sucessfully";
            }
            else
            {
                message = "Failed While adding user";
            }
            return message;
        }

        public string requestTotalFee()
        {
            DataSet collection = myDbManager.getTotalFee();
            foreach (DataRow item in collection.Tables["TotalFee"].Rows)
            {
                message = item.ItemArray[0].ToString();
            }
            return message;
        }

        public string requestUserUpdate(UserModel user)
        {
            int rows = myDbManager.updateUser(user.userID, user.userName, user.password, user.accountLevel, user.email);
            if (rows > 0)
            {
                message = "User Updated";
            }
            else
            {
                message = "Fail updating the user";
            }
            return message;
        }

        public string requsetUserDelete(int user)
        {
            int rows = myDbManager.deleteUser(user);
            if (rows > 0)
            {
                message = "User Deleted";
            }
            else
            {
                message = "Fail Deleting the user";
            }
            return message;
        }
    }
}
