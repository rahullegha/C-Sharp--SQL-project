namespace D2
{
    partial class Customer
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
            this.labelCustomer = new System.Windows.Forms.Label();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.comboBoxEquip = new System.Windows.Forms.ComboBox();
            this.labelBooking = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEquip = new System.Windows.Forms.Label();
            this.labelBranch = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.buttonHire = new System.Windows.Forms.Button();
            this.labelStatistics = new System.Windows.Forms.Label();
            this.labellogout = new System.Windows.Forms.Label();
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCustomer.ForeColor = System.Drawing.Color.White;
            this.labelCustomer.Location = new System.Drawing.Point(2, 9);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(318, 50);
            this.labelCustomer.TabIndex = 2;
            this.labelCustomer.Text = "Customer Details";
            this.labelCustomer.Click += new System.EventHandler(this.labelCustomer_Click);
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Items.AddRange(new object[] {
            "All",
            "Upcoming",
            "Ongoing",
            "Past"});
            this.comboBoxSort.Location = new System.Drawing.Point(658, 46);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(141, 23);
            this.comboBoxSort.TabIndex = 3;
            this.comboBoxSort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(581, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sort By:";
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(163, 334);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(130, 23);
            this.comboBoxBranch.TabIndex = 5;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // comboBoxEquip
            // 
            this.comboBoxEquip.FormattingEnabled = true;
            this.comboBoxEquip.Location = new System.Drawing.Point(163, 382);
            this.comboBoxEquip.Name = "comboBoxEquip";
            this.comboBoxEquip.Size = new System.Drawing.Size(130, 23);
            this.comboBoxEquip.TabIndex = 6;
            this.comboBoxEquip.SelectedIndexChanged += new System.EventHandler(this.comboBoxEquip_SelectedIndexChanged);
            // 
            // labelBooking
            // 
            this.labelBooking.AutoSize = true;
            this.labelBooking.BackColor = System.Drawing.Color.Transparent;
            this.labelBooking.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBooking.ForeColor = System.Drawing.Color.White;
            this.labelBooking.Location = new System.Drawing.Point(2, 281);
            this.labelBooking.Name = "labelBooking";
            this.labelBooking.Size = new System.Drawing.Size(146, 30);
            this.labelBooking.TabIndex = 8;
            this.labelBooking.Text = "Booking/Hire";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.BackColor = System.Drawing.Color.Transparent;
            this.labelRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRate.Location = new System.Drawing.Point(332, 336);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(106, 21);
            this.labelRate.TabIndex = 9;
            this.labelRate.Text = "Rate Per Hour";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.BackColor = System.Drawing.Color.Transparent;
            this.labelStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStartDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStartDate.Location = new System.Drawing.Point(341, 380);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(78, 21);
            this.labelStartDate.TabIndex = 10;
            this.labelStartDate.Text = "Start Date";
            // 
            // labelEquip
            // 
            this.labelEquip.AutoSize = true;
            this.labelEquip.BackColor = System.Drawing.Color.Transparent;
            this.labelEquip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEquip.ForeColor = System.Drawing.Color.White;
            this.labelEquip.Location = new System.Drawing.Point(2, 380);
            this.labelEquip.Name = "labelEquip";
            this.labelEquip.Size = new System.Drawing.Size(121, 21);
            this.labelEquip.TabIndex = 11;
            this.labelEquip.Text = "Equipment Type";
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.BackColor = System.Drawing.Color.Transparent;
            this.labelBranch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBranch.ForeColor = System.Drawing.Color.White;
            this.labelBranch.Location = new System.Drawing.Point(25, 332);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(58, 21);
            this.labelBranch.TabIndex = 12;
            this.labelBranch.Text = "Branch";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 378);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(477, 336);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.ReadOnly = true;
            this.textBoxRate.Size = new System.Drawing.Size(130, 23);
            this.textBoxRate.TabIndex = 14;
            this.textBoxRate.TextChanged += new System.EventHandler(this.textBoxRate_TextChanged);
            // 
            // buttonHire
            // 
            this.buttonHire.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHire.Location = new System.Drawing.Point(684, 336);
            this.buttonHire.Name = "buttonHire";
            this.buttonHire.Size = new System.Drawing.Size(82, 35);
            this.buttonHire.TabIndex = 15;
            this.buttonHire.Text = "Hire";
            this.buttonHire.UseVisualStyleBackColor = true;
            this.buttonHire.Click += new System.EventHandler(this.buttonHire_Click);
            // 
            // labelStatistics
            // 
            this.labelStatistics.AutoSize = true;
            this.labelStatistics.BackColor = System.Drawing.Color.Transparent;
            this.labelStatistics.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelStatistics.ForeColor = System.Drawing.Color.White;
            this.labelStatistics.Location = new System.Drawing.Point(658, 393);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(128, 25);
            this.labelStatistics.TabIndex = 16;
            this.labelStatistics.Text = "View Statistics";
            this.labelStatistics.Click += new System.EventHandler(this.labelStatistics_Click);
            this.labelStatistics.MouseLeave += new System.EventHandler(this.labelStatistics_MouseLeave);
            this.labelStatistics.MouseHover += new System.EventHandler(this.labelStatistics_MouseHover);
            // 
            // labellogout
            // 
            this.labellogout.AutoSize = true;
            this.labellogout.BackColor = System.Drawing.Color.Transparent;
            this.labellogout.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.labellogout.ForeColor = System.Drawing.Color.White;
            this.labellogout.Location = new System.Drawing.Point(715, 9);
            this.labellogout.Name = "labellogout";
            this.labellogout.Size = new System.Drawing.Size(60, 18);
            this.labellogout.TabIndex = 17;
            this.labellogout.Text = "Log Out";
            this.labellogout.Click += new System.EventHandler(this.labellogout_Click);
            this.labellogout.MouseLeave += new System.EventHandler(this.labellogout_MouseLeave);
            this.labellogout.MouseHover += new System.EventHandler(this.labellogout_MouseHover);
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.ItemHeight = 15;
            this.listBoxDetails.Location = new System.Drawing.Point(2, 106);
            this.listBoxDetails.Name = "listBoxDetails";
            this.listBoxDetails.Size = new System.Drawing.Size(834, 184);
            this.listBoxDetails.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Equipment Type            Start Time                      Return Time            " +
    "       Pickup Branch              Return Branch";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::D2.Properties.Resources.desktop_wallpaper_minimalism_landscape_lake_mountain_artistic_purple_stars_sky_background_minimalism;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDetails);
            this.Controls.Add(this.labellogout);
            this.Controls.Add(this.labelStatistics);
            this.Controls.Add(this.buttonHire);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelBranch);
            this.Controls.Add(this.labelEquip);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelBooking);
            this.Controls.Add(this.comboBoxEquip);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSort);
            this.Controls.Add(this.labelCustomer);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelCustomer;
        private ComboBox comboBoxSort;
        private Label label2;
        private ComboBox comboBoxBranch;
        private ComboBox comboBoxEquip;
        private Label labelBooking;
        private Label labelRate;
        private Label labelStartDate;
        private Label labelEquip;
        private Label labelBranch;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxRate;
        private Button buttonHire;
        private Label labelStatistics;
        private Label labellogout;
        private ListBox listBoxDetails;
        private Label label1;
    }
}