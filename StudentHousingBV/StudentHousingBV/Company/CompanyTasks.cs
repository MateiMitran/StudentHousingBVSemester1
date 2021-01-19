using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentHousingBV
{
    public partial class CompanyTasks : Form
    {
        private List<TenantClass> allTenants;
        private TenantClass currentTenant;

        public CompanyTasks()
        {
            InitializeComponent();
        }

        private void CompanyTasks_Load(object sender, EventArgs e)
        {
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            allTenants = login.getTenants();

            for (int i = 0; i < allTenants.Count(); i++)
            {
                this.comboBox1.Items.Add(allTenants[i].getName());
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == "" || this.comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select a tenant and a due time!");
            }
            else
            {
                string format = "dd/MM/yyyy";
                DateTime dueDate;

                if (DateTime.TryParseExact(textBox1.Text.Trim(), format, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out dueDate))
                {
                    if (DateTime.Compare(dueDate, DateTime.Today) >= 0)
                    {
                        for (int i = 0; i < allTenants.Count(); i++)
                        {
                            if (allTenants[i].getName() == Convert.ToString(this.comboBox1.SelectedItem))
                            {
                                currentTenant = allTenants[i];
                            }
                        }

                        bool selectedTask = false;
                        Task newTask = new Task(dueDate);

                        if (this.rbClean.Checked)
                        {
                            newTask.setTaskType(TaskTypeEnum.CLEAN);
                            selectedTask = true;
                        }
                        else if (this.rbDishes.Checked)
                        {
                            newTask.setTaskType(TaskTypeEnum.DISHES);
                            selectedTask = true;
                        }
                        else if (this.rbGroceries.Checked)
                        {
                            newTask.setTaskType(TaskTypeEnum.GROCERIES);
                            selectedTask = true;
                        }
                        else if (this.rbTrash.Checked)
                        {
                            newTask.setTaskType(TaskTypeEnum.TRASH);
                            selectedTask = true;
                        }
                        else
                        {
                            MessageBox.Show("Please select a task to assign to tenant");
                        }

                        if (selectedTask == true)
                        {
                            // Write to tasks.txt new task

                            String path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../tasks.txt");

                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                            {
                                String taskString = currentTenant.getName() + " -%- " + newTask.getTaskType() + " -%- " + newTask.getDueDate() + " -%- " + newTask.getStatus() + " -%- " + newTask.getId();
                                file.WriteLine(taskString);
                                file.Close();
                            }

                            comboBox1.Text = "";
                            textBox1.Text = "DD/MM/YYYY";

                            rbTrash.Checked = false;
                            rbDishes.Checked = false;
                            rbGroceries.Checked = false;
                            rbClean.Checked = false;

                            MessageBox.Show("Task assigned successfuly!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Deadline cannot be a past date");
                    }
                } else
                {
                    MessageBox.Show("Invalid date, please try again.");
                }
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "DD/MM/YYYY")
            {
                textBox1.Text = "";
            }
        }
    }
}