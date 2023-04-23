namespace Database_connection
{
    partial class FormAuthorization
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PasswordVisibility = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(171, 119);
            this.textBoxLogin.MaxLength = 32;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(160, 29);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(171, 158);
            this.textBoxPassword.MaxLength = 32;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(160, 29);
            this.textBoxPassword.TabIndex = 1;
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.AuthorizationButton.Location = new System.Drawing.Point(171, 198);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(160, 40);
            this.AuthorizationButton.TabIndex = 2;
            this.AuthorizationButton.Text = "Войти";
            this.AuthorizationButton.UseVisualStyleBackColor = true;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Elephant", 12.25F);
            this.LoginLabel.Location = new System.Drawing.Point(92, 121);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(60, 22);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "Логин";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Elephant", 12.25F);
            this.PasswordLabel.Location = new System.Drawing.Point(92, 165);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 22);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Elephant", 16.25F);
            this.TitleLabel.Location = new System.Drawing.Point(166, 77);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(166, 29);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Авторизация";
            // 
            // PasswordVisibility
            // 
            this.PasswordVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordVisibility.AutoSize = true;
            this.PasswordVisibility.Image = global::Database_connection.Properties.Resources.eye_off_svgrepo_com__2___1___2_;
            this.PasswordVisibility.Location = new System.Drawing.Point(337, 154);
            this.PasswordVisibility.Name = "PasswordVisibility";
            this.PasswordVisibility.Size = new System.Drawing.Size(53, 38);
            this.PasswordVisibility.TabIndex = 3;
            this.PasswordVisibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PasswordVisibility.UseVisualStyleBackColor = true;
            this.PasswordVisibility.CheckedChanged += new System.EventHandler(this.PasswordVisibility_CheckedChanged);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 341);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.PasswordVisibility);
            this.Controls.Add(this.AuthorizationButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.CheckBox PasswordVisibility;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}