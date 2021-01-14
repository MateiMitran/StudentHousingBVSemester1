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
using System.Text.RegularExpressions;

namespace StudentHousingBV
{
    public partial class CompanyTenants : Form
    {
        private List<TenantClass> allTenants;
        LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
        public CompanyTenants()
        {
            
            InitializeComponent();
        }

        private void CompanyTenants_Load(object sender, EventArgs e)
        {
            
            allTenants = login.getTenants();
            for (int i = 0; i < allTenants.Count(); i++)
            {
                this.comboBox1.Items.Add(allTenants[i].getName());
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.textBox1.TextLength > 0)
            {
                TenantClass x = new TenantClass(this.textBox1.Text, "password");
                login.addTenant(x);

                String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../users.txt");

                List<String> lines = new List<String>();
                lines = File.ReadAllLines(path).ToList();

                lines.Add(Regex.Replace(this.textBox1.Text, @"\s+", "") + " password " + "user");
                File.WriteAllLines(path, lines);
                this.comboBox1.Items.Add(x.getName());

                MessageBox.Show("Tenant added successfuly!");
            } else
            {
                MessageBox.Show("Please enter a tenant name to add!");
            }
        }

        private void btnMakeSoTM_Click(object sender, EventArgs e)
        {
            for (int i= 0 ;i < allTenants.Count; i++)
            {
                if (allTenants[i].getName() == Convert.ToString(this.comboBox1.SelectedItem))
                {
                    allTenants[i].makeStudentOfTheMonth();
                    MessageBox.Show("Successfully updated tenant of the month!");
                } else
                {
                    allTenants[i].removeStudentOfTheMonth();
                }
            }
        }
    }
}
