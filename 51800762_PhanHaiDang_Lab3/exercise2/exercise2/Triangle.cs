using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    abstract class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Color color = Color.Green;

        public void setColor(Color c)
        {
            color = c;
        }

        public void Draw(Graphics g)
        {
            drawFistLine(g);
            draw2nLine(g);
        }

        protected void drawFistLine(Graphics g)
        {
            
            g.DrawLine(new Pen(color), A, B);
        }

        protected abstract void draw2nLine(Graphics g);
    }
    // tam giac can
    class isoscelesTriangle : Triangle
    {
        protected override void draw2nLine(Graphics g)
        {
            if((A.X != B.X && A.Y != B.Y) || (A.X == B.X && A.Y != B.Y))
            {
                //Điều chỉnh C sao cho AC = BC
                Point p1 = new Point(A.X * 2 / 3 + B.X / 3, A.Y * 2 / 3 + B.Y / 3);
                Point p2 = new Point(A.X / 3 + B.X * 2 / 3, A.Y / 3 + B.Y * 2 / 3);
                Point D = new Point(A.X - p1.X, A.Y - p1.Y);

                C = new Point(Convert.ToInt32(p1.X + D.X * Math.Cos(2 * Math.PI / 3) - D.Y * Math.Sin(2 * Math.PI / 3)), Convert.ToInt32(p1.Y + D.X * Math.Sin(2 * Math.PI / 3) + D.Y * Math.Cos(2 * Math.PI / 3)));

                Console.WriteLine("A = " + A + ", B = " + B + ", C = " + C);
                g.DrawLine(new Pen(color), A, C);
                g.DrawLine(new Pen(color), B, C);
            }
            

        }
    }
    // tam giac thuong
    class norTriangle : Triangle
    {
        protected override void draw2nLine(Graphics g)
        {
            if ((A.X != B.X && A.Y != B.Y) || (A.X == B.X && A.Y != B.Y) )
            {
                C = new Point(A.X + 100, B.Y - 58);

                g.DrawLine(new Pen(color), A, C);
                g.DrawLine(new Pen(color), B, C);
            }
            
        }
    }
    //tam giac vuong
    class rightTriangle : Triangle
    {
        protected override void draw2nLine(Graphics g)
        {
            if(A.X == B.X && A.Y == B.Y)
            {

            }
            if(A.X == B.X && A.Y != B.Y)
            {
                C = new Point(A.X + 5, B.Y);
                g.DrawLine(new Pen(color), A, C);
                g.DrawLine(new Pen(color), B, C);
            }
            else
            {
                C = new Point(A.X, B.Y);
                g.DrawLine(new Pen(color), A, C);
                g.DrawLine(new Pen(color), B, C);
            }
        }

    }
}
