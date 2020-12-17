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
    public partial class CompanyAccount : Form
    {
        public CompanyAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInScreen login = new LogInScreen();
            CompanyHome home = (CompanyHome)Application.OpenForms["CompanyHome"];
            this.Hide();
            home.Hide();
            login.Show();
        }
    }
}
