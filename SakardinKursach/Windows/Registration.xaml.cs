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
using SakardinKursach.Model;


namespace SakardinKursach.Windows
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
                        string mes = "";
            if (string.IsNullOrWhiteSpace(tb1.Text))
                mes += "Введите логин\n";
            if (string.IsNullOrWhiteSpace(pb1.Password))
                mes += "Введите пароль\n";

            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            operators user = new operators();
            {
                user.name = tb1.Text;
                user.Password = pb1.Password;
            }
            Kit.rk.operators.Add(user);
            Kit.rk.SaveChanges();
            MessageBox.Show("Регистрация успешна");
            Navigation navigation = new Navigation();
            navigation.Show();
            this.Close();
        }
    }
}
