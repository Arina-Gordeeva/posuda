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
    /// Логика взаимодействия для redactirovanie_tovara.xaml
    /// </summary>
    public partial class redactirovanie_tovara : Window
    {
        public redactirovanie_tovara()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            spisok_tvrvxaml wnd = new spisok_tvrvxaml();
            wnd.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            this.Hide(); ;
        }
    }
}
