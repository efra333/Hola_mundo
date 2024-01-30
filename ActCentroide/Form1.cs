using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActCentroide
{
    public partial class Form1 : Form
    {
        private Figura miFigura;
        static Bitmap bmp;
        private static Graphics g;

        public Form1()
        {
            InitializeComponent();
            miFigura = new Figura();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            createcartesian(g);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void createcartesian(Graphics g)
        {
            float xm = pictureBox1.Width / 2f;
            float ym = pictureBox1.Height / 2f;
            g.TranslateTransform(xm, ym);
            // Dibujar ejes del centro
            g.DrawLine(Pens.Yellow, -xm, 0, xm, 0);
            g.DrawLine(Pens.Yellow, 0, -ym, 0, ym);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Utiliza el mismo contexto de gráficos (g) para dibujar
            miFigura.Render(g);
            pictureBox1.Invalidate();  // Solicita que se repinte el PictureBox
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miFigura.MoverAlCentro(pictureBox1.Width, pictureBox1.Height);

            // Volver a dibujar el PictureBox para reflejar los cambios
            pictureBox1.Invalidate();
        }
    }
}
