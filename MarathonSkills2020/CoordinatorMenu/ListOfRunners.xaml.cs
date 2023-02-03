using System.Linq;
using System.Windows.Controls;

namespace MarathonSkills2020.CoordinatorMenu
{
    /// <summary>
    /// Логика взаимодействия для ListOfRunners.xaml
    /// </summary>
    public partial class ListOfRunners : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public ListOfRunners()
        {
            InitializeComponent();

            //Вывод бегунов из базы данных.
            using (MarathonEntities db = new MarathonEntities())
            {
                RunnersListView.ItemsSource = db.Runners.ToList();
            }
        }
    }
}
