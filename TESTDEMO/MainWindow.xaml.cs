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

namespace TESTDEMO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginBt_Click(object sender, RoutedEventArgs e)
        {
            var User_Login = App.DB.userDB.Where(p => p.user_login == LoginBox.Text && p.user_pswd == pswd.Text).FirstOrDefault();
            if (User_Login != null)
            {
                var New_Window = new WorkWindow();
                New_Window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные введены не корректно!");
            }
        }
    }
}