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

        private void TenantComplaint_Load(object sender, EventArgs e)
        {
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            alltenants = login.getTenants();
            TenantHome home = (TenantHome)Application.OpenForms["TenantHome"];
            currentTenant = home.getTenant();

            for (int i = 0; i < alltenants.Count(); i++)
            {
                if (alltenants[i] != currentTenant)
                {
                    this.cbxTenants.Items.Add(alltenants[i].getName());
                }
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            String selectedTenant = Convert.ToString(this.cbxTenants.SelectedItem);

            if (selectedTenant.Trim() != "")
            {
                for (int i = 0; i < alltenants.Count(); i++)
                {
                    if (alltenants[i].getName() == selectedTenant)
                    {
                        reportedTenant = alltenants[i];
                    }
                }

                Complaint newComplaint = new Complaint();
                bool error = false;

                if (this.rbLoud.Checked)
                {
                    newComplaint.addType(ComplaintTypeEnum.NOISE);
                }
                else if (this.rbDirty.Checked)
                {
                    newComplaint.addType(ComplaintTypeEnum.DIRTY);
                }
                else if (this.rbTrash.Checked)
                {
                    newComplaint.addType(ComplaintTypeEnum.TRASH);
                }
                else if (this.rbUnlocked.Checked)
                {
                    newComplaint.addType(ComplaintTypeEnum.UNLOCKED);
                } else if (this.rbOther.Checked)
                {
                    newComplaint.addType(ComplaintTypeEnum.OTHER);
                }
                else
                {
                    error = true;
                    MessageBox.Show("No complaint selected!");
                }

                if(tbCustom.Text.Trim() != "")
                {
                    newComplaint.addMessage(tbCustom.Text.Trim());
                }

                if(error == false)
                {
                    reportedTenant.addComplaints(newComplaint);

                    MessageBox.Show("Successfully filed a new complaint!");
                    this.Close();
                }
            } else
            {
                MessageBox.Show("Please select a tenant to report!");
            }
        }
    }
}
