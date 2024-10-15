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
        }

        private void SendMessage(string message)
        {
            if (message == "") {return;}
            textBox1.Size = defaultrPosSize.Size;
            textBox1.Location = defaultrPosSize.Location;
            textBox1.Text = "";
            amountOfEnters = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Shift)
            {
                if (amountOfEnters <= 12)
                {
                    amountOfEnters++;
                    textBox1.Size = new Size(textBox1.Width, textBox1.Height + 20);
                    textBox1.Location = new Point(textBox1.Location.X, textBox1.Location.Y - 20);
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendMessage(textBox1.Text);
            }
        }

        private void btr_Send_Click(object sender, EventArgs e)
        {
            SendMessage(textBox1.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
