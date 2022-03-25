using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise2
{
    public partial class Form1 : Form
    {
        List<Triangle> triangles = new List<Triangle>();
        int typeTriangle = 5;
        Point tmpA ; // la noi bat dau
        Point tmpB ; // la noi ket thuc
        bool move = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            foreach (var tg in triangles)
            {
                
                tg.Draw(e.Graphics);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Runn");
        }

        private void btnVuong_Click(object sender, EventArgs e)
        {
            typeTriangle = 0;
            
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            typeTriangle = 2;
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            typeTriangle = 1;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tmpA = new Point(e.Location.X, e.Location.Y);
            move = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            tmpB = new Point(e.Location.X, e.Location.Y);
            
            runDraw(tmpA, tmpB);
            move = false;
        }

        private void runDraw(Point pointA, Point pointB)
        {
            Triangle tg;
            switch (typeTriangle)
            {
                case 0:
                    tg = new rightTriangle();
                    break;
                case 1:
                    tg = new isoscelesTriangle();
                    break;
                case 2:
                    tg = new norTriangle();
                    break;
                default:
                    tg = new norTriangle();
                    break;

            }

            tg.A = pointA;
            tg.B = pointB;
            foreach (var i in triangles)
            {

                if (i.A.X == tg.A.X )
                {
                    Console.WriteLine("Có trùng");
                    tg.setColor(Color.Red);
                }
            }
            triangles.Add(tg);
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }
    }
}
