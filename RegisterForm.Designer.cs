namespace Chatting_Application
{
    partial class RegisterForm
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
            this.txt_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btr_createAccount = new System.Windows.Forms.Button();
            this.btr_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_EnterPass = new System.Windows.Forms.TextBox();
            this.txtBox_EnterUser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.txt_label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btr_createAccount);
            this.panel1.Controls.Add(this.btr_login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBox_EnterPass);
            this.panel1.Controls.Add(this.txtBox_EnterUser);
            this.panel1.Location = new System.Drawing.Point(-10, -24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 636);
            this.panel1.TabIndex = 1;
            // 
            // txt_label
            // 
            this.txt_label.AutoSize = true;
            this.txt_label.Font = new System.Drawing.Font("Verdana", 20F);
            this.txt_label.Location = new System.Drawing.Point(494, 146);
            this.txt_label.Name = "txt_label";
            this.txt_label.Size = new System.Drawing.Size(125, 32);
            this.txt_label.TabIndex = 0;
            this.txt_label.Text = "Register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(366, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Re-enter Password:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Libre Baskerville", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(370, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // btr_createAccount
            // 
            this.btr_createAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btr_createAccount.Location = new System.Drawing.Point(370, 439);
            this.btr_createAccount.Name = "btr_createAccount";
            this.btr_createAccount.Size = new System.Drawing.Size(123, 34);
            this.btr_createAccount.TabIndex = 7;
            this.btr_createAccount.Text = "Create Account";
            this.btr_createAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btr_createAccount.UseVisualStyleBackColor = true;
            // 
            // btr_login
            // 
            this.btr_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btr_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btr_login.Location = new System.Drawing.Point(681, 444);
            this.btr_login.Name = "btr_login";
            this.btr_login.Size = new System.Drawing.Size(58, 23);
            this.btr_login.TabIndex = 6;
            this.btr_login.Text = "Log in?";
            this.btr_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btr_login.UseVisualStyleBackColor = true;
            this.btr_login.Click += new System.EventHandler(this.btr_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(366, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Username:";
            // 
            // txtBox_EnterPass
            // 
            this.txtBox_EnterPass.Font = new System.Drawing.Font("Libre Baskerville", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_EnterPass.Location = new System.Drawing.Point(370, 315);
            this.txtBox_EnterPass.Name = "txtBox_EnterPass";
            this.txtBox_EnterPass.Size = new System.Drawing.Size(370, 21);
            this.txtBox_EnterPass.TabIndex = 4;
            this.txtBox_EnterPass.UseSystemPasswordChar = true;
            // 
            // txtBox_EnterUser
            // 
            this.txtBox_EnterUser.Font = new System.Drawing.Font("Libre Baskerville", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_EnterUser.Location = new System.Drawing.Point(370, 260);
            this.txtBox_EnterUser.Name = "txtBox_EnterUser";
            this.txtBox_EnterUser.Size = new System.Drawing.Size(370, 24);
            this.txtBox_EnterUser.TabIndex = 1;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 588);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_label;
        private System.Windows.Forms.TextBox txtBox_EnterUser;
        private System.Windows.Forms.TextBox txtBox_EnterPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btr_createAccount;
        private System.Windows.Forms.Button btr_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}