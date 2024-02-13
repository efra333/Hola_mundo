using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FigurasCent
{
    public partial class Form1 : Form
    {
        private Canvas canvas;
        private float angulo;
        private float escalar;
        
        private List<Figura> figuras;
        private Figura figuraSeleccionada;
        private PointF desplazamiento = new PointF(0, 0);
        static Bitmap bmp;
        static Graphics g;

       

        public Form1()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            pictureBox1.Paint += pictureBox1_Paint;
           

            timer1 = new Timer();
            timer1.Interval = 50; 
            timer1.Tick +=Timer1_Tick;
          

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            canvas = new Canvas(bmp);
            figuras = new List<Figura>();
            AgregarCuadrado();
            AgregarTriangulo();
            AgregarRomboide();
            AgregarRectangulo();

            comboBox1.Items.Add("Cuadrado");
            comboBox1.Items.Add("Triángulo");
            comboBox1.Items.Add("Romboide");
            comboBox1.Items.Add("Rectángulo");

         
            comboBox1.SelectedIndexChanged += ComboBoxFiguras_SelectedIndexChanged;

            comboBox1.SelectedIndex = 0;

          
            Render();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Render();
            
        }


        private void AgregarCuadrado()
        {
            List<PointF> puntosCuadrado = new List<PointF>
        {
            new PointF(-60, -60),
            new PointF(-60, 60),
            new PointF(60, 60),
            new PointF(60, -60)
        };
            Figura cuadrado = new Figura(puntosCuadrado);
            figuras.Add(cuadrado);
        }

        private void AgregarTriangulo()
        {
            List<PointF> puntosTriangulo = new List<PointF>
        {
            new PointF(-30, -30),
            new PointF(30, -30),
            new PointF(0, 30)
        };
            Figura triangulo = new Figura(puntosTriangulo);
            figuras.Add(triangulo);
        }
        private void AgregarRomboide()
        {
            List<PointF> puntosRomboide = new List<PointF>
        {
            new PointF(-40, -40),
            new PointF(-50, 50),
            new PointF(40, 40),
            new PointF(50, -50)
        };
            Figura cuadrado = new Figura(puntosRomboide);
            figuras.Add(cuadrado);
        }
        private void AgregarRectangulo()
        {
            List<PointF> puntosRectangulo = new List<PointF>
        {
          new PointF(-40, -50),
        new PointF(50, -50),
        new PointF(50, 50),
        new PointF(-40, 50),
        new PointF(-40, -50)
        };
            Figura cuadrado = new Figura(puntosRectangulo);
            figuras.Add(cuadrado);
        }



        private void ComboBoxFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int indiceSeleccionado = comboBox1.SelectedIndex;

           
            if (indiceSeleccionado >= 0 && indiceSeleccionado < figuras.Count)
            {
                
                figuraSeleccionada = figuras[indiceSeleccionado];

             
                Render();

            }
        }

       


        private void Render()
        {
            canvas.Clear();
       

          
            for (int i = 0; i < figuraSeleccionada.Puntos.Count - 1; i++)
            {
                canvas.DrawLine(figuraSeleccionada.Puntos[i], figuraSeleccionada.Puntos[i + 1], Pens.White);
            }
            canvas.DrawLine(figuraSeleccionada.Puntos[figuraSeleccionada.Puntos.Count - 1], figuraSeleccionada.Puntos[0], Pens.White);

           
          
            pictureBox1.Invalidate();

        }
        private void mapaCartesiano(Graphics g)
        {
            float xm = pictureBox1.Width / 2f;
            float ym = pictureBox1.Height / 2f;
            g.TranslateTransform(xm, ym);
           
            g.DrawLine(Pens.Yellow, -xm, 0, xm, 0);
            g.DrawLine(Pens.Yellow, 0, -ym, 0, ym);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
                      figuraSeleccionada.Trasladar(desplazamiento.X,desplazamiento.Y);

            Render();
        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            mapaCartesiano(e.Graphics);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                
                MessageBox.Show("Por favor, ingresa el valor del ángulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            angulo = float.Parse(textBox1.Text);
            figuraSeleccionada.Rotar(angulo);

         
            Render();
        }
        private void button3_Click(object sender, EventArgs e)
        {
           

            figuraSeleccionada.CentrarEnCanvas(pictureBox1.Width, pictureBox1.Height);
            Render();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {

                MessageBox.Show("Por favor, ingresa el valor ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            escalar = float.Parse(textBox2.Text);
            figuraSeleccionada.Escalar(escalar);
            Render();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            desplazamiento= new PointF(-1, 0);
            timer1.Start();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            desplazamiento = new PointF(1, 0);
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Stop();
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            desplazamiento = new PointF(0, -1);
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            desplazamiento = new PointF(0, 1);
            timer1.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {


           
            figuraSeleccionada.Reiniciar();
            Render();


        }
    }
}
