using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Simple_Paint
{
    public class GroupShape:DrawShape
    {
        #region Properties
        public List<DrawShape> lstShapeInGroup = new List<DrawShape>();

        /// <summary>
        /// Dùng để xác định hình chữ nhật bao quanh đối tượng shape 
        /// </summary>
        public Rectangle RectShape { get; set; }
        /// <summary>
        /// Đếm số hình trong group
        /// </summary>
        public int Count => lstShapeInGroup.Count;
        #endregion

        #region Contructors
        public GroupShape(List<DrawShape> group)
        {
            pen = new Pen(Color.Black);
            for (int i = 0; i < group.Count;)
            {
                if (group[i].isSelected)
                {
                    lstShapeInGroup.Add(group[i]);
                    group.RemoveAt(i);
                }
                else i++;
            }
            this.isSelected = true;
        }
        #endregion

        #region Methods
        // Thêm hình vào group
        public void Add(DrawShape shape)
        {
            lstShapeInGroup.Add(shape);
        }


        #region Methods overried
        public override void SelectPoint(Point p)
        {
            SelectPoint(p);
        }
        public override void Zoom(Point firstPoint, Point eLocation)
        {
            lstShapeInGroup.ForEach(shape =>
            {
                shape.selectedEdge = this.selectedEdge;
                shape.Zoom(firstPoint, eLocation);
            });
        }
        public override void Draw(Graphics gp)
        {
            using (var pen = new Pen(Color.Blue) { Width = 2, DashStyle = System.Drawing.Drawing2D.DashStyle.Dash })
            {
                FindGroupRegion();
                RectShape = BoundRectangle();
                gp.DrawRectangle(pen, RectShape);
                foreach (var shape in lstShapeInGroup)
                {
                    shape.isSelected = this.isSelected;
                    shape.Draw(gp);
                }
            }
        }
        public override void Move(Point firstPoint, Point eLocation)
        {
            lstShapeInGroup.ForEach(shape => shape.Move(firstPoint, eLocation));
        }
        public void FindGroupRegion()
        {
            int minX = Int32.MaxValue, maxX = Int32.MinValue, minY = Int32.MaxValue, maxY = Int32.MinValue;
            for (int i = 0; i < lstShapeInGroup.Count; i++)
            {
                DrawShape shape = lstShapeInGroup[i] as DrawShape;
                if (shape is clsDrawCurve curve)
                {
                    FindCurveRegion(curve);
                }
                else if (shape is clsDrawPolygon polygon)
                {
                    FindPolygonRegion(polygon);
                }
                if (shape.p1.X < minX) minX = shape.p1.X;
                if (shape.p2.X < minX) minX = shape.p2.X;
                if (shape.p1.Y < minY) minY = shape.p1.Y;
                if (shape.p2.Y < minY) minY = shape.p2.Y;
                if (shape.p1.X > maxX) maxX = shape.p1.X;
                if (shape.p2.X > maxX) maxX = shape.p2.X;
                if (shape.p1.Y > maxY) maxY = shape.p1.Y;
                if (shape.p2.Y > maxY) maxY = shape.p2.Y;
            }
            this.p1 = new Point(minX, minY);
            this.p2 = new Point(maxX, maxY);
        }

        private void FindPolygonRegion(clsDrawPolygon polygon)
        {
            int minX = Int32.MaxValue, maxX = Int32.MinValue, minY = Int32.MaxValue, maxY = Int32.MinValue;
            polygon.lstPoints.ForEach(p =>
            {
                if (minX > p.X) minX = p.X;
                if (minY > p.Y) minY = p.Y;
                if (maxX < p.X) maxX = p.X;
                if (maxY < p.Y) maxY = p.Y;
            });
            polygon.p1 = new Point(minX, minY);
            polygon.p2 = new Point(maxX, maxY);
        }

        private void FindCurveRegion(clsDrawCurve curve)
        {
            int minX = Int32.MaxValue, maxX = Int32.MinValue, minY = Int32.MaxValue, maxY = Int32.MinValue;
            curve.lstPoints.ForEach(p =>
            {
                if (minX > p.X) minX = p.X;
                if (minY > p.Y) minY = p.Y;
                if (maxX < p.X) maxX = p.X;
                if (maxY < p.Y) maxY = p.Y;
            });
            curve.p1 = new Point(minX, minY);
            curve.p2 = new Point(maxX, maxY);
        }

        public override bool CheckSelected(Point p)
        {
            if (p.X >= p1.X && p.X <= p2.X && p.Y >= p1.Y && p.Y <= p2.Y)
                return true;
            return false;
        }

        public override void Update(bool isBrush, Brush newbrush, int penSize, DashStyle dashStyle, Color penColor)
        {
            lstShapeInGroup.ForEach(shape => shape.Update(isBrush, newbrush, penSize, dashStyle, penColor));
        }

        public override void AddPoin(Point p)
        {
        }
        #endregion
        #endregion

    }
}
