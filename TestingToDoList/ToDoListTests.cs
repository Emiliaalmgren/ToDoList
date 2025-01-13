using ToDoAppWPF;

namespace TestingToDoList
{
    public class ToDoListTests
    {
        private ToDoList _todoList;
        public ToDoListTests()
        {
            _todoList = new ToDoList();
        }

        //Testar om "lägga till task" fungerar
        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            //Kontrollerar om task adderas till lista
            var task = "Test task";
            _todoList.AddTask(task);
            //Kontrollerar i listan om task finns med efter addering
            var tasks = _todoList.GetAllTasks();
            Assert.Contains(task, tasks);
        }

        //Testar om "ta bort task från listan" fungerar
        [Fact]
        public void RemoveTask_ShouldRemoveTaskFromList()
        {
            //Kontrollerar om task adderats till listan
            var task = "Test to remove";
            _todoList.AddTask(task);
            //Kontrollerar om task raderats från position 0 (hårdkodat)
            _todoList.RemoveTask(0);
            var tasks = _todoList.GetAllTasks();
            Assert.DoesNotContain(task, tasks);
        }

        //Testar om ett ogiltigt index inte leder till exeption
        [Fact]
        public void RemoveTask_InvalidIndex_ShoulNotThrowException()
        {
            var task = "Valid Task";
            _todoList.AddTask(task);
            //Försöker ta bort task på index 10 (vilket inte finns)
            _todoList.RemoveTask(10);
            var tasks = _todoList.GetAllTasks();
            Assert.Single(tasks);
        }

    }
}