using SakardinKursach.Model;
using SakardinKursach.Windows;
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

namespace SakardinKursach
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

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            operators oper = Kit.rk.operators.FirstOrDefault(i => i.name == Logtb.Text && i.Password == Passtb.Password);
            if (oper != null)
            {
                OperSave.opers = oper;
                Navigation navigation = new Navigation();
                navigation.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте логин или пароль");
            }
           
            // Получаем пользователя из базы данных по логину и паролю
            var user = Kit.rk.operators.FirstOrDefault(u => u.name == Name && u.Password == Passtb.Password);
   
        }
    }
}
