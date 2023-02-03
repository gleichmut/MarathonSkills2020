using System.Windows;
using System.Windows.Controls;

namespace MarathonSkills2020.MoreInformation
{
    /// <summary>
    /// Логика взаимодействия для MoreInformationPage.xaml
    /// </summary>
    public partial class MoreInformationPage : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public MoreInformationPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход на страницу со списком благотворительных организаций.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void СharityButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Charity.Charity());
        }

        /// <summary>
        /// Переход на страницу со BMR калькулятором.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMRButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new BMR.BMR());
        }

        /// <summary>
        /// Переход на страницу со списком BMI калькулятором.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMIButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new BMI.BMI());
        }

        /// <summary>
        /// Переход на страницу с подробной информацией о марафоне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MSButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AboutMarathonSkills.AboutMarathonSkills());
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
    }
}
