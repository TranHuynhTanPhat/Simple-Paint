using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Simple_Paint
{
    public abstract class DrawShape
    {
        #region Properties

        #region Cờ
        /// <summary>
        /// Cờ để xác định có đang dùng Brush không
        /// </summary>
        public bool isBrushing { get; set; } 
        /// <summary>
        /// Cờ để xác định có vẽ viền khi tô hay không
        /// </summary>
        public bool isBordering { get; set; }
        /// <summary>
        /// Cờ để xác định hình có đang được chọn hay không
        /// </summary>
        public bool isSelected { get; set; }
        #endregion

        #region Định vị hình
        /// <summary>
        /// Điểm thứ nhất
        /// </summary>
        public Point p1 { get; set; }
        /// <summary>
        /// Điểm thứ hai
        /// </summary>
        public Point p2 { get; set; }
        /// <summary>
        /// Lưu lại cạnh được chọn
        /// </summary>
        public int selectedEdge { get; set; }
        #endregion

        /// <summary>
        /// Pen dùng để thực hiện thao tác vẽ 
        /// </summary>
        public Pen pen { get; set; }
        /// <summary>
        /// Brush dùng để thực hiện tô màu
        /// </summary>
        public Brush brush { get; set; }

        /// <summary>
        /// Lưu lại khung của hình để thao tác chọn hình
        /// </summary>
        public GraphicsPath gpPath { get; set; }

        #endregion

        #region Contructors
        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        public DrawShape() 
        {
            gpPath = new GraphicsPath();
        }
        /// <summary>
        /// Hàm khởi tạo
        /// </summary>
        /// <param name="myPen"></param>
        /// <param name="myBrush"></param>
        public DrawShape(Pen myPen, Brush myBrush)
        {
            pen = myPen;
            brush = myBrush;
            gpPath = new GraphicsPath();
        }
        #endregion

        #region Methods default

        public virtual bool CheckSelected(Point e)
        {
            if (isBrushing) return gpPath.IsVisible(e);
            return gpPath.IsOutlineVisible(e,pen);
        }

        /// <summary>
        /// Cập nhật thuộc tính cho hình
        /// </summary>
        /// <param name="isBrush">Cờ xác định có sử dụng Brush hay không</param>
        /// <param name="newbrush">Brush mới</param>
        /// <param name="penSize">Kích cỡ bút</param>
        /// <param name="dashStyle">Kiểu của bút</param>
        /// <param name="penColor">Màu của bút</param>
        public virtual void Update(bool isBrush, Brush newbrush, int penSize, DashStyle dashStyle, Color penColor)
        {
            isBrushing = isBrush;
            brush = newbrush;
            pen.Width = penSize;
            pen.DashStyle = dashStyle;
            pen.Color = penColor;
        }
        #endregion

        #region Virtual Methods

        /// <summary>
        /// Xác định khung ràng buộc của những hình được tạo thành bởi khung hình chữ nhât
        /// </summary>
        /// <returns>Hình chữ nhât bao quanh hình</returns>
        public virtual Rectangle BoundRectangle()
        {
            int X = Math.Min(p1.X, p2.X);
            int Y = Math.Min(p1.Y, p2.Y);
            int dx = Math.Abs(p1.X - p2.X);
            int dy = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(X, Y, dx, dy);
        }

        /// <summary>
        /// Hàm di chuyển hình
        /// </summary>
        /// <param name="fixedPoint">Điểm cố định</param>
        /// <param name="movedPoint">Điểm di chuyển đến</param>
        public virtual void Move(Point fixedPoint,Point movedPoint)
        {
            int dx = movedPoint.X - fixedPoint.X;
            int dy = movedPoint.Y - fixedPoint.Y;
            p1 = new Point(p1.X + dx, p1.Y + dy);
            p2 = new Point(p2.X + dx, p2.Y + dy);
        }
        /// <summary>
        /// Hàm xác định điểm được chọn thuộc điểm nào hoặc cạnh nào của hình
        /// </summary>
        /// <param name="p">Điểm click chuột</param>
        public virtual void SelectPoint(Point p)
        {
            if (p1.X - 20 <= p.X && p.X <= p1.X + 20)
                selectedEdge = 1;// ĐIểm được chọn thuộc cạnh trái của hình
            else if (p2.X - 20 <= p.X && p.X <= p2.X + 20)
                selectedEdge = 2;// Điểm được chọn thuộc cạnh phải của hình
            else if (p1.Y - 20 <= p.Y && p.Y <= p1.Y + 20)
                selectedEdge = 3;// Điểm được chọn thuộc cạnh trên của hình
            else if (p2.Y - 20 <= p.Y && p.Y <= p2.Y + 20)
                selectedEdge = 4;// Điểm được chọn thuộc cạnh dưới của hình
            else
                selectedEdge = 0;// Không thuộc cạnh nào
        }
        /// <summary>
        /// Dùng để zoom hình
        /// </summary>
        /// <param name="firstPoint">Điểm ban đầu</param>
        /// <param name="p">Điểm sau khi di chuột</param>
        public virtual void Zoom(Point firstPoint, Point p)
        {
            int x;
            switch (selectedEdge)
            {
                case 1:
                    x = p1.X + p.X - firstPoint.X;
                    p1 = new Point(x, p1.Y);
                    break;
                case 2:
                    x = p2.X + p.X - firstPoint.X;
                    p2 = new Point(x, p2.Y);
                    break;
                case 3:
                    x = p1.Y + p.Y - firstPoint.Y;
                    p1 = new Point(p1.X, x);
                    break;
                case 4:
                    x = p2.Y + p.Y - firstPoint.Y;
                    p2 = new Point(p2.X, x);
                    break;
            }
        }
        #endregion

        #region Abstract
        /// <summary>
        /// Hàm vẽ hình
        /// </summary>
        /// <param name="gp"></param>
        public abstract void Draw(Graphics gp);
        /// <summary>
        /// Hàm thêm điểm sử dụng cho hình Polygon hoăc hình Curve
        /// </summary>
        /// <param name="p">Điểm click chuột</param>
        public abstract void AddPoin(Point p);
        
        
        #endregion
    }
}
