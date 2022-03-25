using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    enum ShapeType
    {
        Circle,
        SolidCircle,
        Rectangle,
        SolidRectangle,
        Squares,
        SolidSquare,
        DashCircle,
        DashRectangle,
        DashSquare
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
                    return new NormalCircle();
                case ShapeType.SolidCircle:
                    return new SolidCircle();
                case ShapeType.Rectangle:
                    return new NormalRectangle();
                case ShapeType.SolidRectangle:
                    return new SolidRectangle();
                case ShapeType.Squares:
                    return new NormalSquare();
                case ShapeType.DashCircle:
                    return new DashedCircle();
                case ShapeType.SolidSquare:
                    return new SolidSquare();
                case ShapeType.DashRectangle:
                    return new DashedRectangle();
                case ShapeType.DashSquare:
                    return new DashedSquare();

            }
            return null;
        }
    }
    public abstract class Shape
    {
        public Color Color { get; set; } = Color.Black;
        public Point A { get; set; }
        public Point B { get; set; }
        public virtual  void draw(Graphics g)
        {

        }

    }

   
}
