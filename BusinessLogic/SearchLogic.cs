using System;
using System.Data;
using System.Net.Http;
using Data_Access_Layer;

namespace Business_Logic
{
    public class SearchLogic
    {
        dbManager myDbManager; //declare dbManager
        DataSet data;
        string queryString;
        string message;

        public SearchLogic()
        {
            myDbManager = new dbManager(); // initialize 
        }

        public DataSet getBooksBy(string userChoice)
        {
            switch (userChoice)
            {
                case "Title":
                    data = myDbManager.QueryDatabase("SELECT BookName FROM ViewBook");
                    return data;
                case "Published Year":
                    data = myDbManager.QueryDatabase("SELECT PublishYear FROM TabBook");
                    return data;
                case "Language":
                    data = myDbManager.QueryDatabase("SELECT Language FROM TabBook");
                    return data;
                case "Author":
                    data = myDbManager.QueryDatabase("SELECT * FROM TabAuthor");
                    return data;
                case "Display All":
                    data = myDbManager.QueryDatabase("SELECT * FROM TabBook");
                    return data;
            }
            return null;

        }

        
    }
}
