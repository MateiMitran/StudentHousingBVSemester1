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
    public partial class CompanyAddAnnouncements : Form
    {
        public CompanyAddAnnouncements()
        {
            InitializeComponent();
        }

        private void CompanyAddAnnouncements_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.tbAdd.TextLength > 0)
            {
                LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
                login.updateAnnouncements(this.tbAdd.Text);
                MessageBox.Show("Announcement added!");
                CompanyAnnouncements announcements = (CompanyAnnouncements)Application.OpenForms["CompanyAnnouncements"];
                announcements.updateListBox();
            }
            else
                MessageBox.Show("Please fill in an announcement to add!");
            
        }
    }
}
