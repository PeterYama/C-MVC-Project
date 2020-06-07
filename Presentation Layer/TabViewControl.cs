using BusinessLogic;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class TabViewControl : Form
    { 
        DataSet dataSet;
        AdminLogic adminLogic;
        SearchLogic search;
        BorrowLogic borrowLogic;
        ReserveLogic reserveLogic;
        ReturnLogic returnLogic;
        DateTime localDate;
        string userChoice;
        string borrowDate;
        string returnDate;
        string bookISBN;
        string message;
        int userID;
        int userLevel;
        string reservationDate;
        string currentTime;
        int adminCategorySelected;
        int adminLanguageSelected;
        int adminAuthorSelection;
        string adminPublishYear;
        public TabViewControl(UserModel user)
        {
            localDate = DateTime.Now;
            currentTime = localDate.ToString().Remove(9).Replace("/", "-");
            userID = user.userID;
            userLevel = user.userLevel;
            dataSet = new DataSet();
            adminLogic = new AdminLogic();
            search = new SearchLogic();
            borrowLogic = new BorrowLogic();
            reserveLogic = new ReserveLogic();
            returnLogic = new ReturnLogic();
            InitializeComponent();
            InitializeDefault();
            changeVisibilityDependingOnThe(userLevel);
            this.myCombo.Items.AddRange(new object[] {
                "Title",
                "Published Year",
                "Language",
                "Author",
                "Category"});
        }

        private void changeVisibilityDependingOnThe(int userLevel)
        {
            //If Admin Show Admin Pages, Else Hide Admin Pages
            if (userLevel == 3)
            {
                TabControl.HideTab(browseTab);
                TabControl.HideTab(searchTab);
                TabControl.HideTab(borrowTab);
                TabControl.HideTab(bookRetrunTab);
                TabControl.HideTab(reserveTab);
                this.categoryDropDown.Items.AddRange(adminLogic.getCategory());
                this.authorDropDown.Items.AddRange(adminLogic.getAuthor());
                this.languageDropDown.Items.AddRange(adminLogic.getLanguage());
            }
            else if((userLevel == 1) || (userLevel == 2)){
                
                TabControl.HideTab(addBookTab);
            }
        }

        private void InitializeDefault()
        {
            dataSet = search.getBooksBy("Display All");
            resultGridView.DataSource = dataSet;
            resultGridView.DataMember = "books";
            formatTable(resultGridView);
        }
        private void InitializeDataGridView()
        {
            dataSet = new DataSet();
            userChoice = myCombo.SelectedItem.ToString();
            dataSet = search.getBooksBy(userChoice);
            searchResultGrid.DataSource = dataSet;
            searchResultGrid.DataMember = "books";
            formatTable(searchResultGrid);

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
            try
            {
                object value = availableBooks_dataGridView.Rows[e.RowIndex].Cells[0].Value;
                bookISBN = value.ToString();
                userSelection_lbl.Text = bookISBN;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please Click on the Book To select it");
            }
           
        }

        private void Selected_TabChanged(object sender, TabControlEventArgs e)
        {
            //TabPageIndex 0 = Book Browse
            //TabPageIndex 1 = Book Search
            //TabPageIndex 2 = Book Borrow
            //TabPageIndex 3 = Book Reserve
            //TabPageIndex 4 = Book Return
            if (e.TabPageIndex == 2)
            {
                dataSet.Clear();
                dataSet = borrowLogic.getBooksAvailableToBorrow();
                availableBooks_dataGridView.DataSource = dataSet;
                availableBooks_dataGridView.DataMember = "books";
                formatTable(availableBooks_dataGridView);

            }else if(e.TabPageIndex == 3)
            {
                dataSet.Clear();
                dataSet = reserveLogic.getBooksReservable();
                reserveGridView.DataSource = dataSet;
                reserveGridView.DataMember = "books";
                formatTable(reserveGridView);

            }
            else if (e.TabPageIndex == 4)
            {
                dataSet.Clear();
                dataSet = returnLogic.getUserBoorrowedByTheUser(userID);
                userBorrowedBooks_GridView.DataSource = dataSet;
                userBorrowedBooks_GridView.DataMember = "userBooks";
                formatTable(userBorrowedBooks_GridView);
            }
        }
        private void bookBorrowBtnClick(object sender, EventArgs e)
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
            try
            {
                object value = reserveGridView.Rows[e.RowIndex].Cells[0].Value;
                bookISBN = value.ToString();
                reserveSelection_txt.Text = reserveGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please click on the book to select it");
            }
            
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
            if(reservationDate == null)
            {
                MessageBox.Show("Select a reservation Date");
            }
            else
            {
                string message = reserveLogic.saveNewRecordToReserved(bookISBN, reservationDate, userID);
                MessageBox.Show(message);
            }
        }

        private void userBorrowedBooks_GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                object value = userBorrowedBooks_GridView.Rows[e.RowIndex].Cells[0].Value;
                bookISBN = value.ToString();
                returnSelection_lbl.Text = userBorrowedBooks_GridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (ArgumentOutOfRangeException problem)
            {
                Console.WriteLine(problem.Message);
                MessageBox.Show("Out of Range, click over a book to select it");
            }
            
        }

        private void returnButtomPressed(object sender, EventArgs e)
        {
            //should send user Selection Return Logic
            if(bookISBN == null)
            {
                message = "Please Select a Book";
            }
            else
            {
                message = returnLogic.updateSelectedBook(bookISBN, currentTime);

            }
            MessageBox.Show(message);
            //Update the List
            dataSet = returnLogic.getUserBoorrowedByTheUser(userID);
            userBorrowedBooks_GridView.DataSource = dataSet;
            userBorrowedBooks_GridView.DataMember = "userBooks";
            //remove user selection
            returnSelection_lbl.Text = "";
        }

        private void formatTable(DataGridView name)
        {
            name.DataBindingComplete += (o, _) =>
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

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            //Should grab the user input and send to Admin Logic
            //Grab adminPublisherText.Txt, adminNumberOfPagesTxt.Txt, adminBookTitleTxt
            //Add to book model
            //request to save the new book to the db
            var rand = new Random();
            bookISBN = rand.Next().ToString();
            BookModel book = new BookModel();
            //Check if the form was filled properly
            if(adminBookTitleTxt.Text == "")
            {
                message = "Title cannot be empty";
            }else if (adminPublisherText.Text == "") 
            {
                message = "Please select the publisher";
            }else if (adminNumberOfPagesTxt.Text == "")
            {
                message = "Insert the number of pages";
            }else if(adminPublishYear == "")
            {
                message = "Publish Year cannot be empty";
            }else if(adminLanguageSelected <= 0)
            {
                message = "Select a language";
            }else if(adminCategorySelected <= 0)
            {
                message = "Select a category";
            }else if(adminAuthorSelection <= 0)
            {
                message = "Select an Author";

            }else if ((adminBookTitleTxt.Text != "")&& (adminPublisherText.Text != "") && (adminNumberOfPagesTxt.Text != "") 
                && (adminPublishYear != "") && (adminLanguageSelected > 0) && (adminCategorySelected > 0) && (adminAuthorSelection > 0))
            {
                book.ISBN = bookISBN;
                book.bookName = adminBookTitleTxt.Text;
                book.publisher = adminPublisherText.Text;
                book.pages = Convert.ToInt32(adminNumberOfPagesTxt.Text);
                book.publishYear = Convert.ToInt32(adminPublishYear);
                book.language = Convert.ToInt32(adminLanguageSelected);
                book.category = Convert.ToInt32(adminCategorySelected);
                book.author = adminAuthorSelection;
                int affectedrows =adminLogic.handleNewBookInsertion(book);

                if (affectedrows > 0)
                {
                    message = "Book was saved to the database successfully !";
                }
                else
                {
                    message = "there was an error when saving the book";
                }
            }
            MessageBox.Show(message);
        }

        private void categorySelected(object sender, EventArgs e)
        {
            if ((string)((System.Windows.Forms.ComboBox)sender).SelectedItem != "")
            {
                adminCategorySelected = ((System.Windows.Forms.ComboBox)sender).SelectedIndex +1;
                MessageBox.Show("Category Selected = " + adminCategorySelected.ToString());
            }
        }

        private void languageClicked(object sender, EventArgs e)
        {
            if ((string)((System.Windows.Forms.ComboBox)sender).SelectedItem != "")
            {
                adminLanguageSelected = ((System.Windows.Forms.ComboBox)sender).SelectedIndex +1;
                MessageBox.Show("Category Selected = " + adminLanguageSelected.ToString());
            }
        }

        private void authorClicked(object sender, EventArgs e)
        {
            if ((string)((System.Windows.Forms.ComboBox)sender).SelectedItem != "")
            {
                adminAuthorSelection = ((System.Windows.Forms.ComboBox)sender).SelectedIndex + 1;
                MessageBox.Show("Category Selected = " + adminAuthorSelection.ToString());
            }
        }

        private void adminSelectedPublishDate(object sender, EventArgs e)
        {
            var untreatedPublishYear = adminPublishYearSelection.Value.ToString().Replace("/", "-");
            var publishyear = untreatedPublishYear.Remove(10);
            adminPublishYear = publishyear.Substring(5).Replace("-", "");
        }

        private void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}