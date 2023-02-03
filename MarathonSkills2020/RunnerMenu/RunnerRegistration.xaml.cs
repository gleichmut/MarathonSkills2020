using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using KeyEventArgs = System.Windows.Input.KeyEventArgs;

namespace MarathonSkills2020.RunnerMenu
{
    /// <summary>
    /// Логика взаимодействия для RunnerRegistration.xaml
    /// </summary>
    public partial class RunnerRegistration : Page
    {
        /// <summary>
        /// Пустота.
        /// </summary>
        private static readonly string empty = "";
        /// <summary>
        /// Код страны.
        /// </summary>
        private string codeCountry;

        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public RunnerRegistration()
        {
            InitializeComponent();

            //Constants.FillCountries();

            using (MarathonEntities db = new MarathonEntities())
            {
                foreach (var item in db.Countries.OrderBy(p => p.CountryName))
                {
                    CountryRunner.Items.Add(item);
                }

                foreach (var item in db.Genders)
                {
                    GenderRunner.Items.Add(item);
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
            if (EmailRunner.Text == empty || EmailRunner.BorderBrush == Brushes.Red)
            {
                System.Windows.MessageBox.Show("Некорректно введена почта!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (PasswordRunner.Text == empty || PasswordRunner.BorderBrush == Brushes.Red)
            {
                System.Windows.MessageBox.Show("Некорректно введён пароль!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (TryPasswordRunner.Text == empty || TryPasswordRunner.BorderBrush == Brushes.Red)
            {
                System.Windows.MessageBox.Show("Повторите пароль!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (NameRunner.Text == empty || NameRunner.BorderBrush == Brushes.Red)
            {
                System.Windows.MessageBox.Show("Некорректно введено имя!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (SurnameRunner.Text == empty || SurnameRunner.BorderBrush == Brushes.Red)
            {
                System.Windows.MessageBox.Show("Некорректно введена фамилия!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (GenderRunner.SelectedItem == null)
            {
                System.Windows.MessageBox.Show("Не выбран пол!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (BirthdayRunner.Text == null || BirthdayRunner.BorderBrush == Brushes.Red)
            {
                System.Windows.MessageBox.Show("Некорректно введена дата рождения!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (CountryRunner.SelectedItem == null)
            {
                System.Windows.MessageBox.Show("Не выбрана страна!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (!(EmailRunner.Text == empty || EmailRunner.BorderBrush == Brushes.Red || PasswordRunner.Text == empty || PasswordRunner.BorderBrush == Brushes.Red ||
                 TryPasswordRunner.Text == empty || TryPasswordRunner.BorderBrush == Brushes.Red || NameRunner.Text == empty || NameRunner.BorderBrush == Brushes.Red ||
                 SurnameRunner.Text == empty || SurnameRunner.BorderBrush == Brushes.Red || GenderRunner.SelectedItem == null || BirthdayRunner.Text == null || BirthdayRunner.BorderBrush == Brushes.Red
                 || CountryRunner.SelectedItem == null))
            {
                using (MarathonEntities db = new MarathonEntities())
                {
                    foreach (var item in db.Countries.Where(p => p.CountryName == CountryRunner.Text))
                    {
                        codeCountry = item.CountryCode;
                    }

                    User user = new User() { Email = EmailRunner.Text, FirstName = NameRunner.Text, LastName = SurnameRunner.Text, Password = PasswordRunner.Text, RoleId = "1" };
                    Runner runner = new Runner() { Email = EmailRunner.Text, Gender = GenderRunner.Text, DateOfBirth = BirthdayRunner.Text, CountryCode = codeCountry };

                    db.Users.Add(user);
                    db.Runners.Add(runner);
                    db.SaveChanges();
                    System.Windows.MessageBox.Show("Бегун записан!", "Предупреждение!", MessageBoxButton.OK, MessageBoxImage.Information);
                    Manager.MainFrame.Navigate(new MarathonRegistrationPage());
                }
            }
        }

        /// <summary>
        /// Загрузка фото.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdPicture = new OpenFileDialog();
            ofdPicture.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPicture.FilterIndex = 1;

            if (ofdPicture.ShowDialog() == DialogResult.OK)
            {
                ImageRunner.Source = new BitmapImage(new Uri(ofdPicture.FileName));
            }

            PathToPhotoRunner.Text = ofdPicture.FileName;
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
        private void NoSpace(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Валидация поля.
        /// Запрет нажатия на клавишу Backspace.
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

        /// <summary>
        /// Валидация поля имя бегуна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameRunner_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NameRunner.Text.Length < 2)
            {
                NameRunner.BorderBrush = Brushes.Red;
            }
            else
            {
                NameRunner.BorderBrush = Brushes.Black;
            }
        }

        /// <summary>
        /// Валидация поля фамилия бегуна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SurnameRunner_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SurnameRunner.Text.Length < 3)
            {
                SurnameRunner.BorderBrush = Brushes.Red;
            }
            else
            {
                SurnameRunner.BorderBrush = Brushes.Black;
            }
        }

        /// <summary>
        /// Валидация поля почта бегуна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailRunner_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Checks.IsValidEmail(EmailRunner.Text) == false)
            {
                EmailRunner.BorderBrush = Brushes.Red;
            }
            else
            {
                EmailRunner.BorderBrush = Brushes.Black;
            }
        }

        /// <summary>
        /// Валидация поля пароль бегуна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PasswordRunner_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Checks.IsValidPassword(PasswordRunner.Text) == true)
            {
                PasswordRunner.BorderBrush = Brushes.Black;
            }
            else
            {
                PasswordRunner.BorderBrush = Brushes.Red;
            }
        }

        /// <summary>
        /// Валидация поля повторения пароля бегуна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TryPasswordRunner_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PasswordRunner.BorderBrush == Brushes.Red)
            {
                TryPasswordRunner.BorderBrush = Brushes.Red;
            }

            if (PasswordRunner.Text != TryPasswordRunner.Text)
            {
                TryPasswordRunner.BorderBrush = Brushes.Red;
            }
        }

        /// <summary>
        /// Валидация поля даты рождения бегуна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayRunner_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                DateTime dateNow = Convert.ToDateTime(BirthdayRunner.Text);

                if (dateNow >= DateTime.Now)
                {
                    BirthdayRunner.BorderBrush = Brushes.Red;
                }
                else
                {
                    BirthdayRunner.BorderBrush = Brushes.Black;
                }
            }
            catch { }
        }

        /// <summary>
        /// Сброс полей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            EmailRunner.Text = null;
            PasswordRunner.Text = null;
            TryPasswordRunner.Text = null;
            NameRunner.Text = null;
            SurnameRunner.Text = null;
            GenderRunner.Text = null;
            ImageRunner.Source = null;
            PathToPhotoRunner.Text = null;
            BirthdayRunner.Text = null;
            CountryRunner.Text = null;
        }
    }
}
