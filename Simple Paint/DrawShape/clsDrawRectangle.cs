using System;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_Paint
{
    /// <summary>
    /// Vẽ hình Chữ Nhật
    /// </summary>
    public class ClsDrawRetangle : DrawShape
    {
        // Contructors
        public ClsDrawRetangle(Pen pen, Brush brush):base(pen, brush) { }

        #region override
        public override void AddPoin(Point p)
        {
            p2 = p;
        }

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
        #endregion
    }
}
