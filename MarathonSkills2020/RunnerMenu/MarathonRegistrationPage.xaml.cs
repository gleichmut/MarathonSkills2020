using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace MarathonSkills2020.RunnerMenu
{
    /// <summary>
    /// Логика взаимодействия для MarathonRegistrationPage.xaml
    /// </summary>
    public partial class MarathonRegistrationPage : Page
    {
        /// <summary>
        /// Стоимость полного марафона.
        /// </summary>
        private int FullMarathon = 145;
        /// <summary>
        /// Стоимость полумарафона.
        /// </summary>
        private int HalfMarathon = 75;
        /// <summary>
        /// Стоимость малой дистанции.
        /// </summary>
        private int LittleDistance = 20;
        /// <summary>
        /// Взнос.
        /// </summary>
        private int AmountValue = 0;
        /// <summary>
        /// Стоимость варианта А.
        /// </summary>
        private int VarAValue = 0;
        /// <summary>
        /// Стоимость варианта В.
        /// </summary>
        private int VarBValue = 20;
        /// <summary>
        /// Стоимость варинта С.
        /// </summary>
        private int VarCValue = 45;
        /// <summary>
        /// Введенная стоимость.
        /// </summary>
        private int amountVC = 0;

        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public MarathonRegistrationPage()
        {
            InitializeComponent();

            //Вывод благотворительных организаций из базы данных.
            using (MarathonEntities db = new MarathonEntities())
            {
                foreach (var item in db.CharityDBs.OrderBy(p => p.CharityName))
                {
                    CharityName.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Регистрация.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if ((FullMarathonCheckBox.IsChecked == true || HalfMarathonCheckBox.IsChecked == true || LittleDistanceCheckBox.IsChecked == true)
                 && (VarA.IsChecked == true || VarB.IsChecked == true || VarC.IsChecked == true) &&
                 CharityName.SelectedItem != null && AmountSponsorship.Text != null)
            {
                Manager.MainFrame.Navigate(new MarathonRegistrationConfirmation());
            }
            else System.Windows.MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Сброс полей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            FullMarathonCheckBox.IsChecked = false;
            HalfMarathonCheckBox.IsChecked = false;
            LittleDistanceCheckBox.IsChecked = false;
            VarA.IsChecked = false;
            VarB.IsChecked = false;
            VarC.IsChecked = false;
            CharityName.Text = null;
            AmountSponsorship.Text = Charity.Sponsorship.empty;
            DisplayAmount.Content = null;
            AmountValue = 0;
        }

        /// <summary>
        /// Валидация поля.
        /// Ввод только цифр.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputNumber(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!Int32.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Валидация поля.
        /// Запрет ввода пробела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoSpace(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Прибавление стоимости полного марафона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullMarathonCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (FullMarathonCheckBox.IsChecked == true)
            {
                AmountValue += FullMarathon;
            }
        }

        /// <summary>
        /// Отнятие стоимости полного марафона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullMarathonCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (FullMarathonCheckBox.IsChecked == false)
            {
                AmountValue -= FullMarathon;
            }
        }

        /// <summary>
        /// Прибавление стоимости полумарафона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HalfMarathonCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (HalfMarathonCheckBox.IsChecked == true)
            {
                AmountValue += HalfMarathon;
            }
        }

        /// <summary>
        /// Отнятие стоимости полумарафона.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HalfMarathonCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (HalfMarathonCheckBox.IsChecked == false)
            {
                AmountValue -= HalfMarathon;
            }
        }

        /// <summary>
        /// Прибавление стоимости малой дистанции.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LittleDistanceCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (LittleDistanceCheckBox.IsChecked == true)
            {
                AmountValue += LittleDistance;
            }
        }

        /// <summary>
        /// Отнятие стоимости малой дистанции.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LittleDistanceCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (LittleDistanceCheckBox.IsChecked == false)
            {
                AmountValue -= LittleDistance;
            }
        }

        /// <summary>
        /// Подчет стоимости.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Counter_Click(object sender, RoutedEventArgs e)
        {
            DisplayAmount.Content = Charity.Sponsorship.dollar + (AmountValue + amountVC);
        }

        /// <summary>
        /// Прибавление стоимости варианта А.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VarA_Checked(object sender, RoutedEventArgs e)
        {
            if (VarA.IsChecked == true)
            {
                AmountValue += VarAValue;
            }
        }

        /// <summary>
        /// Отнятие стоимости варианта А.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VarA_Unchecked(object sender, RoutedEventArgs e)
        {
            if (VarA.IsChecked == false)
            {
                AmountValue -= VarAValue;
            }
        }

        /// <summary>
        /// Прибавление стоимости варианта В.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VarB_Checked(object sender, RoutedEventArgs e)
        {
            if (VarB.IsChecked == true)
            {
                AmountValue += VarBValue;
            }
        }

        /// <summary>
        /// Отнятие стоимости варианта В.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VarB_Unchecked(object sender, RoutedEventArgs e)
        {
            if (VarB.IsChecked == false)
            {
                AmountValue -= VarBValue;
            }
        }

        /// <summary>
        /// Прибавление стоимости варианта С.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VarC_Checked(object sender, RoutedEventArgs e)
        {
            if (VarC.IsChecked == true)
            {
                AmountValue += VarCValue;
            }
        }

        /// <summary>
        /// Отнятие стоимости варианта С.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VarC_Unchecked(object sender, RoutedEventArgs e)
        {
            if (VarC.IsChecked == false)
            {
                AmountValue -= VarCValue;
            }
        }

        /// <summary>
        /// Получение суммы взноса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AmountSponsorship_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            amountVC = Convert.ToInt32(AmountSponsorship.Text);
        }
    }
}
