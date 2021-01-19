using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV
{
    public partial class TenantTasks : Form
    {
        TenantClass currentTenant;
        List<Task> tasks;

        public TenantTasks()
        {
            InitializeComponent();
        }

        public void UpdateListBox()
        {
            this.lbTasks.Items.Clear();

            for (int i = 0; i < tasks.Count; i++)
            {
                String task;

                if (tasks[i].getTaskType() == TaskTypeEnum.GROCERIES)
                {
                    task = tasks[i].getTaskType() + "\t" + tasks[i].getDueDate().ToString("dd/MM/yyyy") + "\t\t" + tasks[i].getStatusWords();
                }
                else
                {
                    task = tasks[i].getTaskType() + "\t\t" + tasks[i].getDueDate().ToString("dd/MM/yyyy") + "\t\t" + tasks[i].getStatusWords();
                }

                this.lbTasks.Items.Add(task);
            }
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
            int index = lbTasks.SelectedIndex;

            if (index >= 0)
            {
                // Read tasks.txt and make changes
                String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../tasks.txt");
                String newPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../new-tasks.txt");

                System.IO.StreamReader fileRead = new System.IO.StreamReader(path);

                String line;
                String text = "";

                while ((line = fileRead.ReadLine()) != null)
                {
                    String[] elements = line.Split(new string[] { " -%- " }, StringSplitOptions.None);
                    String username = elements[0];

                    TaskTypeEnum taskType;
                    Enum.TryParse(elements[1], out taskType);

                    DateTime dueDate = DateTime.Parse(elements[2]);
                    bool taskStatus = Convert.ToBoolean(elements[3]);
                    int id = Convert.ToInt32(elements[4]);

                    Console.WriteLine(currentTenant.getName());
                    Console.WriteLine(username);
                    Console.WriteLine(tasks[index].getId());
                    Console.WriteLine(id);

                    if (currentTenant.getName() == username)
                    {
                        if (tasks[index].getId() == id)
                        {
                            tasks[index].setStatus(true);

                            String info = username + " -%- " + taskType + " -%- " + dueDate + " -%- " + tasks[index].getStatus() + " -%- " + id;
                            text += info + Environment.NewLine;
                        }
                        else
                        {
                            text += line + Environment.NewLine;
                        }
                    }
                    else
                    {
                        text += line + Environment.NewLine;
                    }
                }

                fileRead.Close();

                // Write old file into new file, delete old file and rename new file
                File.WriteAllText(newPath, text);
                File.Delete(path);
                File.Move(newPath, path);

                UpdateListBox();
            }
        }
    }
}
