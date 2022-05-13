using System;
using System.Drawing;

namespace Simple_Paint
{
    /// <summary>
    /// Vẽ hình Vuông
    /// </summary>
    public class ClsDrawSquare : DrawShape
    {
        public ClsDrawSquare(Pen pen, Brush brush) : base(pen, brush) { }

        #region override
        public override void Draw(Graphics gp)
        {
            Rectangle rect = BoundRectangle();
            gpPath.Reset();
            gpPath.AddRectangle(rect);
            if(isBrushing)
            {
                gp.FillRectangle(brush, rect);
                if(isBordering)
                gp.DrawRectangle(pen, rect);// Vẽ viền cho hình
            }    
            else
                gp.DrawRectangle(pen, rect);
            if (isSelected)
            {
                Brush sBrush = new SolidBrush(Color.White);
                gp.FillRectangle(sBrush, p1.X - 3, p1.Y - 3, 5, 5);
                gp.FillRectangle(sBrush, p1.X - 3, p2.Y - 3, 5, 5);
                gp.FillRectangle(sBrush, p2.X - 3, p1.Y - 3, 5, 5);
                gp.FillRectangle(sBrush, p2.X - 3, p2.Y - 3, 5, 5);

                Pen sPen = new Pen(Color.Black, (float)0.1);
                gp.DrawRectangle(sPen, p1.X - 3, p1.Y - 3, 5, 5);
                gp.DrawRectangle(sPen, p1.X - 3, p2.Y - 3, 5, 5);
                gp.DrawRectangle(sPen, p2.X - 3, p1.Y - 3, 5, 5);
                gp.DrawRectangle(sPen, p2.X - 3, p2.Y - 3, 5, 5);

                sPen = new Pen(Color.White, (float)1.2)
                {
                    DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
                };
                gp.DrawRectangle(sPen, rect);
            }    
        }
        public override Rectangle BoundRectangle()
        {
            int dx = Math.Abs(p1.X - p2.X);
            int dy = Math.Abs(p1.Y - p2.Y);
            int width = Math.Max(dx, dy);
            p2 = new Point(p1.X + width, p1.Y + width);

            return new Rectangle( p1.X, p1.Y, width, width);
        }

        public override void AddPoin(Point p)
        {
            p2 = p;
        }
        #endregion
    }
}
