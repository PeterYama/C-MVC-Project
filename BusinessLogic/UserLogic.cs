using BusinessLogic.CloudController;
using System.Data;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace BusinessLogic
{
    public class userLogic
    {
        //Create object of the Binding
        static Binding binding;
        //Create endpointAddress of the Service
        static EndpointAddress endpointAddress;
        //Create Client of the Service
        CloudControllerSoapClient cloudController;
        DataSet data;
        UserModel user;
        public userLogic()
        {
            binding = new BasicHttpsBinding();
            endpointAddress = new
            EndpointAddress("https://localhost:44357/CloudController.asmx");
            cloudController = new CloudControllerSoapClient(binding, endpointAddress);
            user = new UserModel();
        }

        //Prepare a statment agains sql injections
        //Request the database manager a query
        public UserModel checkUser(string userName, string userPass)
        {
            data = cloudController.CheckUser(userName, userPass);
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
