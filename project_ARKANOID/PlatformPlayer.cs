using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_ARKANOID
{
    public class PlatformPlayer : Platform
    {
        public Timer speedupPlatformTimer;//таймер для ускорения платформы каждые 15 сек

        public PlatformPlayer(int x, int y, Control parent) : base(x, y)
        {
            PlatformImage.BackColor = Color.Blue;
            speed = 7;

            speedupPlatformTimer = new Timer { Interval = 15000 };
            speedupPlatformTimer.Tick += (sender, e) => SpeedupPlatform();

            parent.Controls.Add(PlatformImage);//заносим в форму
        }
        public void PlatformPlayerControl(object sender, KeyEventArgs e)//чтобы управлять платформой
        {
            if (e.KeyCode == Keys.S)
                ChangeDirection();
        }
        public virtual void SpeedupPlatform() => speed += 2;
        public void ResetSpeed() => speed = 3;
    }
}