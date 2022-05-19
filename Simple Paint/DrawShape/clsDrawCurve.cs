using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Simple_Paint
{
    /// <summary>
    /// Vẽ đường Cong
    /// </summary>
    public class clsDrawCurve : DrawShape
    {
        // Properties
        public List<Point> lstPoints { get; set; }
        public int selectedPoint { get; set; }

        // Contructors
        public clsDrawCurve(Pen pen, Brush brush):base(pen, brush) 
        {
            lstPoints = new List<Point>();
        }

        #region override
        public override void Draw(Graphics gp)
        {
            gpPath.Reset();
            // Nếu chỉ có 2 điểm mà cả 2 điểm đều giống nhau thì báo lỗi
            if (lstPoints.Count == 2 && lstPoints[0] != lstPoints[lstPoints.Count - 1])
            {
                gpPath.AddCurve(lstPoints.ToArray());
                gp.DrawLine(pen, lstPoints[0], lstPoints[1]);
            }
            else if(lstPoints.Count>2)
            {
                // Vẽ Curve
                gpPath.AddCurve(lstPoints.ToArray());
                gp.DrawCurve(pen, lstPoints.ToArray());
            }
            if (isSelected)
            {
                lstPoints.ForEach(p =>
                {
                    Brush sBrush = new SolidBrush(Color.White);
                    gp.FillRectangle(sBrush, p.X - 3, p.Y - 3, 5, 5);

                    Pen sPen = new Pen(Color.Black, (float)0.1);
                    gp.DrawRectangle(sPen, p.X - 3, p.Y - 3, 5, 5);

                });
            }
        }

        public override void AddPoin(Point p)
        {
            lstPoints.Add(p);
        }
        public override void Move(Point fixedPoint, Point movedPoint)
        {
            int dx = movedPoint.X - fixedPoint.X;
            int dy = movedPoint.Y - fixedPoint.Y;
            for (int i = 0; i < lstPoints.Count; i++)
                lstPoints[i] = new Point(lstPoints[i].X + dx, lstPoints[i].Y + dy);
        }
        public override void SelectPoint(Point p)
        {
            for (int i = 0; i < lstPoints.Count; i++)
            {
                if ((lstPoints[i].X - 10 <= p.X && p.X <= lstPoints[i].X + 10)
                    && (lstPoints[i].Y - 10 <= p.Y && p.Y <= lstPoints[i].Y + 10))
                {
                    selectedPoint = i;
                    return;
                }
            }
            selectedPoint = -1;
        }
        public override void Zoom(Point firstPoint, Point p)
        {
            if (selectedPoint < 0) return;
            int dx = p.X - firstPoint.X;
            int dy = p.Y - firstPoint.Y;
            for (int i = selectedPoint - 1; i <= selectedPoint + 1; i++)
            {
                if (i < 0 || i >= lstPoints.Count) continue;
                else
                    lstPoints[i] = new Point(lstPoints[i].X + dx, lstPoints[i].Y + dy);
            }
        }
        #endregion
    }
}
