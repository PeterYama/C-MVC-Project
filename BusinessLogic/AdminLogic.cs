using BusinessLogic.CloudController;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace BusinessLogic

{
    public class AdminLogic
    {
        object[] temp;
        int count = 0;
        string message;
        //Create object of the Binding
        static Binding binding;
        //Create endpointAddress of the Service
        static EndpointAddress endpointAddress;
        //Create Client of the Service
        CloudControllerSoapClient cloudController;
        public AdminLogic()
        {
            binding = new BasicHttpsBinding();
            endpointAddress = new
            EndpointAddress("https://localhost:44357/CloudController.asmx");
            cloudController = new CloudControllerSoapClient(binding, endpointAddress);
        }

        public object[] getCategory()
        {
            DataSet tempDataSet = new DataSet();
            tempDataSet = cloudController.getCurrentCategories();
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
            tempDataSet = cloudController.getCurrentAuthor();
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
            tempDataSet = cloudController.getCurrentLanguage();
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
            int affectedrows = cloudController.insertNewBook(book.ISBN, book.bookName, book.author, book.category, book.language, book.publishYear,book.pages, book.publisher);
            return affectedrows;
        }

        public string insertNewField(string text, string v)
        {
            if (v == "new category")
            {
                int rows = cloudController.insertNewCategory(text);
                if (rows > 0)
                {
                    message = "New Category was added";
                }
            }
            else if (v == "new author")
            {
                int rows = cloudController.insertNewAuthor(text);
                if (rows > 0)
                {
                    message = "New Author was added";
                }
            }
            else if (v == "new language")
            {
                int rows = cloudController.insertNewlanguage(text);
                if (rows > 0)
                {
                    message = "New Laguage was added";
                }
            }

          return message;
        }

        public string requestBookUpdate(BookModel book)
        {
            int rows = cloudController.updateBook(book.ISBN, book.bookName, book.author, book.category, book.language, book.publishYear, book.pages, book.publisher);
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
            int rows = cloudController.deleteBook(bookISBN);
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
            int rows = cloudController.saveNewUser(user.userName, user.password, user.userLevel, user.email);
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
            DataSet collection = cloudController.getTotalFee();
            foreach (DataRow item in collection.Tables["TotalFee"].Rows)
            {
                message = item.ItemArray[0].ToString();
            }
            return message;
        }

        public string requestUserUpdate(UserModel user)
        {
            int rows = cloudController.updateUser(user.userID, user.userName, user.password, user.accountLevel, user.email);
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
            int rows = cloudController.deleteUser(user);
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
