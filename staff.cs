using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace D2
{
    public partial class staff : Form
    {
        public staff()
        {
            try { 
            InitializeComponent();
            clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEquipment_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxEquipID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try 
            { 
            comboBoxBranch.Items.Clear();
            comboBoxRentalID.Items.Clear();
            comboBoxRentalID.Visible = true;
            textBoxEquipment.Visible = true;
            sql.editComboBoxItems(comboBoxBranch, "select BranchName from branch");
            sql.editComboBoxItems(comboBoxRentalID, "select distinct rRentalID from rentEquipment where CURRENT_TIMESTAMP <= ReturnTime or returnTime is null and rEquipmentID='" + comboBoxEquipID.Text + "' ");
            sql.selectQuery("SELECT distinct TypeName FROM Equipment WHERE EquipmentID = '"+int.Parse(comboBoxEquipID.Text)+" '");
            if (sql.read.HasRows)
            {
               
                while (sql.read.Read())
                {
                    textBoxEquipment.Text = sql.read[0].ToString();
                }
            }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }



}

        private void comboBoxRentalID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
            dateTimePicker1.Visible = true;
            comboBoxBranch.Visible = true;
            textBoxCustomer.Visible = true;
            sql.selectQuery("select distinct fname,sname from Customer join Rental on Customer.Email=Rental.CustomerEmail join rentEquipment on Rental.RentalID=rentEquipment.rRentalID where rRentalID='"+int.Parse(comboBoxRentalID.Text)+"'");
            if (sql.read.HasRows)
            {
               
                while (sql.read.Read())
                {
                    textBoxCustomer.Text = (sql.read[0].ToString()+" "+ sql.read[1].ToString());
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            { 

            if (comboBoxBranch.Text!="" && comboBoxEquipID.Text!="" && dateTimePicker1.Text != "" &&comboBoxRentalID.Text != "")
            {
                DialogResult result = MessageBox.Show("You Want to Confirm ", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sql.executeQuery("update rentEquipment set returnTo='" + comboBoxBranch.Text + "' where rEquipmentID='" + comboBoxEquipID.Text + "' and rRentalID='" + comboBoxRentalID.Text + "'");
                    sql.executeQuery("update rentEquipment set returnTime='" + dateTimePicker1.Value + "' where rEquipmentID='" + comboBoxEquipID.Text + "' and rRentalID='" + comboBoxRentalID.Text + "'");
                    clear();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select all details");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void clear()
        {
            try
            { 
            comboBoxEquipID.Text = "";
            comboBoxBranch.Items.Clear();
            comboBoxEquipID.Items.Clear();
            comboBoxRentalID.Items.Clear();           
            comboBoxBranch.Visible = false;
            comboBoxRentalID.Visible = false;
            dateTimePicker1.Visible = false;
            textBoxEquipment.Visible = false;
            textBoxCustomer.Visible = false;
            sql.editComboBoxItems(comboBoxEquipID, "select distinct rEquipmentID from rentEquipment where CURRENT_TIMESTAMP <= ReturnTime or returnTime is null");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try
            { 
            clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            { 
            this.Hide();
            login login =new login();
            login.ShowDialog();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
