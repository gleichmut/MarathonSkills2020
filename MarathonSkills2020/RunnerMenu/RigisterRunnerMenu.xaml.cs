using System.Windows;
using System.Windows.Controls;

namespace MarathonSkills2020.RunnerMenu
{
    /// <summary>
    /// Логика взаимодействия для RigisterRunnerMenu.xaml
    /// </summary>
    public partial class RigisterRunnerMenu : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public RigisterRunnerMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход на страницу с авторизацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AuthorizationMenu.LoginPage());
        }

        /// <summary>
        /// Переход на страницу с регистрацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewParticipant_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RunnerRegistration());
        }

        /// <summary>
        /// Переход на страницу с авторизацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExParticipant_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AuthorizationMenu.LoginPage());
        }
    }
}
