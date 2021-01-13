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
    public partial class TenantTasks : Form
    {
        TenantClass currentTenant;
        List<String> tasks;
        public TenantTasks()
        {
            InitializeComponent();
        }
        public void UpdateListBox()
        {
            this.lbTasks.Items.Clear();
            for (int i = 0; i < tasks.Count; i++)
                this.lbTasks.Items.Add(tasks[i]);
        }

        private void TenantTask_Load(object sender, EventArgs e)
        {
            TenantHome home = (TenantHome)Application.OpenForms["TenantHome"];
            currentTenant = home.getTenant();
            tasks = currentTenant.getTasks();
            UpdateListBox();
           
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            for (int i=0;i<tasks.Count;i++)
            {
                if (tasks[i] == Convert.ToString(this.lbTasks.SelectedItem))
                    tasks[i] = tasks[i].Remove(tasks[i].Length - 10) + " DONE";
            }
            UpdateListBox();
        }
    }
}
