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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string imgsorcel1 = @"C:\img2.akspic.ru-bak-masiny-world_of_tanks-boevaya_mashina-vid_transporta-2560x1600.jpg";
        private string imgsorcel2 = @"C:\img1.akspic.ru-voennosluzhashhie-polet-aviaciya-vozdushnye_sily-aerokosmicheskaya_tehnika-3543x2362.jpg";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            windows2 window = new windows2();
            window.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("приложение закрылос");
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(imgsorcel1));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(imgsorcel2));
        }
    }
}
