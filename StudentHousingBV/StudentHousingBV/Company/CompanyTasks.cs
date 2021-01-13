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
    public partial class CompanyTasks : Form
    {
        private List<TenantClass> allTenants;
        private TenantClass currentTenant;
        public CompanyTasks()
        {
            InitializeComponent();
        }

        private void CompanyTasks_Load(object sender, EventArgs e)
        {
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            allTenants = login.getTenants();
            for (int i = 0; i < allTenants.Count(); i++)
            {
                this.comboBox1.Items.Add(allTenants[i].getName());
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (this.textBox1.TextLength == 0 || this.comboBox1.SelectedIndex == -1)
                MessageBox.Show("Select a tenant and a due time!");
            else
            {
                for (int i = 0; i < allTenants.Count(); i++)
                    if (allTenants[i].getName() == Convert.ToString(this.comboBox1.SelectedItem))
                        currentTenant = allTenants[i];
                if (this.rbClean.Checked)
                    currentTenant.addTasks("Clean,   Due:" + this.textBox1.Text + " Status: UNFINISHED");
                else if (this.rbDishes.Checked)
                    currentTenant.addTasks("Dishes,   Due:" + this.textBox1.Text + " Status: UNFINISHED");
                else if (this.rbGroceries.Checked)
                    currentTenant.addTasks("Groceries,   Due:" + this.textBox1.Text + " Status: UNFINISHED");
                else if (this.rbTrash.Checked)
                    currentTenant.addTasks("Trash,   Due:" + this.textBox1.Text + " Status: UNFINISHED");
                MessageBox.Show("Assigned successfuly!");
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
