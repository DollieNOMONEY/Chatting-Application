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
    public partial class Chat : Form
    {
        int amountOfEnters = 0;

        public Chat()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            pa2_messages.Visible = false;
        }

        private void SendMessage(string message)
        {
            if (message == "") {return;}
            txtBox_SendMsg.Size = defaultrPosSize.Size;
            txtBox_SendMsg.Location = defaultrPosSize.Location;
            txtBox_SendMsg.Text = "";
            amountOfEnters = 0;
        }


        private void txtBox_SendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Shift)
            {
                if (amountOfEnters <= 12)
                {
                    amountOfEnters++;
                    txtBox_SendMsg.Size = new Size(txtBox_SendMsg.Width, txtBox_SendMsg.Height + 20);
                    txtBox_SendMsg.Location = new Point(txtBox_SendMsg.Location.X, txtBox_SendMsg.Location.Y - 20);
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendMessage(txtBox_SendMsg.Text);
            }
        }

        private void btr_globalchat_Click(object sender, EventArgs e)
        {
            Form form = new PopupJoin();
            form.ShowDialog();
        }

        private void btr_Send_Click(object sender, EventArgs e)
        {

        }

  
    }
}
