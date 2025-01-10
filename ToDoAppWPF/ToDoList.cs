using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppWPF
{
    //summary
    //Hanterar logiken för att lägga till, ta bort och 
    //</summery>
    public class ToDoList
    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }

        public List<string> GetAllTasks()
        {
            return tasks;
        }

    }
}