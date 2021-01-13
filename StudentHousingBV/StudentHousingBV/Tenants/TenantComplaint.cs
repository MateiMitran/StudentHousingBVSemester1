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
    public partial class TenantComplaint : Form
    {
        List<TenantClass> alltenants = new List<TenantClass>();
        TenantClass reportedTenant;
        TenantClass currentTenant;
        public TenantComplaint()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TenantComplaint_Load(object sender, EventArgs e)
        {
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            alltenants = login.getTenants();
            TenantHome home = (TenantHome)Application.OpenForms["TenantHome"];
            currentTenant = home.getTenant();
            for (int i = 0; i < alltenants.Count(); i++)
            {
                if (alltenants[i]!=currentTenant)
                    this.cbxTenants.Items.Add(alltenants[i].getName());
            }
                
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            
                
            for (int i = 0; i < alltenants.Count(); i++)
                 if (alltenants[i].getName() == Convert.ToString(this.cbxTenants.SelectedItem))
                       reportedTenant = alltenants[i];
             if (this.rbLoud.Checked)
            {
                reportedTenant.addComplaints("Noise");
                MessageBox.Show("Complaint filed!");
            }
                 
             else if (this.rbDirty.Checked)
            {
                reportedTenant.addComplaints("Dirty");
                MessageBox.Show("Complaint filed!");
            }
                 
             else if (this.rbTrash.Checked)
            {
                reportedTenant.addComplaints("Trash");
                MessageBox.Show("Complaint filed!");
            }
                 
             else if (this.rbUnlocked.Checked)
            {
                reportedTenant.addComplaints("Unlocked");
                MessageBox.Show("Complaint filed!");
            }
                 
             else if (this.tbCustom.TextLength > 0)
            {
                reportedTenant.addComplaints(this.tbCustom.Text);
                MessageBox.Show("Complaint filed!");
            }
                 
             else
                 MessageBox.Show("No complaint selected!"); 
          
          

        }
    }
}
