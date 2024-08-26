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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace D2
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
           
           
        }

        private void comboBoxStats_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
            if (comboBoxStats.SelectedIndex == 0)
            {
                listBoxStatistics.Items.Clear();
                listBoxStatistics.Items.Add("BranchName".PadRight(80)+" "+ "UniqueCustomers");
                sql.selectQuery("SELECT hireFrom as BranchName, COUNT(DISTINCT CustomerEmail) AS UniqueCustomers FROM Rental WHERE YEAR(startTime) = '2023' GROUP BY hireFrom;");
                if (sql.read.HasRows)
                {
                   
                    while (sql.read.Read())
                    {
                        listBoxStatistics.Items.Add(sql.read[0].ToString().PadRight(80) + " " + sql.read[1].ToString());
                    }
                }
            }
            if (comboBoxStats.SelectedIndex == 1)
            {
                listBoxStatistics.Items.Clear();
                listBoxStatistics.Items.Add("TypeName".PadRight(80) + " " + "AvgRentalDuration");
                sql.selectQuery("SELECT Equipment.TypeName, AVG(DATEDIFF(day, Rental.startTime, rentEquipment.returnTime)) AS AvgRentalDuration FROM Rental JOIN rentEquipment  ON rental.RentalID = rentEquipment.rRentalID join Equipment on rentEquipment.rEquipmentID=Equipment.EquipmentID WHERE YEAR(startTime) = '2023'GROUP BY Equipment.TypeName;");
                if (sql.read.HasRows)
                {
                   
                    while (sql.read.Read())
                    {
                        listBoxStatistics.Items.Add(sql.read[0].ToString().PadRight(80) + " " + sql.read[1].ToString());
                    }
                }
            }
            if (comboBoxStats.SelectedIndex == 2)
            {
                listBoxStatistics.Items.Clear();
                listBoxStatistics.Items.Add("BranchName" + "  ,  " + "TypeName" + "  ,  " + "Popular_Count");
                sql.selectQuery("SELECT hireFrom, TypeName, COUNT(*) AS Popular_Count FROM Rental JOIN rentEquipment ON Rental.RentalID = rentEquipment.rRentalID JOIN Equipment ON rentEquipment.rEquipmentID = Equipment.EquipmentID WHERE YEAR(Rental.startTime) = 2023 GROUP BY hireFrom, TypeName HAVING COUNT(*) = (     SELECT MAX(Popular_Count)     FROM (         SELECT hireFrom, TypeName, COUNT(*) AS Popular_Count         FROM Rental         JOIN rentEquipment ON Rental.RentalID = rentEquipment.rRentalID         JOIN Equipment ON rentEquipment.rEquipmentID = Equipment.EquipmentID         WHERE YEAR(Rental.startTime) = 2023         GROUP BY hireFrom, TypeName     ) AS BranchRentalCounts     WHERE BranchRentalCounts.hireFrom = Rental.hireFrom ) ORDER BY Popular_Count,hireFrom ;");
                if (sql.read.HasRows)
                {
                   
                    while (sql.read.Read())
                    {
                        listBoxStatistics.Items.Add(sql.read[0].ToString() + "  ,  " + sql.read[1].ToString() + "  ,  " + sql.read[2].ToString());
                    }
                }
            }
            if (comboBoxStats.SelectedIndex == 3)
            {
                listBoxStatistics.Items.Clear();
                listBoxStatistics.Items.Add("Month".PadRight(80) + " " + "TotalRentals");
                sql.selectQuery("SELECT MONTH(startTime) AS Month, COUNT(*) AS TotalRentals FROM Rental WHERE YEAR(startTime) = 2023 GROUP BY MONTH(startTime);");
                if (sql.read.HasRows)
                {
                   
                    while (sql.read.Read())
                    {
                        listBoxStatistics.Items.Add(sql.read[0].ToString().PadRight(80) + " " + sql.read[1].ToString());
                    }
                }
            }
            if (comboBoxStats.SelectedIndex == 4)
            {
                listBoxStatistics.Items.Clear();

                listBoxStatistics.Items.Add("TypeName".PadRight(80) + " " + "TotalIncome");
                sql.selectQuery("select EquipmentType.TypeName,SUM(DATEDIFF(DAY,rental.startTime,rentEquipment.returnTime))*(EquipmentType.ratePerHour)*24 AS TotalIncome from EquipmentType join Equipment on EquipmentType.TypeName=Equipment.TypeName join rentEquipment on rentEquipment.rEquipmentID=Equipment.EquipmentID join Rental on Rental.RentalID=rentEquipment.rRentalID WHERE YEAR(Rental.startTime) = 2023 GROUP BY EquipmentType.TypeName,EquipmentType.ratePerHour;");
                if (sql.read.HasRows)
                {
                   
                    while (sql.read.Read())
                    {
                        listBoxStatistics.Items.Add(sql.read[0].ToString().PadRight(80) + " " + sql.read[1].ToString());
                    }
                }
            }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Customer login = new Customer();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); };
        }
    }
}
