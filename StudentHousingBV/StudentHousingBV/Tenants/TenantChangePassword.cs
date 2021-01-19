using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV.Tenants
{
    public partial class TenantChangePassword : Form
    {
        public TenantChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            String currentPassword = tbCurrentPassword.Text;
            String newPassword = tbNewPassword.Text;
            String verifyNewPassword = tbVerifyNewPassword.Text;

            // Get current user
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            TenantClass currenTenant = login.getTenant();
            String currentTenantName = currenTenant.getName();
            String currentTenantPassword = currenTenant.getPassword();

            if (currentPassword == currentTenantPassword)
            {
                if (newPassword.Trim() != "")
                {
                    if (newPassword == verifyNewPassword) {
                        // Read users.txt and compare current password
                        String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../users.txt");
                        String newPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../new-users.txt");

                        System.IO.StreamReader fileRead = new System.IO.StreamReader(path);

                        String line;
                        String text = "";

                        while ((line = fileRead.ReadLine()) != null)
                        {
                            String[] elements = line.Split(' ');
                            String username = elements[0];
                            String password = elements[1];
                            String role = elements[2];

                            if (currentTenantName == username)
                            {
                                String info = username + " " + newPassword + " " + role;
                                text += info + Environment.NewLine;

                                currenTenant.setPassword(newPassword);
                            }
                            else
                            {
                                text += line + Environment.NewLine;
                            }
                        }

                        fileRead.Close();

                        // Write old file into new file, delete old file and rename new file
                        File.WriteAllText(newPath, text);
                        fileRead.Close();
                        File.Delete(path);
                        fileRead.Close();
                        File.Move(newPath, path);

                        // Close current form
                        MessageBox.Show("Password change successfully!");
                        this.Close();
                    } else
                    {
                        MessageBox.Show("Your new password and confirmation password do not match.");
                    }
                } else
                {
                    MessageBox.Show("New password cannot be empty");

                    tbCurrentPassword.Text = "";
                    tbNewPassword.Text = "";
                    tbVerifyNewPassword.Text = "";
                }
            } else
            {
                MessageBox.Show("Current password is incorrect.");

                tbCurrentPassword.Text = "";
                tbNewPassword.Text = "";
                tbVerifyNewPassword.Text = "";
            }
        }
    }
}