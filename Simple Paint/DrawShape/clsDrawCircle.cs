using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Simple_Paint
{
    /// <summary>
    /// Vẽ hình Tròn
    /// </summary>
    public class clsDrawCircle : DrawShape
    {
        // Contructors
        public clsDrawCircle(Pen pen, Brush brush) : base(pen, brush) { }

        #region override
        public override void Draw(Graphics gp)
        {
            gpPath.Reset();
            Rectangle rect = BoundRectangle();
            gpPath.AddEllipse(rect);
            if(isBrushing)
            {
                gp.FillEllipse(brush, rect);
                if(isBordering)
                gp.DrawEllipse(pen, rect);// Vẽ viền cho hình
            }    
            else
                gp.DrawEllipse(pen, rect);
            if (isSelected)
            {
                Brush sBrush = new SolidBrush(Color.White);
                gp.FillRectangle(sBrush, (p1.X + p2.X) / 2, p1.Y-3, 6, 6);
                gp.FillRectangle(sBrush, (p1.X + p2.X) / 2, p2.Y-3, 6, 6);
                gp.FillRectangle(sBrush, p1.X-3, (p1.Y + p2.Y) / 2, 6, 6);
                gp.FillRectangle(sBrush, p2.X-3, (p1.Y + p2.Y) / 2, 6, 6);

                Pen sPen = new Pen(Color.Black, (float)0.1);
                gp.DrawRectangle(sPen, (p1.X + p2.X) / 2, p1.Y-3, 6, 6);
                gp.DrawRectangle(sPen, (p1.X + p2.X) / 2, p2.Y-3, 6, 6);
                gp.DrawRectangle(sPen, p1.X-3, (p1.Y + p2.Y) / 2, 6, 6);
                gp.DrawRectangle(sPen, p2.X-3, (p1.Y + p2.Y) / 2, 6, 6);

                sPen = new Pen(Color.White, (float)1.2)
                {
                    DashStyle = DashStyle.Dash
                };
                gp.DrawEllipse(sPen, rect);
            }
        }

        public override Rectangle BoundRectangle()
        {
            int dx = Math.Abs(p1.X - p2.X);
            int dy = Math.Abs(p1.Y - p2.Y);
            int width = Math.Max(dx, dy);
            p2 = new Point(p1.X + width, p1.Y + width);

            return new Rectangle(p1.X, p1.Y, width, width);
        }

        public override void AddPoin(Point p)
        {
            p2 = p;
        }
        #endregion
    }
    
}
