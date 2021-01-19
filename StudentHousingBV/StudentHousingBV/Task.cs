using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Task
    {
        private TaskTypeEnum taskType;
        private DateTime dueDate;
        private bool finishedStatus; // False = unfinished, True = finished
        private int id;
        public static int nextId = 0;

        public Task(DateTime dueDate)
        {
            this.dueDate = dueDate;
            this.finishedStatus = false;
            this.id = nextId;

            nextId++;
        }

        public Task(TaskTypeEnum task, DateTime dueDate)
        {
            this.taskType = task;
            this.dueDate = dueDate;
            this.finishedStatus = false;
            this.id = nextId;

            nextId++;
        }

        public Task(TaskTypeEnum task, DateTime dueDate, bool finishedStatus)
        {
            this.taskType = task;
            this.dueDate = dueDate;
            this.finishedStatus = finishedStatus;
            this.id = nextId;

            nextId++;
        }

        public Task(TaskTypeEnum task, DateTime dueDate, bool finishedStatus, int id)
        {
            this.taskType = task;
            this.dueDate = dueDate;
            this.finishedStatus = finishedStatus;
            this.id = id;

            nextId = nextId + id;
        }

        public void setTaskType(TaskTypeEnum type)
        {
            this.taskType = type;
        }

        public TaskTypeEnum getTaskType()
        {
            return taskType;
        }

        public DateTime getDueDate()
        {
            return dueDate;
        }

        public void setStatus(bool status)
        {
            this.finishedStatus = status;
        }

        public bool getStatus()
        {
            return finishedStatus;
        }

        public String getStatusWords()
        {
            if(this.finishedStatus == false)
            {
                return "Unfinished";
            } else
            {
                return "Finished";
            }
        }

        public int getId()
        {
            return id;
        }
    }
}
