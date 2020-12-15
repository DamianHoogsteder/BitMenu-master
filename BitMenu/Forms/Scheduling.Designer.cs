namespace BitMenu
{
    partial class Scheduling
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
            this.lbl_KiesEenWerknemer = new System.Windows.Forms.Label();
            this.comBox_Users = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_KiesEenWerknemer
            // 
            this.lbl_KiesEenWerknemer.AutoSize = true;
            this.lbl_KiesEenWerknemer.Location = new System.Drawing.Point(23, 30);
            this.lbl_KiesEenWerknemer.Name = "lbl_KiesEenWerknemer";
            this.lbl_KiesEenWerknemer.Size = new System.Drawing.Size(136, 17);
            this.lbl_KiesEenWerknemer.TabIndex = 0;
            this.lbl_KiesEenWerknemer.Text = "Kies een werknemer";
            // 
            // comBox_Users
            // 
            this.comBox_Users.FormattingEnabled = true;
            this.comBox_Users.Location = new System.Drawing.Point(21, 60);
            this.comBox_Users.Name = "comBox_Users";
            this.comBox_Users.Size = new System.Drawing.Size(312, 24);
            this.comBox_Users.TabIndex = 1;
            // 
            // Scheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1049, 507);
            this.Controls.Add(this.comBox_Users);
            this.Controls.Add(this.lbl_KiesEenWerknemer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scheduling";
            this.Text = "Scheduling";
            this.Load += new System.EventHandler(this.Scheduling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KiesEenWerknemer;
        private System.Windows.Forms.ComboBox comBox_Users;
    }
}