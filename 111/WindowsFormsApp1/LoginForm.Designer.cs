﻿namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBTN.Location = new System.Drawing.Point(77, 209);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(142, 50);
            this.LoginBTN.TabIndex = 0;
            this.LoginBTN.Text = "ВОЙТИ";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ЛОГИН:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ПАРОЛЬ:";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(105, 52);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(143, 20);
            this.NameTxt.TabIndex = 3;
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(105, 122);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.Size = new System.Drawing.Size(143, 20);
            this.PassTxt.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 290);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox PassTxt;
    }
}