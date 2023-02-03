using System.IO;

/// <summary>
/// Конвертер изображения в двоичные данные.
/// </summary>
public class ImagePathConverter
{
    /// <summary>
    /// Конвертер изображения в двоичные данные.
    /// </summary>
    /// <param name="filename">Путь к изображению.</param>
    /// <returns></returns>
    public static byte[] ImagePutter(string filename)
    {
        byte[] imageData;

        using (FileStream fs = new FileStream(filename, FileMode.Open))
        {
            imageData = new byte[fs.Length];
            fs.Read(imageData, 0, imageData.Length);
        }
        return imageData;
    }
}