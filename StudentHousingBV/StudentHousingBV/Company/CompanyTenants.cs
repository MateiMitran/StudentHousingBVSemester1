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
using System.Text.RegularExpressions;

namespace StudentHousingBV
{
    public partial class CompanyTenants : Form
    {
        private List<TenantClass> allTenants;
        LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];

        List<string> tenantUsernames;
        List<string> adminUsernames;

        public CompanyTenants()
        {
            InitializeComponent();
        }

        private void CompanyTenants_Load(object sender, EventArgs e)
        {
            allTenants = login.getTenants();

            for (int i = 0; i < allTenants.Count(); i++)
            {
                this.comboBox1.Items.Add(allTenants[i].getName());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String newTenantName = tbNewUsername.Text.Trim();
            String newTenantPassword = tbNewPassword.Text.Trim();
            String newTenantRole = cbNewUserRole.Text.Trim();

            if(newTenantName != "")
            {
                tenantUsernames = login.getTenantUsernames();
                adminUsernames = login.getAdminUsernames();

                if (tenantUsernames.IndexOf(newTenantName) == -1 && adminUsernames.IndexOf(newTenantName) == -1)
                {
                    if (newTenantPassword != "")
                    {
                        if (newTenantRole == "user" || newTenantRole == "admin")
                        {
                            TenantClass newTenant = new TenantClass(newTenantName, newTenantPassword);
                            login.addTenant(newTenant);

                            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../users.txt");

                            List<String> lines = new List<String>();
                            lines = File.ReadAllLines(path).ToList();

                            lines.Add(Regex.Replace(newTenantName, @"\s+", "") + " " + newTenantPassword + " " + newTenantRole);
                            File.WriteAllLines(path, lines);
                            this.comboBox1.Items.Add(newTenant.getName());

                            if(newTenantRole == "admin")
                            {
                                adminUsernames.Add(newTenantName);
                            }
                            else
                            {
                                tenantUsernames.Add(newTenantName);
                            }

                            tbNewUsername.Text = "";
                            tbNewPassword.Text = "";
                            cbNewUserRole.Text = "";
                            MessageBox.Show("User added successfuly!");
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid role for the new user");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose a password for the new user");
                    }
                } else
                {
                    tbNewUsername.Text = "";
                    MessageBox.Show("This username has already been taken. Please choose another one.");
                }
            } else
            {
                MessageBox.Show("Please enter a username for the new user");
            }
        }

        private void btnMakeSoTM_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allTenants.Count; i++)
            {
                if (allTenants[i].getName() == Convert.ToString(this.comboBox1.SelectedItem))
                {
                    allTenants[i].makeStudentOfTheMonth();
                    MessageBox.Show("Successfully updated tenant of the month!");
                    comboBox1.Text = "";
                } else
                {
                    allTenants[i].removeStudentOfTheMonth();
                }
            }
        }

        private void btnGenerateRandomPassword_Click(object sender, EventArgs e)
        {
            string randomPassword = GeneratePassword(8);
            tbNewPassword.Text = randomPassword;
        }

        public string GeneratePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890+-_=@#$%^&*!.,";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }

            return res.ToString();
        }

        private void cbNewUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
