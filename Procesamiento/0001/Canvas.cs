using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0001
{
    public class Canvas
    {
        private Bitmap bmp;
        private byte[] bits;

        public byte[] Bits
        {
            get { return bits; }
            set { 
                bits = value; 
               if(pct != null)
                pct.Invalidate();
            }
        }
        PictureBox pct;
        private int pixelFormatSize, stride;

        public Graphics g;
        public float Width, Height;

        public Bitmap Bmp
        {
            get { return bmp; }
            set {
               
                bmp = value;
                Init(bmp);
                pct.Image = bmp;
                pct.Invalidate();
            }
        }
        public Canvas(PictureBox pct)
        {
            Init(pct.Width, pct.Height);
            this.pct = pct;
        }

        private void Init(Bitmap loadedImage)
        {
            PixelFormat format;
            GCHandle handle;
            IntPtr bitPtr;
            int padding;
            int width, height;
            int pixelFormatSize;
            int stride;

            format = PixelFormat.Format32bppArgb;
            width = loadedImage.Width;
            height = loadedImage.Height;
            pixelFormatSize = Image.GetPixelFormatSize(format) / 8; // 8 bits = 1 byte
            stride = width * pixelFormatSize; // total pixels (width) times ARGB (4)
            padding = (stride % 4); // PADD = move every pixel in bytes
            stride += padding == 0 ? 0 : 4 - padding; // pad out to multiple of 4 byte Alpha, Red, Green, Blue
            Bits = new byte[stride * height];

            // Bloquear la imagen cargada para acceder a los datos de los píxeles
            BitmapData bmpData = loadedImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, format);

            // Copiar los datos de los píxeles al arreglo de bytes 'Bits'
            Marshal.Copy(bmpData.Scan0, Bits, 0, Bits.Length);

            // Desbloquear la imagen cargada
            loadedImage.UnlockBits(bmpData);

            // Crear un nuevo Bitmap a partir del arreglo de bytes 'Bits'
            handle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            bitPtr = Marshal.UnsafeAddrOfPinnedArrayElement(Bits, 0);
            if (bmp != null) bmp.Dispose(); // Asegúrate de desechar el Bitmap anterior para evitar fugas de memoria
                bmp = new Bitmap(width, height, stride, format, bitPtr);
            g = Graphics.FromImage(bmp);          
        }


        private void Init(int width, int height)
        {
            PixelFormat format;
            GCHandle handle;
            IntPtr bitPtr;
            int padding;

            format          = PixelFormat.Format32bppArgb;
            Width           = width;
            Height          = height;
            pixelFormatSize = Image.GetPixelFormatSize(format) / 8;             // 8 bits = 1 byte
            stride = width * pixelFormatSize;                          // total pixels (width) times ARGB (4)
            padding = (stride % 4);                                     // PADD = move every pixel in bytes
            stride += padding == 0 ? 0 : 4 - padding;                  // pad out to multiple of 4 byte Alpha, Red, Green, Blue
            Bits = new byte[stride * height];
            handle = GCHandle.Alloc(Bits, GCHandleType.Pinned);        // TO LOCK THE MEMORY FOR GB
            bitPtr = Marshal.UnsafeAddrOfPinnedArrayElement(Bits, 0);

            if (bmp == null)
                bmp = new Bitmap(width, height, stride, format, bitPtr);

            g = Graphics.FromImage(bmp);
        }
        
        public void PutPixel(int x, int y, Color c)
        {
            int res;
          
            if (x < 0 || x >= Width || y < 0 || y >= Height)
                return;

            res = (int)((x * pixelFormatSize) + (y * stride));

            Bits[res + 0] = c.B;// (byte)Blue;
            Bits[res + 1] = c.G;// (byte)Green;
            Bits[res + 2] = c.R;// (byte)Red;
            Bits[res + 3] = c.A;// (byte)ALPHA;
        }

        public void FastClear()
        {
            int div = 16;
            Parallel.For(0, Bits.Length / div, i => // unrolling 
            {
                Bits[(i * div) + 0] = 0;
                Bits[(i * div) + 1] = 0;
                Bits[(i * div) + 2] = 0;
                Bits[(i * div) + 3] = 0;

                Bits[(i * div) + 4] = 0;
                Bits[(i * div) + 5] = 0;
                Bits[(i * div) + 6] = 0;
                Bits[(i * div) + 7] = 0;

                Bits[(i * div) + 8] = 0;
                Bits[(i * div) + 9] = 0;
                Bits[(i * div) + 10] = 0;
                Bits[(i * div) + 11] = 0;

                Bits[(i * div) + 12] = 0;
                Bits[(i * div) + 13] = 0;
                Bits[(i * div) + 14] = 0;
                Bits[(i * div) + 15] = 0;
            });
        }

        public void Update(Bitmap bmp)
        {
            pct.Image = bmp;
            pct.Invalidate();
        }
    }
}
