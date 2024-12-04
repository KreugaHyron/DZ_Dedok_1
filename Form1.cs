using DZ_Dedok_1.Controller;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DZ_Dedok_1
{
    public partial class MainForm : Form
    {
        private TodoController _controller;

        public MainForm()
        {
            InitializeComponent();
            _controller = new TodoController();
        }

        private void UpdateTaskList()
        {
            listBox1.Items.Clear();
            foreach (var task in _controller.GetTasks())
            {
                listBox1.Items.Add(task.ToString());
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {

            string task = textBox1.Text;
            _controller.AddTask(task);
            textBox1.Clear();
            UpdateTaskList();
        }

        private void buttonCompleteTask_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                _controller.MarkTaskAsCompleted(listBox1.SelectedIndex);
                UpdateTaskList();
            }
        }

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                _controller.DeleteTask(listBox1.SelectedIndex);
                UpdateTaskList();
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
