using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_13_in_Form
{
    public partial class Form1 : Form
    {
        public static int image_count = 0;
        Graphics gr;
        Image[] img = new Image[5];
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox[] pctBox = new PictureBox[2];


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                img[i] = Image.FromFile("D:\\Франка\\2-й курс ПМа - 22\\2-й семестр\\Обчислювальна Парктика\\C_13\\C_13_in_Form\\Астон\\"+i+".jpg");
            }
            gr = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\Франка\\2-й курс ПМа - 22\\2-й семестр\\Обчислювальна Парктика\\C_13\\C_13_in_Form\\suits_charactergallery_harvey_11.JPG");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\Франка\\2-й курс ПМа - 22\\2-й семестр\\Обчислювальна Парктика\\C_13\\C_13_in_Form\\Завдання!.PNG");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            image_count++;
            
            int y = 5;
            gr.DrawImage(img[image_count], new Point(0,0));
            gr.Dispose();
        }
    }
}
