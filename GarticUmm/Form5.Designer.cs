﻿namespace GarticUmm
{
    partial class AccessClientForm
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
            this.ipTextBox = new MetroFramework.Controls.MetroTextBox();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            // 
            // 
            // 
            this.ipTextBox.CustomButton.Image = null;
            this.ipTextBox.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.ipTextBox.CustomButton.Name = "";
            this.ipTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ipTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ipTextBox.CustomButton.TabIndex = 1;
            this.ipTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ipTextBox.CustomButton.UseSelectable = true;
            this.ipTextBox.CustomButton.Visible = false;
            this.ipTextBox.Lines = new string[0];
            this.ipTextBox.Location = new System.Drawing.Point(61, 94);
            this.ipTextBox.MaxLength = 32767;
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.PasswordChar = '\0';
            this.ipTextBox.PromptText = "127.0.0.1";
            this.ipTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ipTextBox.SelectedText = "";
            this.ipTextBox.SelectionLength = 0;
            this.ipTextBox.SelectionStart = 0;
            this.ipTextBox.ShortcutsEnabled = true;
            this.ipTextBox.Size = new System.Drawing.Size(283, 23);
            this.ipTextBox.TabIndex = 0;
            this.ipTextBox.UseSelectable = true;
            this.ipTextBox.WaterMark = "127.0.0.1";
            this.ipTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ipTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(166, 152);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // AccessClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 229);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.ipTextBox);
            this.Name = "AccessClientForm";
            this.Text = "Enter server address!";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox ipTextBox;
        private MetroFramework.Controls.MetroButton btnConnect;
    }
}