using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Application
    {
        public static Application application { get; set; }
        public List<TaskList> taskLists { get; set; }

        private Application()
        {
            taskLists = new List<TaskList>();
        }
        /// <summary>
        /// Создает список задач с указанным именем и добавляет его в taskLists.
        /// </summary>
        /// <param name="name"></param>
        public void CreateTaskList(string name)
        {
            taskLists.Add(new TaskList(name));
        }
        /// <summary>
        /// возвращает ссылку на экземпляр приложения, а в его отсутствие создает экземпляр.
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            if (application == null)
            {
                return new Application();
            }
            return application;
        }
        /// <summary>
        /// возвращает список задач по имени списка.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TaskList GetTaskByName(string name)
        {
            var taskList = taskLists.FirstOrDefault(t => t.GetName() == name);
            return taskList;
        }
        /// <summary>
        /// Создает список задач с указанным именем и добавляет его в taskLists.
        /// </summary>
        /// <param name="name"></param>
        //public void CreateTaskList(string name)
        //{
        //    taskLists.Add(new TaskList(name));
        //}
        public List<Task> GetTaskListNames()
        {
            var names = taskLists.Select(t => t.GetName().ToList());
            //return names;
        }
    }
}
