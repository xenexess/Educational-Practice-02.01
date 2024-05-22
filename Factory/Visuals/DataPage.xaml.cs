using Factory.DBase;
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

namespace Factory.Visuals
{
    
    public partial class DataPage : Page
    {
        public DataPage()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)//Логика присоединения таблицы
        {
            UsersGrid.ItemsSource = AppData.db.User.ToList();
        }

        private void wareVol_Click(object sender, RoutedEventArgs e)//Логика кнопки назад
        {
            NavigationService.Navigate(new Stock());
        }

        private void logistics_Click(object sender, RoutedEventArgs e)//Переадресация к странице с логикой
        {
            NavigationService.Navigate(new LogisticsPage());
        }
    }
}
