using System.Linq;
using System.Windows.Controls;

namespace MarathonSkills2020.AdministratorMenu
{
    /// <summary>
    /// Логика взаимодействия для ListOfUsers.xaml
    /// </summary>
    public partial class ListOfUsers : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public ListOfUsers()
        {
            InitializeComponent();

            //Загрузка списка пользователей из баззы данных.
            using (MarathonEntities db = new MarathonEntities())
            {
                UsersListView.ItemsSource = db.Users.ToList();
            }
        }
    }
}
