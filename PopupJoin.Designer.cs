namespace Chatting_Application
{
    partial class PopupJoin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_EnterUser = new System.Windows.Forms.TextBox();
            this.pa_title = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btr_Join = new System.Windows.Forms.Button();
            this.btr_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter \r\nAddress:";
            // 
            // txtBox_EnterUser
            // 
            this.txtBox_EnterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.txtBox_EnterUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_EnterUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_EnterUser.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBox_EnterUser.Location = new System.Drawing.Point(116, 22);
            this.txtBox_EnterUser.Name = "txtBox_EnterUser";
            this.txtBox_EnterUser.Size = new System.Drawing.Size(262, 20);
            this.txtBox_EnterUser.TabIndex = 11;
            this.txtBox_EnterUser.TextChanged += new System.EventHandler(this.txtBox_EnterUser_TextChanged);
            // 
            // pa_title
            // 
            this.pa_title.BackColor = System.Drawing.SystemColors.Window;
            this.pa_title.Location = new System.Drawing.Point(116, 92);
            this.pa_title.Name = "pa_title";
            this.pa_title.Size = new System.Drawing.Size(256, 3);
            this.pa_title.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Location = new System.Drawing.Point(116, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 3);
            this.panel1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(5, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter Port:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(116, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btr_Join
            // 
            this.btr_Join.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.btr_Join.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr_Join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btr_Join.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btr_Join.ForeColor = System.Drawing.Color.White;
            this.btr_Join.Location = new System.Drawing.Point(8, 132);
            this.btr_Join.Name = "btr_Join";
            this.btr_Join.Size = new System.Drawing.Size(82, 31);
            this.btr_Join.TabIndex = 19;
            this.btr_Join.Text = "Join";
            this.btr_Join.UseVisualStyleBackColor = false;
            this.btr_Join.Click += new System.EventHandler(this.btr_Join_Click);
            // 
            // btr_Cancel
            // 
            this.btr_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.btr_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btr_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btr_Cancel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btr_Cancel.ForeColor = System.Drawing.Color.White;
            this.btr_Cancel.Location = new System.Drawing.Point(285, 132);
            this.btr_Cancel.Name = "btr_Cancel";
            this.btr_Cancel.Size = new System.Drawing.Size(86, 31);
            this.btr_Cancel.TabIndex = 20;
            this.btr_Cancel.Text = "Cancel";
            this.btr_Cancel.UseVisualStyleBackColor = false;
            this.btr_Cancel.Click += new System.EventHandler(this.btr_Cancel_Click);
            // 
            // PopupJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(383, 175);
            this.Controls.Add(this.btr_Cancel);
            this.Controls.Add(this.btr_Join);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pa_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_EnterUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupJoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupJoin";
            this.Load += new System.EventHandler(this.PopupJoin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_EnterUser;
        private System.Windows.Forms.Panel pa_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btr_Join;
        private System.Windows.Forms.Button btr_Cancel;
    }
}