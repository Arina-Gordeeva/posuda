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
using System.Data.SqlClient;
using Microsoft.Win32;


namespace posuda
{
    public class User
    {
        public int UserId { get; set; }
        public string UserSurname { get; set; }
        public string UserName { get; set; }
        public string UserPatronymic { get; set; }
        public int IDRole { get; set; }
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kak_gost wnd = new kak_gost();
            wnd.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (UserAuthentication(login.Text, password.Password))
            {
                MessageBox.Show("Вы вошли");


                spisok_tovarov wnd = new spisok_tovarov();
                wnd.Show();
                this.Hide();
            }

        }
        public static bool UserAuthentication(string login, string password)
        {
            ManageData manageData = new ManageData(); SqlDataReader reader = manageData.SqlRequestReader($"select * from [User] where UserLogin = '{login}' and UserPassword = '{password}'");
            if (reader.Read())
            {
                User user = new User();

                user.UserSurname = (string)reader["UserSurname"];
                user.UserName = (string)reader["UserName"];
                user.UserPatronymic = (string)reader["UserPatronymic"];
                return true;
            }
            return false;
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
