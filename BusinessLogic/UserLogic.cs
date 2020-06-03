using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Logic
{
    public class userLogic
    {
        dbManager myDbManager; //declare dbManager
        bool userExist;
        DataSet data;

        public userLogic()
        {
            myDbManager = new dbManager();
        }

        //Prepare a statment agains sql injections
        //Request the database manager a query
        public bool checkUser(string userName, string userPass)
        {
            data = myDbManager.CheckUser(userName, userPass);

            if(data.Tables[0].Rows.Count == 0)
            {
                userExist = false;
            }
            else
            {
                userExist = true;
            }
            return userExist;
        }
        
        //Based on the result redirect the user to BookSearch Page or
        //Display an error message
    }
}
