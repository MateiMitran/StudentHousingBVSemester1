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
        public TenantHome()
        {
            InitializeComponent();
        }

        private void ClientHome_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

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
            this.Hide();
            LogInScreen login = new LogInScreen();
            login.Show();
        }

        private void lblRules_Click(object sender, EventArgs e)
        {
            TenantRules rules = new TenantRules();
            rules.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
