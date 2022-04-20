using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class TaskList
    {
        private string name { get; set; }
        private List<Task> tasks { get; set; }
        /// <summary>
        /// Объявляется список имён.
        /// </summary>
        /// <param name="name"></param>
        public TaskList(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// добавляет задачу в список задач
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        /// <summary>
        /// возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }
        /// <summary>
        /// удаляет задачу из списка задач
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
            }
        }
        /// <summary>
        /// возвращает задачи запланированные на сегодня в хронологическом порядке.
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTaskByToday()
        {
            var today = DateTime.Now.ToString();
            var tasksByToday = tasks.Where(t => t.Due.ToString() == today).ToList();
            return tasksByToday;
        }
        /// <summary>
        /// возвращает задачи на завтра и позже в хронологическом порядке.
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTaskByFuture()
        {
            var future = DateTime.Now;
            var tasksByFuture = tasks.Where(t => t.Due > future).ToList();
            return tasksByFuture;
        }
    }
}
