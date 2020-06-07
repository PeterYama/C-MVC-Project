using System.Data;
using DataAccess;

namespace BusinessLogic
{
    public class SearchLogic
    {
        dbManager myDbManager; //declare dbManager
        DataSet data;
        public SearchLogic()
        {
            myDbManager = new dbManager(); // initialize 
            data = new DataSet();
        }
        public DataSet getBooksBy(string userChoice)
        {
            switch (userChoice)
            {
                case "Title":
                    data = myDbManager.getTableUsing("SELECT BookName, PublishYear, Publisher FROM TabBook");
                    return data;
                case "Published Year":
                    data = myDbManager.getTableUsing("SELECT PublishYear, BookName,  Publisher FROM TabBook");
                    return data;
                case "Language":
                    data = myDbManager.getTableUsing("SELECT Language, BookName, PublishYear, Publisher FROM TabBook");
                    return data;
                case "Author":
                    data = myDbManager.getTableUsing("SELECT * FROM TabAuthor");
                    return data;
                case "Display All":
                    data = myDbManager.getTableUsing("SELECT * FROM TabBook");
                    return data;
            }
            return null;
        }
    }
}
