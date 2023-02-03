using System.Linq;
using System.Windows.Controls;

namespace MarathonSkills2020.RunnerMenu
{
    /// <summary>
    /// Логика взаимодействия для ListOfSponsors.xaml
    /// </summary>
    public partial class ListOfSponsors : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public ListOfSponsors()
        {
            InitializeComponent();

            //Вывод спонсоров из базы данных.
            using (MarathonEntities db = new MarathonEntities())
            {
                SponsorsListView.ItemsSource = db.Sponsorships.ToList();
            }
        }
    }
}
