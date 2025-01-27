﻿using QuizAppClient.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizAppClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string IniPath = @"..\..\Settings\Ini.ini";
            IniFileService iniFileService = new IniFileService(IniPath);
            if(iniFileService.iniData == null)
            {
                MessageBox.Show("IniFileを読み込めませんでした");
                buttonLogin.Enabled = false;
                labelCreateAccount.Enabled = false;
            }
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            var createAccount = new CreateAccount();
            //createAccount.FormClosed += createAccountFormClosed;
            createAccount.VisibleChanged += (closedSender, closedE) =>
            {
                if (!createAccount.Visible)
                {
                    Home home = new Home();
                    home.ShowDialog();
                }
            };
            this.Hide();
            createAccount.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "") MessageBox.Show("名前を入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (textBoxPassword.Text == "") MessageBox.Show("パスワードを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (StockInstance.userService.CheckAccountExist(textBoxUserName.Text, textBoxPassword.Text))
            {
                Home home = new Home();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("入力情報が誤っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
