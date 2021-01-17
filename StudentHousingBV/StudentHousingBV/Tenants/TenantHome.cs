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
    public partial class TenantHome : Form
    {
        private TenantClass currentTenant;
        private List<TenantClass> allTenants;

        public TenantHome()
        {
            InitializeComponent();
        }

        public int getReports()
        {
            return currentTenant.getReports();
        }
        public TenantClass getTenant()
        {
            return currentTenant;
        }

        private void ClientHome_Load(object sender, EventArgs e)
        {
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];

            allTenants = login.getTenants();

            for (int i = 0; i < allTenants.Count; i++)
            {
                if (allTenants[i].isStudentOfTheMonth() == true)
                {
                    this.lblSoTM.Text = allTenants[i].getName();
                }
            }

            currentTenant = login.getTenant();
            lblWelcome.Text = "Welcome, " + currentTenant.getName() + " !";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            TenantComplaint complaint = new TenantComplaint();
            complaint.Show();
        }

        private void lblAnnouncements_Click(object sender, EventArgs e)
        {
            TenantAnnouncements announcements = new TenantAnnouncements();
            announcements.Show();
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            TenantAccount account = new TenantAccount();
            account.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            TenantTasks tasks = new TenantTasks();
            tasks.Show();
        }

        private void lblRules_Click(object sender, EventArgs e)
        {
            TenantRules rules = new TenantRules();
            rules.Show();
        }

        private void lblEssentials_Click(object sender, EventArgs e)
        {
            TenantEsentials esentials = new TenantEsentials();
            esentials.Show();
        }
    }
}
