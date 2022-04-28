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

namespace QuizAppClient
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            labelUserName.Text = StockInstance.userService.currentLoginUser.userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.ShowDialog();

        }
    }
}
