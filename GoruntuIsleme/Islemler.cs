using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GoruntuIsleme
{
    public class Islemler
    {
        public Bitmap negative(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            Color firstColor, secondColor;
            int r, g, b;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    firstColor = bitmap.GetPixel(i, j);
                    r = 255 - firstColor.R;
                    g = 255 - firstColor.G;
                    b = 255 - firstColor.B;
                    secondColor = Color.FromArgb(r, g, b);
                    result.SetPixel(i,j,secondColor);
                }
            }
            return result;
        }

        public  Bitmap grayScale(Bitmap bitmap)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            int ton;
            Color color,color2;
            
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                  ton = Convert.ToInt16(color.R * 0.299) + Convert.ToInt16(color.G * 0.587) + Convert.ToInt32(color.B * 0.114);
                   
                    color2 = Color.FromArgb(ton,ton,ton);
                    result.SetPixel(i, j, color2);
                }
            }
            return result;
        }

        public Bitmap BlackWriteScale(Bitmap bitmap,int esik)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
            
            Color color, color2;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    if (color.R >= esik)
                    {
                        color2 = Color.FromArgb(255,255,255);
                    }
                    else
                    {
                        color2 = Color.FromArgb(0, 0, 0);
                    }
                    result.SetPixel(i, j, color2);
                }
            }
            return result;
        }

        public Bitmap Brightness(Bitmap bitmap,int value)
        {
            Bitmap result = new Bitmap(bitmap.Width, bitmap.Height);
          
            Color color, color2;
            int r, g, b;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    if (color.R + value > 255)
                    {
                        r = 255;
                    }
                    else if (color.R + value < 0)
                    {
                        r = 0;
                    }
                    else 
                    {
                        r = color.R + value;
                    }

                    if (color.G + value > 255)
                    {
                        g = 255;
                    }
                    else if (color.G + value < 0)
                    {
                        g = 0;
                    }
                    else 
                    {
                        g = color.G + value;
                    }
                    if (color.B+value>255)
                    {
                        b = 255;
                    }
                    else if (color.B + value < 0)
                    {
                        b= 0;
                    }else
                    {
                        b = color.B + value;
                    }
                    

                    
                    
                  
                    color2 = Color.FromArgb(r, g, b);
                    result.SetPixel(i, j, color2);
                }
            }
            return result;
        }
    }
}
