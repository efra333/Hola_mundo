using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0001
{
    public class BitProcess
    {
        //private static byte a = 3;
        private static byte r = 2;
        private static byte g = 1;
        private static byte b = 0;

        public static byte[] Invert(  byte[] bits)
        {
            int div = 16;
            Parallel.For(0, bits.Length / div, i => // unrolling 
            {
                bits[(i * div) + 0] = (byte)(255 - bits[(i * div) + 0]);
                bits[(i * div) + 1] = (byte)(255 - bits[(i * div) + 1]);
                bits[(i * div) + 2] = (byte)(255 - bits[(i * div) + 2]);
                //bits[(i * div) + 3] = (byte)(255 - bits[(i * div) + 3]);

                bits[(i * div) + 4] = (byte)(255 - bits[(i * div) + 4]);
                bits[(i * div) + 5] = (byte)(255 - bits[(i * div) + 5]);
                bits[(i * div) + 6] = (byte)(255 - bits[(i * div) + 6]);
                //bits[(i * div) + 7] = (byte)(255 - bits[(i * div) + 7]);

                bits[(i * div) + 8] = (byte)(255 - bits[(i * div) + 8]);
                bits[(i * div) + 9] = (byte)(255 - bits[(i * div) + 9]);
                bits[(i * div) + 10] = (byte)(255 - bits[(i * div) + 10]);
                //bits[(i * div) + 11] = (byte)(255 - bits[(i * div) + 11]);

                bits[(i * div) + 12] = (byte)(255 - bits[(i * div) + 12]); 
                bits[(i * div) + 13] = (byte)(255 - bits[(i * div) + 13]);
                bits[(i * div) + 14] = (byte)(255 - bits[(i * div) + 14]);
                //bits[(i * div) + 15] = (byte)(255 - bits[(i * div) + 15]);
            });

            return bits;
        }
        private static void AdjustBrightnessPixel(byte[] bits, int div, int i, int idx, int value)
        {
            int[] rgbOffsets = { r, g, b };
            for (int j = 0; j < 3; j++)
            {
                int newValue = bits[(i * div) + idx + rgbOffsets[j]] + value;
                bits[(i * div) + idx + rgbOffsets[j]] = (byte)Math.Min(255, Math.Max(0, newValue));
            }
        }

        public static byte[] AdjustBrightness(byte[] bits, int value)
        {
            int div = 16;

            Parallel.For(0, bits.Length / div, i =>
            {
                for (int j = 0; j < 4; j++)
                {
                    AdjustBrightnessPixel(bits, div, i, j * 4, value);
                }
            });

            return bits;
        }

        public static byte[] AdjustContrast(byte[] bits, float alpha)
        {
            int div = 16;

            Parallel.For(0, bits.Length / div, i =>
            {
                for (int j = 0; j < div; j += 4)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        int index = (i * div) + j + k;
                        bits[index] = AdjustComponent(bits[index], alpha);
                    }
                }
            });

            return bits;
        }

        private static byte AdjustComponent(byte original, float alpha)
        {
            float newComponent = alpha * (original - 128) + 128;
            return (byte)Math.Max(0, Math.Min(255, newComponent));
        }



        private static void GrayPixel(byte[] bits, int div, int i, int idx)
        {
            float val;

            val = bits[(i * div) + idx + r] + bits[(i * div) + idx + g] + bits[(i * div) + idx + b];
            val /= 3;

            bits[(i * div) + idx + r] = (byte)val;
            bits[(i * div) + idx + g] = (byte)val;
            bits[(i * div) + idx + b] = (byte)val;
        }

        private static void SepiaPixel(byte[] bits, int div, int i, int idx)
        {            
            int newRed;
            int newBlue;
            int newGreen;

            newRed      = (int)((bits[(i * div) + idx + r] * 0.393) + (bits[(i * div) + idx + g] * 0.769) + (bits[(i * div) + idx + b] * 0.189));
            newGreen    = (int)((bits[(i * div) + idx + r] * 0.349) + (bits[(i * div) + idx + g] * 0.686) + (bits[(i * div) + idx + b] * 0.168));
            newBlue     = (int)((bits[(i * div) + idx + r] * 0.272) + (bits[(i * div) + idx + g] * 0.534) + (bits[(i * div) + idx + b] * 0.131));

            newRed = Math.Min(255, newRed);
            newGreen = Math.Min(255, newGreen);
            newBlue = Math.Min(255, newBlue);
            
            bits[(i * div) + idx + r] = (byte)newRed;
            bits[(i * div) + idx + g] = (byte)newGreen;
            bits[(i * div) + idx + b] = (byte)newBlue;
        }
        
        public static byte[] Gray(byte[] bits)
        {
            int div = 16;
            Parallel.For(0, bits.Length / div, i => // unrolling 
            {               
                GrayPixel(bits, div, i, 0);
                GrayPixel(bits, div, i, 4);
                GrayPixel(bits, div, i, 8);
                GrayPixel(bits, div, i, 12);
            });

            return bits;
        }

        public static byte[] Sepia(byte[] bits)
        {
            int div = 16;

            Parallel.For(0, bits.Length / div, i => // unrolling 
            {
                SepiaPixel(bits, div, i, 0);
                SepiaPixel(bits, div, i, 4);
                SepiaPixel(bits, div, i, 8);
                SepiaPixel(bits, div, i, 12);
            });

            return bits;
        }
        
    }
}
