﻿namespace Celikoor_Tixycket
{
    partial class FormLoginKonsumen
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.labelLoginPanel = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelCreateAnAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.labelUsername.Location = new System.Drawing.Point(623, 272);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(187, 34);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.labelPassword.Location = new System.Drawing.Point(623, 354);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(180, 34);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // textBoxUsernameLogin
            // 
            this.textBoxUsernameLogin.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameLogin.Location = new System.Drawing.Point(862, 271);
            this.textBoxUsernameLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            this.textBoxUsernameLogin.Size = new System.Drawing.Size(351, 39);
            this.textBoxUsernameLogin.TabIndex = 2;
            this.textBoxUsernameLogin.TextChanged += new System.EventHandler(this.textBoxUsernameLogin_TextChanged);
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(862, 353);
            this.textBoxPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(351, 39);
            this.textBoxPasswordLogin.TabIndex = 3;
            this.textBoxPasswordLogin.TextChanged += new System.EventHandler(this.textBoxPasswordLogin_TextChanged);
            // 
            // labelLoginPanel
            // 
            this.labelLoginPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.labelLoginPanel.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLoginPanel.Location = new System.Drawing.Point(0, -5);
            this.labelLoginPanel.Name = "labelLoginPanel";
            this.labelLoginPanel.Size = new System.Drawing.Size(536, 685);
            this.labelLoginPanel.TabIndex = 6;
            this.labelLoginPanel.Text = "LOGIN";
            this.labelLoginPanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelLoginPanel.Click += new System.EventHandler(this.labelLoginPanel_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Azure;
            this.buttonLogin.Location = new System.Drawing.Point(862, 508);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(138, 50);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabelCreateAnAccount
            // 
            this.linkLabelCreateAnAccount.AutoSize = true;
            this.linkLabelCreateAnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreateAnAccount.LinkColor = System.Drawing.Color.BlueViolet;
            this.linkLabelCreateAnAccount.Location = new System.Drawing.Point(785, 581);
            this.linkLabelCreateAnAccount.Name = "linkLabelCreateAnAccount";
            this.linkLabelCreateAnAccount.Size = new System.Drawing.Size(289, 32);
            this.linkLabelCreateAnAccount.TabIndex = 8;
            this.linkLabelCreateAnAccount.TabStop = true;
            this.linkLabelCreateAnAccount.Text = "New User? Click Here";
            this.linkLabelCreateAnAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateAnAccount_LinkClicked);
            // 
            // FormLoginKonsumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1289, 675);
            this.Controls.Add(this.linkLabelCreateAnAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelLoginPanel);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Controls.Add(this.textBoxUsernameLogin);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLoginKonsumen";
            this.Text = "LOGIN KONSUMEN";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsernameLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.Label labelLoginPanel;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabelCreateAnAccount;
    }
}