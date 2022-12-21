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
using TESTDEMO.Database;

namespace TESTDEMO
{
    /// <summary>
    /// Логика взаимодействия для WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        public WorkWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = App.DB.Tour.ToList();
        }

        //изменение
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Izm = DataGrid.SelectedItem as Tour;
            if(Izm == null)
            {
                return;
            }
            App.DB.SaveChanges();
        }

        //удаление
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var id = DataGrid.SelectedItem as Tour;
            if (id == null)
            {
                return;
            }
            App.DB.Tour.Remove(id);
            App.DB.SaveChanges();
            DataGrid.ItemsSource = App.DB.Tour.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var newWind = new Dobavlenie();
        }
    }
}
