using System.Windows.Controls;

namespace MarathonSkills2020.Charity
{
    /// <summary>
    /// Логика взаимодействия для SponsorshipConfirmation.xaml
    /// </summary>
    public partial class SponsorshipConfirmation : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public SponsorshipConfirmation()
        {
            InitializeComponent();

            RunnerName.Content = Sponsorship.runnerName;
            FondName.Content = Sponsorship.fondName;
            AmountName.Content = Sponsorship.amountName;
        }
    }
}
