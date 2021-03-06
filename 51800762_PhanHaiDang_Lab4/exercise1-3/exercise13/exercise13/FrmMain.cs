using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercise13
{
    public partial class FrmMain : Form
    {
        List<Shape> shapes=new List<Shape>();
        ShapeType type = ShapeType.Circle;
        private bool isDrawing = false;
        public FrmMain()
        {
            InitializeComponent();
            toolCircle.BackColor = SystemColors.ActiveCaption;
            toolColor.BackColor = Color.Black;
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.draw(e.Graphics);
            }
        }
        

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolSolidCircle_Click(object sender, EventArgs e)
        {
            type = ShapeType.SolidCircle;
            isActive(toolSolidCircle);
        }

        private void toolCircle_Click(object sender, EventArgs e)
        {
            type = ShapeType.Circle;
            isActive(toolCircle);
            
            
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            var shape = ShapeFactory.Instance.CreateShape(type);
            shape.A = e.Location;
            shape.B = e.Location;
            shape.Color = toolColor.BackColor;
            shapes.Add(shape);
            Invalidate();
        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                shapes[shapes.Count - 1].B = e.Location;
                Invalidate();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                toolColor.BackColor = colorDialog1.Color;
            }
        }

        private void toolRectangle_Click(object sender, EventArgs e)
        {
            type = ShapeType.Rectangle;
            isActive(toolRectangle);
            /*toolRectangle.BackColor = SystemColors.Control;*/

        }
        /*private void isActive(object sender)
        {
            sender.BackColor
        }*/
        private void isActive(ToolStripButton btn)
        {
            toolCircle.BackColor = SystemColors.Control;
            toolRectangle.BackColor = SystemColors.Control;
            toolSolidCircle.BackColor = SystemColors.Control;
            toolSquare.BackColor = SystemColors.Control;
            toolSolidRectangle.BackColor = SystemColors.Control;

            btn.BackColor = SystemColors.ActiveCaption;

        }

        private void toolSolidRectangle_Click(object sender, EventArgs e)
        {
            type = ShapeType.SolidRectangle;
            isActive(toolSolidRectangle);
        }

        private void toolSquare_Click(object sender, EventArgs e)
        {
            type = ShapeType.Squares;
            
            isActive(toolSquare);
        }
    }
}
