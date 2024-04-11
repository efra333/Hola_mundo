using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _0001
{
    internal class HistogramGraphics
    {
        public Canvas canvas;
        public HistogramGraphics(Canvas canvas)
        {
            this.canvas = canvas;
        }

        public void GraphicHistogram(List<float[]> arr)
        {
            canvas.FastClear();

            Point lowerPoint = new Point(0, (int)canvas.Height);
            Point endPoint = new Point(0, 0);

            //array is 255 long
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    endPoint = new Point(j, (int)(canvas.Height - arr[i][j] * canvas.Height));
                    lowerPoint = new Point(j, (int)canvas.Height);

                    // Imprimir puntos de inicio y fin de las líneas
                    Console.WriteLine($"Start Point: {lowerPoint}, End Point: {endPoint}");

                    Pen pen = new Pen(Color.Red, 3);
                    switch (i)
                    {
                        case 0:
                            pen = new Pen(Color.Red, 3);
                            break;
                        case 1:
                            pen = new Pen(Color.Green, 3);
                            break;
                        case 2:
                            pen = new Pen(Color.Blue, 3);
                            break;
                    }

                    canvas.g.DrawLine(pen, lowerPoint, endPoint);
                    canvas.Update(canvas.Bmp);
                }
            }
        }
        public static class ImageUtils
        {
            public static List<float[]> CalculateHistogram(Bitmap image)
            {
                int[] histogramR = new int[256];
                int[] histogramB = new int[256];
                int[] histogramG = new int[256];
                float[] normalizedHistogramR = new float[256];
                float[] normalizedHistogramG = new float[256];
                float[] normalizedHistogramB = new float[256];

                int higherR = 0;
                int higherB = 0;
                int higherG = 0;

                for (int i = 0; i < image.Width; i++)
                {
                    for (int j = 0; j < image.Height; j++)
                    {
                        Color pixel = image.GetPixel(i, j);
                        histogramR[pixel.R]++;
                        histogramG[pixel.G]++;
                        histogramB[pixel.B]++;                   

                    }
                }

                higherB = HigherVal(histogramB);
                higherG = HigherVal(histogramG);
                higherR = HigherVal(histogramR);

                for (int i = 0; i < 256; i++)
                {
                    normalizedHistogramR[i] = (float)histogramR[i] / higherR;
                    normalizedHistogramG[i] = (float)histogramB[i] / higherB;
                    normalizedHistogramB[i] = (float)histogramG[i] / higherG;
                }

                List<float[]> histogramList = new List<float[]>();
                histogramList.Add(normalizedHistogramR);
                histogramList.Add(normalizedHistogramG);
                histogramList.Add(normalizedHistogramB);

                return histogramList;
            }
        }

        public static int HigherVal(int[] arr)
        {
            int max = 0;
            for(int i = 0; i < arr.Length; i++) { 
                if(max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

    }
}
