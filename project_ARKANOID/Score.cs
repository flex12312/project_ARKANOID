using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_ARKANOID
{
    public class Score
    {
        public int PlayerScore { get; private set; } = 0;//счет игрока
        public int BotScore { get; private set; } = 0;//счет бота

        private Label playerLabel;//лейблы для счета 
        private Label botLabel;

        private FormGame formGame;

        public Score(Label playerLabel, Label botLabel,FormGame formGame)
        {
            this.playerLabel = playerLabel;
            this.botLabel = botLabel;
            this.formGame = formGame;
            UpdateScore();
        }
        private void UpdateScore()
        {
            botLabel.Text = BotScore.ToString();
            playerLabel.Text = PlayerScore.ToString();
            if (PlayerScore >= 3) formGame.GameOver("Поздравляем! Вы победили!");
            else if (BotScore >= 3) formGame.GameOver("Вы проиграли! Бот выиграл.");
        }
        public void Reset()
        {
            PlayerScore = 0;
            BotScore = 0;
            UpdateScore();
        }
        public void IncreasePlayerScore()
        {
            PlayerScore++;
            UpdateScore();
        }
        public void IncreaseBotScore()
        {
            BotScore++;
            UpdateScore();
        }
    }
}