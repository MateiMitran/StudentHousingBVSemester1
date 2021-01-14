using StudentHousingBV.Tenants;
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

namespace StudentHousingBV
{
    public partial class CompanyAccount : Form
    {
        public CompanyAccount()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInScreen login = new LogInScreen();
            CompanyHome home = (CompanyHome)Application.OpenForms["CompanyHome"];
            CompanyAccount account = (CompanyAccount)Application.OpenForms["CompanyAccount"];

            this.Close();
            home.Close();
            account.Close();
            login.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            String currentPassword = tbCurrentPassword.Text;
            String newPassword = tbNewPassword.Text;
            String verifyNewPassword = tbVerifyNewPassword.Text;

            // Get current admin
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            Admin currentAdmin = login.getAdmin();
            String currentAdminName = currentAdmin.getName();
            String currentAdminPassword = currentAdmin.getPassword();

            if (currentPassword == currentAdminPassword)
            {
                if (newPassword == verifyNewPassword)
                {
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

                        if (currentAdminName == username)
                        {
                            String info = username + " " + newPassword + " " + role;
                            text += info + Environment.NewLine;

                            currentAdmin.setPassword(newPassword);
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
                    tbCurrentPassword.Text = "";
                    tbNewPassword.Text = "";
                    tbVerifyNewPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Your new password and confirmation password do not match.");

                    tbCurrentPassword.Text = "";
                    tbNewPassword.Text = "";
                    tbVerifyNewPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Current password is incorrect.");

                tbCurrentPassword.Text = "";
                tbNewPassword.Text = "";
                tbVerifyNewPassword.Text = "";
            }
        }
    }
}
