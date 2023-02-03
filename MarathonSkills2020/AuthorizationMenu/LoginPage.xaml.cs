using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MarathonSkills2020.AuthorizationMenu
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
            FillingRoles();
        }

        /// <summary>
        /// Заполнение списка ролей.
        /// </summary>
        private static void FillingRoles()
        {
            if (Constants.rolesList.Count == 0)
            {
                foreach (var item in MarathonEntities.GetContext().Roles.ToList())
                {
                    Constants.rolesList.Add(item.RoleId);
                }
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Вход в систему.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginIn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in MarathonEntities.GetContext().Users.ToList())
            {
                if (EmailField.Text == item.Email && PasswordField.Password == item.Password)
                {
                    string currentRole = item.RoleId;

                    switch (currentRole)
                    {
                        case "1":
                            Manager.MainFrame.Navigate(new RunnerMenu.RunnerPage());
                            break;
                        case "2":
                            Manager.MainFrame.Navigate(new CoordinatorMenu.CoordinatorPage());
                            break;
                        case "3":
                            Manager.MainFrame.Navigate(new AdministratorMenu.AdministratorPage());
                            break;
                    }
                    break;
                }
                /*else
                {
                    if (MessageBox.Show("Пользователь не найден. Зарегистрироваться?", "Предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        Manager.MainFrame.Navigate(new RunnerMenu.RunnerRegistration());
                    break;
                }*/
            }
        }

        /// <summary>
        /// Сброс полей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            EmailField.Text = null;
            PasswordField.Password = null;
        }
    }
}
