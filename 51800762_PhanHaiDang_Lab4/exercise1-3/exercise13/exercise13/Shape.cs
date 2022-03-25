using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise13
{
    enum ShapeType
    {
        Circle,
        SolidCircle,
        Rectangle,
        SolidRectangle,
        Squares
    }

    class ShapeFactory
    {
        //ap singleton vao lop nay
        private static ShapeFactory instance;
        public static ShapeFactory Instance
        {
            get
            {
                if (instance == null)
                    instance = new ShapeFactory();
                return instance;
            }
            private set { instance = value; }
        }

        public Shape CreateShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.SolidCircle:
                    return new SolidCircle();
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.SolidRectangle:
                    return new SolidRectangle();
                case ShapeType.Squares:
                    return new Squares();
            }
            return null;
        }
    }
    abstract class Shape
    {
        public Color Color { get; set; } = Color.Black;
        public Point A { get; set; }
        public Point B { get; set; }
        public abstract void draw(Graphics g);

    }

    class Circle : Shape
    {
        public override void draw(Graphics g)
        {
            var r = (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
            var rect = new RectangleF(A.X-r,A.Y-r,r*2,r*2);
            g.DrawEllipse(new Pen(Color), rect);
        }
    }
    class SolidCircle : Shape
    { 
        public override void draw(Graphics g)
        {
            var r = (float)Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
            var rect = new RectangleF(A.X - r, A.Y - r, r * 2, r * 2);
            g.FillEllipse(new SolidBrush(Color), rect);
        }
    }
    class Rectangle : Shape
    {
        public override void draw(Graphics g)
        {
            if (A.X < B.X && A.Y < B.Y)
            {
                g.DrawRectangle(new Pen(Color), A.X, A.Y, B.X - A.X, B.Y - A.Y);
            }
            else if (A.X > B.X && A.Y > B.Y)
            {
                g.DrawRectangle(new Pen(Color), B.X, B.Y, A.X - B.X, A.Y - B.Y);
            }
            else if (A.X > B.X && B.Y > A.Y)
            {
                g.DrawRectangle(new Pen(Color), B.X, A.Y, A.X - B.X, B.Y - A.Y);
            }
            else
            {
                g.DrawRectangle(new Pen(Color), A.X, B.Y, B.X - A.X, A.Y - B.Y);
            }
        }
    }
    class SolidRectangle : Shape
    {
        public override void draw(Graphics g)
        {
            if (A.X < B.X && A.Y < B.Y)
            {
                g.FillRectangle(new SolidBrush(Color), A.X, A.Y, B.X - A.X, B.Y - A.Y);
            }
            else if (A.X > B.X && A.Y > B.Y)
            {
                g.FillRectangle(new SolidBrush(Color), B.X, B.Y, A.X - B.X, A.Y - B.Y);
            }
            else if (A.X > B.X && B.Y > A.Y)
            {
                g.FillRectangle(new SolidBrush(Color), B.X, A.Y, A.X - B.X, B.Y - A.Y);
            }
            else
            {
                g.FillRectangle(new SolidBrush(Color), A.X, B.Y, B.X - A.X, A.Y - B.Y);
            }
        }
    }
    class Squares : Shape
    {
        public override void draw(Graphics g)
        {
            
            float h = Math.Abs(A.Y - B.Y);
            float w = Math.Abs(A.X - B.X);
            if(h > w)
            {
                g.DrawRectangle(new Pen(Color), A.X, A.Y, h, h);
            }
            else
            {
                g.DrawRectangle(new Pen(Color), A.X, A.Y, w, w);
            }
        }
    }
}
