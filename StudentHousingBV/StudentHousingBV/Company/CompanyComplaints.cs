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
        List<Complaint> complaints;
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
            {
                if (allTenants[i].getName() == Convert.ToString(this.cbTenants.SelectedItem))
                {
                    currentTenant = allTenants[i];
                }
            }

            if (currentTenant != null)
            {
                complaints = currentTenant.getComplaints();
                UpdateListBox();
            } else
            {
                MessageBox.Show("Please select a tenant to view complaints");
            }
        }

        public void UpdateListBox()
        {
            this.lbComplaints.Items.Clear();

            for (int i = 0; i < complaints.Count(); i++)
            {
                String complaint = complaints[i].getType().ToString().ToLower();
                String complaintFormatted = char.ToUpper(complaint[0]) + complaint.Substring(1);
                String item;

                if (complaint != "unlocked")
                {
                    item = complaintFormatted + "\t\t" + complaints[i].getDateCreated();
                }
                else
                {
                    item = complaintFormatted + "\t" + complaints[i].getDateCreated();
                }

                lbComplaints.Items.Add(item);
            }
        }

        private void lbComplaints_SelectedIndexChanged(object sender, EventArgs e)
        {

            Complaint complaint = new Complaint();

            if (lbComplaints.SelectedIndex >= 0)
            {
                complaint = complaints[lbComplaints.SelectedIndex];
            }

            if (complaint.getMessage() != null)
            {
                tbComplaintMessage.Text = complaint.getMessage();
            }
            else
            {
                tbComplaintMessage.Text = "This complaint has no message";
            }
        }
    }
}
