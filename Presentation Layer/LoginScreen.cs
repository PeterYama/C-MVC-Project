using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Logic;

namespace Presentation_Layer
{
    public partial class LoginScreen : Form
    {
        userLogic myUserLogic;
        bool userCheck;
        public LoginScreen()
        {
            InitializeComponent();
            myUserLogic = new userLogic();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            userCheck = myUserLogic.checkUser(user_ID_txt.Text, user_Pass_txt.Text);

            if (userCheck == false)
            {
                MessageBox.Show("Invalid User Name or Password");
            }
            else
            {
                error_message_lbl.Text = Convert.ToString(userCheck);
                TabViewControl firstPage = new TabViewControl();
                this.Hide();
                firstPage.ShowDialog();
            }
        }
    }
}
