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
    public partial class CompanyAddRule : Form
    {
        public CompanyAddRule()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.tbAdd.TextLength > 0)
            {
                LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
                login.updateRules(this.tbAdd.Text);
                MessageBox.Show("Rule added!");
                CompanyRules rules = (CompanyRules)Application.OpenForms["CompanyRules"];
                rules.updateListBox();
            }
            else
            {
                MessageBox.Show("Please fill in a rule to add!");
            }
        }
    }
}
