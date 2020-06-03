using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.Common;

namespace Data_Access_Layer
{
    public class dbManager
    {
        private string connString; //Connection String
        private SqlConnection SqlConn; //Manages the connection to SQL Server
        private SqlDataAdapter dataAdapter; //Manages the Queries
        private DataSet dataSet; //Set of Data in the memory
        int affectedRows;

        public dbManager()
        {
            connString = "Data Source=SQL5045.site4now.net;Initial Catalog=DB_A57252_B20ES6518;Persist Security Info=True;User ID=DB_A57252_B20ES6518_admin;Password=Ah6tqEC8";
        }

        private void OpenConnection()
        {
            SqlConn = new SqlConnection(connString);
            SqlConn.Open();
        }
        private void CloseConnection()
        {
            SqlConn.Close();
        }

        public DataSet QueryDatabase(string queryString)
        {
            dataSet = new DataSet(); //initialize the DataSet
            OpenConnection(); //Opens the Connection
            SqlCommand sqlCommand = new SqlCommand(queryString, SqlConn); //Create an SqlCommand
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet, "books"); //Fills a DataSet & gives a table name
            CloseConnection();
            return dataSet;
        }
        
        public DataSet CheckUser(string userName, string userPassword)
        {
            dataSet = new DataSet(); //initialize the DataSet
            OpenConnection(); //Opens the Connection
            SqlCommand sqlCommand = new SqlCommand(null, SqlConn); //Create an SqlCommand

            sqlCommand.CommandText =
            "select * from TabUser where UserName = @id AND Password = @pass";

            SqlParameter userID = new SqlParameter("@id", SqlDbType.VarChar, 100);
            SqlParameter userPass = new SqlParameter("@pass", SqlDbType.VarChar, 100);
            userID.Value = userName;
            userPass.Value = userPassword;
            sqlCommand.Parameters.Add(userID);
            sqlCommand.Parameters.Add(userPass);
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet, "user");
            CloseConnection();
            return dataSet;
        }
        public int createNewReservedRecord(int userID, string ISBN, string reservationDate)
        {
            OpenConnection();
            string queryText = "Insert Into TabReserved ( UID, ISBN, ReservedDate )" + "Values (@_UID, @_ISBN, @_ReservedDate)";
            ;
            using (SqlCommand sqlCommand = new SqlCommand(queryText, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_UID", SqlDbType.Int, 5).Value = userID;
                sqlCommand.Parameters.Add("@_ISBN", SqlDbType.VarChar, 50).Value = ISBN;
                sqlCommand.Parameters.Add("@_ReservedDate", SqlDbType.VarChar, 50).Value = reservationDate;
                affectedRows = sqlCommand.ExecuteNonQuery();
                return affectedRows;
            }
        }

        public string checkActualReturnDate(string bookISBN)
        {
            string query = "select ActualReturnDate from tabborrow where ISBN = @_ISBN";
            using (SqlCommand sqlCommand = new SqlCommand(query, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_ISBN", SqlDbType.VarChar, 50).Value = bookISBN;
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataSet, "bookISBN");

                //if the selected book is not in TabBorrow, then it's available
                if (dataSet.Tables["bookISBN"].Rows.Count <= 0)
                {
                    return "2000-01-01"; //default value for available
                }
                else
                {
                    //if the book was found in the tabBorrow, then return the ActualReturnDate
                    string untreatedDate = ((System.DateTime)dataSet.Tables["bookISBN"].Rows[0].ItemArray[0]).Date.ToString();
                    string treatedDate = untreatedDate.Remove(9).Replace("/", "-");
                    return treatedDate;
                }
            }
        }

        public int saveBookBorrowed(int userID, string bookISBN, string borrowDate, string estimatedReturnDate)
        {
            OpenConnection();
            string queryText = "Insert Into TabBorrow ( UID, ISBN, BorrowDate, ReturnDate ) " + "Values (@_UID, @_ISBN, @_BorrowDate, @_ReturnDate)";
            ;
            using (SqlCommand sqlCommand = new SqlCommand(queryText, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_UID", SqlDbType.Int, 5).Value = userID;
                sqlCommand.Parameters.Add("@_ISBN", SqlDbType.VarChar, 50).Value = bookISBN;
                sqlCommand.Parameters.Add("@_BorrowDate", SqlDbType.Date, 50).Value = DateTime.Parse(borrowDate);
                sqlCommand.Parameters.Add("@_ReturnDate", SqlDbType.Date, 50).Value = DateTime.Parse(estimatedReturnDate);
                affectedRows = sqlCommand.ExecuteNonQuery();
                return affectedRows;
            }

        }
    }
    }
