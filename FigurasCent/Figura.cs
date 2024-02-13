using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasCent
{
    public class Figura
    {
        public PointF Centroid { get; private set; }
        public List<PointF> Puntos { get; private set; }
        private List<PointF> puntosOriginales;
        public Figura(List<PointF> puntos)
        {
            Puntos = puntos;
            puntosOriginales = new List<PointF>(puntos);
            CalcularCentroide();
        }
        public void Reiniciar()
        {
            // Restablecer los puntos a los puntos originales
            Puntos.Clear();
            Puntos.AddRange(puntosOriginales);
        }
        public void Rotar(float grados)
        {
            for (int i = 0; i < Puntos.Count; i++)
            {
                Puntos[i] = RotarPunto(Puntos[i], Centroid, grados);
            }
            CalcularCentroide();
        }
        public void Escalar(float factor)
        {
            for (int i = 0; i < Puntos.Count; i++)
            {
                Puntos[i] = EscalarPunto(Puntos[i], Centroid, factor);
            }
            CalcularCentroide();
        }
        public void Trasladar(float deltaX, float deltaY)
        {
            for (int i = 0; i < Puntos.Count; i++)
            {
                Puntos[i] = new PointF(Puntos[i].X + deltaX, Puntos[i].Y + deltaY);
            }
            CalcularCentroide();
        }
        private void CalcularCentroide()
        {
            float sumX = 0, sumY = 0;
            foreach (var punto in Puntos)
            {
                sumX += punto.X;
                sumY += punto.Y;
            }
            Centroid = new PointF(sumX / Puntos.Count, sumY / Puntos.Count);
        }
        public void CentrarEnCanvas(float canvasWidth, float canvasHeight)
        {
            // Calcular el centro del canvas
            float canvasCenterX = canvasWidth / 2f;
            float canvasCenterY = canvasHeight / 2f;

            // Calcular el desplazamiento necesario para centrar la figura en el canvas
            float deltaX = canvasCenterX - Centroid.X;
            float deltaY = canvasCenterY - Centroid.Y;

            // Trasladar la figura para centrarla
            Trasladar(deltaX, deltaY);
        }

        private PointF RotarPunto(PointF punto, PointF centro, float angulo)
        {
            float x = centro.X + (float)((punto.X - centro.X) * Math.Cos(angulo) - (punto.Y - centro.Y) * Math.Sin(angulo));
            float y = centro.Y + (float)((punto.X - centro.X) * Math.Sin(angulo) + (punto.Y - centro.Y) * Math.Cos(angulo));
            return new PointF(x, y);
        }

        private PointF EscalarPunto(PointF punto, PointF centro, float factor)
        {
            float x = centro.X + (punto.X - centro.X) * factor;
            float y = centro.Y + (punto.Y - centro.Y) * factor;
            return new PointF(x, y);
        }
    }
}

