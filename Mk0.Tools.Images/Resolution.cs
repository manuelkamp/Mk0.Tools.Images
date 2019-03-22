using System;
using System.Drawing;

namespace Mk0.Tools.Images
{
    public class Resolution
    {
        /// <summary>
        /// Gibt die Auflösung eines Bildes zurück
        /// </summary>
        /// <param name="img">Bild</param>
        /// <returns>Auflösung</returns>
        public static string GetImageResolution(Image img)
        {
            return Math.Round((((double)img.Height * (double)img.Width) / 1000000), 2) + " MP";
        }
    }
}
