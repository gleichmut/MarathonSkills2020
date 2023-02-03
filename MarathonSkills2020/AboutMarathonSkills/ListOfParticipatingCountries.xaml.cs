using System.Linq;
using System.Windows.Controls;

namespace MarathonSkills2020.AboutMarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для ListOfParticipatingCountries.xaml
    /// </summary>
    public partial class ListOfParticipatingCountries : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public ListOfParticipatingCountries()
        {
            InitializeComponent();

            //Загрузка списка стран из базы данных.
            using (MarathonEntities db = new MarathonEntities())
            {
                CountryListView.ItemsSource = db.Countries.ToList();
            }
        }
    }
}