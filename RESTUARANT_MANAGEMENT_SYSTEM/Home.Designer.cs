namespace RESTUARANT_MANAGEMENT_SYSTEM
{
    partial class Home
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
            this.menuBtn = new System.Windows.Forms.Button();
            this.empBtn = new System.Windows.Forms.Button();
            this.cusBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.Location = new System.Drawing.Point(73, 45);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(153, 87);
            this.menuBtn.TabIndex = 1;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // empBtn
            // 
            this.empBtn.Location = new System.Drawing.Point(232, 131);
            this.empBtn.Name = "empBtn";
            this.empBtn.Size = new System.Drawing.Size(153, 87);
            this.empBtn.TabIndex = 2;
            this.empBtn.Text = "Employee";
            this.empBtn.UseVisualStyleBackColor = true;
            this.empBtn.Click += new System.EventHandler(this.empBtn_Click);
            // 
            // cusBtn
            // 
            this.cusBtn.Location = new System.Drawing.Point(391, 216);
            this.cusBtn.Name = "cusBtn";
            this.cusBtn.Size = new System.Drawing.Size(153, 87);
            this.cusBtn.TabIndex = 3;
            this.cusBtn.Text = "Customer";
            this.cusBtn.UseVisualStyleBackColor = true;
            this.cusBtn.Click += new System.EventHandler(this.cusBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(544, 309);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(153, 87);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cusBtn);
            this.Controls.Add(this.empBtn);
            this.Controls.Add(this.menuBtn);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button empBtn;
        private System.Windows.Forms.Button cusBtn;
        private System.Windows.Forms.Button backBtn;
    }
}