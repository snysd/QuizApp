using QuizAppClient.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuizAppClient
{
    public partial class CreateAccount : Form
    {
        UserService userService = new UserService();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "") MessageBox.Show("名前を入力してください。","エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (userService.CheckAccountExist(textBoxUserName.Text))
            {
                if (!Zenkaku_Check(textBoxPassword.Text))
                {
                    if (Regex.IsMatch(textBoxPassword.Text, @"[^a-zA-z]") && Regex.IsMatch(textBoxPassword.Text, @"[^0-9]"))
                    {
                        if (textBoxPassword.Text.Length >= 4 && textBoxPassword.Text.Length <= 8)
                        {

                        }
                        else
                        {
                            MessageBox.Show("パスワードは4文字以上8文字以内にしてください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("パスワードは英数混合にしてください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("パスワードは半角にしてください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else 
            {
                MessageBox.Show("既に使用されているユーザ名です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Zenkaku_Check(string s)
        {
            Encoding Enc = Encoding.GetEncoding("Shift-JIS");

            if (Enc.GetByteCount(s) == s.Length * 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
