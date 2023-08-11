using snake.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{

    public partial class Menu : Form
    {
        public int Uid = 0;
        public int UserId { get; set; }
        public int HighScore { get; set; }
        public Menu()
        {
            InitializeComponent();
            this.Load += Menu_Load;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Normal f = new Normal();
            f.UserId = UserId;
            f.ShowDialog();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Medium m = new Medium();
            m.UserId = UserId;
            m.ShowDialog();
        }
        Project_PRN211Context context = new Project_PRN211Context();
        private void Menu_Load(object sender, EventArgs e)
        {
            Project_PRN211Context context = new Project_PRN211Context();
            var game1Score = context.UserGames
                                   .Where(x => x.UserId == UserId && x.GameId == 1)
                                   .Select(x => x.Score)
                                   .Single();

            var game2Score = context.UserGames
                                   .Where(x => x.UserId == UserId && x.GameId == 2)
                                   .Select(x => x.Score)
                                   .Single();
            var game3Score = context.UserGames
                                   .Where(x => x.UserId == UserId && x.GameId == 3)
                                   .Select(x => x.Score)
                                   .Single();
            var game1HighScore = context.UserGames
                                   .Where(x => x.GameId == 1)
                                   .Max(x => x.Score);
            var game2HighScore = context.UserGames
                                   .Where(x => x.GameId == 2)
                                   .Max(x => x.Score);
            var game3HighScore = context.UserGames
                                   .Where(x => x.GameId == 3)
                                   .Max(x => x.Score);
            txtShi.Text = context.UserItems.Where(x => x.UserId == 2 && x.ItemId == 1).Select(x => x.Quatity).FirstOrDefault().ToString();
            txtSp.Text = context.UserItems.Where(x => x.UserId == 2 && x.ItemId == 2).Select(x => x.Quatity).FirstOrDefault().ToString();
            txtLive.Text = context.UserItems.Where(x => x.UserId == 2 && x.ItemId == 3).Select(x => x.Quatity).FirstOrDefault().ToString();

            if (game1Score != null && game2Score != null)
            {
                label2.Text = label2.Text + "  " + game1Score.ToString();
                label3.Text = label3.Text + "  " + game2Score.ToString();
                lbScoreSpecial.Text = lbScoreSpecial.Text + "  " + game3Score.ToString();
                lbGame1HighScore.Text = lbGame1HighScore.Text + "  " + game1HighScore.ToString();
                lbGame2HighScore.Text = lbGame2HighScore.Text + "  " + game2HighScore.ToString();
                lbGame3HighScore.Text = lbGame3HighScore.Text + "  " + game3HighScore.ToString();
            }


        }

        public void ReloadForm()
        {
            txtShi.Text = context.UserItems.Where(x => x.UserId == 2 && x.ItemId == 1).Select(x => x.Quatity).FirstOrDefault().ToString();
            txtSp.Text = context.UserItems.Where(x => x.UserId == 2 && x.ItemId == 2).Select(x => x.Quatity).FirstOrDefault().ToString();
            txtLive.Text = context.UserItems.Where(x => x.UserId == 2 && x.ItemId == 3).Select(x => x.Quatity).FirstOrDefault().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Special s = new Special();
            s.UserId = UserId;
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shop sh = new Shop();
            sh.ShowDialog();
        }
    }
}
