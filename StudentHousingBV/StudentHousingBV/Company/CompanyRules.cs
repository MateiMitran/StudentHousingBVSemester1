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
    public partial class CompanyRules : Form
    {
        private List<String> rules;
        public CompanyRules()
        {
            InitializeComponent();
        }
        public List<String> getRules()
        {
            return rules;
        }
        public void updateListBox()
        {
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            rules = login.getRules();
            this.lbRules.Items.Clear();
            for (int i = 0; i < rules.Count; i++)
                this.lbRules.Items.Add(rules[i]);
        }
        private void CompanyRules_Load(object sender, EventArgs e)
        {
            updateListBox();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            CompanyAddRule rule = new CompanyAddRule();
            rule.Show();
        }

        private void btnViewRule_Click(object sender, EventArgs e)
        {
            if (this.lbRules.SelectedIndex == -1)
                MessageBox.Show("Please select a rule to update!");
            else
            {
                CompanyUpdateRule update = new CompanyUpdateRule(Convert.ToString(this.lbRules.SelectedItem), this.lbRules.SelectedIndex);
                update.Show();
            }
        }

        private void btnRemoveRule_Click(object sender, EventArgs e)
        {
            if (this.lbRules.SelectedIndex == -1)
                MessageBox.Show("Please select a rule to remove!");
            else
            {
                LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
                login.removeRule(Convert.ToString(this.lbRules.SelectedItem));
                updateListBox();
                MessageBox.Show("Rule successfuly removed!");
            }
        }
    }
}
