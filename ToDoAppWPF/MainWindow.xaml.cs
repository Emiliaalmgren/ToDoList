using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ToDoList _todoList;
        public MainWindow()
        {
            InitializeComponent();
            _todoList = new ToDoList();
        }

        //Lägger till det inskriva objektet till listan och sedan rensar rutan
        private void Button_Click_LäggTill(object sender, RoutedEventArgs e)
        {
            string task = TaskTextBox.Text;
            if (!string.IsNullOrEmpty(task))
            {
                _todoList.AddTask(task);
                UpdateTaskList();
                TaskTextBox.Clear();
            }
        }

        //Metod som uppdaterar listan
        private void UpdateTaskList()
        {
            TaskListBox.Items.Clear();
            foreach (var task in _todoList.GetAllTasks())
            {
                TaskListBox.Items.Add(task);
            }
        }

        //Selectar ett objekt i listan och tar bort den och slutligen uppdaterar listan
        private void Button_Click_TaBort(object sender, RoutedEventArgs e)
        {
            if (TaskListBox.SelectedIndex >= 0)
            {
                _todoList.RemoveTask(TaskListBox.SelectedIndex);
                UpdateTaskList();
            }
        }

        //Tar bort placeholdertext när man klickar i textbox rutan
        private void TaskTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TaskTextBox.Text == "Write a task here...")
            {
                TaskTextBox.Text = string.Empty;
            }
        }
    }
}