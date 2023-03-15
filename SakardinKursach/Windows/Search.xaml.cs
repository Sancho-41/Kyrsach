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

namespace SakardinKursach.Windows
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             // Получаем строку поиска из TextBox
             string searchQuery = tb1.Text;

            // Фильтруем коллекцию Calls по условию, содержащему searchQuery
            var filteredCalls = Kit.rk.emergency_calls.Where(emergency_calls => emergency_calls..Contains(searchQuery)
            || call.Address.Contains(searchQuery)
            || call.DateTime.ToString().Contains(searchQuery))
            .ToList();

            // Обновляем источник данных DataGrid
            CallsDataGrid.ItemsSource = filteredCalls;
        }
    }
}
