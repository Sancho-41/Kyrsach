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
    /// Логика взаимодействия для Navigation.xaml
    /// </summary>
    public partial class Navigation : Window
    {
        public Navigation()
        {
            InitializeComponent();
            TB22.Text = Kit.rk.operators.First(i => i.id == OperSave.opers.id).id.ToString();
            TB11.Text = Kit.rk.operators.First(i => i.id == OperSave.opers.id).name.ToString();
            dfg.ItemsSource = Kit.rk.emergency_calls.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           try
            {
                Model.emergency_calls properties = new Model.emergency_calls()
                {
                    caller_name = TB1.Text,
                    caller_location = TB2.Text,
                    emergency_type = TB3.Text,
                    call_time = Convert.ToDateTime(DP1.Text),
                    operator_id = OperSave.opers.id

                };
                Kit.rk.emergency_calls.Add(properties);
                Kit.rk.SaveChanges();
                MessageBox.Show("Карточка добавлена");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении карточки: {ex.Message}");
            }
            // очистка значений
            TB1.Text = "";
            TB2.Text = "";
            TB3.Text = "";
            DP1.SelectedDate = null;
        }
    }
 }
