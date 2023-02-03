using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MarathonSkills2020.Charity
{
    /// <summary>
    /// Логика взаимодействия для Sponsorship.xaml
    /// </summary>
    public partial class Sponsorship : Page
    {
        /// <summary>
        /// Знак доллара.
        /// </summary>
        public static readonly string dollar = "$";
        /// <summary>
        /// Cумма взноса.
        /// </summary>
        public static int amount = 0;
        /// <summary>
        /// Пустота.
        /// </summary>
        public static readonly string empty = "";
        /// <summary>
        /// Дата сегодня.
        /// </summary>
        private static string dateNow;
        /// <summary>
        /// Месяц сегодня.
        /// </summary>
        private static string monthNow;
        /// <summary>
        /// Год сегодня.
        /// </summary>
        private static string yearNow;
        /// <summary>
        /// Валидация.
        /// </summary>
        private static bool checkValidity;

        /// <summary>
        /// Бегун.
        /// </summary>
        public static string runnerName;
        /// <summary>
        /// Спонсор.
        /// </summary>
        public static string fondName;
        /// <summary>
        /// Сумма взноса.
        /// </summary>
        public static string amountName;
        /// <summary>
        /// Благотворительная организация.
        /// </summary>
        public static string charity;

        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public Sponsorship()
        {
            InitializeComponent();

            yearNow = DateTime.Now.Year.ToString();

            if (DateTime.Now.Month.ToString().Length < 2)
            {
                monthNow = "0" + DateTime.Now.Month.ToString();
            }

            dateNow = monthNow + yearNow;

            using (MarathonEntities db = new MarathonEntities())
            {
                foreach (var item in db.Users.Where(r => r.RoleId == 1.ToString()))
                {
                    RunnerCB.Items.Add(item);
                }
            }

            Random random = new Random();
            charity = Constants.charityList[random.Next(0, Constants.charityList.Count)];
            CharityOrg.Text = charity;
        }

        /// <summary>
        /// Переход на страницу с информацией о благотворительной организации.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new AboutCharity());
        }

        /// <summary>
        /// Сброс полей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            YourName.Text = null;
            RunnerCB.Text = null;
            Card.Text = null;
            CardNumber.Text = null;
            ValidityMonth.Text = null;
            ValidityYear.Text = null;
            CVC.Text = null;
            Amount.Text = null;
            DisplayAmount.Content = null;

            YourName.BorderBrush = Brushes.Red;
            RunnerCB.BorderBrush = Brushes.Red;
            Card.BorderBrush = Brushes.Red;
            CardNumber.BorderBrush = Brushes.Red;
            ValidityMonth.BorderBrush = Brushes.Red;
            ValidityYear.BorderBrush = Brushes.Red;
            CVC.BorderBrush = Brushes.Red;
            Amount.BorderBrush = Brushes.Red;
        }

        /// <summary>
        /// Понижение суммы взноса.
        /// Валидация поля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DownAmount_Click(object sender, RoutedEventArgs e)
        {
            if (amount <= 1)
            {
                MessageBox.Show("Серьёзно?", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
                amount = 1;
            }
            else
            {
                amount -= 10;
                Amount.Text = amount.ToString();
            }
        }

        /// <summary>
        /// Увеличение суммы взноса.
        /// Валидация поля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpAmount_Click(object sender, RoutedEventArgs e)
        {
            amount += 10;
            Amount.Text = amount.ToString();
        }

        /// <summary>
        /// Валидация суммы взноса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Amount_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (Amount.Text == empty)
            {
                Amount.BorderBrush = Brushes.Red;
                amount = 1;
                DisplayAmount.Content = dollar + amount.ToString();
                Amount.Text = 1.ToString();

                if (DisplayAmount.Content.ToString() == "$0" || DisplayAmount.Content.ToString() == "$1")
                {
                    Amount.Text = 1.ToString();
                }
            }
            else
            {
                amount = Convert.ToInt32(Amount.Text);
                Checks.CheckingAmount(amount);
                Amount.BorderBrush = Brushes.Black;
                DisplayAmount.Content = dollar + amount.ToString();
            }
        }

        /// <summary>
        /// Валидация CVC кода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CVC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CVC.Text.Length != 3)
            {
                CVC.BorderBrush = Brushes.Red;
            }
            else
            {
                CVC.BorderBrush = Brushes.Black;
            }
        }

        /// <summary>
        /// Валидация месяца действия карты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidityMonth_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ValidityMonth.Text.Length != 2)
            {
                ValidityMonth.BorderBrush = Brushes.Red;
            }
            else
            {
                int checkValue;
                Int32.TryParse(ValidityMonth.Text, out checkValue);
                checkValidity = Checks.CheckingMonth(checkValue);
                if (checkValidity == false)
                {
                    ValidityMonth.BorderBrush = Brushes.Red;
                }
                else
                {
                    ValidityMonth.BorderBrush = Brushes.Black;
                }
            }
        }

        /// <summary>
        /// Валидация года действия карты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidityYear_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ValidityYear.Text.Length != 4)
            {
                ValidityYear.BorderBrush = Brushes.Red;
            }
            else
            {
                int checkValue;
                Int32.TryParse(ValidityYear.Text, out checkValue);
                checkValidity = Checks.CheckingYear(checkValue);
                if (checkValidity == false)
                {
                    ValidityYear.BorderBrush = Brushes.Red;
                }
                else
                {
                    ValidityYear.BorderBrush = Brushes.Black;
                }
            }
        }

        /// <summary>
        /// Валидация номера карты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CardNumber.Text.Length != 16)
            {
                CardNumber.BorderBrush = Brushes.Red;
            }
            else
            {
                CardNumber.BorderBrush = Brushes.Black;
            }
        }

        /// <summary>
        /// Валидация навзания карты.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Card_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Card.Text.Length < 2)
            {
                Card.BorderBrush = Brushes.Red;
            }
            else
            {
                Card.BorderBrush = Brushes.Black;
            }
        }

        /// <summary>
        /// Валидация имени спонсора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YourName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (YourName.Text.Length < 2)
            {
                YourName.BorderBrush = Brushes.Red;
            }
            else
            {
                YourName.BorderBrush = Brushes.Black;
            }
        }

        /// <summary>
        /// Внести взнос.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            if (YourName.Text == empty || YourName.BorderBrush == Brushes.Red)
            {
                MessageBox.Show("Некорректно введено имя!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (RunnerCB.SelectedItem == null)
            {
                MessageBox.Show("Не выбран бегун!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (Card.Text == empty || Card.BorderBrush == Brushes.Red)
            {
                MessageBox.Show("Некорректно введён владелец карты!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (CardNumber.Text == empty || CardNumber.BorderBrush == Brushes.Red)
            {
                MessageBox.Show("Некорректно введён номер карты!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (ValidityMonth.Text == empty || ValidityMonth.BorderBrush == Brushes.Red)
            {
                MessageBox.Show("Некорректно введён месяц срока действия карты!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (ValidityYear.Text == empty || ValidityYear.BorderBrush == Brushes.Red)
            {
                MessageBox.Show("Некорректно введён год срока действия карты!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (CVC.Text == empty || CVC.BorderBrush == Brushes.Red)
            {
                MessageBox.Show("Некорректно введён CVC код!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (Amount.Text == null || amount == 0)
            {
                MessageBox.Show("Задана пустая сумма!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (ValidityMonth.Text == empty || ValidityYear.Text == empty)
            { }
            else
            {
                if (Convert.ToInt32(ValidityYear.Text) > Convert.ToInt32(yearNow))
                { }
                else
                if (Convert.ToInt32(ValidityYear.Text) == Convert.ToInt32(yearNow))
                {
                    if (Convert.ToInt32(ValidityMonth.Text) > Convert.ToInt32(monthNow))
                    { }
                    else
                    {
                        MessageBox.Show("Карта не действительна!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                if (Convert.ToInt32(ValidityYear.Text) < Convert.ToInt32(yearNow))
                {
                    MessageBox.Show("Карта не действительна!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

            if (!(YourName.Text == empty || YourName.BorderBrush == Brushes.Red || RunnerCB.SelectedItem == null || Card.Text == empty || Card.BorderBrush == Brushes.Red ||
                CardNumber.Text == empty || CardNumber.BorderBrush == Brushes.Red || ValidityMonth.Text == empty || ValidityMonth.BorderBrush == Brushes.Red ||
                ValidityYear.Text == empty || ValidityYear.BorderBrush == Brushes.Red || CVC.Text == empty || CVC.BorderBrush == Brushes.Red || Amount.Text == null || amount == 0))
            {
                runnerName = RunnerCB.Text;
                fondName = YourName.Text;
                amountName = DisplayAmount.Content.ToString();

                MessageBox.Show("Спасибо за поддержку!", "Спасибо", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager.MainFrame.Navigate(new SponsorshipConfirmation());
            }
        }

        /// <summary>
        /// Валидация поля.
        //  Ввод только цифр.
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
        /// Ввод только букв.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputLetter(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (Int32.TryParse(e.Text, out val))
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
        private void NoSpace(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Валидация поля.
        /// Запрет нажатия клавиши Backspace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Runner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                e.Handled = true;
            }
        }
    }
}
