using System.Windows;
using System.Windows.Controls;

namespace MarathonSkills2020.CoordinatorMenu
{
    /// <summary>
    /// Логика взаимодействия для CoordinatorPage.xaml
    /// </summary>
    public partial class CoordinatorPage : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public CoordinatorPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход на страницу со списком бегунов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Runners_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ListOfRunners());
        }

        /// <summary>
        /// Переход на страницу со списком спонсоров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sponsors_Click(object sender, RoutedEventArgs e)
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
