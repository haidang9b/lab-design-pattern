using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    public abstract class Circle: Shape
    {
        protected RectangleF rect;
        public override void draw(Graphics graphics)
        {
            // xac dinh hinh cn
            determineRectangle();
            drawLine(graphics);
            if (customerWantsFill())
            {
                fill(graphics);
            }
            
        }

        public void determineRectangle()
        {
            var r = (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
            rect = new RectangleF(A.X - r, A.Y - r, r * 2, r * 2);
        }

        public abstract void drawLine(Graphics g);
        public abstract void fill(Graphics g);
        public virtual bool customerWantsFill()
        {
            return true;
        }
    }

    public class NormalCircle : Circle
    {
        public override void drawLine(Graphics g)
        {
            g.DrawEllipse(new Pen(Color), rect);
        }

        public override void fill(Graphics g)
        {
            
        }
    }

    public class SolidCircle : Circle
    {
        public override void drawLine(Graphics g)
        {
            
        }

        public override void fill(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), rect);
        }
        public override bool customerWantsFill()
        {
            return true;
        }
    }

    public class DashedCircle : Circle
    {
        public override void drawLine(Graphics g)
        {
            float[] dashValues = { 5, 2, 15, 4 };
            Pen p = new Pen(Color);
            p.DashPattern = dashValues;
            g.DrawEllipse(p, rect);
        }

        public override void fill(Graphics g)
        {
           
        }
    }
}
