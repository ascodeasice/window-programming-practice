using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace e24106254_practice_7_2
{
    public partial class Form1 : Form
    {
        public string newTaskName = "";
        public bool shouldAddNewTask = false;
        public string finishTaskName = "";
        public bool shouldFinishTask = false;
        public string deleteTaskName = "";
        public bool shouldDeleteTask = false;
        public string searchTaskString = "";
        public bool shouldSearch = false;

        bool showFinishedTasks = true;
        List<string> taskTexts = new List<string>(); // already contains prefix

        string filePath = "";
        string extFilter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All File(*.*)|*.*";

        string finishedPrefix = "[√] ";
        string unfinishedPrefix = "[ ] ";
        public Form1()
        {
            InitializeComponent();
        }

        // SECTION helper function

        private string unserializeFileText(string fileText)
        {
            string[] lines = fileText.Split(
                new string[] { Environment.NewLine },
                StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                // NOTE should only replace start of a task name

                if (lines[i].StartsWith("+"))
                {
                    lines[i] = finishedPrefix + lines[i].Substring(1);
                }
                else if (lines[i].StartsWith("-"))
                {
                    lines[i] = unfinishedPrefix + lines[i].Substring(1);
                }
            }

            return string.Join(Environment.NewLine, lines);
        }

        private string serializeTaskName(string taskName)
        {
            // NOTE this function is only for a single task, not breaking line
            if (taskName.StartsWith(finishedPrefix))
            {
                return "+" + taskName.Substring(finishedPrefix.Length);
            }
            else if (taskName.StartsWith(unfinishedPrefix))
            {
                return "-" + taskName.Substring(unfinishedPrefix.Length);

            }
            else
            {
                // invalid
                return taskName;
            }
        }

        private bool taskIsFinished(string taskText)
        {
            return taskText.Contains(finishedPrefix);
        }

        private void showTasksOnTextbox()
        {
            // show or hide tasks by showFinishedTasks variable
            taskTextBox.Text = "";

            if (showFinishedTasks)
            {
                foreach (string text in taskTexts)
                {
                    if (text == "")
                    {
                        continue;
                    }
                    taskTextBox.Text += (text + Environment.NewLine);
                }
            }
            else
            {
                foreach (string text in taskTexts)
                {
                    if (taskIsFinished(text) || text == "")
                    {
                        continue;
                    }
                    taskTextBox.Text += (text + Environment.NewLine);
                }
            }
        }

        private void writeToFile(string path)
        {
            StreamWriter writer = new StreamWriter(path);
            foreach (string line in taskTexts)
            {
                if (line != "")
                {
                    writer.WriteLine(serializeTaskName(line));
                }
            }
            writer.Flush();
            writer.Close();
        }

        private void showSearchedTasks()
        {
            taskTextBox.Text = "";

            foreach(string text in taskTexts)
            {
                if ((!showFinishedTasks && taskIsFinished(text))
                    ||!text.Contains(searchTaskString))
                {
                    continue;
                }

                taskTextBox.Text += (text + Environment.NewLine);
            }
        }

        // SECTION windows form object event
        private void 離開ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filePath = "";
            taskTextBox.Text = "";
        }

        private void 字型大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                taskTextBox.Font = fontDialog.Font;
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            EditForm addTaskForm = new EditForm(this, "addTask");
            addTaskForm.Show();
            this.Enabled = false;
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            if (shouldAddNewTask)
            {
                taskTextBox.Text += (unfinishedPrefix + newTaskName + Environment.NewLine);
                shouldAddNewTask = false;
                taskTexts = new List<string>(taskTextBox.Lines);
            }
            else if (shouldFinishTask)
            {
                // need to copy and reassign to modify the value
                string[] linesCopy = taskTextBox.Lines;

                for (int i = 0; i < linesCopy.Length; i++)
                {
                    if (linesCopy[i].Length <= unfinishedPrefix.Length)
                    {
                        continue;
                    }

                    if (linesCopy[i].Substring(unfinishedPrefix.Length) == finishTaskName)
                    {
                        linesCopy[i] = finishedPrefix + finishTaskName;
                    }
                }
                taskTextBox.Lines = linesCopy;
                shouldFinishTask = false;
                taskTexts = new List<string>(taskTextBox.Lines);
            }
            else if (shouldSearch)
            {
                menuStrip.Enabled = false;
                editButtonPanel.Visible = false;
                endSearchButtonPanel.Visible = true;
                shouldSearch = false;

                showSearchedTasks();
            }
            else if (shouldDeleteTask)
            {
                // remove both tasks with and without [ ] 
                taskTexts.RemoveAll(text=>text==deleteTaskName
                ||(text.Length>4&&text.Substring(4)==deleteTaskName));
                shouldDeleteTask = false;

                showTasksOnTextbox();
            }
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = extFilter;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                StreamReader reader = new StreamReader(filePath);

                taskTextBox.Text = unserializeFileText(reader.ReadToEnd());
                taskTexts = new List<string>(taskTextBox.Lines);
                showTasksOnTextbox();

                reader.Close();
            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 新增檔案->另存新檔
            if (filePath == "")
            {
                另存新檔ToolStripMenuItem_Click(null, null);
            }
            // 開啟檔案->寫入原檔
            else
            {
                writeToFile(filePath);
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = extFilter;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filePath = sfd.FileName;
                writeToFile(filePath);
            }
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            EditForm finishForm = new EditForm(this, "finishTask");
            finishForm.Show();
            this.Enabled = false;
        }

        private void 隱藏完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFinishedTasks = false;
            showTasksOnTextbox();
        }

        private void 顯示完成事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFinishedTasks = true;
            showTasksOnTextbox();
        }

        private void 尋找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm searchForm = new EditForm(this, "searchTask");
            searchForm.Show();
            this.Enabled = false;
        }

        private void endSearchButton_Click(object sender, EventArgs e)
        {
            endSearchButtonPanel.Visible = false;
            editButtonPanel.Visible = true;
            menuStrip.Enabled = true;
            showTasksOnTextbox();
        }

        private void 刪除事項ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm deleteForm = new EditForm(this,"deleteTask");
            deleteForm.Show();
            this.Enabled = false;
        }
    }
}
