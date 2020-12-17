using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
   public class Tenant
    {
        private String name;
        private int reports;
        private List<String> complaints = new List<String>();
        private List<String> tasks = new List<String>();
        private bool studentOfTheMonth = false;
        public Tenant(String name1)
        {
            name = name1;
        }
        public String getName()
        {
            return name;
        }
        public void addComplaints(String complaint)
        {
            complaints.Add(complaint);
            reports++;
        }
        public void removeComplaints(String complaint)
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
        public List<String> getComplaints()
        {
            return complaints;
        }
        public bool isStudentOfTheMonth()
        {
            return studentOfTheMonth;
        }
    }
}
