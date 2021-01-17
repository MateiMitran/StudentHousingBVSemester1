using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
     public class TenantClass
    {
        public int moneyContributed = 2;
        public int voteContributed = 1;
        private String name;
        private String password;
        private int reports;
        private List<Complaint> complaints = new List<Complaint>();
        private List<String> tasks = new List<String>();
        private bool studentOfTheMonth = false;
        private int bank;
        public int balance = 10;
        public int option = 1;
        public bool voted = false;
        public bool choose = false;
        public TenantClass(String nameOfTenant, String tenantPassword)
        {
            name = nameOfTenant;
            password = tenantPassword;
        }
        public bool Contribution()
        {
            if (this.balance >= this.moneyContributed)
            {
                this.balance -= this.moneyContributed;
                this.voted = true;
                return true;
            }

            return false;
        }
        public bool Chose()
        {
            if (this.option == 1)
            {
                this.option -= 1;
                this.choose = true;
                return true;
            }
            return false;
        }

        public int Bank
        {
            get { return this.bank; }
            set { this.bank = value; }
        }

        public void addMoney(int value)
        {
            this.balance += value;
        }

        public String getName()
        {
            return name;
        }

        public String getPassword()
        {
            return password;
        }

        public void setPassword(String newPassword)
        {
            password = newPassword;
        }
        public void addComplaints(Complaint complaint)
        {
            complaints.Add(complaint);
            reports++;
        }
        public void removeComplaints(Complaint complaint)
        {
            complaints.Remove(complaint);
            reports--;
        }
        public void addTasks(String task)
        {
            tasks.Add(task);
        }
        public void removeTasks(String task)
        {
            tasks.Remove(task);
        }
        public void makeStudentOfTheMonth()
        {
            studentOfTheMonth = true;
        }
        public void removeStudentOfTheMonth()
        {
            studentOfTheMonth = false;
        }
        public int getReports()
        {
            return reports;
        }
        public List<String> getTasks()
        {
            return tasks;
        }
        public List<Complaint> getComplaints()
        {
            return complaints;
        }
        public bool isStudentOfTheMonth()
        {
            return studentOfTheMonth;
        }
    }
}
