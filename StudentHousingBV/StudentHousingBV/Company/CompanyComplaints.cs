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
    public partial class CompanyComplaints : Form
    {
        List<TenantClass> allTenants;
        TenantClass currentTenant;
        List<String> complaints;
        public CompanyComplaints()
        {
            InitializeComponent();
        }

        private void CompanyComplaints_Load(object sender, EventArgs e)
        {
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            allTenants = login.getTenants();
            for (int i=0;i<allTenants.Count();i++)
            {
                this.cbTenants.Items.Add(allTenants[i].getName());
            }

        }

        private void btnShowComplaints_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allTenants.Count(); i++)
                if (allTenants[i].getName() == Convert.ToString(this.cbTenants.SelectedItem))
                    currentTenant = allTenants[i];
            complaints = currentTenant.getComplaints();
            UpdateListBox();
        }
        public void UpdateListBox()
        {
            this.lbComplaints.Items.Clear();
            for (int i = 0; i < complaints.Count(); i++)
                this.lbComplaints.Items.Add(complaints[i]);
        }
        private void btnRemoveComplaint_Click(object sender, EventArgs e)
        {
            String complaint = Convert.ToString(this.lbComplaints.SelectedItem);
            currentTenant.removeComplaints(complaint);
            UpdateListBox();
        }
    }
}
