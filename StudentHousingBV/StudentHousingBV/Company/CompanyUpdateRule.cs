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
    public partial class CompanyUpdateRule : Form
    {
        private List<String> rules;
        private int Index;
        public CompanyUpdateRule(String rule, int index)
        {
            InitializeComponent();
            this.tbUpdate.Text = rule;
            CompanyRules form = (CompanyRules)Application.OpenForms["CompanyRules"];
            rules = form.getRules();
            Index = index;
        }

        private void CompanyUpdateRule_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rules.Count; i++)
            {
                if (i == Index)
                    rules[i] = this.tbUpdate.Text;
            }
            CompanyRules form = (CompanyRules)Application.OpenForms["CompanyRules"];
            form.updateListBox();
            MessageBox.Show("Rule updated successfuly!");
        }
    }
}
