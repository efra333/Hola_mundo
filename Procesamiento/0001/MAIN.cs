using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;
using static _0001.HistogramGraphics;

namespace _0001
{
    public partial class MAIN : Form
    {
        Bitmap bmp;
        Canvas canvas;
        FileInfo info;
        //CODIGO PARA GRAFICAR HISTOGRAMA
        Canvas histogramCanvas;
        HistogramGraphics histogramGraphics;
        //
        public MAIN()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            canvas = new Canvas(PCT_CANVAS);

            //CODIGO PARA GRAFICAR HISTOGRAMA
            histogramCanvas = new Canvas(pictureBoxH);
            histogramCanvas.Bmp = new Bitmap(pictureBoxH.Width,pictureBoxH.Height);
            histogramGraphics = new HistogramGraphics(histogramCanvas);
   
            //
        }

        //CODIGO PARA GRAFICAR HISTOGRAMA
        private void Histograma_Click(object sender, EventArgs e)
        {
            /*float[] arrayExample1 = new float[255];
            float[] arrayExample2 = new float[255];
            float[] arrayExample3 = new float[255];

            Random random = new Random();
            for(int i = 0; i < 255; i ++)
            {
                arrayExample1[i] = (float)random.Next(125, 249) / 255;
            }
            for (int i = 0; i < 255; i++)
            {
                arrayExample2[i] = (float)random.Next(125, 249) / 255;
            }
            for (int i = 0; i < 255; i++)
            {
                arrayExample3[i] = (float)random.Next(125, 249) / 255;
            }

            List<float[]> floatList = new List<float[]>();
            floatList.Add(arrayExample1);
            floatList.Add(arrayExample2);
            floatList.Add(arrayExample3);

            histogramGraphics.GraphicHistogram(floatList);
        */

            if (bmp == null)  // Verificamos que tengas una imagen cargada
            {
                MessageBox.Show("Carga una imagen primero");
                return;
            }

            histogramCanvas.FastClear(); // Limpia el canvas del histograma
            List<float[]> histogramData = ImageUtils.CalculateHistogram(bmp);
            histogramGraphics.GraphicHistogram(histogramData);

        }
        //


        private void BTN_EXE_Click(object sender, EventArgs e)
        {               
            using (var previewDialog = FormPreviewDialog.Dialog)
            {               
                previewDialog.ShowDialog();
                if (previewDialog.Result== DialogResult.OK)
                {
                    // Carga y muestra la imagen seleccionada en tu aplicación principal
                    info                = new FileInfo(previewDialog.SelectedImagePath);
                    canvas.Bmp          = new Bitmap(previewDialog.SelectedImagePath);
                    bmp                 = new Bitmap(previewDialog.SelectedImagePath);
                    PCT_THUMBNAIL.Image = bmp;
                }
            }//*/
        }

        private void BTN_INVERT_Click(object sender, EventArgs e)
        {
            canvas.Bits = BitProcess.Invert(canvas.Bits);
        }

        private void BTN_SEPIA_Click(object sender, EventArgs e)
        {
            canvas.Bits = BitProcess.Sepia(canvas.Bits);
        }

        private void BTN_GRAY_Click(object sender, EventArgs e)
        {
            canvas.Bits = BitProcess.Gray(canvas.Bits);
        }

        private void BTN_RELOAD_Click(object sender, EventArgs e)
        {
            canvas.Bmp = new Bitmap(bmp);
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            canvas.Bmp.Save(@info.Name, ImageFormat.Png);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr;
            int S;
            Random rnd;
            Color colorAleatorio;
            int r, g, b;
            Brush brush;

            S       = 200;
            bmp     = new Bitmap(S, S);
            gr      = Graphics.FromImage(bmp);
            rnd     = new Random();
            info    = new FileInfo("SQUARES.PNG");

            for (int x = 0; x < S; x++)
            {
                for (int y = 0; y < S; y++)
                {
                    r = rnd.Next(256);
                    g = rnd.Next(256);
                    b = rnd.Next(256);
                    colorAleatorio = Color.FromArgb(255, r, g, b);
                    brush = new SolidBrush(colorAleatorio);

                    gr.FillRectangle(brush, x * 10, y * 10, 10, 10);
                    gr.DrawRectangle(Pens.Gray, x * 10, y * 10, 10, 10);
                }
            }
            gr.DrawRectangle(Pens.Gray, 0, 0, S-1, S-1);
            
            canvas.Bmp = bmp;
            PCT_THUMBNAIL.Image = canvas.Bmp;
        }

       

       


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PNL_HEAD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int adjustment = 10;
            canvas.Bits = BitProcess.AdjustBrightness(canvas.Bits, adjustment);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int adjustment = -10;
            canvas.Bits = BitProcess.AdjustBrightness(canvas.Bits, adjustment);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float alpha = 1.5f;
            canvas.Bits = BitProcess.AdjustContrast(canvas.Bits, alpha);
        }
    }
}
