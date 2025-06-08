using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_ARKANOID
{
    public class PlatformBot : Platform
    {
        public Timer FollowingBallTimer;//таймер для движения платформы за мячем
        public enum Difficulty { Easy, Medium, Hard }//перечисление сложностей
        public Difficulty difficulty = Difficulty.Medium;//по дефолту средняя сложность

        public PlatformBot(int x, int y,Ball ball,Control parent) : base(x, y)
        {
            PlatformImage.BackColor = Color.Red;
            parent.Controls.Add(PlatformImage);

            FollowingBallTimer = new Timer() { Interval = 10 };
            FollowingBallTimer.Tick += (sender, e) => MoveToBall(ball);
        }
        public void MoveToBall(Ball ball)
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    int move = new Random().Next(-20, 20);//ошибки в движении
                    PlatformImage.Top += (ball.BallImage.Top - PlatformImage.Top) + move;
                    break;
                case Difficulty.Medium:
                    PlatformImage.Top += (ball.BallImage.Top - PlatformImage.Top) / 5;//небольшая задержка в реакции
                    break;
                case Difficulty.Hard:
                    PlatformImage.Top = ball.BallImage.Top - 20;//полное следование за мячом
                    break;
            }
        }
    }
}
