using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_ARKANOID
{
    public class Ball
    {
        public PictureBox BallImage;

        private int speedX = 5;//скорость полета мяча
        private int speedY = 5;

        public bool IsGameOver;//флаг конца игры

        private Control parent;//для добавления мяча на форму

        public FormGame formGame;

        public Timer IncreaseSpeedTimer;//таймер для ускорения мяча каждые 5 сек
        public Timer MoveBallTimer;//таймер для постоянного движения мяча

        public Ball(Control parent, FormGame formGame)
        {
            this.parent = parent;
            this.formGame = formGame;

            BallImage = new PictureBox
            {
                Image = Image.FromFile("C:images/Blue_Ball (1).png"),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(300, 195) 
            };
            parent.Controls.Add(BallImage);//добавляем на форму мяч

            MoveBallTimer = new Timer { Interval = 10 };
            MoveBallTimer.Tick += (sender, e) => Move(formGame, formGame.platformPlayer, formGame.platformBot, formGame.score);

            IncreaseSpeedTimer = new Timer { Interval = 5000 };
            IncreaseSpeedTimer.Tick += IncreaseBallSpeed;
            IncreaseSpeedTimer.Start();
        }

        public void Move(FormGame form, PlatformPlayer playerPlatform,PlatformBot botPlatform, Score score)
        {
            //движение вверх и вниз
            BallImage.Left += speedX;
            BallImage.Top += speedY;

            //отскок от верхней и нижней границы
            if (BallImage.Top <= 0 || BallImage.Bottom >= parent.ClientSize.Height)
                speedY = -speedY;

            //отскок от платформ
            if (BallImage.Bounds.IntersectsWith(playerPlatform.PlatformImage.Bounds) || BallImage.Bounds.IntersectsWith(botPlatform.PlatformImage.Bounds))
                speedX = -speedX;

            //проверка гола
            if (BallImage.Left <= 0)//вышел за левую, то бот забил
            {
                  score.IncreaseBotScore();//увеличиваем счёт бота
                  RespawnBall(form, IsGameOver);//если ещё нет 3 очков, просто респаун мяча
            }
            else if (BallImage.Right >= parent.ClientSize.Width) //если вышел за правую, то игрок забил
            {
                  score.IncreasePlayerScore();//увеличиваем счёт игрока
                  RespawnBall(form, IsGameOver);//если ещё нет 3 очков, просто респаун мяча
            }
        }

        private void IncreaseBallSpeed(object sender, EventArgs e)//ускорение мяча каждые 5 сек
        {
            speedX += Math.Sign(speedX);
            speedY += Math.Sign(speedY);
        }

        public async void RespawnBall(FormGame form,bool IsGameOver)
        {
            this.IsGameOver = IsGameOver;

            MoveBallTimer.Stop();//
            IncreaseSpeedTimer.Stop();

            BallImage.Location = new Point(300, 195); 
            await Task.Delay(1000);//ждем 1 сек
            speedX = -speedX;//меняем направление
            speedX = 5; //сбрасываем скорость
            speedY = 5;
            if (!IsGameOver)//если конец игры, то мяч ждет старта, а если это просто гол , то ждет секунду и начинает движение
            {
                IncreaseSpeedTimer.Start();
                MoveBallTimer.Start();
            }
        }
    }
}
