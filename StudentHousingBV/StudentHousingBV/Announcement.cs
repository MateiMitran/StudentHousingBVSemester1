using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    class Announcement
    {
        private String announcement;

        public Announcement(String Announcement)
        {
            announcement = Announcement;
        }
        public String getAnnouncement()
        {
            return announcement;
        }
    }
}
