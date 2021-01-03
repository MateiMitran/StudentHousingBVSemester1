using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace StudentHousingBV.Company
{
    public partial class CompanyRulesAddNew : Form
    {
        public CompanyRulesAddNew()
        {
            InitializeComponent();
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            // Get text from TextBox and split it line by line
            String ruleText = tbCompanyRulesAddNew.Text;
            String[] lines = ruleText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Get rules.txt path and start a writing stream
            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../rules.txt");
                
            using (StreamWriter file = File.AppendText(path))
            {
                if (ruleText.Trim() != "") {
                    foreach (var line in lines)
                    {
                        file.WriteLine(line);
                    }

                    file.WriteLine("<!-- END OF RULE -->");

                    MessageBox.Show("Successfully added a new rule!");
                    tbCompanyRulesAddNew.Text = "";

                    this.Hide();
                } else
                {
                    MessageBox.Show("Rule content cannot be empty");
                    tbCompanyRulesAddNew.Text = "";
                }
            }
        }
    }
}
