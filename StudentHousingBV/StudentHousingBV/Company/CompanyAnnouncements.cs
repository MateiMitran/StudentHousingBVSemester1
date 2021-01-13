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
    public partial class CompanyAnnouncements : Form
    {
        private List<String> announcements;
        public CompanyAnnouncements()
        {
            InitializeComponent();
            
        }
        public List<String> getAnnouncements()
        {
            return announcements;
        }
        public void updateListBox()
        {
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            announcements = login.getAnnouncements();
            this.lbAnnouncements.Items.Clear();
            for (int i = 0; i < announcements.Count; i++)
                this.lbAnnouncements.Items.Add(announcements[i]);
        }
        private void CompanyAnnouncements_Load(object sender, EventArgs e)
        {
           
            updateListBox();
            
        }
        private void btnAddAnnouncement_Click(object sender, EventArgs e)
        {
            CompanyAddAnnouncements newForm = new CompanyAddAnnouncements();
            newForm.Show();
            
            
        }

        private void btnRemoveAnnouncement_Click(object sender, EventArgs e)
        {
            if (this.lbAnnouncements.SelectedIndex == -1)
                MessageBox.Show("Please select an announcement to remove!");
            else
            {
                LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
                login.removeAnnouncement(Convert.ToString(this.lbAnnouncements.SelectedItem));
                updateListBox();
                MessageBox.Show("Announcement successfuly removed!");
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.lbAnnouncements.SelectedIndex == -1)
                MessageBox.Show("Please select an announcement to update!");
            else
            {
                CompanyUpdateAnnouncement update = new CompanyUpdateAnnouncement(Convert.ToString(this.lbAnnouncements.SelectedItem),this.lbAnnouncements.SelectedIndex);
                update.Show();
            }
           
        }
    }
}
