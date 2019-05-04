using System.Drawing.Imaging;

namespace Mk0.Tools.Images
{
    public static class ImagesFormat
    {
        public static string GetImageFormat(this System.Drawing.Image img)
        {
            if (img.RawFormat.Equals(ImageFormat.Jpeg))
                return ".jpg";
            if (img.RawFormat.Equals(ImageFormat.Bmp))
                return ".bmp";
            if (img.RawFormat.Equals(ImageFormat.Png))
                return ".png";
            if (img.RawFormat.Equals(ImageFormat.Emf))
                return ".emf";
            if (img.RawFormat.Equals(ImageFormat.Exif))
                return ".exif";
            if (img.RawFormat.Equals(ImageFormat.Gif))
                return ".gif";
            if (img.RawFormat.Equals(ImageFormat.Icon))
                return ".ico";
            if (img.RawFormat.Equals(ImageFormat.MemoryBmp))
                return ".mbp";
            if (img.RawFormat.Equals(ImageFormat.Tiff))
                return ".tif";
            else
                return ".wmf";
        }
    }
}
