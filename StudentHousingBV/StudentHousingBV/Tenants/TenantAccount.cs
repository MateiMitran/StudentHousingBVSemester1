using StudentHousingBV.Tenants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV
{
    public partial class TenantAccount : Form
    {
        private Banks ammount;

        List<Banks> account = new List<Banks>();

        TenantClass currentTenant;
        public TenantAccount()
        {
            InitializeComponent();
            this.ammount = new Banks(10); // Here it should be that a user has a starting ammount in the accounts   
        }

        private void TenantAccount_Load(object sender, EventArgs e)
        {
            TenantHome home = (TenantHome)Application.OpenForms["TenantHome"];
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];

            currentTenant = home.getTenant();
            this.lblReports.Text = currentTenant.getReports() + " reports.";

            for (int i = 0; i < account.Count(); i++ )
            {
                String Ammount = Convert.ToString(this.ammount);
               // this.personalMoneylbl.Text = Ammount;  
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            TenantHome home = (TenantHome)Application.OpenForms["TenantHome"];
            this.Close();
            home.Close();
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            login.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            TenantChangePassword changePassword = new TenantChangePassword();
            changePassword.Show();
        }
    }
}
