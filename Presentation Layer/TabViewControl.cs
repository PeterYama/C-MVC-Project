using Business_Logic;
using BusinessLogic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class TabViewControl : Form
    { 
        DataSet dataSet;
        SearchLogic search;
        BorrowLogic borrowLogic;
        ReserveLogic reserveLogic;
        string userChoice;
        string borrowDate;
        string returnDate;
        string bookISBN;
        string message;
        int userID;
        string reservationDate;
        DateTime localDate;
        string currentTime;
        public TabViewControl()
        {
            localDate = DateTime.Now;
            currentTime = localDate.ToString().Remove(9).Replace("/", "-");
            //var rand = new Random();
            //userID = rand.Next();
            //later on get the user ID when Login
            userID = 1;
            InitializeComponent();
            dataSet = new DataSet();
            search = new SearchLogic();
            borrowLogic = new BorrowLogic();
            reserveLogic = new ReserveLogic();
            InitializeDefault(); 
            this.myCombo.Items.AddRange(new object[] {
                "Title",
                "Published Year",
                "Language",
                "Author",
                "Category"});
        }
        private void InitializeDefault()
        {
            dataSet = search.getBooksBy("Display All");
            resultGridView.DataSource = dataSet;
            resultGridView.DataMember = "books";
            resultGridView.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.BackgroundColor = Color.LightGray;
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };
        }
        private void InitializeDataGridView()
        {
            userChoice = myCombo.SelectedItem.ToString();
            dataSet = search.getBooksBy(userChoice);
            searchResultGrid.DataSource = dataSet;
            searchResultGrid.DataMember = "books";

            searchResultGrid.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.BackgroundColor = Color.LightGray;
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            InitializeDataGridView();
        }

        //Get the Book when user click on the cell content
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get User Selection
            //Always get the book title Get the exact cell clicked
            object value = resultGridView.Rows[e.RowIndex].Cells[0].Value;
            bookISBN = value.ToString();
            userSelection_lbl.Text = bookISBN;
        }

        //Load Available books when the user select the tab borrow
        private void Selected_TabChanged(object sender, TabControlEventArgs e)
        {
            //TabPageIndex 0 = Book Browse
            //TabPageIndex 1 = Book Search
            //TabPageIndex 2 = Book Borrow
            //TabPageIndex 3 = Book Reserve
            if (e.TabPageIndex == 2)
            {
                dataSet = borrowLogic.getAllBooks();
                availableBooks_dataGridView.DataSource = dataSet;
                availableBooks_dataGridView.DataMember = "books";
                availableBooks_dataGridView.DataBindingComplete += (o, _) =>
                {
                    var dataGridView = o as DataGridView;
                    if (dataGridView != null)
                    {
                        dataGridView.BackgroundColor = Color.LightGray;
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                };
            }else if(e.TabPageIndex == 3)
            {
                dataSet = reserveLogic.getAllBooks();
                reserveGridView.DataSource = dataSet;
                reserveGridView.DataMember = "books";
                reserveGridView.DataBindingComplete += (o, _) =>
                {
                    var dataGridView = o as DataGridView;
                    if (dataGridView != null)
                    {
                        dataGridView.BackgroundColor = Color.LightGray;
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                };
            }
        }
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            //front-end validation to check if any value is null
            if(userSelection_lbl.Text == "")
            {
                //user has not selected a book
                MessageBox.Show("Please Select a Book");
            }else if (borrowDate == null)
            {
                //user has not selected a borrow date
                MessageBox.Show("Please select a Borrow Date");
            }
            else if (returnDate == null)
            {
                //user has not selecte a returnDate
                MessageBox.Show("Please Select a return Date");
            }else if((userSelection_lbl.Text != "") && (borrowDate != null) && (returnDate != null))
            {
                //All values were inserted, check if the book is borrowable
                message = borrowLogic.checkBorrowableBook(userID, bookISBN, borrowDate, returnDate);
                MessageBox.Show(message);
            }

            //If borrowDate is equal to today AND the book is not borrowed
            //Register the book to tabborrow

        }

        private void setBorrowDate(object sender, EventArgs e)
        {
            //Get user Borrow Date
            //Make the date from the dropdowwn suitable for Queries
            var borrowStr = userBorrowDate_DropDown.Value.ToString().Replace("/", "-");
            var borrowStrTimeRemoved = borrowStr.Remove(10);
            borrowDate = borrowStrTimeRemoved.Trim();
            
        }

        private void setReturnDate(object sender, EventArgs e)
        {
            //Get user Return Date
            var returnStr = retrunDate_DropDown.Value.ToString().Replace("/", "-");
            var returnStrTimeRemoved = returnStr.Remove(10);
            returnDate = returnStrTimeRemoved.Trim();
        }

        private void reserveGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = reserveGridView.Rows[e.RowIndex].Cells[0].Value;
            bookISBN = value.ToString();
        }

        private void setReservationDate(object sender, EventArgs e)
        {
            var returnStr = reserveStartDropdown.Value.ToString().Replace("/", "-");
            var returnStrTimeRemoved = returnStr.Remove(10);
            reservationDate = returnStrTimeRemoved.Trim();
        }

        private void reservationConfirm_Btn_Click(object sender, EventArgs e)
        {
            //Reserve Logic
            string message = reserveLogic.saveNewRecordToReserved(bookISBN, reservationDate, userID);
            MessageBox.Show(message);
        }
    }
}