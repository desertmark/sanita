using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace Sanita.Tools
{
    public abstract class ImageResizer
    {
        public static Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((System.Drawing.Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }
        public static Bitmap ResizeBitmap(Bitmap b, int nWidth)
        {
            //El Height adecuado para un dado Width se obtiene de dividir el nuevo width por el aspectRatio
            double AspectRatio = (double)b.Width / (double)b.Height;
            int nHeight = (int)Math.Truncate(nWidth / AspectRatio);
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((System.Drawing.Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }
    }
}