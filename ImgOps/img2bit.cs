using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgOps
{
    class img2bit
    {
        public Tuple <Color[][], int, int> i2b(string bitmapFilePath)
        {
            Bitmap b1 = new Bitmap(bitmapFilePath);

            int height = b1.Height;
            int width = b1.Width;

            Color[][] colorMatrix = new Color[width][];
            for (int i = 0; i < width; i++)
            {
                colorMatrix[i] = new Color[height];
                for (int j = 0; j < height; j++)
                {
                    colorMatrix[i][j] = b1.GetPixel(i, j);
                }
            }
            return Tuple.Create(colorMatrix, width, height);
        }

        public void Scan(Color[][] first, int firstWidth, int firstHeight, Color[][] second, int secondWidth, int secondHeight)
        {
            int firstArrayCountX = firstWidth;
            int firstArrayCountY = firstHeight;

            int secondArrayCountX = secondWidth;
            int secondArrayCountY = secondHeight;

            Color[][] tmpArray = new Color[secondArrayCountX][];
            Bitmap Pic = new Bitmap(secondArrayCountX, secondArrayCountY, PixelFormat.Format32bppArgb);

            for (int i = 0; i < secondArrayCountX; i++)
            {
                tmpArray[i] = new Color[secondArrayCountY];
                for (int j = 0; j < secondArrayCountY; j++) 
                {
                    tmpArray[i][j] = first[i][j];
                    Pic.SetPixel(i, j, tmpArray[i][j]);
                }
            }

            //TBC
            //if (tmpArray == second) 
            //{

            //}

            Pic.Save("ciz.png");
        }
    }
}
