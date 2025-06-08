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

        private int speedX = 4;//скорость полета мяча
        private int speedY = 4;

        public bool IsGameOver;//флаг конца игры

        public FormGame formGame;

        public Timer IncreaseSpeedTimer;//таймер для ускорения мяча каждые 5 сек
        public Timer MoveBallTimer;//таймер для постоянного движения мяча

        public Ball(FormGame formGame)
        {
            this.formGame = formGame;

            BallImage = new PictureBox
            {
                Image = Image.FromFile("images/Blue_Ball.png"),
                Size = new Size(40, 40),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(300, 195),
                BackColor = Color.Transparent
            };
            formGame.Controls.Add(BallImage);//добавляем на форму мяч

            MoveBallTimer = new Timer { Interval = 1 };
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
            if (BallImage.Top <= 50)
                speedY = Math.Abs(speedY);
            if (BallImage.Bottom >= form.ClientSize.Height - 10)
                speedY = -Math.Abs(speedY);

            //отскок от платформ
            if (BallImage.Bounds.IntersectsWith(playerPlatform.PlatformImage.Bounds))
                speedX = Math.Abs(speedX);
            if (BallImage.Bounds.IntersectsWith(botPlatform.PlatformImage.Bounds))
                speedX = -Math.Abs(speedX);

            //проверка гола
            if (BallImage.Left <= 25)//вышел за левую, то бот забил
            {
                score.IncreaseBotScore();//увеличиваем счёт бота
                playerPlatform.ResetSpeed();
                RespawnBall(form, IsGameOver);//если ещё нет 3 очков, просто респаун мяча
            }
            else if (BallImage.Right >= form.ClientSize.Width - 25) //вышел за правую, то игрок забил
            {
                score.IncreasePlayerScore();//увеличиваем счёт игрока
                playerPlatform.ResetSpeed();
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
