using BusinessLogic.CloudController;

using System.Data;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace BusinessLogic
{
    public class SearchLogic
    {
        //Create object of the Binding
        static Binding binding;
        //Create endpointAddress of the Service
        static EndpointAddress endpointAddress;
        //Create Client of the Service
        CloudControllerSoapClient cloudController;
        DataSet data;
        public SearchLogic()
        {
            binding = new BasicHttpsBinding();
            endpointAddress = new
            EndpointAddress("https://localhost:44357/CloudController.asmx");
            cloudController = new CloudControllerSoapClient(binding, endpointAddress);
            data = new DataSet();
        }
        public DataSet getBooksBy(string userChoice)
        {
            switch (userChoice)
            {
                case "Title":
                    data = cloudController.getTableUsing("SELECT BookName, PublishYear, Publisher FROM TabBook");
                    return data;
                case "Published Year":
                    data = cloudController.getTableUsing("SELECT PublishYear, BookName,  Publisher FROM TabBook");
                    return data;
                case "Language":
                    data = cloudController.getTableUsing("SELECT Language, BookName, PublishYear, Publisher FROM TabBook");
                    return data;
                case "Author":
                    data = cloudController.getTableUsing("SELECT * FROM TabAuthor");
                    return data;
                case "Display All":
                    data = cloudController.getTableUsing("SELECT * FROM TabBook");
                    return data;
                case "Get Users":
                    data = cloudController.getAllUsers("Select * from TabUser");
                    return data;
                case "All Books Borrowed":
                    data = cloudController.getTableUsing("Select * from TabBorrow");
                    return data;
                case "All Pending Books":
                    data = cloudController.getTableUsing("Select * from TabBorrow " +
                        "where ActualReturnDate= CAST(CURRENT_TIMESTAMP AS DATE)");
                    return data;
            }
            return null;
        }
    }
}
