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
        Tenant currentTenant;
        List<String> tasks;
        public TenantTasks()
        {
            InitializeComponent();
        }

        private void TenantTask_Load(object sender, EventArgs e)
        {
            TenantHome home = (TenantHome)Application.OpenForms["TenantHome"];
            currentTenant = home.getTenant();
            tasks = currentTenant.getTasks();
            for (int i = 0; i < tasks.Count; i++)
                this.lbTasks.Items.Add(tasks[i]);
        }
    }
}
