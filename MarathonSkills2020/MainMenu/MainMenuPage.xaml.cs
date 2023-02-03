using System.Windows;
using System.Windows.Controls;

namespace MarathonSkills2020.MainMenu
{
    /// <summary>
    /// Логика взаимодействия для MainMenuPage.xaml
    /// </summary>
    public partial class MainMenuPage : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public MainMenuPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход на страницу с подробной информацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoreButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MoreInformation.MoreInformationPage());
        }

        /// <summary>
        /// Переход на страницу спонсорства.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SponsorButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Charity.Sponsorship());
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
        /// Переход на страницу бегуна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunnerButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RunnerMenu.RigisterRunnerMenu());
        }
    }
}
