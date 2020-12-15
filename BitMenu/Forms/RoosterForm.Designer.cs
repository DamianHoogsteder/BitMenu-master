namespace BitMenu
{
    partial class RoosterForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.WindowFrame, null);
            this.lv_Rooster = new System.Windows.Forms.ListView();
            this.Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lv_Rooster
            // 
            this.lv_Rooster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Rooster.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Day});
            this.lv_Rooster.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Rooster.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Rooster.HideSelection = false;
            listViewItem2.StateImageIndex = 0;
            this.lv_Rooster.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lv_Rooster.Location = new System.Drawing.Point(6, 8);
            this.lv_Rooster.Name = "lv_Rooster";
            this.lv_Rooster.Scrollable = false;
            this.lv_Rooster.Size = new System.Drawing.Size(787, 438);
            this.lv_Rooster.TabIndex = 0;
            this.lv_Rooster.UseCompatibleStateImageBehavior = false;
            this.lv_Rooster.View = System.Windows.Forms.View.Details;
            // 
            // Day
            // 
            this.Day.Text = "Day";
            this.Day.Width = 120;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(657, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // RoosterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lv_Rooster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoosterForm";
            this.Text = "RoosterForm";
            this.Load += new System.EventHandler(this.RoosterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Rooster;
        private System.Windows.Forms.ColumnHeader Day;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}