using LogisticsDLL;
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
using ClassLibrary;
using StockDLL;

namespace Factory.Visuals
{
    /// <summary>
    /// Логика взаимодействия для Stock.xaml
    /// </summary>
    public partial class Stock : Page
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)//Основной блок расчета
        {
            if (double.TryParse(cerealTBox.Text, out double amountCereal) &&
                double.TryParse(oilTBox.Text, out double amountOil) &&
                double.TryParse(sugarTBox.Text, out double amountSugar) &&
                double.TryParse(powderTBox.Text, out double amountPowder) &&
                double.TryParse(waterTBox.Text, out double amountWater))
            {
                ProductionCalculator calculator = new ProductionCalculator(); // Создаем экземпляр класса ProductionCalculator
                double result = calculator.CalculatePossibleProduction(amountCereal,
                                                                amountOil,
                                                                amountSugar,
                                                                amountPowder,
                                                                amountWater); // Вызываем метод CalculatedLogisticsCost и сохраняем его результат в переменной result
                resultTBlock.Text = result.ToString("F2"); // Выводим результат в текстовый блок с именем resultTextBlock
            }
            else
            {
                MessageBox.Show("Invalid input data", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
