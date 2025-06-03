using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static project_ARKANOID.PlatformBot;

namespace project_ARKANOID
{
    public partial class FormGame : Form
    {
        public Ball ball;

        public Score score;

        public PlatformBot platformBot;
        public PlatformPlayer platformPlayer;

        public FormGame()
        {
            InitializeComponent();

            ball = new Ball(this,this);
            score = new Score(LabelPlayerScore, LabelBotScore,this);

            platformBot = new PlatformBot(600,100,ball,this);
            platformPlayer = new PlatformPlayer(50,100,this);

            this.KeyDown += platformPlayer.PlatformPlayerControl;
            this.KeyPreview = true;
        }
        public void RestartGame(FormGame form, bool IsGameOver)
        {
            score.Reset();
            ball.RespawnBall(form,IsGameOver);
        }
        public void GameOver(string message, FormGame form)
        {
            platformPlayer.movePlatformTimer.Stop();
            platformBot.FollowingBallTimer.Stop();
            ball.IncreaseSpeedTimer.Stop();
            ball.MoveBallTimer.Stop();

            DialogResult result = MessageBox.Show($"{message}\nХотите сыграть снова?", "Игра окончена", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RestartGame(form, true);
                buttonStart.Enabled = true;
            }
            else Application.Exit();//выход
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();
            platformBot.difficulty = (Difficulty)formSettings.DifficultyBox.SelectedIndex;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            ball.MoveBallTimer.Start();//запуск всех таймеров
            ball.IncreaseSpeedTimer.Start();
            platformBot.FollowingBallTimer.Start();
            platformPlayer.movePlatformTimer.Start();

            ball.RespawnBall(this, false);//сброс флага конца игры
            buttonStart.Enabled = false;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void buttonStasik_Click(object sender, EventArgs e)
        {
            //пасхалка
            ball.BallImage.Image = Image.FromFile("C:\\Users\\Flex\\Desktop\\project_ARKANOID\\project_ARKANOID\\images\\stasik.png");
        }
    }
}
