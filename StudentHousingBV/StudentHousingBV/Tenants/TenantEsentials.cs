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
    public partial class TenantEsentials : Form
    {
        
        List<TenantClass> allTenants;
        TenantClass currentTenant;
        int s;
        int nrOfTenants;
        int goal;

        public TenantEsentials()
        {
            InitializeComponent();
            this.addbtn.BackColor = Color.Gainsboro;
        }

        private void TenantEsentials_Load(object sender, EventArgs e)
        {
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            allTenants = login.getTenants();
            nrOfTenants = allTenants.Count();

            this.goallbl.Text = Convert.ToString(nrOfTenants * 2);
            String currentTenantName = login.getTenantName();

            this.HouseBanklbl.Text = Convert.ToString(s);
            goal = nrOfTenants * 2;

            for (int i = 0; i < allTenants.Count; i++)
            {
                nrOfTenants = allTenants.Count;
                goal = nrOfTenants * 2;

                if (allTenants[i].getName() == currentTenantName)
                {
                    currentTenant = allTenants[i];

                    if (currentTenant.voted == true)
                    {
                        this.HouseBanklbl.Text = Convert.ToString(s);
                        this.addbtn.Enabled = false;
                        this.addbtn.BackColor = Color.Gray;
                        this.addbtn.ForeColor = Color.DimGray;
                        this.contributionlbl.Text = "You added your contribution";

                        if (s == goal)
                        {
                            this.enoughGatheredlbl.Text = "The sum for this month has been gathered";
                        }
                    }
                }
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (currentTenant.Contribution() == true)
            {
                this.currentTenant.voted = true;

                s += this.currentTenant.moneyContributed;
                this.HouseBanklbl.Text = Convert.ToString(s);
                this.addbtn.Enabled = false;
                this.addbtn.BackColor = Color.Gray;
                this.addbtn.ForeColor = Color.DimGray;
                this.contributionlbl.Text = "You added your contribution";
            }
        }
    }
}
