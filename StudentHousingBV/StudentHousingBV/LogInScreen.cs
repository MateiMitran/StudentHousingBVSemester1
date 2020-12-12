using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV
{
    public partial class LogInScreen : Form
    {
        private String tenantPassword = "TENANT";
        private String companyPassword = "COMPANY";
        public LogInScreen()
        {
            InitializeComponent();
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
            if (this.tbPassword.Text == tenantPassword)
            {
                this.Hide();
                TenantHome tenantScreen = new TenantHome();
                tenantScreen.Show();
            }
            else if (this.tbPassword.Text == companyPassword)
            {
                this.Hide();
                CompanyHome companyScreen = new CompanyHome();
                companyScreen.Show();
            }
            else
                MessageBox.Show("Invalid password!");

            
            

        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
