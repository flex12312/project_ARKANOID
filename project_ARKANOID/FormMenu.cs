using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static project_ARKANOID.PlatformBot;

namespace project_ARKANOID
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("images/menu.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame();
            formGame.Show();
            this.Hide();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.ShowDialog();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "Арканоид - это аркадная игра, в которой нужно" +
                " соревноваться с ботом, управляя платформой и " +
                "отбивая шарик. Платформа движется сама , по нажатию кнопки S " +
                "платформа меняет направление своего движения. " +
                "Игра заканчивается когда один из игроков набирает 3 очка.", 

                "Информация об игре",MessageBoxButtons.OK,MessageBoxIcon.Information
            );
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
