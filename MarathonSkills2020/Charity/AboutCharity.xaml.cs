using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MarathonSkills2020.Charity
{
    /// <summary>
    /// Логика взаимодействия для AboutCharity.xaml
    /// </summary>
    public partial class AboutCharity : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public AboutCharity()
        {
            InitializeComponent();

            CharityName.Content = Sponsorship.charity;

            //Вывод благотворительных организаций из базы данных.
            using (MarathonEntities db = new MarathonEntities())
            {
                foreach (var item in db.CharityDBs.Where(p => p.CharityName == Sponsorship.charity))
                {
                    CharityDescription.Text = item.CharityDescription;

                    //Преобразование двоичных данных в изображение.
                    MemoryStream ms = new MemoryStream(item.CharityLogo, 0, item.CharityLogo.Length);
                    ms.Write(item.CharityLogo, 0, item.CharityLogo.Length);
                    BitmapImage image = new BitmapImage();
                    image.BeginInit();
                    image.StreamSource = ms;
                    image.EndInit();
                    CharityLogo.Source = image;
                }
            }
        }
    }
}
