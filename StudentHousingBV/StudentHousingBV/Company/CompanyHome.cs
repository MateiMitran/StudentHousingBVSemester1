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
    public partial class CompanyHome : Form
    {
        public CompanyHome()
        {
            InitializeComponent();
        }

        private void lblComplaints_Click(object sender, EventArgs e)
        {
            CompanyComplaints complaint = new CompanyComplaints();
            complaint.Show();
        }

        private void lblAnnouncements_Click(object sender, EventArgs e)
        {
            CompanyAnnouncements announcements = new CompanyAnnouncements();
            announcements.Show();
        }

        private void lblTenants_Click(object sender, EventArgs e)
        {
            CompanyTenants tenants = new CompanyTenants();
            tenants.Show();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            CompanyTasks tasks = new CompanyTasks();
            tasks.Show();
        }

        private void lblRules_Click(object sender, EventArgs e)
        {
            CompanyRules rules = new CompanyRules();
            rules.Show();
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {
            CompanyAccount account = new CompanyAccount();
            account.Show();
        }

        private void pbAccountSettings_Click(object sender, EventArgs e)
        {
            CompanyAccount account = new CompanyAccount();
            account.Show();
        }
    }
}
