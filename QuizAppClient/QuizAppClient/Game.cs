using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace QuizAppClient
{
    public partial class Game : Form
    {
        int currentSeconds = 300;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(UpdateTimer);
            timer.Start();
        }

        public void UpdateTimer(object sender, EventArgs e)
        {
            this.BeginInvoke((Action)(() => {
                currentSeconds--;
                int minutes = currentSeconds / 60;
                int seconds = currentSeconds % 60;
                labelTimer.Text = $"{minutes} : {seconds}";                
            }));
        }

    }
}
