using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MarathonSkills2020.BMR
{
    /// <summary>
    /// Логика взаимодействия для BMR.xaml
    /// </summary>
    public partial class BMR : Page
    {
        /// <summary>
        /// Рост.
        /// </summary>
        private int growth = 0;
        /// <summary>
        /// Вес.
        /// </summary>
        private int weight = 0;
        /// <summary>
        /// Возраст.
        /// </summary>
        private int age = 0;
        /// <summary>
        /// Пол.
        /// </summary>
        private string gender = null;

        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public BMR()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Расчёт.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (Growth.Text == null)
            {
                MessageBox.Show("Заполните рост!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (Weight.Text == null)
            {
                MessageBox.Show("Заполните вес!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (Age.Text == null)
            {
                MessageBox.Show("Заполните возраст!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (gender == null)
            {
                MessageBox.Show("Выберите пол!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (Growth.Text != null && Weight.Text != null && Age.Text != null && (MaleRectangle.Visibility == Visibility.Visible || FemaleRectangle.Visibility == Visibility.Visible) && (growth > 0 && growth < 300) && (weight > 0 && weight < 500) && (age > 0 && age < 100))
            {
                if (gender == Constants.MALE)
                {
                    BMRItog.Content = Calculating.CalculateMale(growth, weight, age);
                }

                if (gender == Constants.FEMALE)
                {
                    BMRItog.Content = Calculating.CalculateFemale(growth, weight, age);
                }

                SedentaryActivity.Content = Calculating.SedentaryActivity();
                LittleActivity.Content = Calculating.LittleActivity();
                AverageActivity.Content = Calculating.AverageActivity();
                StrongActivity.Content = Calculating.StrongActivity();
                MaximumActivity.Content = Calculating.MaximumActivity();
            }
            else
            {
                MessageBox.Show("Данные введены неверно!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
                Growth.Text = 1.ToString();
                Weight.Text = 1.ToString();
                Age.Text = 1.ToString();
            }
        }

        /// <summary>
        /// Сброс полей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MaleRectangle.Visibility = Visibility.Hidden;
            FemaleRectangle.Visibility = Visibility.Hidden;
            Growth.Text = null;
            Weight.Text = null;
            Age.Text = null;
            gender = null;
            BMRItog.Content = "*";
            SedentaryActivity.Content = "*";
            LittleActivity.Content = "*";
            AverageActivity.Content = "*";
            StrongActivity.Content = "*";
            MaximumActivity.Content = "*";
        }

        /// <summary>
        /// Переход на страницу со списком активностей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new ActivitiesDescription());
        }

        /// <summary>
        ///  Валидация поля роста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Growth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (Growth.Text == "")
            {
                growth = 0;
            }
            else
            {
                growth = Convert.ToInt32(Growth.Text);
                Checks.CheckingGrowth(growth);
            }
        }

        /// <summary>
        ///  Валидация поля веса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Weight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (Weight.Text == "")
            {
                weight = 0;
            }
            else
            {
                weight = Convert.ToInt32(Weight.Text);
                Checks.CheckingWeight(weight);
            }
        }

        /// <summary>
        /// Валидация поля возраста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Age_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (Age.Text == "")
            {
                age = 0;
            }
            else
            {
                age = Convert.ToInt32(Age.Text);
                Checks.CheckingAge(age);
            }
        }

        /// <summary>
        /// Выделение изображения женщины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FemaleImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gender = "Женский";
            if (gender == Constants.FEMALE)
            {
                FemaleRectangle.Visibility = Visibility.Visible;
                MaleRectangle.Visibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// Выделение изображения мужчины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaleImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gender = "Мужской";
            if (gender == Constants.MALE)
            {
                MaleRectangle.Visibility = Visibility.Visible;
                FemaleRectangle.Visibility = Visibility.Hidden;
            }
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
        private void NoSpace(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }
    }
}