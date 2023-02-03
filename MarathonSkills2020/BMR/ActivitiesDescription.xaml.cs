using System.Collections.Generic;
using System.Windows.Controls;

namespace MarathonSkills2020.BMR
{
    /// <summary>
    /// Логика взаимодействия для ActivitiesDescription.xaml
    /// </summary>
    public partial class ActivitiesDescription : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public ActivitiesDescription()
        {
            InitializeComponent();

            List<Activities> activitiesList = new List<Activities>
            {
                new Activities("Сидячий образ", "Нет работы или работа за столом."),
                new Activities("Маленькая активность", "Мало физической работы или занятия спортом 1-3 раза в неделю."),
                new Activities("Средняя активность", "Умеренная физическая работа или занятия спортом 3-5 дней в неделю."),
                new Activities("Сильная активность", "Сильная физическая нагрузка или занятия спортом 6-7 дней в неделю."),
                new Activities("Максимальная активность", "Сильная ежедневная физическая нагрузка или спорт и физическая работа.")
            };

            ListViewActivities.ItemsSource = activitiesList;
        }
    }
}
