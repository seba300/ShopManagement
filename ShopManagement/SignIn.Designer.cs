namespace ShopManagement
{
    partial class SignIn
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
            this.TB_login = new System.Windows.Forms.TextBox();
            this.TB_password = new System.Windows.Forms.TextBox();
            this.Button_signIn = new System.Windows.Forms.Button();
            this.Image_signIn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LogFailed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Image_signIn)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_login
            // 
            this.TB_login.Location = new System.Drawing.Point(208, 47);
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(100, 20);
            this.TB_login.TabIndex = 0;
            this.TB_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_login_KeyDown);
            this.TB_login.MaxLength = 10;
            this.TB_login.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // TB_password
            // 
            this.TB_password.Location = new System.Drawing.Point(208, 73);
            this.TB_password.Name = "TB_password";
            this.TB_password.PasswordChar = '*';
            this.TB_password.Size = new System.Drawing.Size(100, 20);
            this.TB_password.TabIndex = 1;
            this.TB_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_password_KeyDown);
            this.TB_password.MaxLength = 10;
            // 
            // Button_signIn
            // 
            this.Button_signIn.Location = new System.Drawing.Point(208, 99);
            this.Button_signIn.Name = "Button_signIn";
            this.Button_signIn.Size = new System.Drawing.Size(100, 23);
            this.Button_signIn.TabIndex = 3;
            this.Button_signIn.Text = "Sign In";
            this.Button_signIn.UseVisualStyleBackColor = true;
            this.Button_signIn.Click += new System.EventHandler(this.B_signIn);
            // 
            // Image_signIn
            // 
            this.Image_signIn.Image = global::ShopManagement.Properties.Resources.SignInIcon;
            this.Image_signIn.Location = new System.Drawing.Point(-10, -41);
            this.Image_signIn.Name = "Image_signIn";
            this.Image_signIn.Size = new System.Drawing.Size(242, 226);
            this.Image_signIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image_signIn.TabIndex = 4;
            this.Image_signIn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "L:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "P:";
            // 
            // LogFailed
            // 
            this.LogFailed.ForeColor = System.Drawing.Color.Red;
            this.LogFailed.Location = new System.Drawing.Point(208, 125);
            this.LogFailed.Name = "LogFailed";
            this.LogFailed.Size = new System.Drawing.Size(100, 13);
            this.LogFailed.TabIndex = 7;
            this.LogFailed.Text = "Login Failed";
            this.LogFailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogFailed.Visible = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 161);
            this.Controls.Add(this.LogFailed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_signIn);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_login);
            this.Controls.Add(this.Image_signIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Image_signIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_login;
        private System.Windows.Forms.TextBox TB_password;
        private System.Windows.Forms.Button Button_signIn;
        private System.Windows.Forms.PictureBox Image_signIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LogFailed;
    }
}

