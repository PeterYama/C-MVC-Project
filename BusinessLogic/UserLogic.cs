using System.Data;
using DataAccess;

namespace BusinessLogic
{
    public class userLogic
    {
        dbManager myDbManager; //declare dbManager
        DataSet data;
        UserModel user;
        public userLogic()
        {
            myDbManager = new dbManager();
            user = new UserModel();
        }

        //Prepare a statment agains sql injections
        //Request the database manager a query
        public UserModel checkUser(string userName, string userPass)
        {
            data = myDbManager.CheckUser(userName, userPass);
            //Check user Lever
            //Lvl 1 user, Lvl 2 Support, lvl 3 Admin
            

            if(data.Tables[0].Rows.Count == 0)
            {
                user = new UserModel();
            }
            else
            {
                foreach (DataRow row in data.Tables["user"].Rows)
                {
                    user = UserModel.Parse(row);
                }
            }
            return user;
        }

       
        
        //Based on the result redirect the user to BookSearch Page or
        //Display an error message
    }
}
