using System.Drawing;
using System.Windows.Forms;

namespace Chatting_Application
{
    partial class Chat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btr_newChatRoom = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pa_title = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_amountOfUsers = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.defaultrPosSize = new System.Windows.Forms.TextBox();
            this.txtBox_SendMsg = new System.Windows.Forms.TextBox();
            this.btr_Send = new System.Windows.Forms.Button();
            this.pa2_messages = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.flp_messages = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pa_title.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pa2_messages.SuspendLayout();
            this.flp_messages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pa2_messages);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Enter);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 636);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 627);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Location = new System.Drawing.Point(0, -6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(47, 700);
            this.panel7.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Window;
            this.panel8.Location = new System.Drawing.Point(45, -6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(322, 39);
            this.panel8.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel9);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(45, 32);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(313, 598);
            this.flowLayoutPanel2.TabIndex = 7;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btr_newChatRoom);
            this.panel3.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 37);
            this.panel3.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "New Chat Room";
            // 
            // btr_newChatRoom
            // 
            this.btr_newChatRoom.BackColor = System.Drawing.Color.LightGray;
            this.btr_newChatRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btr_newChatRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btr_newChatRoom.ForeColor = System.Drawing.Color.Transparent;
            this.btr_newChatRoom.Location = new System.Drawing.Point(0, 0);
            this.btr_newChatRoom.Name = "btr_newChatRoom";
            this.btr_newChatRoom.Size = new System.Drawing.Size(307, 37);
            this.btr_newChatRoom.TabIndex = 26;
            this.btr_newChatRoom.UseVisualStyleBackColor = false;
            this.btr_newChatRoom.Click += new System.EventHandler(this.btr_globalchat_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel9.Controls.Add(this.pictureBox4);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.button1);
            this.panel9.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel9.Location = new System.Drawing.Point(3, 46);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(307, 81);
            this.panel9.TabIndex = 31;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(10, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 62);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGray;
            this.label16.Location = new System.Drawing.Point(78, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "0 Users on Chat";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Enabled = false;
            this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(78, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 18);
            this.label17.TabIndex = 28;
            this.label17.Text = "Chat Room";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 81);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Enter
            // 
            this.Enter.AutoSize = true;
            this.Enter.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Italic);
            this.Enter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enter.Location = new System.Drawing.Point(658, 275);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(158, 72);
            this.Enter.TabIndex = 16;
            this.Enter.Text = "Before messaging, \r\nselect one of the chats \r\non the left.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(858, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 60);
            this.label13.TabIndex = 24;
            this.label13.Text = "Before messaging, \r\nselect one of the chats \r\non the left.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(466, 449);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 60);
            this.label14.TabIndex = 23;
            this.label14.Text = "Before messaging, \r\nselect one of the chats \r\non the left.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(658, 450);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 72);
            this.label15.TabIndex = 22;
            this.label15.Text = "Before messaging, \r\nselect one of the chats \r\non the left.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(858, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 60);
            this.label10.TabIndex = 21;
            this.label10.Text = "Before messaging, \r\nselect one of the chats \r\non the left.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(466, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 60);
            this.label11.TabIndex = 20;
            this.label11.Text = "Before messaging, \r\nselect one of the chats \r\non the left.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(658, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 72);
            this.label12.TabIndex = 19;
            this.label12.Text = "Before messaging, \r\nselect one of the chats \r\non the left.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Italic);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(858, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 72);
            this.label9.TabIndex = 18;
            this.label9.Text = "Before messaging, \r\nselect one of the chats \r\non the left.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(466, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 72);
            this.label8.TabIndex = 17;
            this.label8.Text = "Before messaging, \r\nselect one of the chats \r\non the left.";
            // 
            // pa_title
            // 
            this.pa_title.BackColor = System.Drawing.Color.White;
            this.pa_title.Controls.Add(this.title);
            this.pa_title.Location = new System.Drawing.Point(-3, -6);
            this.pa_title.Name = "pa_title";
            this.pa_title.Size = new System.Drawing.Size(524, 39);
            this.pa_title.TabIndex = 7;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(6, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(105, 18);
            this.title.TabIndex = 0;
            this.title.Text = "Chat Room";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel15);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(518, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 635);
            this.panel4.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 592);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel6.Location = new System.Drawing.Point(3, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(241, 55);
            this.panel6.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sent 0 Messages";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.txt_amountOfUsers);
            this.panel5.Controls.Add(this.label5);
            this.panel5.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(241, 87);
            this.panel5.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(80, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chat Room";
            // 
            // txt_amountOfUsers
            // 
            this.txt_amountOfUsers.AutoSize = true;
            this.txt_amountOfUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amountOfUsers.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_amountOfUsers.Location = new System.Drawing.Point(81, 31);
            this.txt_amountOfUsers.Name = "txt_amountOfUsers";
            this.txt_amountOfUsers.Size = new System.Drawing.Size(101, 17);
            this.txt_amountOfUsers.TabIndex = 9;
            this.txt_amountOfUsers.Text = "0 Users on Chat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 62);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chat Information";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel15.Location = new System.Drawing.Point(0, 32);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(244, 11);
            this.panel15.TabIndex = 8;
            // 
            // defaultrPosSize
            // 
            this.defaultrPosSize.BackColor = System.Drawing.Color.Crimson;
            this.defaultrPosSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.defaultrPosSize.Font = new System.Drawing.Font("Libre Baskerville", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultrPosSize.Location = new System.Drawing.Point(0, 586);
            this.defaultrPosSize.Multiline = true;
            this.defaultrPosSize.Name = "defaultrPosSize";
            this.defaultrPosSize.ReadOnly = true;
            this.defaultrPosSize.Size = new System.Drawing.Size(517, 43);
            this.defaultrPosSize.TabIndex = 17;
            // 
            // txtBox_SendMsg
            // 
            this.txtBox_SendMsg.Font = new System.Drawing.Font("Libre Baskerville", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_SendMsg.Location = new System.Drawing.Point(0, 586);
            this.txtBox_SendMsg.Multiline = true;
            this.txtBox_SendMsg.Name = "txtBox_SendMsg";
            this.txtBox_SendMsg.Size = new System.Drawing.Size(517, 43);
            this.txtBox_SendMsg.TabIndex = 16;
            this.txtBox_SendMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_SendMsg_KeyDown);
            // 
            // btr_Send
            // 
            this.btr_Send.BackColor = System.Drawing.Color.White;
            this.btr_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btr_Send.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btr_Send.ForeColor = System.Drawing.Color.DarkGray;
            this.btr_Send.Location = new System.Drawing.Point(446, 585);
            this.btr_Send.Name = "btr_Send";
            this.btr_Send.Size = new System.Drawing.Size(72, 43);
            this.btr_Send.TabIndex = 20;
            this.btr_Send.Text = "Send";
            this.btr_Send.UseVisualStyleBackColor = false;
            // 
            // pa2_messages
            // 
            this.pa2_messages.BackColor = System.Drawing.Color.White;
            this.pa2_messages.Controls.Add(this.btr_Send);
            this.pa2_messages.Controls.Add(this.txtBox_SendMsg);
            this.pa2_messages.Controls.Add(this.defaultrPosSize);
            this.pa2_messages.Controls.Add(this.panel4);
            this.pa2_messages.Controls.Add(this.pa_title);
            this.pa2_messages.Controls.Add(this.flp_messages);
            this.pa2_messages.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pa2_messages.Location = new System.Drawing.Point(355, 0);
            this.pa2_messages.Name = "pa2_messages";
            this.pa2_messages.Size = new System.Drawing.Size(750, 630);
            this.pa2_messages.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Libre Baskerville", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Global Chat";
            // 
            // flp_messages
            // 
            this.flp_messages.BackColor = System.Drawing.Color.DodgerBlue;
            this.flp_messages.Controls.Add(this.label4);
            this.flp_messages.ForeColor = System.Drawing.Color.DodgerBlue;
            this.flp_messages.Location = new System.Drawing.Point(0, 0);
            this.flp_messages.Name = "flp_messages";
            this.flp_messages.Size = new System.Drawing.Size(518, 587);
            this.flp_messages.TabIndex = 10;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 627);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pa_title.ResumeLayout(false);
            this.pa_title.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pa2_messages.ResumeLayout(false);
            this.pa2_messages.PerformLayout();
            this.flp_messages.ResumeLayout(false);
            this.flp_messages.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Enter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Panel panel2;
        private Panel panel7;
        private Panel panel8;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel3;
        private Label label7;
        private Button btr_newChatRoom;
        private Panel panel9;
        private PictureBox pictureBox4;
        private Label label16;
        private Label label17;
        private Button button1;
        private Panel pa2_messages;
        private Button btr_Send;
        private TextBox txtBox_SendMsg;
        private TextBox defaultrPosSize;
        private Panel panel4;
        private Panel panel15;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label txt_amountOfUsers;
        private Label label5;
        private Panel panel6;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
        private Panel pa_title;
        private Label title;
        private FlowLayoutPanel flp_messages;
        private Label label4;
    }
}

