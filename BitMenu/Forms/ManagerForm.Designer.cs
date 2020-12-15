namespace BitMenu
{
    partial class ManagerForm
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
            this.lbl_Welkom = new System.Windows.Forms.Label();
            this.lbl_AdminName = new System.Windows.Forms.Label();
            this.btn_AccountPage_open = new System.Windows.Forms.Button();
            this.btn_AddSchedule = new System.Windows.Forms.Button();
            this.btn_YourTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Welkom
            // 
            this.lbl_Welkom.AutoSize = true;
            this.lbl_Welkom.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welkom.Location = new System.Drawing.Point(45, 35);
            this.lbl_Welkom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Welkom.Name = "lbl_Welkom";
            this.lbl_Welkom.Size = new System.Drawing.Size(141, 31);
            this.lbl_Welkom.TabIndex = 0;
            this.lbl_Welkom.Text = "Welkom :";
            // 
            // lbl_AdminName
            // 
            this.lbl_AdminName.AutoSize = true;
            this.lbl_AdminName.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminName.Location = new System.Drawing.Point(197, 35);
            this.lbl_AdminName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AdminName.Name = "lbl_AdminName";
            this.lbl_AdminName.Size = new System.Drawing.Size(191, 31);
            this.lbl_AdminName.TabIndex = 1;
            this.lbl_AdminName.Text = "AdminName";
            // 
            // btn_AccountPage_open
            // 
            this.btn_AccountPage_open.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_AccountPage_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AccountPage_open.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AccountPage_open.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AccountPage_open.Location = new System.Drawing.Point(51, 141);
            this.btn_AccountPage_open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AccountPage_open.Name = "btn_AccountPage_open";
            this.btn_AccountPage_open.Size = new System.Drawing.Size(219, 58);
            this.btn_AccountPage_open.TabIndex = 2;
            this.btn_AccountPage_open.Text = "Create an account";
            this.btn_AccountPage_open.UseVisualStyleBackColor = false;
            this.btn_AccountPage_open.Click += new System.EventHandler(this.btn_AccountPage_open_Click);
            // 
            // btn_AddSchedule
            // 
            this.btn_AddSchedule.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_AddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AddSchedule.Location = new System.Drawing.Point(51, 285);
            this.btn_AddSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AddSchedule.Name = "btn_AddSchedule";
            this.btn_AddSchedule.Size = new System.Drawing.Size(219, 58);
            this.btn_AddSchedule.TabIndex = 3;
            this.btn_AddSchedule.Text = "Scheduling";
            this.btn_AddSchedule.UseVisualStyleBackColor = false;
            // 
            // btn_YourTeam
            // 
            this.btn_YourTeam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_YourTeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_YourTeam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_YourTeam.Location = new System.Drawing.Point(51, 448);
            this.btn_YourTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btn_YourTeam.Name = "btn_YourTeam";
            this.btn_YourTeam.Size = new System.Drawing.Size(219, 58);
            this.btn_YourTeam.TabIndex = 4;
            this.btn_YourTeam.Text = "Your team";
            this.btn_YourTeam.UseVisualStyleBackColor = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_YourTeam);
            this.Controls.Add(this.btn_AddSchedule);
            this.Controls.Add(this.btn_AccountPage_open);
            this.Controls.Add(this.lbl_AdminName);
            this.Controls.Add(this.lbl_Welkom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welkom;
        private System.Windows.Forms.Label lbl_AdminName;
        private System.Windows.Forms.Button btn_AccountPage_open;
        private System.Windows.Forms.Button btn_AddSchedule;
        private System.Windows.Forms.Button btn_YourTeam;
    }
}