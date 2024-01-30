using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActCentroide
{
    internal class Figura
    {
        private int lado;
        private Point[] puntos;

        public Figura()
        {
            lado = 50;
            puntos = new Point[]
            {
            new Point(0, 0),        // Esquina superior izquierda
            new Point(lado, 0),     // Esquina superior derecha
            new Point(lado, lado),  // Esquina inferior derecha
            new Point(0, lado)      // Esquina inferior izquierda
            };
        }

        public void Escalar(float factor)
        {
            // Aplicar escala a cada punto de la figura
            for (int i = 0; i < puntos.Length; i++)
            {
                puntos[i] = new Point((int)(puntos[i].X * factor), (int)(puntos[i].Y * factor));
            }
        }

        public void Render(Graphics g)
        {
            // Dibujar la figura utilizando líneas conectando los puntos
            using (Pen pen = new Pen(Brushes.Blue))
            {
                g.DrawLines(pen, puntos);
            }
        }

        public void MoverAlCentro(int canvasWidth, int canvasHeight)
        {
            // Calcular el centro del canvas
            int centerX = canvasWidth / 2;
            int centerY = canvasHeight / 2;

            // Calcular el desplazamiento necesario para centrar la figura
            int deltaX = centerX - lado / 2;
            int deltaY = centerY - lado / 2;

            // Aplicar la traslación para mover la figura al centro
            for (int i = 0; i < puntos.Length; i++)
            {
                puntos[i] = new Point(puntos[i].X + deltaX, puntos[i].Y + deltaY);
            }
        }

        // Propiedad o método para acceder a los puntos (si es necesario)
        public Point[] Puntos
        {
            get { return puntos; }
        }

    }
}

