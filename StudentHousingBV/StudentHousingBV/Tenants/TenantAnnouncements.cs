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
    public partial class TenantAnnouncements : Form
    {
        private List<int> votes;
        private List<String> announcements;
        private List<TenantClass> allTenants;
        TenantClass currentTenant;
        static int v = 0;
        public TenantAnnouncements()
        {
            InitializeComponent();
            votes = new List<int>();
            this.votebtn.BackColor = Color.Gainsboro;
        }

        private void TenantAnnouncements_Load(object sender, EventArgs e)
        {

            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            announcements = login.getAnnouncements();

            for (int i = 0; i < announcements.Count; i++) {
                this.lbAnnouncements.Items.Add(announcements[i]);
            }

            allTenants = login.getTenants();
            this.lblNrOfTenants.Text = Convert.ToString(allTenants.Count);
            TenantHome home = (TenantHome)Application.OpenForms["TenantHome"];
            currentTenant = home.getTenant();
            this.voteslbl.Text = Convert.ToString(v);
            if (currentTenant.choose == true)
            {
               this.voteslbl.Text = Convert.ToString(v);
               this.votebtn.Enabled = false;
               this.votebtn.BackColor = Color.Gray;
               this.votebtn.ForeColor = Color.DimGray;
               this.opinionlbl.Text = "You presented your view on the matter!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.currentTenant.choose = true;
            v += this.currentTenant.voteContributed;
            this.voteslbl.Text = Convert.ToString(v);
            this.votebtn.Enabled = false;
            this.votebtn.BackColor = Color.Gray;
            this.votebtn.ForeColor = Color.DimGray;
            this.opinionlbl.Text = "You presented your view on the matter!";

            if (v == allTenants.Count)
            {
                this.eventTakesPlacelbl.Text = "According to your votes the event will take place";
            }
        }
    }
}
