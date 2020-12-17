using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace StudentHousingBV
{
    public partial class LogInScreen : Form
    {
        
        private List<Tenant> tenants = new List<Tenant>();
        public LogInScreen()
        {
            InitializeComponent();
            initializeTenants();
        }
        private void initializeTenants()
        {
            Tenant firstTenant = new Tenant("MitranMatei");
            Tenant secondTenant = new Tenant("AlexanderBogdanov");
            Tenant thirdTenant = new Tenant("IoanPopa");
            firstTenant.makeStudentOfTheMonth();
            tenants.Add(firstTenant);
            tenants.Add(secondTenant);
            tenants.Add(thirdTenant);
        }
        public List<Tenant> getTenants()
        {
            return tenants;
        }
        public String getTenant()
        {
            return this.tbUserName.Text;
        }
        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Get typed in username and password
            String enteredUsername = tbUserName.Text;
            String enteredPassword = tbPassword.Text;

            String line;
            int counter = 0;

            bool loggedIn = false;
            bool encounteredError = false;

            // Read users.txt and compare values
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../users.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                String[] elements = line.Split(' ');
                String username = elements[0];
                String password = elements[1];
                String role = elements[2];

                if (enteredUsername == username)
                {
                    if (enteredPassword == password)
                    {
                        if (role == "admin")
                        {
                            // Go to Company form

                            this.Hide();
                            CompanyHome companyScreen = new CompanyHome();
                            companyScreen.Show();
                        }
                        else if (role == "user")
                        {
                            // Go to Tenant form

                            this.Hide();
                            TenantHome tenantScreen = new TenantHome();
                            tenantScreen.Show();
                        }
                        else
                        {
                            // No such role

                            tbUserName.Text = "";
                            tbPassword.Text = "";

                            MessageBox.Show("An error occured, please try logging in with a different account");

                            encounteredError = true;
                            break;
                        }

                        loggedIn = true;
                        break;
                    }
                }

                counter++;
            }

            if (loggedIn == false && encounteredError == false)
            {
                // If login failed

                tbUserName.Text = "";
                tbPassword.Text = "";

                MessageBox.Show("Invalid username or password");
            }
        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_MouseHover(object sender, EventArgs e)
        {
            this.btnLogIn.ForeColor = Color.Green;
        }

        private void btnLogIn_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogIn.ForeColor = Color.Black;
        }
    }
}
