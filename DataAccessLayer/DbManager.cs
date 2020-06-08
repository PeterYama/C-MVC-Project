using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
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
            connString = "Data Source=SQL5045.site4now.net;Initial Catalog=DB_A57252_B20ES6518;" +
                "Persist Security Info=True;User ID=DB_A57252_B20ES6518_admin;Password=Ah6tqEC8";
            dataSet = new DataSet();
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
        public DataSet getTableUsing(string query)
        {
            OpenConnection();
            using (SqlCommand sqlCommand = new SqlCommand(query, SqlConn))
            {
                // define parameters and their values
                dataSet = new DataSet();
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataSet, "books");
                CloseConnection();
                return dataSet;
            }
        }

        public DataSet getAllUsers(string query)
        {
            OpenConnection();
            using (SqlCommand sqlCommand = new SqlCommand(query, SqlConn))
            {
                // define parameters and their values
                dataSet = new DataSet();
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataSet, "users");
                CloseConnection();
                return dataSet;
            }
        }

        public DataSet getCurrentAuthor()
        {
            string queryString = "select * from TabAuthor";
            OpenConnection();
            using (SqlCommand sqlCommand = new SqlCommand(queryString, SqlConn))
            {
                // define parameters and their values
                dataSet = new DataSet();
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataSet, "author");
                CloseConnection();
                return dataSet;
            }
        }

        public DataSet getCurrentLanguage()
        {
            string queryString = "select * from TabLanguage";
            OpenConnection();
            using (SqlCommand sqlCommand = new SqlCommand(queryString, SqlConn))
            {
                // define parameters and their values
                dataSet = new DataSet();
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataSet, "language");
                CloseConnection();
                return dataSet;
            }
        }

        public int insertNewlanguage(string text)
        {
            OpenConnection();
            string queryText =
                "Insert Into TabLanguage ( LanguageName ) Values ( @_LanguageName)";
            using (SqlCommand sqlCommand = new SqlCommand(queryText, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_LanguageName", SqlDbType.VarChar, 50).Value = text;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
        }

        public int updateBook(string ISBN, string bookName, int author, int categ, int lang, int publishYear, int nPages, string publisher)
        {
            OpenConnection();
            string query = "UPDATE TabBook " +
                "SET BookName = @_BookName, " +
                "Author = @_Author, " +
                "Category = @_Category, " +
                "Language = @_Language, " +
                "PublishYear = @_PublishYear, " +
                "Pages = @_Pages, " +
                "Publisher  = @_Publisher " +
                "WHERE ISBN = @_ISBN";

            using (SqlCommand sqlCommand = new SqlCommand(query, SqlConn))
            {
                sqlCommand.Parameters.Add("@_ISBN", SqlDbType.VarChar, 50).Value = ISBN;
                sqlCommand.Parameters.Add("@_BookName", SqlDbType.VarChar, 50).Value = bookName;
                sqlCommand.Parameters.Add("@_Author", SqlDbType.VarChar, 50).Value = author;
                sqlCommand.Parameters.Add("@_Category", SqlDbType.Int, 5).Value = categ;
                sqlCommand.Parameters.Add("@_Language", SqlDbType.Int, 5).Value = lang;
                sqlCommand.Parameters.Add("@_PublishYear", SqlDbType.Int, 4).Value = publishYear;
                sqlCommand.Parameters.Add("@_Pages", SqlDbType.Int, 5).Value = nPages;
                sqlCommand.Parameters.Add("@_Publisher", SqlDbType.VarChar, 50).Value = publisher;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
        }

        public DataSet getTotalFee()
        {
            string queryString = "Select SUM (LateFee) as TotalFee from TabBorrow";
            OpenConnection(); //Opens the Connection
            SqlCommand sqlCommand = new SqlCommand(queryString, SqlConn); //Create an SqlCommand
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet, "TotalFee"); //Fills a DataSet & gives a table name
            CloseConnection();
            return dataSet;
        }

        public int deleteUser(int user)
        {
            OpenConnection();
            string sql = "DELETE FROM TabUser WHERE UID = @_User";
            using (SqlCommand sqlCommand = new SqlCommand(sql, SqlConn))
            {
                sqlCommand.Parameters.Add("@_User", SqlDbType.VarChar, 50).Value = user;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
        }

        public int updateUser(int userID, string userName,string userPass, int userLevel, string email)
        {
            OpenConnection();
            string query = "UPDATE TabUser " +
                "SET UserName  = @_UserName, " +
                "Password = @_Password, " +
                "UserLevel = @_UserLevel, " +
                "UserEmail = @_UserEmail " +
                "WHERE UID = @_UID";

            using (SqlCommand sqlCommand = new SqlCommand(query, SqlConn))
            {
                sqlCommand.Parameters.Add("@_UID", SqlDbType.Int, 4).Value = userID;
                sqlCommand.Parameters.Add("@_UserName", SqlDbType.VarChar, 50).Value = userName;
                sqlCommand.Parameters.Add("@_Password", SqlDbType.VarChar, 5).Value = userPass;
                sqlCommand.Parameters.Add("@_UserLevel", SqlDbType.Int, 50).Value = userLevel;
                sqlCommand.Parameters.Add("@_UserEmail", SqlDbType.VarChar, 50).Value = email;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
        }

        public int saveNewUser(string userName, string password, int userLevel, string email)
        {
            OpenConnection();
            string queryText =
                "Insert Into TabUser ( UserName,  Password, UserLevel, UserEmail ) Values ( @_UserName, @_Password, @_UserLevel, @_UserEmail )";
            using (SqlCommand sqlCommand = new SqlCommand(queryText, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_UserName", SqlDbType.VarChar, 50).Value = userName;
                sqlCommand.Parameters.Add("@_Password", SqlDbType.VarChar, 50).Value = password;
                sqlCommand.Parameters.Add("@_UserLevel", SqlDbType.Int, 4).Value = userLevel;
                sqlCommand.Parameters.Add("@_UserEmail", SqlDbType.VarChar, 50).Value = email;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
        }

        public int deleteBook(string bookISBN)
        {
            deleteFirstChield(bookISBN);
            deleteSecondChield(bookISBN);
            OpenConnection();
            string sql = "DELETE FROM TabBook WHERE ISBN = @_ISBN";
            using (SqlCommand sqlCommand = new SqlCommand(sql, SqlConn))
            {
                sqlCommand.Parameters.Add("@_ISBN", SqlDbType.VarChar, 50).Value = bookISBN;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
        }

        private void deleteSecondChield(string bookISBN)
        {
            OpenConnection();
            string sql = "DELETE FROM TabReserved WHERE ISBN = @_ISBN";
            using (SqlCommand sqlCommand = new SqlCommand(sql, SqlConn))
            {
                sqlCommand.Parameters.Add("@_ISBN", SqlDbType.VarChar, 50).Value = bookISBN;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        private void deleteFirstChield(string bookISBN)
        {
            OpenConnection();
            string sql = "DELETE FROM TabBorrow WHERE ISBN = @_ISBN";
            using (SqlCommand sqlCommand = new SqlCommand(sql, SqlConn))
            {
                sqlCommand.Parameters.Add("@_ISBN", SqlDbType.VarChar, 50).Value = bookISBN;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public int insertNewAuthor(string text)
        {
            OpenConnection();
            string queryText =
                "Insert Into TabAuthor ( AuthorName ) Values ( @_AuthorName)";
            using (SqlCommand sqlCommand = new SqlCommand(queryText, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_AuthorName", SqlDbType.VarChar, 50).Value = text;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
        }

        public int insertNewCategory(string text)
        {
            OpenConnection();
            string queryText =
                "Insert Into TabCategory ( CategoryName ) Values ( @_CategoryName)";
            using (SqlCommand sqlCommand = new SqlCommand(queryText, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_CategoryName", SqlDbType.VarChar, 50).Value = text;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
        }

        public DataSet getCurrentCategories()
        {
            string queryString = "select * from TabCategory";
            OpenConnection(); //Opens the Connection
            SqlCommand sqlCommand = new SqlCommand(queryString, SqlConn); //Create an SqlCommand
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet, "categories"); //Fills a DataSet & gives a table name
            CloseConnection();
            return dataSet;
        }

       

        public int updateActualReturnDate(string bookISBN,string currentTime)
        {
            OpenConnection();
            string query = "UPDATE TabBorrow " +
                "SET ActualReturnDate = @_currentTime " +
                "WHERE ISBN = @_bookISBN";

            using (SqlCommand sqlCommand = new SqlCommand(query, SqlConn))
            {
                sqlCommand.Parameters.Add("@_bookISBN", SqlDbType.VarChar, 50).Value = bookISBN;
                sqlCommand.Parameters.Add("@_currentTime", SqlDbType.DateTime, 50).Value = DateTime.Parse(currentTime);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return rowsAffected;
            }
        }

        public DataSet booksBorrowedBy(int userID)
        {
            OpenConnection();
             //create a new table joining TabBorrow and TabBook
            string query =
                "SELECT TabBorrow.ISBN, TabBook.BookName, TabBorrow.ActualReturnDate , TabBorrow.LateFee " +
                "FROM TabBorrow " +
                "INNER JOIN TabBook ON TabBook.ISBN=TabBorrow.ISBN " +
                "WHERE UID = @_UID";
            using (SqlCommand sqlCommand = new SqlCommand(query, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_UID", SqlDbType.VarChar, 50).Value = userID;
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataSet, "userBooks");
                CloseConnection();
                return dataSet;
            }
        }

        //Books Available to borrow
        public DataSet booksAvailablToBorrow()
        {
            string queryString = "select * from ViewBookAvailable";
            OpenConnection(); //Opens the Connection
            SqlCommand sqlCommand = new SqlCommand(queryString, SqlConn); //Create an SqlCommand
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet, "books"); //Fills a DataSet & gives a table name
            CloseConnection();
            return dataSet;
        }

        public string checkReservedDate(string ISBN)
        {
            OpenConnection();
            dataSet = new DataSet();
            string query = "select ReservedDate from TabReserved where ISBN = @_ISBN";
            using (SqlCommand sqlCommand = new SqlCommand(query, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_ISBN", SqlDbType.VarChar, 50).Value = ISBN;
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataSet, "bookISBN");
                //if the selected book is not in TabBorrow, then it's available
                if (dataSet.Tables["bookISBN"].Rows.Count <= 0)
                {
                    CloseConnection();
                    return ""; //Book has not being reserved
                }
                else
                {
                    //if the book was found in the tabBorrow, then return the ActualReturnDate
                    string untreatedDate = 
                        ((DateTime)dataSet.Tables["bookISBN"].Rows[0].ItemArray[0]).Date.ToString();
                    string treatedDate = untreatedDate.Remove(9).Replace("/", "-");
                    CloseConnection();
                    return treatedDate; 
                    //Reserved Date
                }
            }
        }

        public DataSet CheckUser(string userName, string userPassword)
        {
            OpenConnection(); //Opens the Connection
            SqlCommand sqlCommand = new SqlCommand(null, SqlConn); //Create an SqlCommand

            sqlCommand.CommandText =
            "select * from TabUser where UserName = @id AND Password = @pass";
            sqlCommand.Parameters.Add("@id", SqlDbType.VarChar, 50).Value = userName;
            sqlCommand.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = userPassword;
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataAdapter.Fill(dataSet, "user");
            CloseConnection();
            return dataSet;
        }
        public int createNewReservedRecord(int userID, string ISBN, string reservationDate)
        {
            OpenConnection();
            string queryText = 
                "Insert Into TabReserved ( UID, ISBN, ReservedDate )" + 
                "Values (@_UID, @_ISBN, @_ReservedDate)";
           
            using (SqlCommand sqlCommand = new SqlCommand(queryText, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_UID", SqlDbType.Int, 5).Value = userID;
                sqlCommand.Parameters.Add("@_ISBN", SqlDbType.VarChar, 50).Value = ISBN;
                sqlCommand.Parameters.Add("@_ReservedDate", SqlDbType.DateTime, 50).Value = DateTime.Parse(reservationDate);
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }
        }

        public int insertNewBook(string ISBN, string bookName, int author, int categ, int lang, int publishYear, int nPages, string publisher)
        {
            OpenConnection();
            string queryText =
                "Insert Into TabBook ( ISBN ,BookName , Author , Category , Language , PublishYear , Pages , Publisher  )" +
                "Values ( @ISBN, @BookName, @Author, @Category, @Language, @PublishYear, @Pages, @Publisher)";

            using (SqlCommand sqlCommand = new SqlCommand(queryText, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@ISBN", SqlDbType.VarChar, 50).Value = ISBN;
                sqlCommand.Parameters.Add("@BookName", SqlDbType.VarChar, 50).Value = bookName;
                sqlCommand.Parameters.Add("@Author", SqlDbType.VarChar, 50).Value = author;
                sqlCommand.Parameters.Add("@Category", SqlDbType.Int, 5).Value = categ; 
                sqlCommand.Parameters.Add("@Language", SqlDbType.Int, 5).Value = lang;
                sqlCommand.Parameters.Add("@PublishYear", SqlDbType.Int, 4).Value = publishYear;
                sqlCommand.Parameters.Add("@Pages", SqlDbType.Int, 5).Value = nPages;
                sqlCommand.Parameters.Add("@Publisher", SqlDbType.VarChar, 50).Value = publisher;
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
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
                    CloseConnection();
                    return "2000-01-01"; //default value for available
                }
                else
                {
                    //if the book was found in the tabBorrow, then return the ActualReturnDate
                    string untreatedDate = ((System.DateTime)dataSet.Tables["bookISBN"].Rows[0].ItemArray[0]).Date.ToString();
                    string treatedDate = untreatedDate.Remove(9).Replace("/", "-");
                    CloseConnection();
                    return treatedDate;
                }
            }
        }

        public int saveBookBorrowed(int userID, string bookISBN, string borrowDate, string estimatedReturnDate)
        {
            OpenConnection();
            string queryText = 
                "Insert Into TabBorrow ( UID, ISBN, BorrowDate, ReturnDate ) " + 
                "Values (@_UID, @_ISBN, @_BorrowDate, @_ReturnDate)";
            using (SqlCommand sqlCommand = new SqlCommand(queryText, SqlConn))
            {
                // define parameters and their values
                sqlCommand.Parameters.Add("@_UID", SqlDbType.Int, 5).Value = userID;
                sqlCommand.Parameters.Add("@_ISBN", SqlDbType.VarChar, 50).Value = bookISBN;
                sqlCommand.Parameters.Add("@_BorrowDate", SqlDbType.DateTime, 50).Value = DateTime.Parse(borrowDate);
                sqlCommand.Parameters.Add("@_ReturnDate", SqlDbType.DateTime, 50).Value = DateTime.Parse(estimatedReturnDate);
                affectedRows = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return affectedRows;
            }

        }
    }
    }
