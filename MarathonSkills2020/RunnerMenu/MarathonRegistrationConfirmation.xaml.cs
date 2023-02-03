using System.Windows;
using System.Windows.Controls;

namespace MarathonSkills2020.RunnerMenu
{
    /// <summary>
    /// Логика взаимодействия для MarathonRegistrationConfirmation.xaml
    /// </summary>
    public partial class MarathonRegistrationConfirmation : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public MarathonRegistrationConfirmation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход на страницу меню бегуна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RunnerPage());
        }
    }
}
