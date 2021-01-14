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
    public partial class TenantRules : Form
    {
        private List<String> rules;
        public TenantRules()
        {
            InitializeComponent();
        }

        private void TenantRules_Load(object sender, EventArgs e)
        {
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            rules = login.getRules();

            for (int i = 0; i < rules.Count; i++)
            {
                this.lbRules.Items.Add(rules[i]);
            }
        }
    }
}
