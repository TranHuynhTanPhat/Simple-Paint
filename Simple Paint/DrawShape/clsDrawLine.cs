using System;
using System.Drawing;

namespace Simple_Paint
{
    /// <summary>
    /// Vẽ đường thẳng
    /// </summary>
    public class ClsDrawLine : DrawShape
    {
        //Properties
        public int selectedPoint { get; set; }

        // Contructors
        public ClsDrawLine(Pen pen, Brush brush):base(pen, brush) { }

        #region override
        public override void AddPoin(Point p)
        {
            p2 = p;
        }

        public override void Draw(Graphics gp)
        {
            gpPath.Reset();
            gpPath.AddLine(p1, p2);
            gp.DrawLine(pen, this.p1, this.p2);
            if (isSelected)
            {
                Brush sBrush = new SolidBrush(Color.White);
                gp.FillRectangle(sBrush, p1.X - 3, p1.Y - 3, 5, 5);
                gp.FillRectangle(sBrush, p2.X - 3, p2.Y - 3, 5, 5);

                Pen sPen = new Pen(Color.Black, (float)0.1);
                gp.DrawRectangle(sPen, p1.X - 3, p1.Y - 3, 5, 5);
                gp.DrawRectangle(sPen, p2.X - 3, p2.Y - 3, 5, 5);
            }
        }
        public override void SelectPoint(Point p)
        {
            double d1 = Math.Pow(p.X - p1.X, 2) + Math.Pow(p.Y - p1.Y, 2);
            double d2 = Math.Pow(p.X - p2.X, 2) + Math.Pow(p.Y - p2.Y, 2);
            if (d1 < d2)
                selectedPoint = 1;
            else
                selectedPoint = 2;
        }
        public override void Zoom(Point firstPoint, Point eLocation)
        {
            int x;
            int y;
            if (selectedPoint == 1)
            {
                x = p1.X + eLocation.X - firstPoint.X;
                y = p1.Y + eLocation.Y - firstPoint.Y;
                p1 = new Point(x, y);
            }
            else
            {
                x= p2.X + eLocation.X - firstPoint.X;
                y= p2.Y + eLocation.Y - firstPoint.Y;
                p2 = new Point(x, y);
            }
        }
        #endregion
    }
}
