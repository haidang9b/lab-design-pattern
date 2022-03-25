using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    public abstract class Square: Shape
    {
        protected float edge;
        
        public override void draw(Graphics graphics)
        {
            // xac dinh canh
            determineEdge();
            drawLine(graphics);
            if (customerWantsFill())
            {
                fill(graphics);
            }
        }
        public void determineEdge()
        {
            float h = Math.Abs(A.Y - B.Y);
            float w = Math.Abs(A.X - B.X);
            if (h > w)
            {
                edge = h;
            }
            else
            {
                edge = w;
            }
        }
        public abstract void drawLine(Graphics g);
        public abstract void fill(Graphics g);
        public virtual bool customerWantsFill()
        {
            return false;
        }
    }

    public class NormalSquare : Square
    {
        public override void drawLine(Graphics g)
        {
            g.DrawRectangle(new Pen(Color), A.X, A.Y, edge, edge);
        }

        public override void fill(Graphics g)
        {
            
        }
    }

    public class DashedSquare : Square
    {
        public override void drawLine(Graphics g)
        {
            
            float[] dashValues = { 5, 2, 15, 4 };
            Pen p = new Pen(Color);
            p.DashPattern = dashValues;
            g.DrawRectangle(p, A.X, A.Y, edge, edge);
        }

        public override void fill(Graphics g)
        {
            
        }
    }

    public class SolidSquare : Square
    {
        public override void drawLine(Graphics g)
        {
            
        }

        public override void fill(Graphics g)
        {
            var rect = new RectangleF(A.X, A.Y, edge, edge);
            g.FillRectangle(new SolidBrush(Color), rect);
        }
        public override bool customerWantsFill()
        {
            return true;
        }
    }
}
