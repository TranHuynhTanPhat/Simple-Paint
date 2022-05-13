using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Simple_Paint
{
    /// <summary>
    /// Vẽ hình Ellipse
    /// </summary>
    public class ClsDrawEllipse : DrawShape
    {
        public ClsDrawEllipse(Pen pen, Brush brush):base(pen, brush) { }

        #region override
        public override void AddPoin(Point p)
        {
            p2 = p;
        }

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
                gp.FillRectangle(sBrush, (p1.X + p2.X) / 2, p1.Y - 3, 6, 6);
                gp.FillRectangle(sBrush, (p1.X + p2.X) / 2, p2.Y - 3, 6, 6);
                gp.FillRectangle(sBrush, p1.X - 3, (p1.Y + p2.Y) / 2, 6, 6);
                gp.FillRectangle(sBrush, p2.X - 3, (p1.Y + p2.Y) / 2, 6, 6);

                Pen sPen = new Pen(Color.Black, (float)0.1);
                gp.DrawRectangle(sPen, (p1.X + p2.X) / 2, p1.Y - 3, 6, 6);
                gp.DrawRectangle(sPen, (p1.X + p2.X) / 2, p2.Y - 3, 6, 6);
                gp.DrawRectangle(sPen, p1.X - 3, (p1.Y + p2.Y) / 2, 6, 6);
                gp.DrawRectangle(sPen, p2.X - 3, (p1.Y + p2.Y) / 2, 6, 6);

                sPen = new Pen(Color.White, (float)1.2)
                {
                    DashStyle = DashStyle.Dash
                };
                gp.DrawEllipse(sPen, rect);
            }
        }
        #endregion
    }
}
