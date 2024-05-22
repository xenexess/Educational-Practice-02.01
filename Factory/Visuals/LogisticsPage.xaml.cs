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
using LogisticsDLL;

namespace Factory.Visuals
{
    /// <summary>
    /// Логика взаимодействия для LogisticsPage.xaml
    /// </summary>
    public partial class LogisticsPage : Page
    {        
        public LogisticsPage()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)//Основной блок расчета
        {
            if (double.TryParse(distanceTextBox.Text, out double distance) &&
                double.TryParse(costPerKmTextBox.Text, out double costPerKm))
            {
                LogisticsCalculator calculator = new LogisticsCalculator(); // Создаем экземпляр класса LogisticsCalculator
                double result = calculator.CalculateLogisticsCost(distance, costPerKm); // Вызываем метод CalculatedLogisticsCost и сохраняем его результат в переменной result
                resultTextBlock.Text = result.ToString("F2"); // Выводим результат в текстовый блок с именем resultTextBlock
            }
            else
            {
                MessageBox.Show("Неверное значение", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
