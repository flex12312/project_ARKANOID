using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_ARKANOID
{
    public class Platform
    {
        public PictureBox PlatformImage { get; }

        protected int speed = 10;//дефолт скорость платформы
        protected int direction = 1; //направление движения : 1 = вниз, -1 = вверх

        public Timer movePlatformTimer;//таймер для постоянного двжиения платформы
        
        public Platform(int x, int y)
        {
            PlatformImage = new PictureBox
            {
                Size = new Size(15, 100),
                Location = new Point(x, y)
            };
            movePlatformTimer = new Timer { Interval = 1 };
            movePlatformTimer.Tick += (sender, e) => Move();
        }
        public virtual void Move()
        {
            PlatformImage.Top += direction * speed;
            //достигла ли платформа верхней или нижней границы
            if (PlatformImage.Parent != null && PlatformImage.Top <= 55 || PlatformImage.Bottom + 15 >= PlatformImage.Parent.ClientSize.Height)//
                ChangeDirection();//меняем направление при столкновении с краем
        }
        protected void ChangeDirection() => direction *= -1;
    }
}