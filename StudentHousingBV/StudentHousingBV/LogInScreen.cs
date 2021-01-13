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
        
        private List<TenantClass> tenants = new List<TenantClass>();
        private List<Admin> admins = new List<Admin>();
        private List<String> announcements = new List<String>();
        private List<String> rules = new List<String>();
        private String tenantName;
        private String adminName;
        private TenantClass currentTenant;
        private Admin currentAdmin;
        
        public LogInScreen()
        {
            InitializeComponent();
            initializeTenants();
            initializeAnnouncements();
            initializeRules();
        }
        public void initializeTenants()
        {
            tenants.Clear();
            String line;

            // Read users.txt and get all tenants
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../users.txt");
            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                String[] elements = line.Split(' ');
                String username = elements[0];
                String password = elements[1];
                String role = elements[2];

                if(role == "user") {
                    TenantClass newTenant = new TenantClass(username, password);
                    tenants.Add(newTenant);
                } else if(role == "admin")
                {
                    Admin newAdmin = new Admin(username, password);
                    admins.Add(newAdmin);
                }
            }
            file.Close();
            
            tenants[0].makeStudentOfTheMonth();
        }

        private void initializeAnnouncements()
        {
            announcements.Add("Pizza party at 20:00, Friday");
            announcements.Add("Movie night at 21:00, Saturday");
        }

        private void initializeRules()
        {
            rules.Add("Clean up after yourselves");
            rules.Add("Always lock the front door when leaving");
            rules.Add("No parties due to COVID19");
        }
        public void updateRules(String rule)
        {
            rules.Add(rule);
        }
        public void removeRule(String rule)
        {
            rules.Remove(rule);
        }
        public List<String> getRules()
        {
            return rules;
        }
        public void updateAnnouncements(String announcement)
        {
            announcements.Add(announcement);
        }

        public void removeAnnouncement(String announcement)
        {
            announcements.Remove(announcement);
        }
        public List<String> getAnnouncements()
        {
            return announcements;
        }
        public List<TenantClass> getTenants()
        {
            return tenants;
        }
        public void addTenant(TenantClass x)
        {
            tenants.Add(x);
        }
        public String getTenantName()
        {
            return tenantName;
        }
        public TenantClass getTenant()
        {
            return currentTenant;
        }

        public Admin getAdmin()
        {
            return currentAdmin;
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

                            adminName = this.tbUserName.Text;
                            for (int i = 0; i < admins.Count(); i++)
                                if (adminName == admins[i].getName())
                                    currentAdmin = admins[i];
                            this.Hide();
                            file.Close();
                            CompanyHome companyScreen = new CompanyHome();
                            companyScreen.Show();
                        }
                        else if (role == "user")
                        {
                            // Go to Tenant form

                            tenantName = this.tbUserName.Text;
                            for (int i = 0; i < tenants.Count(); i++)
                                if (tenantName == tenants[i].getName())
                                    currentTenant = tenants[i];
                            this.Hide();
                            file.Close();
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
