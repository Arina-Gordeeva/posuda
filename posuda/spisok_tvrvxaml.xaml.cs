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
using System.Windows.Shapes;

namespace posuda
{
    /// <summary>
    /// Логика взаимодействия для spisok_tvrvxaml.xaml
    /// </summary>
    public partial class spisok_tvrvxaml : Window
    {
        public spisok_tvrvxaml()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dobavlenie_tovara wnd = new dobavlenie_tovara();
            wnd.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            redactirovanie_tovara wnd = new redactirovanie_tovara();
            wnd.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            redactirovanie_tovara wnd = new redactirovanie_tovara();
            wnd.Show();
            this.Hide();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            redactirovanie_tovara wnd = new redactirovanie_tovara();
            wnd.Show();
            this.Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            this.Hide(); ;
        }
    }
}
