using BusinessLogic.CloudController;
using System.Data;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace BusinessLogic
{
    public class ReturnLogic
    {
        //Create object of the Binding
        static Binding binding;
        //Create endpointAddress of the Service
        static EndpointAddress endpointAddress;
        //Create Client of the Service
        CloudControllerSoapClient cloudController;
        public ReturnLogic()
        {
            binding = new BasicHttpsBinding();
            endpointAddress = new
            EndpointAddress("https://localhost:44357/CloudController.asmx");
            cloudController = new CloudControllerSoapClient(binding, endpointAddress);
        }

        public DataSet getUserBoorrowedByTheUser(int userID)
        {
            DataSet userBooks = cloudController.booksBorrowedBy(userID);
            return userBooks;
        }

        //should Update not delete
        public string updateSelectedBook(string bookISBN, string currentDate)
        {
            int rowsAffected = cloudController.updateActualReturnDate(bookISBN, currentDate);
            if (rowsAffected >= 1)
            {
                return "Returned Successfully";
            }else{
                return "Return Failed";
            }
        }
    }
}
