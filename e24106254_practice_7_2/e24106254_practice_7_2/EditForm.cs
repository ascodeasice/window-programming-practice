using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e24106254_practice_7_2
{
    public partial class EditForm : Form
    {
        public string taskName = "";
        private string use = "";
        Form1 mainForm;

        public EditForm(Form1 _mainForm,string _use="addTask")
        {
            InitializeComponent();
            mainForm = _mainForm;
            use = _use;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            this.Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (taskNameInput.Text == "")
            {
                MessageBox.Show("請輸入事項", "");
            }

            else
            {
                switch (use)
                {
                    case "addTask":
                        mainForm.newTaskName = taskNameInput.Text;
                        mainForm.shouldAddNewTask = true;
                        mainForm.Enabled = true;
                        break;
                    case "finishTask":
                        mainForm.finishTaskName = taskNameInput.Text;
                        mainForm.shouldFinishTask = true;
                        mainForm.Enabled = true;
                        break;
                    case "deleteTask":
                        mainForm.shouldDeleteTask = true;
                        mainForm.deleteTaskName = taskNameInput.Text;
                        mainForm.Enabled = true;
                        break;
                    case "searchTask":
                        mainForm.searchTaskString = taskNameInput.Text;
                        mainForm.shouldSearch= true;
                        mainForm.Enabled = true;
                        break;
                    default:
                        Console.WriteLine("Undefined EditForm type");
                        break;
                }
                this.Close();
            }
        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
