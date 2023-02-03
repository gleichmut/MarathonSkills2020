using System.Windows;
using System.Windows.Controls;

namespace MarathonSkills2020.RunnerMenu
{
    /// <summary>
    /// Логика взаимодействия для RunnerPage.xaml
    /// </summary>
    public partial class RunnerPage : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public RunnerPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход на страницу с регистрацией на марафон.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationForTheMarathon_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MarathonRegistrationPage());
        }

        /// <summary>
        /// Переход на страницу контактов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Contacts_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Contacts.ContactsPage());
        }

        /// <summary>
        /// Переход на страницу со списком спонсоров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MySponsor_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RunnerMenu.ListOfSponsors());
        }

        /// <summary>
        /// Переход на страницу с главным меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new MainMenu.MainMenuPage());
        }
    }
}
