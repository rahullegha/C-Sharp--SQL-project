using Azure.Identity;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace D2
{
    public partial class Customer : Form
    {
        
        public Customer()
        {
            //inistialize the form
            try { 
            InitializeComponent();
            listBoxDetails.Items.Clear();
            clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            

            
           
         
        }

        private void labelCustomer_Click(object sender, EventArgs e)
        {

        }

        private void labellogout_Click(object sender, EventArgs e)
        {
            //move to login page
            try { 
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void labellogout_MouseHover(object sender, EventArgs e)
        {
            try { 
            // Change text color on mouse hover
            labellogout.ForeColor = Color.Red;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void labellogout_MouseLeave(object sender, EventArgs e)
        {
            try { 
            // Reset text color on mouse leave
            labellogout.ForeColor= Color.White;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBoxRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                //show data time selection
            dateTimePicker1.Visible = true; 
                //get the rateperhour of equipment selected
            sql.selectQuery("select ratePerHour from equipmenttype where typeName in(select typeName from equipment where TypeName='"+comboBoxEquip.Text+"')");
            if (sql.read.HasRows)
            {
                while (sql.read.Read())
                {
                        //write the value in textBoxRate
                    textBoxRate.Text = sql.read[0].ToString();                    
                }
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            comboBoxEquip.Items.Clear();
            comboBoxEquip.Text = "";
            comboBoxEquip.Visible = true;
            //get value of branch and store in combo box
            sql.editComboBoxItems(comboBoxEquip, "select TypeName from equipment where BranchName='"+comboBoxBranch.Text+"' and available>0 ORDER BY PurchaseDate DESC ");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonHire_Click(object sender, EventArgs e)
        {
            try { 
            if (comboBoxBranch.Visible && comboBoxEquip.Visible && dateTimePicker1.Visible)
            {
                DialogResult result = MessageBox.Show("You Want to Confirm ", "Confirm", MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    string equipmentid = "", rentalid = "";
                    sql.selectQuery("select EquipmentID from Equipment where BranchName='" + comboBoxBranch.Text + "' and TypeName='" + comboBoxEquip.Text + "' and available>0 order by purchaseDate desc");
                    if (sql.read.HasRows)
                    {
                       
                        while (sql.read.Read())
                        {
                            equipmentid = sql.read[0].ToString();
                        }
                    }

                    DateTime date = dateTimePicker1.Value;
                    sql.executeQuery("insert into Rental(startTime,hireFrom,CustomerEmail) values('" + date + "', '" + comboBoxBranch.Text + "', '" + login.username + "')");
                    sql.selectQuery("select RentalID from Rental where startTime='" + date + "' and hireFrom='" + comboBoxBranch.Text + "'and CustomerEmail='" + login.username + "' ");
                    if (sql.read.HasRows)
                    {
                       
                        while (sql.read.Read())
                        {
                            rentalid = sql.read[0].ToString();
                        }
                    }
                    sql.executeQuery("insert into rentEquipment(rEquipmentID,rRentalID) values('" + int.Parse(equipmentid) + "', '" + int.Parse(rentalid) + "')");
                    listBoxDetails.Items.Clear();
                    clear();
                    sql.selectQuery("select TypeName,startTime,returnTime,hireFrom,returnTo from customerlistbox where CustomerEmail ='" + login.username + "'  ");
                    if (sql.read.HasRows)
                    {
                        while (sql.read.Read())
                        {
                            
                            string TypeName = "", hireFrom = "", returnTo = "", startTime = "", ReturnTime = "";

                            TypeName = sql.read[0].ToString();
                            startTime = sql.read[1].ToString();
                            ReturnTime = sql.read[2].ToString();
                            hireFrom = sql.read[3].ToString();
                            returnTo = sql.read[4].ToString();
                            if (TypeName == "")
                            {
                                TypeName = "         NULL           ";
                            }
                            if (startTime == "")
                            {
                                startTime = "         NULL           ";
                            }
                            if (ReturnTime == "")
                            {
                                ReturnTime = "         NULL                               ";
                            }
                            if (hireFrom == "")
                            {
                                hireFrom = "         NULL           ";
                            }
                            if (returnTo == "")
                            {
                                returnTo = "         NULL           ";
                            }
                            listBoxDetails.Items.Add(TypeName.PadRight(40) + " " + startTime.PadRight(40) + " " + ReturnTime.PadRight(30) + " " + hireFrom.PadRight(40) + " " + returnTo);
                        }
                    }


                }
                else
                {
                    return;
                    clear();
                }
                   
            }
            else
            {
                MessageBox.Show("Please Select for hire");
                clear();
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };

        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
            if (comboBoxSort.Text == "Upcoming")
            {
                listBoxDetails.Items.Clear();
                sql.selectQuery("select TypeName,startTime,returnTime,hireFrom,returnTo from customerlistbox where CustomerEmail ='" + login.username + "'  and current_timestamp<startTime ");
                if (sql.read.HasRows)
                {
                   
                    while (sql.read.Read())
                    {
                        string TypeName = "", hireFrom = "", returnTo = "", startTime = "", ReturnTime = "";

                        TypeName = sql.read[0].ToString();
                        startTime = sql.read[1].ToString();
                        ReturnTime = sql.read[2].ToString();
                        hireFrom = sql.read[3].ToString();
                        returnTo = sql.read[4].ToString();
                        if (TypeName == "")
                        {
                            TypeName = "         NULL           ";
                        }
                        if (startTime == "")
                        {
                            startTime = "         NULL           ";
                        }
                        if (ReturnTime == "")
                        {
                            ReturnTime = "         NULL                               ";
                        }
                        if (hireFrom == "")
                        {
                            hireFrom = "         NULL           ";
                        }
                        if (returnTo == "")
                        {
                            returnTo = "         NULL           ";
                        }
                        listBoxDetails.Items.Add(TypeName.PadRight(40) + " " + startTime.PadRight(40) + " " + ReturnTime.PadRight(30) + " " + hireFrom.PadRight(40) + " " + returnTo);
                    }
                }
            } if (comboBoxSort.Text == "Ongoing")
            {
                listBoxDetails.Items.Clear();
                sql.selectQuery("select TypeName,startTime,returnTime,hireFrom,returnTo from customerlistbox where CustomerEmail ='" + login.username + "' and (startTime<=current_timestamp and returnTime>current_timestamp or  returnTime is null) ");
                if (sql.read.HasRows)
                {
                   
                    while (sql.read.Read())
                    {
                        string TypeName = "", hireFrom = "", returnTo = "", startTime = "", ReturnTime = "";

                        TypeName = sql.read[0].ToString();
                        startTime = sql.read[1].ToString();
                        ReturnTime = sql.read[2].ToString();
                        hireFrom = sql.read[3].ToString();
                        returnTo = sql.read[4].ToString();
                        if (TypeName == "")
                        {
                            TypeName = "         NULL           ";
                        }
                        if (startTime == "")
                        {
                            startTime = "         NULL           ";
                        }
                        if (ReturnTime == "")
                        {
                            ReturnTime = "         NULL                               ";
                        }
                        if (hireFrom == "")
                        {
                            hireFrom = "         NULL           ";
                        }
                        if (returnTo == "")
                        {
                            returnTo = "         NULL           ";
                        }
                        listBoxDetails.Items.Add(TypeName.PadRight(40) + " " + startTime.PadRight(40) + " " + ReturnTime.PadRight(30) + " " + hireFrom.PadRight(40) + " " + returnTo);
                    }
                }
            }
            if (comboBoxSort.Text == "Past")
            {
                listBoxDetails.Items.Clear();
                sql.selectQuery("select TypeName,startTime,returnTime,hireFrom,returnTo from customerlistbox where CustomerEmail ='" + login.username + "' and current_timestamp>=returnTime  ");
                if (sql.read.HasRows)
                {
                   
                    while (sql.read.Read())
                    {
                        string TypeName = "", hireFrom = "", returnTo = "", startTime = "", ReturnTime = "";

                        TypeName = sql.read[0].ToString();
                        startTime = sql.read[1].ToString();
                        ReturnTime = sql.read[2].ToString();
                        hireFrom = sql.read[3].ToString();
                        returnTo = sql.read[4].ToString();
                        if (TypeName == "")
                        {
                            TypeName = "         NULL           ";
                        }
                        if (startTime == "")
                        {
                            startTime = "         NULL           ";
                        }
                        if (ReturnTime == "")
                        {
                            ReturnTime = "         NULL                               ";
                        }
                        if (hireFrom == "")
                        {
                            hireFrom = "         NULL           ";
                        }
                        if (returnTo == "")
                        {
                            returnTo = "         NULL           ";
                        }
                        listBoxDetails.Items.Add(TypeName.PadRight(40) + " " + startTime.PadRight(40) + " " + ReturnTime.PadRight(30) + " " + hireFrom.PadRight(40) + " " + returnTo);
                    }
                }
            }
            if (comboBoxSort.Text == "All")
            {
                
                listBoxDetails.Items.Clear();
                sql.selectQuery("select TypeName,startTime,returnTime,hireFrom,returnTo from customerlistbox where CustomerEmail ='" + login.username + "'  ");
                if (sql.read.HasRows)
                {
                   
                    while (sql.read.Read())
                    {
                        string TypeName = "", hireFrom = "", returnTo = "", startTime = "", ReturnTime = "";

                        TypeName = sql.read[0].ToString();
                        startTime = sql.read[1].ToString();
                        ReturnTime = sql.read[2].ToString();
                        hireFrom = sql.read[3].ToString();
                        returnTo = sql.read[4].ToString();
                        if (TypeName == "")
                        {
                            TypeName = "         NULL           ";
                        }
                        if (startTime == "")
                        {
                            startTime = "         NULL           ";
                        }
                        if (ReturnTime == "")
                        {
                            ReturnTime = "         NULL                               ";
                        }
                        if (hireFrom == "")
                        {
                            hireFrom = "         NULL           ";
                        }
                        if (returnTo == "")
                        {
                            returnTo = "         NULL           ";
                        }
                        listBoxDetails.Items.Add(TypeName.PadRight(40) + " " + startTime.PadRight(40) + " " + ReturnTime.PadRight(30) + " " + hireFrom.PadRight(40) + " " + returnTo);                       
                    }
                }
            }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
        public void clear()
        {
            try { 
            comboBoxEquip.Visible = false;
            dateTimePicker1.Visible = false;
            sql.editComboBoxItems(comboBoxBranch, "select BranchName from Branch");           
            comboBoxSort.Text = "All";
            textBoxRate.Clear();
            comboBoxBranch.Text = "";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelStatistics_MouseHover(object sender, EventArgs e)
        {
            try { 
            labelStatistics.ForeColor= Color.Green;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void labelStatistics_MouseLeave(object sender, EventArgs e)
        {
            try { 
            labelStatistics.ForeColor = Color.White;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void labelStatistics_Click(object sender, EventArgs e)
        {
            try { 
            // Redirect to statistics form
            this.Hide();
            Statistics login= new Statistics();
            login.ShowDialog();
            this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
