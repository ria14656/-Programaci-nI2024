namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
namespace EXAM2
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    namespace AgendaApp
    {
        using System;
        using System.Collections.Generic;
        using System.Windows.Forms;

        namespace AgendaApp
        {
            public partial class MainForm : Form
            {
                private List<Task> agenda;

                public object taskDescriptionTextBox { get; private set; }

                public MainForm()
                {
                    InitializeComponent();
                    agenda = new List<Task>();
                }

                private void InitializeComponent()
                {
                    throw new NotImplementedException();
                }

                private void addButton_Click(object sender, EventArgs e)
                {
                    string taskName = taskNameTextBox.Text;
                    string taskDescription = taskDescriptionTextBox.
    
                if (!string.IsNullOrEmpty(taskName) && !string.IsNullOrEmpty(taskDescription))
                    {
                        Task newTask = new Task(taskName, taskDescription);
                        agenda.Add(newTask);
                        UpdateListBox();
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Please enter both task name and description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                private void removeButton_Click(object sender, EventArgs e)
                {
                    if (agendaListBox.SelectedItem != null)
                    {
                        Task selectedTask = (Task)agendaListBox.SelectedItem;
                        agenda.Remove(selectedTask);
                        UpdateListBox();
                    }
                    else
                    {
                        MessageBox.Show("Please select a task to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                private void UpdateListBox()
                {
                    agendaListBox.Items.Clear();
                    foreach (Task task in agenda)
                    {
                        agendaListBox.Items.Add(task);
                    }
                }

                private void ClearTextBoxes()
                {
                    taskNameTextBox.Clear();
                    taskDescriptionTextBox.Clear();
                }
            }

            internal class taskNameTextBox
            {
                public static string Text { get; internal set; }
            }

            public class Task
            {
                public string Name { get; set; }
                public string Description { get; set; }

                public Task(string name, string description)
                {
                    Name = name;
                    Description = description;
                }

                public override string ToString()
                {
                    return Name;
                }
            }
        }
    }




