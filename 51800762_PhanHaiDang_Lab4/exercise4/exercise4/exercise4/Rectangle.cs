using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    public abstract class Rectangle: Shape
    {
        protected Point startPoint { get; set; }
        protected float h = 0;
        protected float w = 0;
        public override void draw(Graphics graphics)
        {
            //xac dinh diem ban dau
            determinePoint();
            drawLine(graphics);
            if (customerWantsFill())
            {
                fill(graphics);
            }
            
        }
        // xac minh diem ban dau, chieu dai, chieu rong cua hinh cn
        public void determinePoint()
        {
            if (A.X < B.X && A.Y < B.Y)
            {
                startPoint = new Point(A.X, A.Y);
                h = B.Y - A.Y;
                w = B.X - A.X;
                
            }
            else if (A.X > B.X && A.Y > B.Y)
            {
                startPoint = new Point(B.X, B.Y);
                h = A.Y - B.Y;
                w = A.X - B.X;
            }
            else if (A.X > B.X && B.Y > A.Y)
            {
                startPoint = new Point(B.X, A.Y);
                h = B.Y - A.Y;
                w = A.X - B.X;
            }
            else
            {
                startPoint = new Point(A.X, B.Y);
                h = A.Y - B.Y;
                w = B.X - A.X;
            }
        }
        public abstract void drawLine(Graphics g);
        public abstract void fill(Graphics g);

        public virtual bool customerWantsFill()
        {
            return true;
        }
    }

    public class NormalRectangle : Rectangle
    {
        public override void drawLine(Graphics g)
        {
            g.DrawRectangle(new Pen(Color), startPoint.X, startPoint.Y, w, h);
        }

        public override void fill(Graphics g)
        {
           
        }
    }

    public class DashedRectangle : Rectangle
    {
        public override void drawLine(Graphics g)
        {
            float[] dashValues = { 5, 2, 15, 4 };
            Pen p = new Pen(Color);
            p.DashPattern = dashValues;
            g.DrawRectangle(p, startPoint.X, startPoint.Y, w, h);
        }

        public override void fill(Graphics g)
        {
           
        }
    }

    public class SolidRectangle : Rectangle
    {
        public override void drawLine(Graphics g)
        {
            
        }

        public override bool customerWantsFill()
        {
            return true;
        }

        public override void fill(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), startPoint.X, startPoint.Y, w, h);
        }
    }
}
