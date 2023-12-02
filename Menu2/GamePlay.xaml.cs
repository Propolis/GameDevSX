using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Menu2
{
    public partial class GamePlay : Window
    {
        private DispatcherTimer GameTimer = new DispatcherTimer();
        private bool UpKeyPressed, DownKeyPressed, LeftKeyPressed, RightKeyPressed;
        private float SpeedX, SpeedY, Friction = 0.77f, Speed = 2f;

        private void KeyboardUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W || e.Key == Key.Up)
            {
                UpKeyPressed = false;
            }
            if (e.Key == Key.S || e.Key == Key.Down)
            {
                DownKeyPressed = false;
            }
            if (e.Key == Key.A || e.Key == Key.Left)
            {
                LeftKeyPressed = false;
            }
            if (e.Key == Key.D || e.Key == Key.Right)
            {
                RightKeyPressed = false;
            }
        }

        private void KeyBoardDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.W || e.Key == Key.Up)
            {
                UpKeyPressed = true;
            }
            if (e.Key == Key.S || e.Key == Key.Down)
            {
                DownKeyPressed = true;
            }
            if (e.Key == Key.A || e.Key == Key.Left)
            {
                LeftKeyPressed = true;
            }
            if (e.Key == Key.D || e.Key == Key.Right)
            {
                RightKeyPressed = true;
            }
        }
        public GamePlay()
        {
            InitializeComponent();
            GameScreen.Focus();
            GameTimer.Interval = TimeSpan.FromMilliseconds(1);
            GameTimer.Tick += GameTick;
            GameTimer.Start();
        }
        private void GameTick(object sender, EventArgs e)
        {
            if (UpKeyPressed)
            {
                SpeedY += Speed;
            }
            if (RightKeyPressed)
            {
                SpeedX += Speed;
            }
            if (LeftKeyPressed)
            {
                SpeedX -= Speed;
            }
            if (DownKeyPressed)
            {
                SpeedY -= Speed;
            }
            SpeedX = SpeedX * Friction;
            SpeedY = SpeedY * Friction;

            Canvas.SetLeft(Player, Canvas.GetLeft(Player) + SpeedX);
            Canvas.SetTop(Player, Canvas.GetTop(Player) - SpeedY);
        }
    }
}
