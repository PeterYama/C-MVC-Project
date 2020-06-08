using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        BookModel defaultBook;
        DateTime localDate;
        List<string> adminNewCatMessages;
        string userChoice;
        string borrowDate;
        string returnDate;
        string bookISBN;
        string message;
        string updateUserID;
        string reservationDate;
        string currentTime;
        string adminPublishYear;
        int userID;
        int userLevel;
        int adminCategorySelected;
        int adminLanguageSelected;
        int adminAuthorSelection;
        int userAccountLevel;

        public TabViewControl(UserModel user)
        {
            InitializeComponent();
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
            defaultBook = new BookModel();
            //user Level has being passed from the login screen
            changeVisibilityDependingOnThe(userLevel);
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
                //new book dropdowns
                this.categoryDropDown.Items.AddRange(adminLogic.getCategory());
                this.authorDropDown.Items.AddRange(adminLogic.getAuthor());
                this.languageDropDown.Items.AddRange(adminLogic.getLanguage());
                //update book dropdowns
                this.updateAuthorDropDown.Items.AddRange(adminLogic.getCategory());
                this.updateCategoryDropDown.Items.AddRange(adminLogic.getAuthor());
                this.updateLanguageDropDown.Items.AddRange(adminLogic.getLanguage());
                //update DataSet for userSelection
                updateBookGridUsing(updataBookGrid);
                //Load List of Books to be deleted
                updateBookGridUsing(deleteBookSelectionGrid);
                //Populate userLevelDropdown
                newUserAdminLevelComboBox.Items.AddRange(new object[] {
                "User",
                "Support",
                "Admin"});
                //Update User Grid View
                updateGridUsing(updateUserAccountSelectionGridView,"Get Users");
                //Pupulate updateUserCombo
                userUpdateComboSelection.Items.AddRange(new object[] {
                "User",
                "Support",
                "Admin"});
                //Populate Report Tab
                updateBookGridUsing(borrowedBooksGridView, "All Books Borrowed");
                //Populate Pending Retunrn View
                updateBookGridUsing(pendingReturnGridView, "All Pending Books");
                //Total Fee Label
                totalFeeValue.Text = adminLogic.requestTotalFee();
            }
            else if((userLevel == 1) || (userLevel == 2)){
                //hide admin pages from regular user and Support
                TabControl.HideTab(addBookTab);
                TabControl.HideTab(newFieldTab);
                TabControl.HideTab(updateBookTab);
                TabControl.HideTab(deleteBookTab);
                TabControl.HideTab(updateUserTab);
                TabControl.HideTab(nweUserTab);
                TabControl.HideTab(reportTab);
                //initialize BookBrowseGrid
                updateBookGridUsing(resultGridView);
                //populate Search DropDown
                this.myCombo.Items.AddRange(new object[] {
                "Title",
                "Published Year",
                "Language",
                "Author",
                "Category"});
            }
        }
        //List the books depending on the user selection
        private void search_btn_Click(object sender, EventArgs e)
        {
            if(userChoice != "")
            {
                updateBookGridUsing(searchResultGrid, userChoice);
            }
            else
            {
                MessageBox.Show("Select a category");
            }
        }

        //Get the Book when user click on the cell content
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get User Selection
            try
            {   
                //Always gets the BookISBN independent on what part of the cell the user has clicked
                object value = availableBooks_dataGridView.Rows[e.RowIndex].Cells[0].Value;
                bookISBN = value.ToString();
                userSelection_lbl.Text = bookISBN;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please Click on the Book To select it");
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
            dataSet.Clear();
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
                    //need to handle ArgumentOutOfRangeException
                    dataGridView.BackgroundColor = Color.LightGray;
                    dataGridView.AutoSizeColumnsMode = 
                    DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1]
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            if ((string)((ComboBox)sender).SelectedItem != "")
            {
                adminCategorySelected = ((System.Windows.Forms.ComboBox)sender).SelectedIndex +1;
            }
        }

        private void languageClicked(object sender, EventArgs e)
        {
            if ((string)((ComboBox)sender).SelectedItem != "")
            {
                adminLanguageSelected = ((System.Windows.Forms.ComboBox)sender).SelectedIndex +1;
            }
        }

        private void authorClicked(object sender, EventArgs e)
        {
            if ((string)((ComboBox)sender).SelectedItem != "")
            {
                adminAuthorSelection = ((ComboBox)sender).SelectedIndex + 1;
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

        private void addNewFieldConfirmButton_Click(object sender, EventArgs e)
        {
            adminNewCatMessages = new List<string>();
            if (newCategoryTxt.Text != "")
            {
                adminNewCatMessages.Add(adminLogic.insertNewField(newCategoryTxt.Text, "new category"));
            }if(newAuthorText.Text != "")
            {
                adminNewCatMessages.Add(adminLogic.insertNewField(newAuthorText.Text, "new author"));
            }
            if (newLnaguageText.Text != "")
            {
                adminNewCatMessages.Add(adminLogic.insertNewField(newLnaguageText.Text, "new language"));
            }

            if (adminNewCatMessages.Count != 0)
            {
                foreach (string item in adminNewCatMessages)
                {
                    MessageBox.Show(item);
                }
            }
            else
            {
                MessageBox.Show("You need to add at least 1");
            }
            
        }

        private void updataBookSelected(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                object bookISBN = updataBookGrid.Rows[e.RowIndex].Cells[0].Value;
                updateUserSelection.Text = bookISBN.ToString();
                //Create a default book to use if the user has not selected a property
                //This will avoid null values being inserted to the database
                defaultBook.ISBN = bookISBN.ToString();
                defaultBook.bookName = updataBookGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                defaultBook.author = Convert.ToInt32(updataBookGrid.Rows[e.RowIndex].Cells[2].Value);
                defaultBook.category = Convert.ToInt32(updataBookGrid.Rows[e.RowIndex].Cells[3].Value);
                defaultBook.language = Convert.ToInt32(updataBookGrid.Rows[e.RowIndex].Cells[4].Value);
                defaultBook.publishYear = Convert.ToInt32(updataBookGrid.Rows[e.RowIndex].Cells[5].Value);
                defaultBook.pages = Convert.ToInt32(updataBookGrid.Rows[e.RowIndex].Cells[6].Value);
                defaultBook.publisher = updataBookGrid.Rows[e.RowIndex].Cells[7].Value.ToString();

            }
            catch (ArgumentOutOfRangeException problem)
            {
                Console.WriteLine(problem.Message);
                MessageBox.Show("Out of Range, click over a book to select it");
            }
        }

        private void updatePublishYearDateDropdDown_ValueChanged(object sender, EventArgs e)
        {
            var untreatedPublishYear = updatePublishYearDateDropdDown.Value.ToString().Replace("/", "-");
            var publishyear = untreatedPublishYear.Remove(10);
            adminPublishYear = publishyear.Substring(5).Replace("-", "");
        }

        private void updateConfirmBtn_Click(object sender, EventArgs e)
        {
            BookModel book = new BookModel();

            if (defaultBook.ISBN != null)
            {
                book.ISBN = defaultBook.ISBN;
                //if the user has not selected a property, default will be used
                if (adminPublishYear != "")
                {
                    book.publishYear = Convert.ToInt32(adminPublishYear);
                }
                else
                {
                    book.publishYear = defaultBook.publishYear;
                }

                if (adminAuthorSelection > 0)
                {
                    book.author = adminAuthorSelection;
                }
                else
                {
                    book.author = defaultBook.author;
                }

                if (adminCategorySelected > 0)
                {
                    book.category = adminCategorySelected;
                }
                else
                {
                    book.category = defaultBook.category;
                }
                if (adminLanguageSelected > 0)
                {
                    book.language = adminLanguageSelected;
                }
                else
                {
                    book.language = defaultBook.language;
                }

                if (updateBookNameTxt.Text != "")
                {
                    book.bookName = updateBookNameTxt.Text;
                }
                else
                {
                    book.bookName = defaultBook.bookName;
                }

                if (updateNumberOfPagesText.Text != "")
                {
                    book.pages = Convert.ToInt32(updateNumberOfPagesText.Text);
                }
                else
                {
                    book.pages = defaultBook.pages;
                }

                if (updatePublisherText.Text != "")
                {
                    book.publisher = updatePublisherText.Text;
                }
                else
                {
                    book.publisher = defaultBook.publisher;
                }

                //submit the request to update
                message = adminLogic.requestBookUpdate(book);
            }
            else
            {
                message = "Select a book to proceed";
            }
             MessageBox.Show(message);
            updateBookGridUsing(updataBookGrid);
        }

        private void deleteBookSelected(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                object value = deleteBookSelectionGrid.Rows[e.RowIndex].Cells[0].Value;
                defaultBook.ISBN = value.ToString();
                deleteBookUserSelectionTxt.Text = deleteBookSelectionGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please click on the book to select it");
            }
        }
        private void bookDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This will delete the book permanently " +
                "Are you sure ?","Action Required", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(defaultBook.ISBN != "")
                {
                    message = adminLogic.requestBookDelete(defaultBook.ISBN);
                }
                else
                {
                    message = "Select one book to proceed";
                }
            }

            MessageBox.Show(message);
            //update the Book List
            updateBookGridUsing(deleteBookSelectionGrid);
           
        }
    
        private void updateGridUsing(DataGridView name, string searchCriteria = "Display All")
        {
            dataSet = search.getBooksBy(searchCriteria);
            name.DataSource = dataSet;
            name.DataMember = "users";
            //formatTable(name);
        }
        private void updateBookGridUsing(DataGridView name, string searchCriteria = "Display All")
        {
            dataSet = search.getBooksBy(searchCriteria);
            name.DataSource = dataSet;
            name.DataMember = "books";
            //formatTable(name);
        }
        private void Selected_TabChanged(object sender, EventArgs e)
        {
            //Manages when a tab was clicked
            var selectedTab = ((TabControl)sender).SelectedTab.Name;
            switch (selectedTab)
            {
                case "borrowTab":
                    updateBookGridUsing(availableBooks_dataGridView);
                    break;
                case "bookRetrunTab":
                    dataSet.Clear();
                    dataSet = returnLogic.getUserBoorrowedByTheUser(userID);
                    userBorrowedBooks_GridView.DataSource = dataSet;
                    userBorrowedBooks_GridView.DataMember = "userBooks";
                    formatTable(userBorrowedBooks_GridView);
                    break;
                case "browseTab":
                    updateBookGridUsing(reserveGridView);
                    break;
                case "reserveTab":
                    dataSet.Clear();
                    dataSet = reserveLogic.getBooksReservable();
                    reserveGridView.DataSource = dataSet;
                    reserveGridView.DataMember = "books";
                    formatTable(reserveGridView);
                    break;
                case "newFieldTab":
                    //Clear the list to avoid duplicate items.
                    categoryDropDown.Items.Clear();
                    authorDropDown.Items.Clear();
                    languageDropDown.Items.Clear();
                    //update the dropdown menu
                    this.categoryDropDown.Items.AddRange(adminLogic.getCategory());
                    this.authorDropDown.Items.AddRange(adminLogic.getAuthor());
                    this.languageDropDown.Items.AddRange(adminLogic.getLanguage());
                    break;
                case "addBookTab":
                    break;
                case "updateBookTab":
                    updateBookGridUsing(updataBookGrid);
                    break;
                case "deleteBookTab":
                    //Clear the list to avoid duplicate items.
                    updateAuthorDropDown.Items.Clear();
                    updateCategoryDropDown.Items.Clear();
                    updateLanguageDropDown.Items.Clear();
                    //update book dropdowns
                    this.updateAuthorDropDown.Items.AddRange(adminLogic.getCategory());
                    this.updateCategoryDropDown.Items.AddRange(adminLogic.getAuthor());
                    this.updateLanguageDropDown.Items.AddRange(adminLogic.getLanguage());
                    //Update delete List
                    updateBookGridUsing(deleteBookSelectionGrid);
                    break;
                case "nweUserTab":
                    break;
                case "updateUserTab":
                    updateGridUsing(updateUserAccountSelectionGridView, "Get Users");
                    break;
                default:
                    break;
            }
        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();

            if ((newUserNameText.Text != "") && (newUserEmailText.Text != "")
                && (newUserPassText.Text != "") && (userAccountLevel > 0))
            {
                user.userName = newUserNameText.Text;
                user.email = newUserEmailText.Text;
                user.password = newUserPassText.Text;
                user.accountLevel = userAccountLevel;
                message = adminLogic.requestNewUserRegistration(user);
            }
            else
            {
                if (newUserNameText.Text != "")
                {
                    message = "Insert User Name";
                }
                if (newUserEmailText.Text != "")
                {
                    message = "Insert User Email";
                }
                if (newUserPassText.Text != "")
                {
                    message = "Insert User Password";
                }
                if (userAccountLevel > 0)
                {
                    message = "Select Account Level";
                }
            }
         MessageBox.Show(message);
        }

        private void setAdminLevel(object sender, EventArgs e)
        {
            userAccountLevel = ((ComboBox)sender).SelectedIndex + 1;
        }
        private void userSelectionClicked(object sender, DataGridViewCellEventArgs e)
        {
            object temp = updateUserAccountSelectionGridView.Rows[e.RowIndex].Cells[0].Value;
            updateUserID = temp.ToString();
            userUpdateSelectionlbl.Text = updateUserID;
        }

        private void userUpdateConfirmBtn_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();

            if ((updateUserNameTxt.Text != "") && (updateUserPassText.Text != "")
                && (updateUserEmailText.Text != "") && (updateUserID != "")
                && (userLevel > 0))
            {
                user.userID = Convert.ToInt32(updateUserID);
                user.userName = updateUserNameTxt.Text;
                user.email = updateUserEmailText.Text;
                user.password = updateUserPassText.Text;
                user.accountLevel = userLevel;
                message = adminLogic.requestUserUpdate(user);
            }
            else
            {
                message = "Some Fields are missing";
            }
            MessageBox.Show(message);
            updateGridUsing(updateUserAccountSelectionGridView, "Get Users");
        }

        private void setUpdateUserLevel(object sender, EventArgs e)
        {
            userLevel = ((ComboBox)sender).SelectedIndex + 1;
        }

        private void userSelected(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*
                 * reference:
                 object bookISBN = updataBookGrid.Rows[e.RowIndex].Cells[0].Value;
                 updateUserSelection.Text = bookISBN.ToString();
                */
                object value = updateUserAccountSelectionGridView.Rows[e.RowIndex].Cells[0].Value;
                userUpdateSelectionlbl.Text = value.ToString();
                updateUserID = value.ToString();

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please Click on the Book To select it");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int user = Convert.ToInt32(updateUserID);

            DialogResult dialogResult = MessageBox.Show("User will be permanently Deleted \n" +
               "\n Continue ?", "Action Required", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (updateUserID != "")
                {
                    message = adminLogic.requsetUserDelete(user);
                }
                else
                {
                    message = "Select one user to proceed";
                }
                MessageBox.Show(message);
                updateGridUsing(updateUserAccountSelectionGridView, "Get Users");
            }
        }

        private void setUserChoice(object sender, EventArgs e)
        {
            userChoice = (string)((ComboBox)sender).SelectedItem;
        }
    }
}