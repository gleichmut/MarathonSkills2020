using System.Windows;
using System.Windows.Controls;

namespace MarathonSkills2020.AdministratorMenu
{
    /// <summary>
    /// Логика взаимодействия для AdministratorPage.xaml
    /// </summary>
    public partial class AdministratorPage : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public AdministratorPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход на страницу со списком пользователей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Users_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ListOfUsers());
        }

        /// <summary>
        /// Переход на страницу со списком спонсоров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharityОrganisations_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RunnerMenu.ListOfSponsors());
        }

        /// <summary>
        /// Переход на страницу со списком участвующих стран.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParticipatingCountries_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AboutMarathonSkills.ListOfParticipatingCountries());
        }

        /// <summary>
        /// Переход на страницу главного меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MainMenu.MainMenuPage());
        }
    }
}
