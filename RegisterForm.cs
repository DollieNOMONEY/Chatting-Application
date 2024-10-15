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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btr_login_Click(object sender, EventArgs e)
        {
            Form form = new LoginForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            this.Close();
        }
    }
}
