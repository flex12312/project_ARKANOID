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
        public PlatformPlayer(int x, int y, Control parent) : base(x, y)
        {
            PlatformImage.BackColor = Color.Blue;
            speed = 5;

            parent.Controls.Add(PlatformImage);//заносим в форму
        }
        protected virtual void ChangeTheDirection()
        {
            direction *= -1; //меняем направление платформы на противоположное 
        }
        public void PlatformPlayerControl(object sender, KeyEventArgs e)//чтобы управлять платформой
        {
            if (e.KeyCode == Keys.S)
                ChangeTheDirection();
        }
    }
}