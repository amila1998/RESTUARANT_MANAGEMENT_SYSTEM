namespace Resturant_management_system.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginClearbutton = new System.Windows.Forms.Button();
            this.loginExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resturant Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.loginClearbutton);
            this.LoginGroupBox.Controls.Add(this.loginButton);
            this.LoginGroupBox.Controls.Add(this.loginPasswordTextBox);
            this.LoginGroupBox.Controls.Add(this.loginUsernameTextBox);
            this.LoginGroupBox.Controls.Add(this.label3);
            this.LoginGroupBox.Controls.Add(this.label2);
            this.LoginGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.Location = new System.Drawing.Point(98, 292);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(569, 219);
            this.LoginGroupBox.TabIndex = 2;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.Location = new System.Drawing.Point(161, 58);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(366, 21);
            this.loginUsernameTextBox.TabIndex = 2;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Location = new System.Drawing.Point(161, 112);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(366, 21);
            this.loginPasswordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(431, 166);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(116, 29);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginClearbutton
            // 
            this.loginClearbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginClearbutton.Location = new System.Drawing.Point(20, 166);
            this.loginClearbutton.Name = "loginClearbutton";
            this.loginClearbutton.Size = new System.Drawing.Size(116, 29);
            this.loginClearbutton.TabIndex = 5;
            this.loginClearbutton.Text = "Clear";
            this.loginClearbutton.UseVisualStyleBackColor = true;
            this.loginClearbutton.Click += new System.EventHandler(this.loginClearbutton_Click);
            // 
            // loginExitButton
            // 
            this.loginExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginExitButton.Location = new System.Drawing.Point(30, 554);
            this.loginExitButton.Name = "loginExitButton";
            this.loginExitButton.Size = new System.Drawing.Size(116, 29);
            this.loginExitButton.TabIndex = 6;
            this.loginExitButton.Text = "Exit";
            this.loginExitButton.UseVisualStyleBackColor = true;
            this.loginExitButton.Click += new System.EventHandler(this.loginExitButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(788, 609);
            this.Controls.Add(this.loginExitButton);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.Button loginClearbutton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button loginExitButton;
    }
}