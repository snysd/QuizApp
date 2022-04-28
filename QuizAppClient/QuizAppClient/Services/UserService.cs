using QuizAppClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppClient.Services
{
    public class UserService
    {
        public User currentLoginUser;
        public bool CheckAccountExistName(string userName)
        {
            // TODO バックエンド問い合わせ
            // ユーザーが存在していればfalse、なければtrue
            return true;
        }

        public bool CreateAccount(User user)
        {
            // TODO: バックエンドに対してuser追加
            currentLoginUser = user;
            // 通信に失敗した場合の処理
            return true;
        }

        public bool CheckAccountExist(string userName,string userPassword)
        {
            // TODO: バックエンド問い合わせ
            // ユーザー名で問い合わせるとユーザオブジェクトが帰ってくるのでパスワードを照合する。

            currentLoginUser = new User();
            currentLoginUser.userName = userName;
            currentLoginUser.password = userPassword;
            return true;
        }



    }
}
