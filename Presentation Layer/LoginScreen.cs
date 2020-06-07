using System;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentation_Layer
{
    public partial class LoginScreen : Form
    {
        UserModel user;
        userLogic myUserLogic;
        public LoginScreen()
        {
            InitializeComponent();
            myUserLogic = new userLogic();
            user = new UserModel();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
             user = myUserLogic.checkUser(user_ID_txt.Text, user_Pass_txt.Text);

            if (user.userName == null)
            {
                MessageBox.Show("Invalid User Name or Password");
            }
            else
            {
                TabViewControl firstPage = new TabViewControl(user);
                this.Hide();
                firstPage.ShowDialog();
            }
        }
    }
}
