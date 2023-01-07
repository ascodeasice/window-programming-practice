using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e24106254_practice_7_1
{
    public partial class AddTaskForm : Form
    {
        public string taskName="";
        Form1 mainForm;

        public AddTaskForm(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
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
                mainForm.newTaskName = taskNameInput.Text;
                mainForm.shouldAddNewTask = true;
                mainForm.Enabled = true;
                this.Close();
            }
        }

        private void AddTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
