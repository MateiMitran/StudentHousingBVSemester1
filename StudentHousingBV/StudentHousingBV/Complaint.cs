using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Complaint
    {
        private ComplaintTypeEnum type;
        private String message;
        private DateTime dateCreated;

        public Complaint(ComplaintTypeEnum type, String message)
        {
            this.type = type;
            this.message = message;
            this.dateCreated = DateTime.Now;
        }

        public Complaint()
        {
            this.dateCreated = DateTime.Now;
        }

        public void addType(ComplaintTypeEnum type)
        {
            this.type = type;
        }

        public void addMessage(String message)
        {
            this.message = message;
        }

        public ComplaintTypeEnum getType()
        {
            return type;
        }

        public String getMessage()
        {
            return message;
        }

        public DateTime getDateCreated()
        {
            return dateCreated;
        }
    }
}
