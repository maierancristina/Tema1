namespace theatre
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.bForgotPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(162, 76);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(208, 22);
            this.tb_user.TabIndex = 2;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(162, 125);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(208, 22);
            this.tb_pass.TabIndex = 3;
            this.tb_pass.UseSystemPasswordChar = true;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(204, 205);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(127, 54);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bForgotPass
            // 
            this.bForgotPass.Location = new System.Drawing.Point(204, 285);
            this.bForgotPass.Name = "bForgotPass";
            this.bForgotPass.Size = new System.Drawing.Size(127, 57);
            this.bForgotPass.TabIndex = 5;
            this.bForgotPass.Text = "Forgot password";
            this.bForgotPass.UseVisualStyleBackColor = true;
            this.bForgotPass.Click += new System.EventHandler(this.bForgotPass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 458);
            this.Controls.Add(this.bForgotPass);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bForgotPass;
    }
}

