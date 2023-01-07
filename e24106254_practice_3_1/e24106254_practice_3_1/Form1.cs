using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e24106254_practice_3_1
{
    public partial class Form1 : Form
    {
        List<Account> list = new List<Account>();


        public Form1()
        {
            InitializeComponent();
        }

        private void appendAccountText(Account account)
        {
            if (resultText.Text != "")
            {
                resultText.Text += "==================================" + Environment.NewLine;
            }
            resultText.Text += $"連結:{account.link}" + Environment.NewLine;
            resultText.Text += $"使用者:{account.user}" + Environment.NewLine;
            resultText.Text += $"密碼:{account.pass}" + Environment.NewLine;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            resultText.Text = "";

            string searchText = searchInput.Text;
            if (searchText == "")
            {
                foreach (Account account in list)
                {
                    appendAccountText(account);
                }
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].link.Contains(searchText))
                {
                    appendAccountText(list[i]);
                }
            }

        }

        private void showDangerousBtn_Click(object sender, EventArgs e)
        {
            resultText.Text = "";

            list.Sort((x, y) => x.pass.CompareTo(y.pass));

            for (int i = 0; i < list.Count; i++)
            {
                // is the same with previous one or next one
                if (i < list.Count - 1 && list[i].pass == list[i + 1].pass)
                {
                    appendAccountText(list[i]);
                }
                else if (i >= 1 && list[i].pass == list[i - 1].pass)
                {
                    appendAccountText(list[i]);
                }
            }
        }

        private void addOrDeleteBtn_Click(object sender, EventArgs e)
        {
            searchLabel.Visible = false;
            showDangerousBtn.Enabled = false;
            searchBtn.Enabled = false;
            addOrDeleteBtn.Visible = false;
            resultText.Visible = false;
            resultLabel.Visible = false;

            searchInput.Enabled = false;

            backBtn.Visible = true;
            linkInput.Visible = true;
            passwordInput.Visible = true;
            userInput.Visible = true;
            linkLabel.Visible = true;
            userLabel.Visible = true;
            passwordLabel.Visible = true;
            stateLabel.Visible = true;
            addBtn.Visible = true;
            deleteBtn.Visible = true;

            searchInput.Text = "";
            resultText.Text = "";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            searchLabel.Visible = true;
            showDangerousBtn.Enabled = true;
            searchBtn.Enabled = true;
            addOrDeleteBtn.Visible = true;
            resultText.Visible = true;
            resultLabel.Visible = true;

            searchInput.Enabled = true;

            backBtn.Visible = false;
            linkInput.Visible = false;
            passwordInput.Visible = false;
            userInput.Visible = false;
            linkLabel.Visible = false;
            userLabel.Visible = false;
            passwordLabel.Visible = false;
            stateLabel.Visible = false;
            addBtn.Visible = false;
            deleteBtn.Visible = false;

            stateLabel.Text = "我是狀態列";
            linkInput.Text = "";
            passwordInput.Text = "";
            userInput.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (linkInput.Text == "" || passwordInput.Text == "" || userInput.Text == "")
            {
                stateLabel.Text = "輸入不可為空";
                return;
            }

            for (int i = 0; i < list.Count; i++)
            {
                // account already exist
                if (list[i].link == linkInput.Text && list[i].user == userInput.Text)
                {
                    stateLabel.Text = "帳號已存在";
                    return;
                }
            }

            // success
            list.Add(new Account(linkInput.Text, userInput.Text, passwordInput.Text));
            stateLabel.Text = "新增完成";
            // clear input
            linkInput.Text = "";
            passwordInput.Text = "";
            userInput.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (linkInput.Text == "" || passwordInput.Text == "" || userInput.Text == "")
            {
                stateLabel.Text = "輸入不可為空";
                return;
            }

            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].link == linkInput.Text && list[i].user == userInput.Text 
                    && list[i].pass == passwordInput.Text)
                {
                    list.RemoveAt(i);
                    stateLabel.Text = "刪除完成";
                    linkInput.Text = "";
                    passwordInput.Text = "";
                    userInput.Text = "";
                    return;
                }
            }

            // not exist
            stateLabel.Text = "帳號不存在或密碼錯誤";
        }
    }

    class Account
    {
        public string link, user, pass;
        public Account(string _link, string _user, string _pass)
        {
            link = _link;
            user = _user;
            pass = _pass;
        }
    }

}
