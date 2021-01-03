using StudentHousingBV.Company;
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
        public CompanyRules()
        {
            InitializeComponent();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            CompanyRulesAddNew newCompaint = new CompanyRulesAddNew();
            newCompaint.Show();
        }
    }
}
