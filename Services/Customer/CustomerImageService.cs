using System.Drawing;
using System.IO;

namespace VRMS.UI.Services;

public class CustomerImageService
{
    public Image? LoadImage(string relativePath)
    {
        if (string.IsNullOrWhiteSpace(relativePath) ||
            relativePath.StartsWith("Assets/", StringComparison.OrdinalIgnoreCase))
            return null;

        var fullPath = Path.Combine("Storage", relativePath);
        if (!File.Exists(fullPath))
            return null;

        using var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
        using var img = Image.FromStream(fs);
        return new Bitmap(img);
    }

    public MemoryStream ImageToStream(Image image)
    {
        var ms = new MemoryStream();
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        ms.Position = 0;
        return ms;
    }

    public void SetPictureBoxImage(PictureBox pb, string relativePath)
    {
        pb.Image = LoadImage(relativePath);
    }
}