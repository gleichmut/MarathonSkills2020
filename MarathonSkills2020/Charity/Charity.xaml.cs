using System.Linq;
using System.Windows.Controls;

namespace MarathonSkills2020.Charity
{
    /// <summary>
    /// Логика взаимодействия для Charity.xaml
    /// </summary>
    public partial class Charity : Page
    {
        /// <summary>
        /// Инициализация всех компонентов.
        /// </summary>
        public Charity()
        {
            InitializeComponent();

            //Вывод благотворительных организаций из базы данных.
            using (MarathonEntities db = new MarathonEntities())
            {
                CharityListView.ItemsSource = db.CharityDBs.ToList();

                foreach (var item in db.CharityDBs.ToList())
                {
                    string charityName = item.CharityName;
                    string filename = null;

                    if (charityName == "Arise")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\arise-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Arise").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Aves do Brasil")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\aves-do-brazil-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Aves do Brasil").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Clara Santos Oliveira Institute")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\clara-santos-oliveira-institute-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Clara Santos Oliveira Institute").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Conquer Cancer - Brazil")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\conquer-cancer-brazil.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Conquer Cancer - Brazil").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Diabetes Brazil")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\diabetes-brazil-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Diabetes Brazil").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Heart Health Sгo Paulo")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\heart-health-sao-paulo-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Heart Health Sгo Paulo").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Human Rights Centre  - Sгo Paulo")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\human-rights-centre-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Human Rights Centre  - Sгo Paulo").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Stay Pumped")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\stay-pumped-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Stay Pumped").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Upbeat SP")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\upbeat-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Upbeat SP").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "WWSM Rescue")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\wwsm-rescue-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "WWSM Rescue").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "The Red Cross")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\the-red-cross-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "The Red Cross").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Oxfam International")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\oxfam-international-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Oxfam International").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Save the Children Fund")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\save-the-children-fund-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Save the Children Fund").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }

                    if (charityName == "Querstadtein Berlin")
                    {
                        filename = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\marathon-skills-2016-charity-data\querstadtein-logo.png";
                        var currentCharity = db.CharityDBs.Where(c => c.CharityName == "Querstadtein Berlin").FirstOrDefault();
                        currentCharity.CharityLogo = ImagePathConverter.ImagePutter(filename); ;
                        db.SaveChanges();
                        filename = null;
                    }
                }
            }
        }
    }
}
