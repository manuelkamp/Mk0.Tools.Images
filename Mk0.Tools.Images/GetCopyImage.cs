using System.Drawing;

namespace Mk0.Tools.Images
{
    public class CopyImage
    {
        /// <summary>
        /// Helfer-Methode um eine Kopie eines Bildes zu erzeugen für Banner, weil es bei Anzeige im Banner nicht mehr am ursprünglichen Speicherort ist
        /// </summary>
        /// <param name="path">Pfad des Bildes</param>
        /// <returns>Kopie des Bildes</returns>
        public static Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }
    }
}
