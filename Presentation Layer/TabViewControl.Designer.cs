namespace Presentation_Layer
{
    partial class TabViewControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new MetroFramework.Controls.MetroTabControl();
            this.browseTab = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.searchTab = new MetroFramework.Controls.MetroTabPage();
            this.search_btn = new MetroFramework.Controls.MetroButton();
            this.myCombo = new MetroFramework.Controls.MetroComboBox();
            this.searchResultGrid = new System.Windows.Forms.DataGridView();
            this.borrowTab = new MetroFramework.Controls.MetroTabPage();
            this.confirm_btn = new MetroFramework.Controls.MetroButton();
            this.retrunDate_DropDown = new MetroFramework.Controls.MetroDateTime();
            this.returnDateFixed_lbl = new System.Windows.Forms.Label();
            this.userBorrowDate_DropDown = new MetroFramework.Controls.MetroDateTime();
            this.borrowTextFixed_lbl = new System.Windows.Forms.Label();
            this.userSelection_lbl = new System.Windows.Forms.Label();
            this.userSelectionFixed_lbl = new System.Windows.Forms.Label();
            this.alert_borrow_lbl = new System.Windows.Forms.Label();
            this.fixed_book_lbl = new System.Windows.Forms.Label();
            this.availableBooks_dataGridView = new System.Windows.Forms.DataGridView();
            this.reserveTab = new MetroFramework.Controls.MetroTabPage();
            this.reserveSelection_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reserveBooksAvailable_fixedLbl = new System.Windows.Forms.Label();
            this.reservationConfirm_Btn = new MetroFramework.Controls.MetroButton();
            this.reseveStartFixedLbl = new System.Windows.Forms.Label();
            this.reserveGridView = new System.Windows.Forms.DataGridView();
            this.reserveStartDropdown = new MetroFramework.Controls.MetroDateTime();
            this.bookRetrunTab = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.returnSelection_lbl = new System.Windows.Forms.Label();
            this.return_fiexd_lbl = new System.Windows.Forms.Label();
            this.userBorrowedBooks_GridView = new System.Windows.Forms.DataGridView();
            this.addBookTab = new MetroFramework.Controls.MetroTabPage();
            this.publishedDateFixedLabel = new MetroFramework.Controls.MetroLabel();
            this.adminPublisherText = new MetroFramework.Controls.MetroTextBox();
            this.publisherFixedLabel = new MetroFramework.Controls.MetroLabel();
            this.adminNumberOfPagesTxt = new MetroFramework.Controls.MetroTextBox();
            this.pagesFixedLbl = new MetroFramework.Controls.MetroLabel();
            this.addBookBtn = new MetroFramework.Controls.MetroButton();
            this.authorSelectionFixedLabel = new MetroFramework.Controls.MetroLabel();
            this.authorDropDown = new MetroFramework.Controls.MetroComboBox();
            this.langageFixedLbl = new MetroFramework.Controls.MetroLabel();
            this.languageDropDown = new MetroFramework.Controls.MetroComboBox();
            this.categoryFixedLbl = new MetroFramework.Controls.MetroLabel();
            this.categoryDropDown = new MetroFramework.Controls.MetroComboBox();
            this.adminBookTitleTxt = new MetroFramework.Controls.MetroTextBox();
            this.bookTitleFixedLabel = new MetroFramework.Controls.MetroLabel();
            this.adminPublishYearSelection = new System.Windows.Forms.DateTimePicker();
            this.TabControl.SuspendLayout();
            this.browseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.searchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).BeginInit();
            this.borrowTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooks_dataGridView)).BeginInit();
            this.reserveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reserveGridView)).BeginInit();
            this.bookRetrunTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBorrowedBooks_GridView)).BeginInit();
            this.addBookTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.browseTab);
            this.TabControl.Controls.Add(this.searchTab);
            this.TabControl.Controls.Add(this.borrowTab);
            this.TabControl.Controls.Add(this.reserveTab);
            this.TabControl.Controls.Add(this.bookRetrunTab);
            this.TabControl.Controls.Add(this.addBookTab);
            this.TabControl.Location = new System.Drawing.Point(0, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 5;
            this.TabControl.Size = new System.Drawing.Size(799, 449);
            this.TabControl.TabIndex = 0;
            this.TabControl.UseSelectable = true;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.Selected_TabChanged);
            // 
            // browseTab
            // 
            this.browseTab.Controls.Add(this.metroLabel1);
            this.browseTab.Controls.Add(this.resultGridView);
            this.browseTab.HorizontalScrollbarBarColor = true;
            this.browseTab.HorizontalScrollbarHighlightOnWheel = false;
            this.browseTab.HorizontalScrollbarSize = 10;
            this.browseTab.Location = new System.Drawing.Point(4, 38);
            this.browseTab.Name = "browseTab";
            this.browseTab.Size = new System.Drawing.Size(791, 407);
            this.browseTab.TabIndex = 0;
            this.browseTab.Text = "Book Browse";
            this.browseTab.VerticalScrollbarBarColor = true;
            this.browseTab.VerticalScrollbarHighlightOnWheel = false;
            this.browseTab.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(325, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "List of Books Available";
            // 
            // resultGridView
            // 
            this.resultGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Location = new System.Drawing.Point(75, 145);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.Size = new System.Drawing.Size(619, 164);
            this.resultGridView.TabIndex = 2;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.search_btn);
            this.searchTab.Controls.Add(this.myCombo);
            this.searchTab.Controls.Add(this.searchResultGrid);
            this.searchTab.HorizontalScrollbarBarColor = true;
            this.searchTab.HorizontalScrollbarHighlightOnWheel = false;
            this.searchTab.HorizontalScrollbarSize = 10;
            this.searchTab.Location = new System.Drawing.Point(4, 38);
            this.searchTab.Name = "searchTab";
            this.searchTab.Size = new System.Drawing.Size(791, 407);
            this.searchTab.TabIndex = 1;
            this.searchTab.Text = "Book Search";
            this.searchTab.VerticalScrollbarBarColor = true;
            this.searchTab.VerticalScrollbarHighlightOnWheel = false;
            this.searchTab.VerticalScrollbarSize = 10;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(447, 105);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "Search";
            this.search_btn.UseSelectable = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // myCombo
            // 
            this.myCombo.FormattingEnabled = true;
            this.myCombo.ItemHeight = 23;
            this.myCombo.Location = new System.Drawing.Point(286, 105);
            this.myCombo.Name = "myCombo";
            this.myCombo.Size = new System.Drawing.Size(121, 29);
            this.myCombo.TabIndex = 3;
            this.myCombo.UseSelectable = true;
            // 
            // searchResultGrid
            // 
            this.searchResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultGrid.Location = new System.Drawing.Point(91, 182);
            this.searchResultGrid.Name = "searchResultGrid";
            this.searchResultGrid.Size = new System.Drawing.Size(599, 150);
            this.searchResultGrid.TabIndex = 2;
            // 
            // borrowTab
            // 
            this.borrowTab.Controls.Add(this.confirm_btn);
            this.borrowTab.Controls.Add(this.retrunDate_DropDown);
            this.borrowTab.Controls.Add(this.returnDateFixed_lbl);
            this.borrowTab.Controls.Add(this.userBorrowDate_DropDown);
            this.borrowTab.Controls.Add(this.borrowTextFixed_lbl);
            this.borrowTab.Controls.Add(this.userSelection_lbl);
            this.borrowTab.Controls.Add(this.userSelectionFixed_lbl);
            this.borrowTab.Controls.Add(this.alert_borrow_lbl);
            this.borrowTab.Controls.Add(this.fixed_book_lbl);
            this.borrowTab.Controls.Add(this.availableBooks_dataGridView);
            this.borrowTab.HorizontalScrollbarBarColor = true;
            this.borrowTab.HorizontalScrollbarHighlightOnWheel = false;
            this.borrowTab.HorizontalScrollbarSize = 10;
            this.borrowTab.Location = new System.Drawing.Point(4, 38);
            this.borrowTab.Name = "borrowTab";
            this.borrowTab.Size = new System.Drawing.Size(791, 407);
            this.borrowTab.TabIndex = 2;
            this.borrowTab.Text = "Book Borrow";
            this.borrowTab.VerticalScrollbarBarColor = true;
            this.borrowTab.VerticalScrollbarHighlightOnWheel = false;
            this.borrowTab.VerticalScrollbarSize = 10;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(576, 324);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(140, 51);
            this.confirm_btn.TabIndex = 13;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseSelectable = true;
            this.confirm_btn.Click += new System.EventHandler(this.bookBorrowBtnClick);
            // 
            // retrunDate_DropDown
            // 
            this.retrunDate_DropDown.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.retrunDate_DropDown.Location = new System.Drawing.Point(551, 162);
            this.retrunDate_DropDown.MinimumSize = new System.Drawing.Size(4, 29);
            this.retrunDate_DropDown.Name = "retrunDate_DropDown";
            this.retrunDate_DropDown.Size = new System.Drawing.Size(200, 29);
            this.retrunDate_DropDown.TabIndex = 12;
            this.retrunDate_DropDown.ValueChanged += new System.EventHandler(this.setReturnDate);
            // 
            // returnDateFixed_lbl
            // 
            this.returnDateFixed_lbl.AutoSize = true;
            this.returnDateFixed_lbl.Location = new System.Drawing.Point(573, 135);
            this.returnDateFixed_lbl.Name = "returnDateFixed_lbl";
            this.returnDateFixed_lbl.Size = new System.Drawing.Size(151, 13);
            this.returnDateFixed_lbl.TabIndex = 11;
            this.returnDateFixed_lbl.Text = "Please Select the Return Date";
            // 
            // userBorrowDate_DropDown
            // 
            this.userBorrowDate_DropDown.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.userBorrowDate_DropDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userBorrowDate_DropDown.Location = new System.Drawing.Point(551, 76);
            this.userBorrowDate_DropDown.MinimumSize = new System.Drawing.Size(4, 29);
            this.userBorrowDate_DropDown.Name = "userBorrowDate_DropDown";
            this.userBorrowDate_DropDown.Size = new System.Drawing.Size(200, 29);
            this.userBorrowDate_DropDown.TabIndex = 10;
            this.userBorrowDate_DropDown.Value = new System.DateTime(2020, 5, 30, 0, 0, 0, 0);
            this.userBorrowDate_DropDown.ValueChanged += new System.EventHandler(this.setBorrowDate);
            // 
            // borrowTextFixed_lbl
            // 
            this.borrowTextFixed_lbl.AutoSize = true;
            this.borrowTextFixed_lbl.Location = new System.Drawing.Point(587, 49);
            this.borrowTextFixed_lbl.Name = "borrowTextFixed_lbl";
            this.borrowTextFixed_lbl.Size = new System.Drawing.Size(129, 13);
            this.borrowTextFixed_lbl.TabIndex = 9;
            this.borrowTextFixed_lbl.Text = "Please Enter Borrow Date";
            // 
            // userSelection_lbl
            // 
            this.userSelection_lbl.AutoSize = true;
            this.userSelection_lbl.Location = new System.Drawing.Point(589, 255);
            this.userSelection_lbl.Name = "userSelection_lbl";
            this.userSelection_lbl.Size = new System.Drawing.Size(0, 13);
            this.userSelection_lbl.TabIndex = 7;
            // 
            // userSelectionFixed_lbl
            // 
            this.userSelectionFixed_lbl.AutoSize = true;
            this.userSelectionFixed_lbl.Location = new System.Drawing.Point(605, 221);
            this.userSelectionFixed_lbl.Name = "userSelectionFixed_lbl";
            this.userSelectionFixed_lbl.Size = new System.Drawing.Size(76, 13);
            this.userSelectionFixed_lbl.TabIndex = 6;
            this.userSelectionFixed_lbl.Text = "Your Selection";
            // 
            // alert_borrow_lbl
            // 
            this.alert_borrow_lbl.AutoSize = true;
            this.alert_borrow_lbl.Location = new System.Drawing.Point(505, 233);
            this.alert_borrow_lbl.Name = "alert_borrow_lbl";
            this.alert_borrow_lbl.Size = new System.Drawing.Size(0, 13);
            this.alert_borrow_lbl.TabIndex = 4;
            // 
            // fixed_book_lbl
            // 
            this.fixed_book_lbl.AutoSize = true;
            this.fixed_book_lbl.Location = new System.Drawing.Point(221, 76);
            this.fixed_book_lbl.Name = "fixed_book_lbl";
            this.fixed_book_lbl.Size = new System.Drawing.Size(114, 13);
            this.fixed_book_lbl.TabIndex = 3;
            this.fixed_book_lbl.Text = "List of Available Books";
            // 
            // availableBooks_dataGridView
            // 
            this.availableBooks_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableBooks_dataGridView.Location = new System.Drawing.Point(65, 150);
            this.availableBooks_dataGridView.Name = "availableBooks_dataGridView";
            this.availableBooks_dataGridView.Size = new System.Drawing.Size(440, 225);
            this.availableBooks_dataGridView.TabIndex = 2;
            this.availableBooks_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reserveTab
            // 
            this.reserveTab.Controls.Add(this.reserveSelection_txt);
            this.reserveTab.Controls.Add(this.label1);
            this.reserveTab.Controls.Add(this.reserveBooksAvailable_fixedLbl);
            this.reserveTab.Controls.Add(this.reservationConfirm_Btn);
            this.reserveTab.Controls.Add(this.reseveStartFixedLbl);
            this.reserveTab.Controls.Add(this.reserveGridView);
            this.reserveTab.Controls.Add(this.reserveStartDropdown);
            this.reserveTab.HorizontalScrollbarBarColor = true;
            this.reserveTab.HorizontalScrollbarHighlightOnWheel = false;
            this.reserveTab.HorizontalScrollbarSize = 10;
            this.reserveTab.Location = new System.Drawing.Point(4, 38);
            this.reserveTab.Name = "reserveTab";
            this.reserveTab.Size = new System.Drawing.Size(791, 407);
            this.reserveTab.TabIndex = 3;
            this.reserveTab.Text = "Book Reserve";
            this.reserveTab.VerticalScrollbarBarColor = true;
            this.reserveTab.VerticalScrollbarHighlightOnWheel = false;
            this.reserveTab.VerticalScrollbarSize = 10;
            // 
            // reserveSelection_txt
            // 
            this.reserveSelection_txt.AutoSize = true;
            this.reserveSelection_txt.Location = new System.Drawing.Point(589, 199);
            this.reserveSelection_txt.Name = "reserveSelection_txt";
            this.reserveSelection_txt.Size = new System.Drawing.Size(0, 13);
            this.reserveSelection_txt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Selection:";
            // 
            // reserveBooksAvailable_fixedLbl
            // 
            this.reserveBooksAvailable_fixedLbl.AutoSize = true;
            this.reserveBooksAvailable_fixedLbl.Location = new System.Drawing.Point(231, 81);
            this.reserveBooksAvailable_fixedLbl.Name = "reserveBooksAvailable_fixedLbl";
            this.reserveBooksAvailable_fixedLbl.Size = new System.Drawing.Size(80, 13);
            this.reserveBooksAvailable_fixedLbl.TabIndex = 7;
            this.reserveBooksAvailable_fixedLbl.Text = "BooksAvailable";
            // 
            // reservationConfirm_Btn
            // 
            this.reservationConfirm_Btn.Location = new System.Drawing.Point(609, 287);
            this.reservationConfirm_Btn.Name = "reservationConfirm_Btn";
            this.reservationConfirm_Btn.Size = new System.Drawing.Size(137, 56);
            this.reservationConfirm_Btn.TabIndex = 6;
            this.reservationConfirm_Btn.Text = "Reserve";
            this.reservationConfirm_Btn.UseSelectable = true;
            this.reservationConfirm_Btn.Click += new System.EventHandler(this.reservationConfirm_Btn_Click);
            // 
            // reseveStartFixedLbl
            // 
            this.reseveStartFixedLbl.AutoSize = true;
            this.reseveStartFixedLbl.Location = new System.Drawing.Point(552, 46);
            this.reseveStartFixedLbl.Name = "reseveStartFixedLbl";
            this.reseveStartFixedLbl.Size = new System.Drawing.Size(89, 13);
            this.reseveStartFixedLbl.TabIndex = 5;
            this.reseveStartFixedLbl.Text = "Reservation Start";
            // 
            // reserveGridView
            // 
            this.reserveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserveGridView.Location = new System.Drawing.Point(38, 140);
            this.reserveGridView.Name = "reserveGridView";
            this.reserveGridView.Size = new System.Drawing.Size(456, 203);
            this.reserveGridView.TabIndex = 4;
            this.reserveGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reserveGridView_CellContentClick);
            // 
            // reserveStartDropdown
            // 
            this.reserveStartDropdown.Location = new System.Drawing.Point(552, 65);
            this.reserveStartDropdown.MinimumSize = new System.Drawing.Size(4, 29);
            this.reserveStartDropdown.Name = "reserveStartDropdown";
            this.reserveStartDropdown.Size = new System.Drawing.Size(200, 29);
            this.reserveStartDropdown.TabIndex = 2;
            this.reserveStartDropdown.ValueChanged += new System.EventHandler(this.setReservationDate);
            // 
            // bookRetrunTab
            // 
            this.bookRetrunTab.Controls.Add(this.label2);
            this.bookRetrunTab.Controls.Add(this.metroButton1);
            this.bookRetrunTab.Controls.Add(this.returnSelection_lbl);
            this.bookRetrunTab.Controls.Add(this.return_fiexd_lbl);
            this.bookRetrunTab.Controls.Add(this.userBorrowedBooks_GridView);
            this.bookRetrunTab.HorizontalScrollbarBarColor = true;
            this.bookRetrunTab.HorizontalScrollbarHighlightOnWheel = false;
            this.bookRetrunTab.HorizontalScrollbarSize = 10;
            this.bookRetrunTab.Location = new System.Drawing.Point(4, 38);
            this.bookRetrunTab.Name = "bookRetrunTab";
            this.bookRetrunTab.Size = new System.Drawing.Size(791, 407);
            this.bookRetrunTab.TabIndex = 4;
            this.bookRetrunTab.Text = "Book Return";
            this.bookRetrunTab.VerticalScrollbarBarColor = true;
            this.bookRetrunTab.VerticalScrollbarHighlightOnWheel = false;
            this.bookRetrunTab.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your Borrowed Books";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(598, 292);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(143, 62);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Return";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.returnButtomPressed);
            // 
            // returnSelection_lbl
            // 
            this.returnSelection_lbl.AutoSize = true;
            this.returnSelection_lbl.Location = new System.Drawing.Point(615, 165);
            this.returnSelection_lbl.Name = "returnSelection_lbl";
            this.returnSelection_lbl.Size = new System.Drawing.Size(0, 13);
            this.returnSelection_lbl.TabIndex = 4;
            // 
            // return_fiexd_lbl
            // 
            this.return_fiexd_lbl.AutoSize = true;
            this.return_fiexd_lbl.Location = new System.Drawing.Point(629, 138);
            this.return_fiexd_lbl.Name = "return_fiexd_lbl";
            this.return_fiexd_lbl.Size = new System.Drawing.Size(79, 13);
            this.return_fiexd_lbl.TabIndex = 3;
            this.return_fiexd_lbl.Text = "User Selection:";
            // 
            // userBorrowedBooks_GridView
            // 
            this.userBorrowedBooks_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userBorrowedBooks_GridView.Location = new System.Drawing.Point(55, 138);
            this.userBorrowedBooks_GridView.Name = "userBorrowedBooks_GridView";
            this.userBorrowedBooks_GridView.Size = new System.Drawing.Size(414, 216);
            this.userBorrowedBooks_GridView.TabIndex = 2;
            this.userBorrowedBooks_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userBorrowedBooks_GridView_CellContentClick);
            // 
            // addBookTab
            // 
            this.addBookTab.Controls.Add(this.adminPublishYearSelection);
            this.addBookTab.Controls.Add(this.publishedDateFixedLabel);
            this.addBookTab.Controls.Add(this.adminPublisherText);
            this.addBookTab.Controls.Add(this.publisherFixedLabel);
            this.addBookTab.Controls.Add(this.adminNumberOfPagesTxt);
            this.addBookTab.Controls.Add(this.pagesFixedLbl);
            this.addBookTab.Controls.Add(this.addBookBtn);
            this.addBookTab.Controls.Add(this.authorSelectionFixedLabel);
            this.addBookTab.Controls.Add(this.authorDropDown);
            this.addBookTab.Controls.Add(this.langageFixedLbl);
            this.addBookTab.Controls.Add(this.languageDropDown);
            this.addBookTab.Controls.Add(this.categoryFixedLbl);
            this.addBookTab.Controls.Add(this.categoryDropDown);
            this.addBookTab.Controls.Add(this.adminBookTitleTxt);
            this.addBookTab.Controls.Add(this.bookTitleFixedLabel);
            this.addBookTab.HorizontalScrollbarBarColor = true;
            this.addBookTab.HorizontalScrollbarHighlightOnWheel = false;
            this.addBookTab.HorizontalScrollbarSize = 10;
            this.addBookTab.Location = new System.Drawing.Point(4, 38);
            this.addBookTab.Name = "addBookTab";
            this.addBookTab.Size = new System.Drawing.Size(791, 407);
            this.addBookTab.TabIndex = 5;
            this.addBookTab.Text = "Add new Book";
            this.addBookTab.VerticalScrollbarBarColor = true;
            this.addBookTab.VerticalScrollbarHighlightOnWheel = false;
            this.addBookTab.VerticalScrollbarSize = 10;
            // 
            // publishedDateFixedLabel
            // 
            this.publishedDateFixedLabel.AutoSize = true;
            this.publishedDateFixedLabel.Location = new System.Drawing.Point(123, 263);
            this.publishedDateFixedLabel.Name = "publishedDateFixedLabel";
            this.publishedDateFixedLabel.Size = new System.Drawing.Size(79, 19);
            this.publishedDateFixedLabel.TabIndex = 15;
            this.publishedDateFixedLabel.Text = "Publish Year";
            // 
            // adminPublisherText
            // 
            // 
            // 
            // 
            this.adminPublisherText.CustomButton.Image = null;
            this.adminPublisherText.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.adminPublisherText.CustomButton.Name = "";
            this.adminPublisherText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.adminPublisherText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adminPublisherText.CustomButton.TabIndex = 1;
            this.adminPublisherText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adminPublisherText.CustomButton.UseSelectable = true;
            this.adminPublisherText.CustomButton.Visible = false;
            this.adminPublisherText.Lines = new string[0];
            this.adminPublisherText.Location = new System.Drawing.Point(123, 208);
            this.adminPublisherText.MaxLength = 32767;
            this.adminPublisherText.Name = "adminPublisherText";
            this.adminPublisherText.PasswordChar = '\0';
            this.adminPublisherText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adminPublisherText.SelectedText = "";
            this.adminPublisherText.SelectionLength = 0;
            this.adminPublisherText.SelectionStart = 0;
            this.adminPublisherText.ShortcutsEnabled = true;
            this.adminPublisherText.Size = new System.Drawing.Size(242, 23);
            this.adminPublisherText.TabIndex = 14;
            this.adminPublisherText.UseSelectable = true;
            this.adminPublisherText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adminPublisherText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // publisherFixedLabel
            // 
            this.publisherFixedLabel.AutoSize = true;
            this.publisherFixedLabel.Location = new System.Drawing.Point(123, 185);
            this.publisherFixedLabel.Name = "publisherFixedLabel";
            this.publisherFixedLabel.Size = new System.Drawing.Size(62, 19);
            this.publisherFixedLabel.TabIndex = 13;
            this.publisherFixedLabel.Text = "Publisher";
            // 
            // adminNumberOfPagesTxt
            // 
            // 
            // 
            // 
            this.adminNumberOfPagesTxt.CustomButton.Image = null;
            this.adminNumberOfPagesTxt.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.adminNumberOfPagesTxt.CustomButton.Name = "";
            this.adminNumberOfPagesTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.adminNumberOfPagesTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adminNumberOfPagesTxt.CustomButton.TabIndex = 1;
            this.adminNumberOfPagesTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adminNumberOfPagesTxt.CustomButton.UseSelectable = true;
            this.adminNumberOfPagesTxt.CustomButton.Visible = false;
            this.adminNumberOfPagesTxt.Lines = new string[0];
            this.adminNumberOfPagesTxt.Location = new System.Drawing.Point(258, 141);
            this.adminNumberOfPagesTxt.MaxLength = 32767;
            this.adminNumberOfPagesTxt.Name = "adminNumberOfPagesTxt";
            this.adminNumberOfPagesTxt.PasswordChar = '\0';
            this.adminNumberOfPagesTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adminNumberOfPagesTxt.SelectedText = "";
            this.adminNumberOfPagesTxt.SelectionLength = 0;
            this.adminNumberOfPagesTxt.SelectionStart = 0;
            this.adminNumberOfPagesTxt.ShortcutsEnabled = true;
            this.adminNumberOfPagesTxt.Size = new System.Drawing.Size(107, 23);
            this.adminNumberOfPagesTxt.TabIndex = 12;
            this.adminNumberOfPagesTxt.UseSelectable = true;
            this.adminNumberOfPagesTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adminNumberOfPagesTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.adminNumberOfPagesTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumbers);
            // 
            // pagesFixedLbl
            // 
            this.pagesFixedLbl.AutoSize = true;
            this.pagesFixedLbl.Location = new System.Drawing.Point(123, 141);
            this.pagesFixedLbl.Name = "pagesFixedLbl";
            this.pagesFixedLbl.Size = new System.Drawing.Size(112, 19);
            this.pagesFixedLbl.TabIndex = 11;
            this.pagesFixedLbl.Text = "Number of Pages";
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(570, 322);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(106, 36);
            this.addBookBtn.TabIndex = 10;
            this.addBookBtn.Text = "Confirm";
            this.addBookBtn.UseSelectable = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // authorSelectionFixedLabel
            // 
            this.authorSelectionFixedLabel.AutoSize = true;
            this.authorSelectionFixedLabel.Location = new System.Drawing.Point(551, 141);
            this.authorSelectionFixedLabel.Name = "authorSelectionFixedLabel";
            this.authorSelectionFixedLabel.Size = new System.Drawing.Size(87, 19);
            this.authorSelectionFixedLabel.TabIndex = 9;
            this.authorSelectionFixedLabel.Text = "Select Author";
            // 
            // authorDropDown
            // 
            this.authorDropDown.FormattingEnabled = true;
            this.authorDropDown.ItemHeight = 23;
            this.authorDropDown.Location = new System.Drawing.Point(551, 166);
            this.authorDropDown.Name = "authorDropDown";
            this.authorDropDown.Size = new System.Drawing.Size(148, 29);
            this.authorDropDown.TabIndex = 8;
            this.authorDropDown.UseSelectable = true;
            this.authorDropDown.SelectedIndexChanged += new System.EventHandler(this.authorClicked);
            // 
            // langageFixedLbl
            // 
            this.langageFixedLbl.AutoSize = true;
            this.langageFixedLbl.Location = new System.Drawing.Point(551, 218);
            this.langageFixedLbl.Name = "langageFixedLbl";
            this.langageFixedLbl.Size = new System.Drawing.Size(115, 19);
            this.langageFixedLbl.TabIndex = 7;
            this.langageFixedLbl.Text = "Select a Language";
            // 
            // languageDropDown
            // 
            this.languageDropDown.FormattingEnabled = true;
            this.languageDropDown.ItemHeight = 23;
            this.languageDropDown.Location = new System.Drawing.Point(551, 243);
            this.languageDropDown.Name = "languageDropDown";
            this.languageDropDown.Size = new System.Drawing.Size(147, 29);
            this.languageDropDown.TabIndex = 6;
            this.languageDropDown.UseSelectable = true;
            this.languageDropDown.SelectedIndexChanged += new System.EventHandler(this.languageClicked);
            // 
            // categoryFixedLbl
            // 
            this.categoryFixedLbl.AutoSize = true;
            this.categoryFixedLbl.Location = new System.Drawing.Point(551, 66);
            this.categoryFixedLbl.Name = "categoryFixedLbl";
            this.categoryFixedLbl.Size = new System.Drawing.Size(113, 19);
            this.categoryFixedLbl.TabIndex = 5;
            this.categoryFixedLbl.Text = "Select a Category";
            // 
            // categoryDropDown
            // 
            this.categoryDropDown.FormattingEnabled = true;
            this.categoryDropDown.ItemHeight = 23;
            this.categoryDropDown.Location = new System.Drawing.Point(551, 89);
            this.categoryDropDown.Name = "categoryDropDown";
            this.categoryDropDown.Size = new System.Drawing.Size(148, 29);
            this.categoryDropDown.TabIndex = 4;
            this.categoryDropDown.UseSelectable = true;
            this.categoryDropDown.SelectedIndexChanged += new System.EventHandler(this.categorySelected);
            // 
            // adminBookTitleTxt
            // 
            // 
            // 
            // 
            this.adminBookTitleTxt.CustomButton.Image = null;
            this.adminBookTitleTxt.CustomButton.Location = new System.Drawing.Point(220, 1);
            this.adminBookTitleTxt.CustomButton.Name = "";
            this.adminBookTitleTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.adminBookTitleTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.adminBookTitleTxt.CustomButton.TabIndex = 1;
            this.adminBookTitleTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.adminBookTitleTxt.CustomButton.UseSelectable = true;
            this.adminBookTitleTxt.CustomButton.Visible = false;
            this.adminBookTitleTxt.Lines = new string[0];
            this.adminBookTitleTxt.Location = new System.Drawing.Point(123, 89);
            this.adminBookTitleTxt.MaxLength = 32767;
            this.adminBookTitleTxt.Name = "adminBookTitleTxt";
            this.adminBookTitleTxt.PasswordChar = '\0';
            this.adminBookTitleTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.adminBookTitleTxt.SelectedText = "";
            this.adminBookTitleTxt.SelectionLength = 0;
            this.adminBookTitleTxt.SelectionStart = 0;
            this.adminBookTitleTxt.ShortcutsEnabled = true;
            this.adminBookTitleTxt.Size = new System.Drawing.Size(242, 23);
            this.adminBookTitleTxt.TabIndex = 3;
            this.adminBookTitleTxt.UseSelectable = true;
            this.adminBookTitleTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.adminBookTitleTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bookTitleFixedLabel
            // 
            this.bookTitleFixedLabel.AutoSize = true;
            this.bookTitleFixedLabel.Location = new System.Drawing.Point(123, 66);
            this.bookTitleFixedLabel.Name = "bookTitleFixedLabel";
            this.bookTitleFixedLabel.Size = new System.Drawing.Size(33, 19);
            this.bookTitleFixedLabel.TabIndex = 2;
            this.bookTitleFixedLabel.Text = "Title";
            // 
            // adminPublishYearSelection
            // 
            this.adminPublishYearSelection.CustomFormat = "yyyy";
            this.adminPublishYearSelection.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adminPublishYearSelection.Location = new System.Drawing.Point(258, 263);
            this.adminPublishYearSelection.Name = "adminPublishYearSelection";
            this.adminPublishYearSelection.Size = new System.Drawing.Size(107, 20);
            this.adminPublishYearSelection.TabIndex = 17;
            this.adminPublishYearSelection.ValueChanged += new System.EventHandler(this.adminSelectedPublishDate);
            // 
            // TabViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "TabViewControl";
            this.Text = "TabViewControl";
            this.TabControl.ResumeLayout(false);
            this.browseTab.ResumeLayout(false);
            this.browseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.searchTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).EndInit();
            this.borrowTab.ResumeLayout(false);
            this.borrowTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooks_dataGridView)).EndInit();
            this.reserveTab.ResumeLayout(false);
            this.reserveTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reserveGridView)).EndInit();
            this.bookRetrunTab.ResumeLayout(false);
            this.bookRetrunTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBorrowedBooks_GridView)).EndInit();
            this.addBookTab.ResumeLayout(false);
            this.addBookTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage browseTab;
        private System.Windows.Forms.DataGridView resultGridView;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage searchTab;
        private System.Windows.Forms.DataGridView searchResultGrid;
        private MetroFramework.Controls.MetroComboBox myCombo;
        private MetroFramework.Controls.MetroButton search_btn;
        private MetroFramework.Controls.MetroTabPage borrowTab;
        private MetroFramework.Controls.MetroButton confirm_btn;
        private MetroFramework.Controls.MetroDateTime retrunDate_DropDown;
        private System.Windows.Forms.Label returnDateFixed_lbl;
        private MetroFramework.Controls.MetroDateTime userBorrowDate_DropDown;
        private System.Windows.Forms.Label borrowTextFixed_lbl;
        private System.Windows.Forms.Label userSelection_lbl;
        private System.Windows.Forms.Label userSelectionFixed_lbl;
        private System.Windows.Forms.Label alert_borrow_lbl;
        private System.Windows.Forms.Label fixed_book_lbl;
        private System.Windows.Forms.DataGridView availableBooks_dataGridView;
        private MetroFramework.Controls.MetroTabPage reserveTab;
        private System.Windows.Forms.Label reserveBooksAvailable_fixedLbl;
        private MetroFramework.Controls.MetroButton reservationConfirm_Btn;
        private System.Windows.Forms.Label reseveStartFixedLbl;
        private System.Windows.Forms.DataGridView reserveGridView;
        private MetroFramework.Controls.MetroDateTime reserveStartDropdown;
        private MetroFramework.Controls.MetroTabPage bookRetrunTab;
        private System.Windows.Forms.Label reserveSelection_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView userBorrowedBooks_GridView;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label returnSelection_lbl;
        private System.Windows.Forms.Label return_fiexd_lbl;
        private MetroFramework.Controls.MetroTabPage addBookTab;
        private MetroFramework.Controls.MetroLabel authorSelectionFixedLabel;
        private MetroFramework.Controls.MetroComboBox authorDropDown;
        private MetroFramework.Controls.MetroLabel langageFixedLbl;
        private MetroFramework.Controls.MetroComboBox languageDropDown;
        private MetroFramework.Controls.MetroLabel categoryFixedLbl;
        private MetroFramework.Controls.MetroComboBox categoryDropDown;
        private MetroFramework.Controls.MetroTextBox adminBookTitleTxt;
        private MetroFramework.Controls.MetroLabel bookTitleFixedLabel;
        private MetroFramework.Controls.MetroButton addBookBtn;
        private MetroFramework.Controls.MetroLabel publishedDateFixedLabel;
        private MetroFramework.Controls.MetroTextBox adminPublisherText;
        private MetroFramework.Controls.MetroLabel publisherFixedLabel;
        private MetroFramework.Controls.MetroTextBox adminNumberOfPagesTxt;
        private MetroFramework.Controls.MetroLabel pagesFixedLbl;
        private System.Windows.Forms.DateTimePicker adminPublishYearSelection;
    }
}