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
        private float SpeedX, SpeedY;
        Player first;
        Collisia collisia;

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
            collisia = new Collisia(GameScreen, Character, SpeedX, SpeedY);
            GameTimer.Interval = TimeSpan.FromMilliseconds(1);
            GameTimer.Tick += GameTick;
            GameTimer.Start();



        }
        private void GameTick(object sender, EventArgs e)
        {

            first.Move();
            SpeedX = first.X;
            SpeedY = first.Y;
            collisia._Canvas = GameScreen;
            Canvas.SetLeft(Character, Canvas.GetLeft(Character) + SpeedX);
            collisia.Collide("x");
            Canvas.SetTop(Character, Canvas.GetTop(Character) - SpeedY);
            collisia.Collide("y");
        }

    }
}
