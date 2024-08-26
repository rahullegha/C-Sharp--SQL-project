using Azure.Identity;
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
    public partial class login : Form
    {
        public static string username = "";               
        public login()
        {
            try 
            {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            labelerror.Visible = false;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        

        public void initializetextbox()
        {
            try { 
            labelerror.Visible = true;
            textBoxusername.Clear();
            textBoxPassword.Clear();
            textBoxusername.Focus();
            comboBoxloginmode.ResetText();
                }catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void login_Load(object sender, EventArgs e)
        {
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelLoginPage_Click(object sender, EventArgs e)
        {

        }

        public void buttonLogin_Click(object sender, EventArgs e)
        {
            try { 
            //Variables to be used: 1x bool, 4x string
            bool loggedIn = false;
            string password = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if (""==(textBoxusername.Text.Trim()) || ""==(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Please make sure you enter a Username and Password");
                labelerror.Visible = true;
                initializetextbox();
                return;
            }

            //(1) GET the username and password from the text boxes, is good to put them in a try catch
            try
            {
                //Get the username and password and store as string
                username = textBoxusername.Text.Trim();
                password = textBoxPassword.Text.Trim();
                
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format.");
                return;
            }
           
           if (comboBoxloginmode.Text== "Staff Login")
            {
                    //Use a select query on the users table
                    sql.selectQuery("SELECT * from Staff");


                    //If there exists at least one User
                    if (sql.read.HasRows)
                {
                    //cycle through all users checking if the username exists and if the password matches
                    while (sql.read.Read())
                    {
                        //sql.read[i]: i=0 is UserName ... i=4 is Password
                        if (username==(sql.read[0].ToString()) &&
                        password==(sql.read[4].ToString()))
                        {
                            //Username and Password correct, get fname, lname to display
                            loggedIn = true;
                            break; //stops the while loop since they have logged in
                        }

                    }
                }
                else
                {
                    //Error message to show that no users have been registered
                    MessageBox.Show("No users have been registered.");
                    return;
                }
            }
            if (comboBoxloginmode.Text == "Customer Login")
            {
                //Use a select query on the users table
                sql.selectQuery("SELECT * from Customer");


                //If there exists at least one User
                if (sql.read.HasRows)
                {
                    //cycle through all users checking if the username exists and if the password matches
                    while (sql.read.Read())
                    {
                        //sql.read[i]: i=0 is UserName ... i=4 is Password
                        if (username == (sql.read[0].ToString()) &&
                        password == (sql.read[4].ToString()))
                        {
                            //Username and Password correct, get fname, lname to display
                            loggedIn = true;
                            break; //stops the while loop since they have logged in
                        }

                    }
                }
                else
                {
                    //Error message to show that no users have been registered
                    MessageBox.Show("No users have been registered.");
                    return;
                }
            }
            if (loggedIn && comboBoxloginmode.Text == "Customer Login")
            {
                Hide();                                 //hides the register form
                Customer login = new Customer();      //creates the login page as an object
                login.ShowDialog();                     //shows the new login page form
                this.Close();

            }
            if(loggedIn && comboBoxloginmode.Text == "Staff Login")
            {
                Hide();                                 //hides the register form
                staff login = new staff();      //creates the login page as an object
                login.ShowDialog();                     //shows the new login page form
                this.Close();

            }
            else
            {
                if (comboBoxloginmode.Text == "")
                {
                    MessageBox.Show("Please select login mode");
                    initializetextbox();
                    labelerror.Visible = false;
                    return;
                }
                else
                {
                    MessageBox.Show("Login attempt unsuccessful! Please check details");
                    initializetextbox();
                    return;
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            try { 
            initializetextbox();
            labelerror.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }
     

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try { 
            
            Hide();                                 //hides the register form
            RegisterPage login = new RegisterPage();      //creates the login page as an object
            
            login.ShowDialog();                     //shows the new login page form
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
       
    }
}
