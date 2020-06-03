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
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.search_btn = new MetroFramework.Controls.MetroButton();
            this.myCombo = new MetroFramework.Controls.MetroComboBox();
            this.searchResultGrid = new System.Windows.Forms.DataGridView();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
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
            this.reserveStartDropdown = new MetroFramework.Controls.MetroDateTime();
            this.reserveGridView = new System.Windows.Forms.DataGridView();
            this.reseveStartFixedLbl = new System.Windows.Forms.Label();
            this.reservationConfirm_Btn = new MetroFramework.Controls.MetroButton();
            this.reserveBooksAvailable_fixedLbl = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooks_dataGridView)).BeginInit();
            this.reserveTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reserveGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.metroTabPage1);
            this.TabControl.Controls.Add(this.metroTabPage2);
            this.TabControl.Controls.Add(this.metroTabPage3);
            this.TabControl.Controls.Add(this.reserveTab);
            this.TabControl.Location = new System.Drawing.Point(0, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 3;
            this.TabControl.Size = new System.Drawing.Size(799, 449);
            this.TabControl.TabIndex = 0;
            this.TabControl.UseSelectable = true;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.Selected_TabChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.resultGridView);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(791, 407);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Book Browse";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
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
            this.resultGridView.Location = new System.Drawing.Point(16, 145);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.Size = new System.Drawing.Size(768, 164);
            this.resultGridView.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.search_btn);
            this.metroTabPage2.Controls.Add(this.myCombo);
            this.metroTabPage2.Controls.Add(this.searchResultGrid);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(791, 407);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Book Search";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
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
            this.searchResultGrid.Location = new System.Drawing.Point(286, 172);
            this.searchResultGrid.Name = "searchResultGrid";
            this.searchResultGrid.Size = new System.Drawing.Size(240, 150);
            this.searchResultGrid.TabIndex = 2;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.confirm_btn);
            this.metroTabPage3.Controls.Add(this.retrunDate_DropDown);
            this.metroTabPage3.Controls.Add(this.returnDateFixed_lbl);
            this.metroTabPage3.Controls.Add(this.userBorrowDate_DropDown);
            this.metroTabPage3.Controls.Add(this.borrowTextFixed_lbl);
            this.metroTabPage3.Controls.Add(this.userSelection_lbl);
            this.metroTabPage3.Controls.Add(this.userSelectionFixed_lbl);
            this.metroTabPage3.Controls.Add(this.alert_borrow_lbl);
            this.metroTabPage3.Controls.Add(this.fixed_book_lbl);
            this.metroTabPage3.Controls.Add(this.availableBooks_dataGridView);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(791, 407);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Book Borrow";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(518, 274);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(140, 51);
            this.confirm_btn.TabIndex = 13;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseSelectable = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // retrunDate_DropDown
            // 
            this.retrunDate_DropDown.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.retrunDate_DropDown.Location = new System.Drawing.Point(493, 162);
            this.retrunDate_DropDown.MinimumSize = new System.Drawing.Size(4, 29);
            this.retrunDate_DropDown.Name = "retrunDate_DropDown";
            this.retrunDate_DropDown.Size = new System.Drawing.Size(200, 29);
            this.retrunDate_DropDown.TabIndex = 12;
            this.retrunDate_DropDown.ValueChanged += new System.EventHandler(this.setReturnDate);
            // 
            // returnDateFixed_lbl
            // 
            this.returnDateFixed_lbl.AutoSize = true;
            this.returnDateFixed_lbl.Location = new System.Drawing.Point(515, 135);
            this.returnDateFixed_lbl.Name = "returnDateFixed_lbl";
            this.returnDateFixed_lbl.Size = new System.Drawing.Size(151, 13);
            this.returnDateFixed_lbl.TabIndex = 11;
            this.returnDateFixed_lbl.Text = "Please Select the Return Date";
            // 
            // userBorrowDate_DropDown
            // 
            this.userBorrowDate_DropDown.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.userBorrowDate_DropDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userBorrowDate_DropDown.Location = new System.Drawing.Point(493, 76);
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
            this.borrowTextFixed_lbl.Location = new System.Drawing.Point(529, 49);
            this.borrowTextFixed_lbl.Name = "borrowTextFixed_lbl";
            this.borrowTextFixed_lbl.Size = new System.Drawing.Size(129, 13);
            this.borrowTextFixed_lbl.TabIndex = 9;
            this.borrowTextFixed_lbl.Text = "Please Enter Borrow Date";
            // 
            // userSelection_lbl
            // 
            this.userSelection_lbl.AutoSize = true;
            this.userSelection_lbl.Location = new System.Drawing.Point(172, 83);
            this.userSelection_lbl.Name = "userSelection_lbl";
            this.userSelection_lbl.Size = new System.Drawing.Size(0, 13);
            this.userSelection_lbl.TabIndex = 7;
            // 
            // userSelectionFixed_lbl
            // 
            this.userSelectionFixed_lbl.AutoSize = true;
            this.userSelectionFixed_lbl.Location = new System.Drawing.Point(188, 49);
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
            this.fixed_book_lbl.Location = new System.Drawing.Point(174, 135);
            this.fixed_book_lbl.Name = "fixed_book_lbl";
            this.fixed_book_lbl.Size = new System.Drawing.Size(114, 13);
            this.fixed_book_lbl.TabIndex = 3;
            this.fixed_book_lbl.Text = "List of Available Books";
            // 
            // availableBooks_dataGridView
            // 
            this.availableBooks_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableBooks_dataGridView.Location = new System.Drawing.Point(114, 180);
            this.availableBooks_dataGridView.Name = "availableBooks_dataGridView";
            this.availableBooks_dataGridView.Size = new System.Drawing.Size(235, 195);
            this.availableBooks_dataGridView.TabIndex = 2;
            this.availableBooks_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reserveTab
            // 
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
            // reserveStartDropdown
            // 
            this.reserveStartDropdown.Location = new System.Drawing.Point(511, 105);
            this.reserveStartDropdown.MinimumSize = new System.Drawing.Size(0, 29);
            this.reserveStartDropdown.Name = "reserveStartDropdown";
            this.reserveStartDropdown.Size = new System.Drawing.Size(200, 29);
            this.reserveStartDropdown.TabIndex = 2;
            this.reserveStartDropdown.ValueChanged += new System.EventHandler(this.setReservationDate);
            // 
            // reserveGridView
            // 
            this.reserveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserveGridView.Location = new System.Drawing.Point(56, 90);
            this.reserveGridView.Name = "reserveGridView";
            this.reserveGridView.Size = new System.Drawing.Size(357, 244);
            this.reserveGridView.TabIndex = 4;
            this.reserveGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reserveGridView_CellContentClick);
            // 
            // reseveStartFixedLbl
            // 
            this.reseveStartFixedLbl.AutoSize = true;
            this.reseveStartFixedLbl.Location = new System.Drawing.Point(511, 86);
            this.reseveStartFixedLbl.Name = "reseveStartFixedLbl";
            this.reseveStartFixedLbl.Size = new System.Drawing.Size(89, 13);
            this.reseveStartFixedLbl.TabIndex = 5;
            this.reseveStartFixedLbl.Text = "Reservation Start";
            // 
            // reservationConfirm_Btn
            // 
            this.reservationConfirm_Btn.Location = new System.Drawing.Point(636, 177);
            this.reservationConfirm_Btn.Name = "reservationConfirm_Btn";
            this.reservationConfirm_Btn.Size = new System.Drawing.Size(75, 23);
            this.reservationConfirm_Btn.TabIndex = 6;
            this.reservationConfirm_Btn.Text = "Reserve";
            this.reservationConfirm_Btn.UseSelectable = true;
            this.reservationConfirm_Btn.Click += new System.EventHandler(this.reservationConfirm_Btn_Click);
            // 
            // reserveBooksAvailable_fixedLbl
            // 
            this.reserveBooksAvailable_fixedLbl.AutoSize = true;
            this.reserveBooksAvailable_fixedLbl.Location = new System.Drawing.Point(56, 52);
            this.reserveBooksAvailable_fixedLbl.Name = "reserveBooksAvailable_fixedLbl";
            this.reserveBooksAvailable_fixedLbl.Size = new System.Drawing.Size(80, 13);
            this.reserveBooksAvailable_fixedLbl.TabIndex = 7;
            this.reserveBooksAvailable_fixedLbl.Text = "BooksAvailable";
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
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResultGrid)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableBooks_dataGridView)).EndInit();
            this.reserveTab.ResumeLayout(false);
            this.reserveTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reserveGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView resultGridView;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView searchResultGrid;
        private MetroFramework.Controls.MetroComboBox myCombo;
        private MetroFramework.Controls.MetroButton search_btn;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
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
    }
}