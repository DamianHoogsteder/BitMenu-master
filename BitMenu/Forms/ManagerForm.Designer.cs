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
            this.btn_AccountPage_ = new System.Windows.Forms.Button();
            this.btn_SchedulingOpen = new System.Windows.Forms.Button();
            this.btn_YourTeam = new System.Windows.Forms.Button();
            this.lv_YourTeam = new System.Windows.Forms.ListView();
            this.Users = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_AdminControl = new System.Windows.Forms.Panel();
            this.pnl_AdminControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Welkom
            // 
            this.lbl_Welkom.AutoSize = true;
            this.lbl_Welkom.Location = new System.Drawing.Point(36, 23);
            this.lbl_Welkom.Name = "lbl_Welkom";
            this.lbl_Welkom.Size = new System.Drawing.Size(66, 17);
            this.lbl_Welkom.TabIndex = 0;
            this.lbl_Welkom.Text = "Welkom :";
            // 
            // lbl_AdminName
            // 
            this.lbl_AdminName.AutoSize = true;
            this.lbl_AdminName.Location = new System.Drawing.Point(108, 23);
            this.lbl_AdminName.Name = "lbl_AdminName";
            this.lbl_AdminName.Size = new System.Drawing.Size(84, 17);
            this.lbl_AdminName.TabIndex = 1;
            this.lbl_AdminName.Text = "AdminName";
            // 
            // btn_AccountPage_
            // 
            this.btn_AccountPage_.Location = new System.Drawing.Point(36, 66);
            this.btn_AccountPage_.Name = "btn_AccountPage_";
            this.btn_AccountPage_.Size = new System.Drawing.Size(262, 78);
            this.btn_AccountPage_.TabIndex = 2;
            this.btn_AccountPage_.Text = "Create an account";
            this.btn_AccountPage_.UseVisualStyleBackColor = true;
            this.btn_AccountPage_.Click += new System.EventHandler(this.btn_AccountPage__Click);
            // 
            // btn_SchedulingOpen
            // 
            this.btn_SchedulingOpen.Location = new System.Drawing.Point(39, 181);
            this.btn_SchedulingOpen.Name = "btn_SchedulingOpen";
            this.btn_SchedulingOpen.Size = new System.Drawing.Size(262, 78);
            this.btn_SchedulingOpen.TabIndex = 3;
            this.btn_SchedulingOpen.Text = "Scheduling";
            this.btn_SchedulingOpen.UseVisualStyleBackColor = true;
            this.btn_SchedulingOpen.Click += new System.EventHandler(this.btn_SchedulingOpen_Click);
            // 
            // btn_YourTeam
            // 
            this.btn_YourTeam.Location = new System.Drawing.Point(39, 300);
            this.btn_YourTeam.Name = "btn_YourTeam";
            this.btn_YourTeam.Size = new System.Drawing.Size(262, 78);
            this.btn_YourTeam.TabIndex = 4;
            this.btn_YourTeam.Text = "Your team";
            this.btn_YourTeam.UseVisualStyleBackColor = true;
            this.btn_YourTeam.Click += new System.EventHandler(this.btn_YourTeam_Click_1);
            // 
            // lv_YourTeam
            // 
            this.lv_YourTeam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Users});
            this.lv_YourTeam.HideSelection = false;
            this.lv_YourTeam.Location = new System.Drawing.Point(525, 73);
            this.lv_YourTeam.Name = "lv_YourTeam";
            this.lv_YourTeam.Size = new System.Drawing.Size(437, 304);
            this.lv_YourTeam.TabIndex = 5;
            this.lv_YourTeam.UseCompatibleStateImageBehavior = false;
            this.lv_YourTeam.View = System.Windows.Forms.View.Details;
            this.lv_YourTeam.Visible = false;
            // 
            // Users
            // 
            this.Users.Text = "Users";
            this.Users.Width = 106;
            // 
            // pnl_AdminControl
            // 
            this.pnl_AdminControl.Controls.Add(this.lv_YourTeam);
            this.pnl_AdminControl.Controls.Add(this.btn_YourTeam);
            this.pnl_AdminControl.Controls.Add(this.btn_SchedulingOpen);
            this.pnl_AdminControl.Controls.Add(this.btn_AccountPage_);
            this.pnl_AdminControl.Controls.Add(this.lbl_AdminName);
            this.pnl_AdminControl.Controls.Add(this.lbl_Welkom);
            this.pnl_AdminControl.Location = new System.Drawing.Point(-2, 0);
            this.pnl_AdminControl.Name = "pnl_AdminControl";
            this.pnl_AdminControl.Size = new System.Drawing.Size(1129, 514);
            this.pnl_AdminControl.TabIndex = 6;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1049, 507);
            this.Controls.Add(this.pnl_AdminControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.Text = "z";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.pnl_AdminControl.ResumeLayout(false);
            this.pnl_AdminControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welkom;
        private System.Windows.Forms.Label lbl_AdminName;
        private System.Windows.Forms.Button btn_AccountPage_;
        private System.Windows.Forms.Button btn_SchedulingOpen;
        private System.Windows.Forms.Button btn_YourTeam;
        private System.Windows.Forms.ListView lv_YourTeam;
        private System.Windows.Forms.ColumnHeader Users;
        private System.Windows.Forms.Panel pnl_AdminControl;
    }
}