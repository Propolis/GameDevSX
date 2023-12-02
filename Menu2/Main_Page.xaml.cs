using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Menu2
{
    /// <summary>
    /// Логика взаимодействия для Main_Page.xaml
    /// </summary>
    public partial class Main_Page : Page
    {
        public Main_Page()
        {
            InitializeComponent();
            // Создание объекта ImageBrush с ссылкой на изображение
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = new BitmapImage(new Uri("menu_picture.png", UriKind.Relative)); // Укажите путь к вашему изображению

            // Установка изображения в качестве заднего фона для грида
            GrMainPage.Background = imageBrush;
            btSettings.BorderBrush = Brushes.White;
            btSettings.Background = Brushes.Black;
            btSettings.Foreground = Brushes.White;

            btPlay.BorderBrush = Brushes.White;
            btPlay.Background = Brushes.Black;
            btPlay.Foreground = Brushes.White;

            btGiveUp.BorderBrush = Brushes.White;
            btGiveUp.Background = Brushes.Black;
            btGiveUp.Foreground = Brushes.White;

        }

        private void btSettings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Settings_Page());
        }

        private void btGiveUp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btPlay_Click(object sender, RoutedEventArgs e)
        {
            GamePlay window = new GamePlay();
            window.Show();
        }
    }
}
