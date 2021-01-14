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
    public partial class CompanyUpdateAnnouncement : Form
    {
        private List<String> announcements;
        private int Index;
        public CompanyUpdateAnnouncement(String announcement,int index)
        {
            InitializeComponent();
            this.tbUpdate.Text = announcement;
            CompanyAnnouncements form = (CompanyAnnouncements)Application.OpenForms["CompanyAnnouncements"];
            announcements = form.getAnnouncements();
            Index = index;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < announcements.Count; i++)
            {
                if (i == Index)
                {
                    announcements[i] = this.tbUpdate.Text;
                }
            }

            CompanyAnnouncements form = (CompanyAnnouncements)Application.OpenForms["CompanyAnnouncements"];
            form.updateListBox();

            MessageBox.Show("Announcement updated successfuly!");
        }
    }
}
