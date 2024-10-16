namespace Chatting_Application
{
    partial class LoginForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.btr_Login = new System.Windows.Forms.Button();
            this.btr_createAcc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_EnterPass = new System.Windows.Forms.TextBox();
            this.txtBox_EnterUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btr_Login);
            this.panel1.Controls.Add(this.btr_createAcc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBox_EnterPass);
            this.panel1.Controls.Add(this.txtBox_EnterUser);
            this.panel1.Location = new System.Drawing.Point(-10, -24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 636);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(623, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Forgot Password?";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btr_Login
            // 
            this.btr_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btr_Login.Location = new System.Drawing.Point(370, 396);
            this.btr_Login.Name = "btr_Login";
            this.btr_Login.Size = new System.Drawing.Size(144, 34);
            this.btr_Login.TabIndex = 14;
            this.btr_Login.Text = "Log In";
            this.btr_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btr_Login.UseVisualStyleBackColor = true;
            this.btr_Login.Click += new System.EventHandler(this.btr_Login_Click);
            // 
            // btr_createAcc
            // 
            this.btr_createAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btr_createAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btr_createAcc.Location = new System.Drawing.Point(623, 401);
            this.btr_createAcc.Name = "btr_createAcc";
            this.btr_createAcc.Size = new System.Drawing.Size(116, 23);
            this.btr_createAcc.TabIndex = 13;
            this.btr_createAcc.Text = "Create an Account";
            this.btr_createAcc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btr_createAcc.UseVisualStyleBackColor = true;
            this.btr_createAcc.Click += new System.EventHandler(this.btr_createAcc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(366, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Enter Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(366, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter Username:";
            // 
            // txtBox_EnterPass
            // 
            this.txtBox_EnterPass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBox_EnterPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_EnterPass.Font = new System.Drawing.Font("Libre Baskerville", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_EnterPass.Location = new System.Drawing.Point(370, 323);
            this.txtBox_EnterPass.Name = "txtBox_EnterPass";
            this.txtBox_EnterPass.ReadOnly = true;
            this.txtBox_EnterPass.Size = new System.Drawing.Size(370, 14);
            this.txtBox_EnterPass.TabIndex = 11;
            this.txtBox_EnterPass.UseSystemPasswordChar = true;
            this.txtBox_EnterPass.TextChanged += new System.EventHandler(this.txtBox_EnterPass_TextChanged);
            // 
            // txtBox_EnterUser
            // 
            this.txtBox_EnterUser.Font = new System.Drawing.Font("Libre Baskerville", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_EnterUser.Location = new System.Drawing.Point(370, 260);
            this.txtBox_EnterUser.Name = "txtBox_EnterUser";
            this.txtBox_EnterUser.Size = new System.Drawing.Size(370, 24);
            this.txtBox_EnterUser.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(499, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Log In";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 588);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_EnterPass;
        private System.Windows.Forms.TextBox txtBox_EnterUser;
        private System.Windows.Forms.Button btr_Login;
        private System.Windows.Forms.Button btr_createAcc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}