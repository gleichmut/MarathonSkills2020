using System;
using System.Windows;
using System.Windows.Threading;

namespace MarathonSkills2020.MainMenu
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        /// <summary>
        /// Дата сегодня, полученный день недели, возвращенный день недели.
        /// Дата до старта марафона.
        /// Таймер.
        /// </summary>
        public static string dateNow, dayOfWeekGet, dayOfWeekReturn;
        public static DateTime marathoneDate = new DateTime(2020, 11, 24, 6, 00, 00);
        public static DispatcherTimer timer;

        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
            MainFrame.Navigate(new MainMenuPage());
            Manager.MainFrame = MainFrame;
        }

        /// <summary>
        /// Таймер.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeRemaining = marathoneDate - DateTime.Now;
            TimeLeft.Content = timeRemaining.Days + " дней " + timeRemaining.Hours + " часов " + timeRemaining.Minutes + " минут " + timeRemaining.Seconds + " до старта марафона";
        }

        /// <summary>
        /// Переход на предыдущую страницу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        /// <summary>
        /// Отображение кнопки назад.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BackButton.Visibility = Visibility.Visible;
            }
            else
            {
                BackButton.Visibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// Загрузка таймера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dateNow = DateTime.Now.ToLongDateString();
            dayOfWeekGet = DateTime.Now.DayOfWeek.ToString();
            dayOfWeekReturn = ConverterDaysOfWeek.ConverterMethod(dayOfWeekGet);
            DateNow.Content = dayOfWeekReturn + " " + dateNow;

            timer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 1) };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Выход из программы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите выйти?", "Предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}