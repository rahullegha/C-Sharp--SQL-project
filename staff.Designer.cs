namespace D2
{
    partial class staff
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
            this.labelheader = new System.Windows.Forms.Label();
            this.labelEquipmentID = new System.Windows.Forms.Label();
            this.labelReturnTime = new System.Windows.Forms.Label();
            this.labelBranch = new System.Windows.Forms.Label();
            this.labelRentalID = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.textBoxEquipment = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.comboBoxEquipID = new System.Windows.Forms.ComboBox();
            this.comboBoxRentalID = new System.Windows.Forms.ComboBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelheader
            // 
            this.labelheader.AutoSize = true;
            this.labelheader.BackColor = System.Drawing.Color.Transparent;
            this.labelheader.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelheader.ForeColor = System.Drawing.Color.Red;
            this.labelheader.Location = new System.Drawing.Point(200, 1);
            this.labelheader.Name = "labelheader";
            this.labelheader.Size = new System.Drawing.Size(409, 65);
            this.labelheader.TabIndex = 0;
            this.labelheader.Text = "Return Equipment";
            this.labelheader.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelEquipmentID
            // 
            this.labelEquipmentID.AutoSize = true;
            this.labelEquipmentID.BackColor = System.Drawing.Color.Transparent;
            this.labelEquipmentID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEquipmentID.ForeColor = System.Drawing.Color.White;
            this.labelEquipmentID.Location = new System.Drawing.Point(67, 66);
            this.labelEquipmentID.Name = "labelEquipmentID";
            this.labelEquipmentID.Size = new System.Drawing.Size(273, 32);
            this.labelEquipmentID.TabIndex = 1;
            this.labelEquipmentID.Text = "Select the Equipment ID";
            // 
            // labelReturnTime
            // 
            this.labelReturnTime.AutoSize = true;
            this.labelReturnTime.BackColor = System.Drawing.Color.Transparent;
            this.labelReturnTime.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReturnTime.ForeColor = System.Drawing.Color.White;
            this.labelReturnTime.Location = new System.Drawing.Point(67, 249);
            this.labelReturnTime.Name = "labelReturnTime";
            this.labelReturnTime.Size = new System.Drawing.Size(257, 32);
            this.labelReturnTime.TabIndex = 2;
            this.labelReturnTime.Text = "Select the Return Time";
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.BackColor = System.Drawing.Color.Transparent;
            this.labelBranch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBranch.ForeColor = System.Drawing.Color.White;
            this.labelBranch.Location = new System.Drawing.Point(51, 302);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(308, 32);
            this.labelBranch.TabIndex = 3;
            this.labelBranch.Text = "Select the Branch to return ";
            // 
            // labelRentalID
            // 
            this.labelRentalID.AutoSize = true;
            this.labelRentalID.BackColor = System.Drawing.Color.Transparent;
            this.labelRentalID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRentalID.ForeColor = System.Drawing.Color.White;
            this.labelRentalID.Location = new System.Drawing.Point(82, 150);
            this.labelRentalID.Name = "labelRentalID";
            this.labelRentalID.Size = new System.Drawing.Size(223, 32);
            this.labelRentalID.TabIndex = 4;
            this.labelRentalID.Text = "Select the Rental ID";
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOk.Location = new System.Drawing.Point(51, 367);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(124, 51);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClear.Location = new System.Drawing.Point(317, 367);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(124, 51);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.Location = new System.Drawing.Point(579, 367);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(124, 51);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // textBoxEquipment
            // 
            this.textBoxEquipment.Location = new System.Drawing.Point(461, 119);
            this.textBoxEquipment.Name = "textBoxEquipment";
            this.textBoxEquipment.ReadOnly = true;
            this.textBoxEquipment.Size = new System.Drawing.Size(278, 23);
            this.textBoxEquipment.TabIndex = 9;
            this.textBoxEquipment.TextChanged += new System.EventHandler(this.textBoxEquipment_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(461, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(278, 23);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2024, 5, 30, 22, 23, 0, 0);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.BackColor = System.Drawing.Color.Transparent;
            this.labelEquipment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEquipment.ForeColor = System.Drawing.Color.White;
            this.labelEquipment.Location = new System.Drawing.Point(90, 110);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(215, 32);
            this.labelEquipment.TabIndex = 12;
            this.labelEquipment.Text = " Equipment  Name";
            // 
            // comboBoxEquipID
            // 
            this.comboBoxEquipID.FormattingEnabled = true;
            this.comboBoxEquipID.Location = new System.Drawing.Point(461, 75);
            this.comboBoxEquipID.Name = "comboBoxEquipID";
            this.comboBoxEquipID.Size = new System.Drawing.Size(278, 23);
            this.comboBoxEquipID.TabIndex = 13;
            this.comboBoxEquipID.SelectedIndexChanged += new System.EventHandler(this.comboBoxEquipID_SelectedIndexChanged);
            // 
            // comboBoxRentalID
            // 
            this.comboBoxRentalID.FormattingEnabled = true;
            this.comboBoxRentalID.Location = new System.Drawing.Point(461, 161);
            this.comboBoxRentalID.Name = "comboBoxRentalID";
            this.comboBoxRentalID.Size = new System.Drawing.Size(278, 23);
            this.comboBoxRentalID.TabIndex = 14;
            this.comboBoxRentalID.SelectedIndexChanged += new System.EventHandler(this.comboBoxRentalID_SelectedIndexChanged);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomer.ForeColor = System.Drawing.Color.White;
            this.labelCustomer.Location = new System.Drawing.Point(95, 202);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(188, 32);
            this.labelCustomer.TabIndex = 16;
            this.labelCustomer.Text = "Customer Name";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(461, 202);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.ReadOnly = true;
            this.textBoxCustomer.Size = new System.Drawing.Size(278, 23);
            this.textBoxCustomer.TabIndex = 15;
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(461, 311);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(278, 23);
            this.comboBoxBranch.TabIndex = 17;
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::D2.Properties.Resources.ai_robot_neutral_black_backgroud_667310_869;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxBranch);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.comboBoxRentalID);
            this.Controls.Add(this.comboBoxEquipID);
            this.Controls.Add(this.labelEquipment);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxEquipment);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelRentalID);
            this.Controls.Add(this.labelBranch);
            this.Controls.Add(this.labelReturnTime);
            this.Controls.Add(this.labelEquipmentID);
            this.Controls.Add(this.labelheader);
            this.Name = "staff";
            this.Text = "staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelheader;
        private Label labelEquipmentID;
        private Label labelReturnTime;
        private Label labelBranch;
        private Label labelRentalID;
        private Button buttonOk;
        private Button buttonClear;
        private Button buttonLogout;
        private TextBox textBoxEquipment;
        private DateTimePicker dateTimePicker1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label labelEquipment;
        private ComboBox comboBoxEquipID;
        private ComboBox comboBoxRentalID;
        private Label labelCustomer;
        private TextBox textBoxCustomer;
        private ComboBox comboBoxBranch;
    }
}