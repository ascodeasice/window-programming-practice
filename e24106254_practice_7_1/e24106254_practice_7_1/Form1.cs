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

namespace e24106254_practice_7_1
{
    public partial class Form1 : Form
    {
        public string newTaskName="";
        public bool shouldAddNewTask = false;

        string filePath="";
        string extFilter= "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All File(*.*)|*.*";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

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
            DialogResult result=fontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                taskTextBox.Font = fontDialog.Font;
            }
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(this);
            addTaskForm.Show();
            this.Enabled = false;
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            if (shouldAddNewTask)
            {
                taskTextBox.Text += (newTaskName + Environment.NewLine);
                shouldAddNewTask = false;
            }
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog=new OpenFileDialog();
            openFileDialog.Filter = extFilter;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                StreamReader reader = new StreamReader(filePath);

                taskTextBox.Text=reader.ReadToEnd();
                reader.Close();
            }
        }

        private void writeToFile(string path)
        {
            StreamWriter writer = new StreamWriter(path);
            foreach(string line in taskTextBox.Lines)
            {
                if (line != "")
                {
                    writer.WriteLine(line);
                }
            }
            writer.Flush();
            writer.Close();
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
    }
}
