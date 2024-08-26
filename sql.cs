using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace D2
{
    class sql
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=cairo.cms.waikato.ac.nz;Database=rl286_D2;Integrated Security=True");
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader read;

        
        public static void executeQuery(string query)
        {
            //try catch to catch any unforseen errors gracefully
            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //put a message box in here if you are recieving errors and see if you can find out why?
                MessageBox.Show(ex.Message);
                return;
            }

        }

        /// <summary>
        /// Generates an SQL query based on the input
        /// query e.g. "SELECT * FROM staff"
        /// </summary>
        /// <param name="query"></param>
        public static void selectQuery(string query)
        {
            try
            {
                con.Close();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                read = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                //put a message box in here if you are recieving errors and see if you can find out why?
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Prints out the ID  based on the query givin into a combo box
        /// </summary>
        /// <param name="comboBox">A control to be used to write existing names to</param>
        /// <param name="query">An sql query to generate from</param>
        public static void editComboBoxItems(ComboBox comboBox, string query)
        {
            bool clear = true;

            //gets data from database
            sql.selectQuery(query);
            //Check that there is something to write brah
            if (sql.read.HasRows)
            {
                while (sql.read.Read())
                {
                    if (comboBox.Text == sql.read[0].ToString())
                    {
                        clear = false;
                    }
                }
            }

            //gets data from database
            sql.selectQuery(query);
            //if nothing in the comboBox then we need to clear it
            if (clear)
            {
                comboBox.Text = "";
                comboBox.Items.Clear();

            }

            // this will print whatever is in the database to the combobox
            if (sql.read.HasRows)
            {
                while (sql.read.Read())
                {
                    comboBox.Items.Add(sql.read[0].ToString());
                }
            }
        }
    }

}
