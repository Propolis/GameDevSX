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

        private void WindowMaximized()
        {
            // Создаем новый объект окна gamePlay
            this.WindowState = WindowState.Maximized;
        }
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
            // Создаем новый объект ImageBrush
            ImageBrush PlayerRight = new ImageBrush();
            // Устанавливаем свойство ImageSource объекта ImageBrush на новое изображение
            PlayerRight.ImageSource = new BitmapImage(new Uri("characterRight.png", UriKind.RelativeOrAbsolute));

            ImageBrush PlayerLeft = new ImageBrush();
            PlayerLeft.ImageSource = new BitmapImage(new Uri("characterLeft.png", UriKind.RelativeOrAbsolute));

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
                Character.Fill = PlayerLeft;
            }
            if (e.Key == Key.D || e.Key == Key.Right)
            {
                RightKeyPressed = true;
                Character.Fill = PlayerRight;
            }
        }
        public GamePlay()
        {
            InitializeComponent();
            WindowMaximized();
            GameScreen.Focus();
            GameTimer.Interval = TimeSpan.FromMilliseconds(1);
            GameTimer.Tick += GameTick;
            GameTimer.Start();



        }
        private void GameTick(object sender, EventArgs e)
        {
            Player first = new Player(SpeedY, SpeedX, UpKeyPressed, DownKeyPressed, LeftKeyPressed, RightKeyPressed);
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
