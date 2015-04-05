namespace CodePress
{
    partial class ViewSignin
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.SigninMenuStrip = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SigninButton = new System.Windows.Forms.Button();
            this.SignupButton = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.SigninMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.UsernameTextbox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.PasswordTextbox);
            this.groupBox4.Location = new System.Drawing.Point(335, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 92);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Login Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Username*";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.Location = new System.Drawing.Point(93, 26);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(183, 22);
            this.UsernameTextbox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password*";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.Location = new System.Drawing.Point(93, 54);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(183, 22);
            this.PasswordTextbox.TabIndex = 2;
            // 
            // SigninMenuStrip
            // 
            this.SigninMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.SigninMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SigninMenuStrip.Name = "SigninMenuStrip";
            this.SigninMenuStrip.Size = new System.Drawing.Size(635, 24);
            this.SigninMenuStrip.TabIndex = 25;
            this.SigninMenuStrip.Text = "SigninMenuStrip";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signUpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.signUpToolStripMenuItem.Text = "&Sign Up";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CodePress.Properties.Resources.Ad_MediumRectangle_300x250;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // SigninButton
            // 
            this.SigninButton.Location = new System.Drawing.Point(335, 136);
            this.SigninButton.Name = "SigninButton";
            this.SigninButton.Size = new System.Drawing.Size(75, 23);
            this.SigninButton.TabIndex = 3;
            this.SigninButton.Text = "Sign In";
            this.SigninButton.UseVisualStyleBackColor = true;
            this.SigninButton.Click += new System.EventHandler(this.SigninButton_Click);
            // 
            // SignupButton
            // 
            this.SignupButton.Location = new System.Drawing.Point(416, 136);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(75, 23);
            this.SignupButton.TabIndex = 4;
            this.SignupButton.Text = "Sign Up";
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // ViewSignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 308);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.SigninButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.SigninMenuStrip);
            this.MainMenuStrip = this.SigninMenuStrip;
            this.Name = "ViewSignin";
            this.Text = "ViewSignin";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.SigninMenuStrip.ResumeLayout(false);
            this.SigninMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.MenuStrip SigninMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SigninButton;
        private System.Windows.Forms.Button SignupButton;

    }
}