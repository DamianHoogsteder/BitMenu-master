namespace BitMenu
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip_Dashboard = new System.Windows.Forms.MenuStrip();
            this.MenuBtn_UBitmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtn_Uitloggen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtn_Rooster = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBtn_DaysOff = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_headerLogo = new System.Windows.Forms.PictureBox();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_Dashboard
            // 
            this.menuStrip_Dashboard.AutoSize = false;
            this.menuStrip_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.menuStrip_Dashboard.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_Dashboard.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Dashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBtn_UBitmenu,
            this.MenuBtn_Rooster,
            this.MenuBtn_DaysOff});
            this.menuStrip_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Dashboard.Name = "menuStrip_Dashboard";
            this.menuStrip_Dashboard.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip_Dashboard.Size = new System.Drawing.Size(796, 65);
            this.menuStrip_Dashboard.TabIndex = 0;
            this.menuStrip_Dashboard.Text = "menuStrip_Dashboard";
            // 
            // MenuBtn_UBitmenu
            // 
            this.MenuBtn_UBitmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBtn_Uitloggen});
            this.MenuBtn_UBitmenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuBtn_UBitmenu.Name = "MenuBtn_UBitmenu";
            this.MenuBtn_UBitmenu.Size = new System.Drawing.Size(148, 61);
            this.MenuBtn_UBitmenu.Text = "U Bitmenu";
            this.MenuBtn_UBitmenu.Click += new System.EventHandler(this.MenuBtn_UBitmenu_Click);
            // 
            // MenuBtn_Uitloggen
            // 
            this.MenuBtn_Uitloggen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuBtn_Uitloggen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuBtn_Uitloggen.Name = "MenuBtn_Uitloggen";
            this.MenuBtn_Uitloggen.Size = new System.Drawing.Size(200, 32);
            this.MenuBtn_Uitloggen.Text = "Uitloggen";
            this.MenuBtn_Uitloggen.Click += new System.EventHandler(this.MenuBtn_Uitloggen_Click);
            // 
            // MenuBtn_Rooster
            // 
            this.MenuBtn_Rooster.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuBtn_Rooster.Name = "MenuBtn_Rooster";
            this.MenuBtn_Rooster.Size = new System.Drawing.Size(114, 61);
            this.MenuBtn_Rooster.Text = "Rooster";
            this.MenuBtn_Rooster.Click += new System.EventHandler(this.MenuBtn_Rooster_Click);
            // 
            // MenuBtn_DaysOff
            // 
            this.MenuBtn_DaysOff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuBtn_DaysOff.Name = "MenuBtn_DaysOff";
            this.MenuBtn_DaysOff.Size = new System.Drawing.Size(125, 61);
            this.MenuBtn_DaysOff.Text = "Days Off";
            // 
            // pb_headerLogo
            // 
            this.pb_headerLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.pb_headerLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_headerLogo.BackgroundImage")));
            this.pb_headerLogo.Location = new System.Drawing.Point(619, 0);
            this.pb_headerLogo.Name = "pb_headerLogo";
            this.pb_headerLogo.Size = new System.Drawing.Size(153, 65);
            this.pb_headerLogo.TabIndex = 1;
            this.pb_headerLogo.TabStop = false;
            this.pb_headerLogo.Click += new System.EventHandler(this.pb_headerLogo_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Location = new System.Drawing.Point(4, 72);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(792, 449);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.pictureBox2.Location = new System.Drawing.Point(-7, 525);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(803, 32);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(796, 547);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.pb_headerLogo);
            this.Controls.Add(this.menuStrip_Dashboard);
            this.MainMenuStrip = this.menuStrip_Dashboard;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip_Dashboard.ResumeLayout(false);
            this.menuStrip_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_headerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem MenuBtn_UBitmenu;
        private System.Windows.Forms.ToolStripMenuItem MenuBtn_Uitloggen;
        private System.Windows.Forms.ToolStripMenuItem MenuBtn_Rooster;
        private System.Windows.Forms.ToolStripMenuItem MenuBtn_DaysOff;
        private System.Windows.Forms.PictureBox pb_headerLogo;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}