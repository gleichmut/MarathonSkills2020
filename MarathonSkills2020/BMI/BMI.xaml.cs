using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MarathonSkills2020.BMI
{
    /// <summary>
    /// Логика взаимодействия для BMI.xaml
    /// </summary>
    public partial class BMI : Page
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
        /// Пол.
        /// </summary>
        private string gender = null;

        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public BMI()
        {
            InitializeComponent();
            States.AddingStates();
            SliderBMI.IsEnabled = false;
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

            if (gender == null)
            {
                MessageBox.Show("Выберите пол!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            if (Growth.Text != null && Weight.Text != null && (MaleRectangle.Visibility == Visibility.Visible || FemaleRectangle.Visibility == Visibility.Visible) && (growth > 0 && growth < 300) && (weight > 0 && weight < 500))
            {
                BMIItog.Content = Calculating.CalculateBMI(growth, weight);
                SliderBMI.Value = Calculating.CalculateBMI(growth, weight);
                Color color = new Color();

                if (Calculating.CalculateBMI(growth, weight) < 18.5)
                {
                    StateBMI.Content = States.states[0];
                    StateImage.Source = new BitmapImage(new Uri("pack://application:,,,/MarathonSkills2020;component/Resources/underweight.png"));
                    color = (Color)ColorConverter.ConvertFromString("#5abae0");
                    SolidColorBrush solidColorBrush = new SolidColorBrush(color);
                    SliderBMI.Background = solidColorBrush;
                }

                if ((18.5 <= Calculating.CalculateBMI(growth, weight)) && (Calculating.CalculateBMI(growth, weight) <= 24.9))
                {
                    StateBMI.Content = States.states[1];
                    StateImage.Source = new BitmapImage(new Uri("pack://application:,,,/MarathonSkills2020;component/Resources/normal.png"));
                    color = (Color)ColorConverter.ConvertFromString("#9cb327");
                    SolidColorBrush solidColorBrush = new SolidColorBrush(color);
                    SliderBMI.Background = solidColorBrush;
                }

                if ((25 <= Calculating.CalculateBMI(growth, weight)) && (Calculating.CalculateBMI(growth, weight) <= 29.9))
                {
                    StateBMI.Content = States.states[2];
                    StateImage.Source = new BitmapImage(new Uri("pack://application:,,,/MarathonSkills2020;component/Resources/overweight.png"));
                    color = (Color)ColorConverter.ConvertFromString("#f68121");
                    SolidColorBrush solidColorBrush = new SolidColorBrush(color);
                    SliderBMI.Background = solidColorBrush;
                }

                if (30 < Calculating.CalculateBMI(growth, weight))
                {
                    StateBMI.Content = States.states[3];
                    StateImage.Source = new BitmapImage(new Uri("pack://application:,,,/MarathonSkills2020;component/Resources/obese.png"));
                    color = (Color)ColorConverter.ConvertFromString("#e64638");
                    SolidColorBrush solidColorBrush = new SolidColorBrush(color);
                    SliderBMI.Background = solidColorBrush;
                }
            }
            else
            {
                MessageBox.Show("Данные введены неверно", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
                Growth.Text = 1.ToString();
                Weight.Text = 1.ToString();
            }
        }

        /// <summary>
        ///Сброс полей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MaleRectangle.Visibility = Visibility.Hidden;
            FemaleRectangle.Visibility = Visibility.Hidden;
            Growth.Text = null;
            Weight.Text = null;
            gender = null;
            BMIItog.Content = "*";
            StateImage.Source = null;
            StateBMI.Content = "*";
            SliderBMI.Background = null;
            SliderBMI.Value = 0;
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
        /// Валидация поля роста.
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
                Checks.CheckingAge(growth);
            }
        }

        /// <summary>
        /// Валидация поля веса.
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
                Checks.CheckingAge(weight);
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
