using BusinessLogic.CloudController;
using System;
using System.Data;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace BusinessLogic
{
    public class BorrowLogic
    {
        //Create object of the Binding
        static Binding binding;
        //Create endpointAddress of the Service
        static EndpointAddress endpointAddress;
        //Create Client of the Service
        CloudControllerSoapClient cloudController;
        DataSet data;
        string message;

        public BorrowLogic()
        {
            binding = new BasicHttpsBinding();
            endpointAddress = new
            EndpointAddress("https://localhost:44357/CloudController.asmx");
            cloudController = new CloudControllerSoapClient(binding, endpointAddress);
        }
        public DataSet getBooksAvailableToBorrow()
        {
                data = cloudController.booksAvailablToBorrow();
                return data;
        }
        public string checkBorrowableBook(int userID, string bookISBN, string borrowDate, string estimatedReturnDate)
        {
            string actualReturnDate = cloudController.checkActualReturnDate(bookISBN);
            if (actualReturnDate != "")
            {
                if (DateTime.Parse(actualReturnDate) <= DateTime.Parse(borrowDate))
                {
                    //book is borrowed
                    //If not reserved return null
                    //IF reserved return the ReservedDate
                    string ReservedDate = cloudController.checkReservedDate(bookISBN);

                    if (ReservedDate != "")
                    {
                        //book has being reserved, check if reserved date is lower than user selection
                        if(DateTime.Parse(ReservedDate) <= DateTime.Parse(borrowDate))
                        {
                            int rows = cloudController.saveBookBorrowed(userID, bookISBN, borrowDate, estimatedReturnDate);
                            if (rows > 0)
                            {
                                //Success
                                message = "Book was borrowed successfully";
                            }
                            else
                            {
                                //fail
                                message = "Fail saving book to the database";
                            }
                        }
                    }
                    else
                    {
                        //book has not being Reserved and can be borrowed
                        int rows = cloudController.saveBookBorrowed(userID, bookISBN, borrowDate, estimatedReturnDate);
                        if (rows > 0)
                        {
                            //Success
                            message = "Book was borrowed successfully";
                        }
                        else
                        {
                            //fail
                            message = "Fail saving book to the database";
                        }
                    }
                }
                else
                {
                    message = "book is alread borrowed";
                }
            }
            else
            {
                message = "could not get the actual return date";
            }
            return message;
        }

    }
}
