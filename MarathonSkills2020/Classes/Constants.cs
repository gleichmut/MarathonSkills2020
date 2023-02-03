using MarathonSkills2020;
using System.Collections.Generic;

/// <summary>
/// Константы.
/// </summary>
public class Constants
{
    /// <summary>
    /// Пол мужской.
    /// </summary>
    public static string MALE = "Мужской";
    /// <summary>
    /// Пол женский.
    /// </summary>
    public static string FEMALE = "Женский";
    /// <summary>
    /// Список ролей.
    /// </summary>
    public static List<string> rolesList = new List<string>();
    /// <summary>
    /// Список благотворительных организаций.
    /// </summary>
    public static List<string> charityList = new List<string> { "Arise", "Aves do Brasil", "Clara Santos Oliveira Institute",
        "Conquer Cancer - Brazil", "Diabetes Brazil", "Heart Health Sгo Paulo", "Human Rights Centre  - Sгo Paulo", "Stay Pumped",
        "Upbeat SP", "WWSM Rescue", "The Red Cross", "Oxfam International", "Save the Children Fund", "Querstadtein Berlin" };
    /// <summary>
    /// Список стран.
    /// </summary>
    public static List<Country> countries = new List<Country>();

    /// <summary>
    /// Заполнение списка стран.
    /// </summary>
    public static void FillCountries()
    {
        string filenameAustralia, filenameAustria, filenameBelgium, filenameSwitzerland, filenameGermany, filenameDenmark,
               filenameSpain, filenameFinland, filenameFrance, filenameGreece, filenameHungary, filenameIreland, filenameLatvia,
               filenameItaly, filenameJapan, filenameIndia, filenameVietnam, filenameRussia, filenameMexico, filenameNorway, filenamePoland,
               filenamePortugal, filenameSweden, filenameTurkey;

        byte[] imageAustralia, imageAustria, imageBelgium, imageSwitzerland, imageGermany, imageDenmark,
               imageSpain, imageFinland, imageFrance, imageGreece, imageHungary, imageIreland, imageLatvia,
               imageItaly, imageJapan, imageIndia, imageVietnam, imageRussia, imageMexico, imageNorway, imagePoland,
               imagePortugal, imageSweden, imageTurkey;

        filenameAustralia = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_australia.png";
        filenameAustria = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_austria.png";
        filenameBelgium = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_belgium.png";
        filenameSwitzerland = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_switzerland.png";
        filenameGermany = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_germany.png";
        filenameDenmark = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_denmark.png";
        filenameSpain = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_spain.png";
        filenameFinland = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_finland.png";
        filenameFrance = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_france.png";
        filenameGreece = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_greece.png";
        filenameHungary = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_hungary.png";
        filenameIreland = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_ireland.png";
        filenameLatvia = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_latvia.png";
        filenameItaly = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_italy.png";
        filenameJapan = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_japan.png";
        filenameIndia = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_india.png";
        filenameVietnam = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_vietnam.png";
        filenameRussia = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_russia.png";
        filenameMexico = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_mexico.png";
        filenameNorway = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_norway.png";
        filenamePoland = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_poland.png";
        filenamePortugal = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_portugal.png";
        filenameSweden = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_sweden.png";
        filenameTurkey = @"F:\mpt\3 курс 4 семестр\wsr_podgotovka\TP09_resources\WSR2016_TP09_общие_ресурсы\flags\flag_turkey.png";

        imageAustralia = ImagePathConverter.ImagePutter(filenameAustralia);
        imageAustria = ImagePathConverter.ImagePutter(filenameAustria);
        imageBelgium = ImagePathConverter.ImagePutter(filenameBelgium);
        imageSwitzerland = ImagePathConverter.ImagePutter(filenameSwitzerland);
        imageGermany = ImagePathConverter.ImagePutter(filenameGermany);
        imageDenmark = ImagePathConverter.ImagePutter(filenameDenmark);
        imageSpain = ImagePathConverter.ImagePutter(filenameSpain);
        imageFinland = ImagePathConverter.ImagePutter(filenameFinland);
        imageFrance = ImagePathConverter.ImagePutter(filenameFrance);
        imageGreece = ImagePathConverter.ImagePutter(filenameGreece);
        imageHungary = ImagePathConverter.ImagePutter(filenameHungary);
        imageIreland = ImagePathConverter.ImagePutter(filenameIreland);
        imageLatvia = ImagePathConverter.ImagePutter(filenameLatvia);
        imageItaly = ImagePathConverter.ImagePutter(filenameItaly);
        imageJapan = ImagePathConverter.ImagePutter(filenameJapan);
        imageIndia = ImagePathConverter.ImagePutter(filenameIndia);
        imageVietnam = ImagePathConverter.ImagePutter(filenameVietnam);
        imageRussia = ImagePathConverter.ImagePutter(filenameRussia);
        imageMexico = ImagePathConverter.ImagePutter(filenameMexico);
        imageNorway = ImagePathConverter.ImagePutter(filenameNorway);
        imagePoland = ImagePathConverter.ImagePutter(filenamePoland);
        imagePortugal = ImagePathConverter.ImagePutter(filenamePortugal);
        imageSweden = ImagePathConverter.ImagePutter(filenameSweden);
        imageTurkey = ImagePathConverter.ImagePutter(filenameTurkey);

        Country Australia = new Country("AUS", "Австралия", imageAustralia);
        Country Austria = new Country("AUT", "Австрия", imageAustria);
        Country Belgium = new Country("BEL", "Бельгия", imageBelgium);
        Country Switzerland = new Country("CHE", "Швейцария", imageSwitzerland);
        Country Germany = new Country("DEU", "Германия", imageGermany);
        Country Denmark = new Country("DNK", "Дания", imageDenmark);
        Country Spain = new Country("ESP", "Испания", imageSpain);
        Country Finland = new Country("FIN", "Финляндия", imageFinland);
        Country France = new Country("FRA", "Франция", imageFrance);
        Country Greece = new Country("GRC", "Греция", imageGreece);
        Country Hungary = new Country("HUN", "Венгрия", imageHungary);
        Country Ireland = new Country("IRL", "Ирландия", imageIreland);
        Country Latvia = new Country("LTV", "Латвия", imageLatvia);
        Country Italy = new Country("ITA", "Италия", imageItaly);
        Country Japan = new Country("JPN", "Япония", imageJapan);
        Country India = new Country("IND", "Индия", imageIndia);
        Country Vietnam = new Country("VTM", "Вьетнам", imageVietnam);
        Country Russia = new Country("RUS", "Россия", imageRussia);
        Country Mexico = new Country("MEX", "Мексика", imageMexico);
        Country Norway = new Country("NOR", "Норвегия", imageNorway);
        Country Poland = new Country("POL", "Польша", imagePoland);
        Country Portugal = new Country("PRT", "Португалия", imagePortugal);
        Country Sweden = new Country("SWE", "Швеция", imageSweden);
        Country Turkey = new Country("TUR", "Турция", imageTurkey);

        using (MarathonEntities db = new MarathonEntities())
        {
            db.Countries.AddRange(new List<Country> { Australia, Austria, Belgium, Switzerland, Germany, Denmark, Spain, Finland, France, Greece, Hungary,
                Ireland, Latvia, Italy, Japan, India, Vietnam, Russia, Mexico, Norway, Poland, Portugal, Sweden, Turkey});
            db.SaveChanges();
        }
    }
}
