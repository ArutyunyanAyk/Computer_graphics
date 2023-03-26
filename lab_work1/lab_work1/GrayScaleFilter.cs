using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;


namespace lab_work1
{
    class GrayScaleFilter : Filters
    {
        double intensity = 0;

        protected override Color calculateNewPixelColor(Bitmap sourseImage, int x, int y)
        {
           
            Color sourseColor = sourseImage.GetPixel(x, y);
            intensity = 0.36 * sourseColor.R + 0.53 * sourseColor.G + 0.11 * sourseColor.B;
            Color resultColor = Color.FromArgb((int)intensity, (int)intensity, (int)intensity);

  
            return resultColor;
        }
    }
}
