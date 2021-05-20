using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoruntuIsleme
{
    public partial class Form1 : Form
    {
        Islemler GetIslemler = new Islemler();
        public Form1()
        {
            InitializeComponent();
            label1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bitmap;
            bitmap = (Bitmap) pictureBox1.Image;
            Color color = bitmap.GetPixel(e.X,e.Y);
            pictureBox2.BackColor = color;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap gelenResim;
          /*  GetIslemler.negative((Bitmap)pictureBox1.Image);
            pictureBox2.Image = gelenResim;
           */
            switch (comboBox1.SelectedItem)
            {
                case "negative":
                     gelenResim =
                           GetIslemler.negative((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = gelenResim;
                    break;
                case "grayScale":
                    gelenResim = GetIslemler.grayScale((Bitmap)pictureBox1.Image);
                    pictureBox2.Image = gelenResim;
                    break;
                case "eşikleme":
                    
                    gelenResim = GetIslemler.grayScale((Bitmap)pictureBox1.Image);
                    gelenResim = GetIslemler.BlackWriteScale((Bitmap)pictureBox1.Image, 128);
                    pictureBox2.Image = gelenResim;
                    break;
                case "BlackWriteScale":
                    gelenResim = GetIslemler.BlackWriteScale((Bitmap)pictureBox1.Image,128);
                    pictureBox2.Image = gelenResim;
                    break;
                case "brightness":
                    gelenResim = GetIslemler.Brightness((Bitmap)pictureBox1.Image,trackBar1.Value);
                    pictureBox2.Image = gelenResim;
                    break;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
