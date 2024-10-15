using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatting_Application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btr_createAcc_Click(object sender, EventArgs e)
        {
            //Form form = new RegisterForm();
            //form.StartPosition = FormStartPosition.CenterScreen;
            //form.Show();
            MessageBox.Show("This is a demo feature. You may proceed to log in without a password.");
        }

        private void btr_Login_Click(object sender, EventArgs e)
        {
            string username = txtBox_EnterUser.Text;
            if (username != "")
            {
                Form form = new Chat();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }
        }

        private void txtBox_EnterPass_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("This is a demo feature. You may proceed to log in without a password.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a demo feature. You may proceed to log in without a password.");
        }
    }
}
