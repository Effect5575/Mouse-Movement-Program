using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Dark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //while (true)
            //{
            //    //  pozisyonunu al
            //    Point currentPosition = Cursor.Position;

            //    //  bir pozisyon oluştur
            //    Point newPosition = new Point(currentPosition.X + 1, currentPosition.Y + 1);

            //    //  pozisyona fareyi taşı
            //    Cursor.Position = newPosition;

            //    // bekleme (3000 milisaniye)
            //    System.Threading.Thread.Sleep(3000);
            //}
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            int directionX = 1; 
            int directionY = 1; 

            while (true)
            {
                Point currentPosition = Cursor.Position;

                int newX = currentPosition.X + directionX;
                int newY = currentPosition.Y + directionY;

                if (newX <= 0 || newX >= screenWidth)
                {
                    directionX *= -1; 
                }

                if (newY <= 0 || newY >= screenHeight)
                {
                    directionY *= -1; 
                }

                Cursor.Position = new Point(newX, newY);

                System.Threading.Thread.Sleep(3000);

            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}
