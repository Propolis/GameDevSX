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
        private float SpeedX, SpeedY;
        Player first;

        private void WindowMaximized()
        {
            // Создаем новый объект окна gamePlay
            this.WindowState = WindowState.Maximized;
        }
        private void KeyboardUp(object sender, KeyEventArgs e)
        {
            first.KeyboardUp(sender, e);
        }

        private void KeyBoardDown(object sender, KeyEventArgs e)
        {
            first.KeyBoardDown(sender, e);
        }
        public GamePlay()
        {
            InitializeComponent();
            WindowMaximized();
            GameScreen.Focus();
            first = new Player(Character);
            GameTimer.Interval = TimeSpan.FromMilliseconds(1);
            GameTimer.Tick += GameTick;
            GameTimer.Start();



        }
        private void GameTick(object sender, EventArgs e)
        {

            first.Move();
            SpeedX = first.X;
            SpeedY = first.Y;
            Canvas.SetLeft(Character, Canvas.GetLeft(Character) + SpeedX);
            Canvas.SetTop(Character, Canvas.GetTop(Character) - SpeedY);

        }


        //private void Collide(string Dir)
        //{
        //    foreach (var x in GameScreen.Children.OfType<Rectangle>())
        //    {
        //        if ((string)x.Tag == "Collide")
        //        {
        //            Rect PlayerHB = new Rect(Canvas.GetLeft(Character), Canvas.GetTop(Character), Character.Width, Character.Height);
        //            Rect ToCollide = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

        //            if (PlayerHB.IntersectsWith(ToCollide))
        //            {
        //                if (Dir == "x")
        //                {
        //                    Canvas.SetLeft(Character, Canvas.GetLeft(Character) - SpeedX);
        //                    SpeedX = 0;
        //                }
        //                else
        //                {
        //                    Canvas.SetTop(Character, Canvas.GetTop(Character) + SpeedY);
        //                    SpeedY = 0;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
