using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Simple_Paint
{
    #region Tạo dữ liệu ENUM
    /// <summary>
    /// Create shapes: Line, Retangle, Square, Ellipse, Curve, Circle, Polygon
    /// </summary>
    enum Shape
    {
        None,
        Line = 1,
        Ellipse = 2,
        Retangle = 3,
        Square = 4,
        Circle = 5,
        Curve = 6,
        Polygon = 7
    }

    /// <summary>
    /// Create actions: Draw, Select
    /// </summary>
    enum Action
    {
        Draw,
        SpecialDraw,
        Select,
        Zoom
    }
    #endregion

    public partial class FrmMain : Form
    {
        #region Declare
        /// <summary>
        /// Biến Graphics để vẽ hình
        /// </summary>
        Graphics gp;
        /// <summary>
        /// Biến Bitmap để thao tác với các pixel trong ảnh
        /// </summary>
        Bitmap bm;
        /// <summary>
        /// Điểm neo của hình để thực hiện thao tác Zoom và Move
        /// </summary>
        Point fixedPoint;


        /// <summary>
        /// Cờ xác định bắt đầu vẽ ở những hình cần di chuyển chuột để vẽ
        /// </summary>
        bool isStartMove = false;
        /// <summary>
        /// Cờ xác định bắt đầu vẽ ở những hình cần click để chọn điểm
        /// </summary>
        bool isStartClick = false;
        /// <summary>
        /// Cờ xác định có đang zoom hay k
        /// </summary>
        bool isZoom = false;
        /// <summary>
        /// Cờ xác định vẽ vùng chọn
        /// </summary>
        bool isRegion = true;
        /// <summary>
        /// Cờ xác định có đang nhấn phím Ctrl hay không
        /// </summary>
        bool isPressed_Ctrl;

        /// <summary>
        /// Hình đang được vẽ
        /// </summary>
        Shape shapeDrawing;
        /// <summary>
        /// Khung chứa để thực hiện select
        /// </summary>
        Rectangle regionSelected;
        /// <summary>
        /// Hình đang được chọn
        /// </summary>
        DrawShape shapeSelected;
        /// <summary>
        /// Hành động đang được thực hiện
        /// </summary>
        Action action;

        /// <summary>
        /// Danh sách chứa các hình đang được vẽ
        /// </summary>
        List<DrawShape> lstDrawing = new List<DrawShape>();


        #endregion

        #region Contructors
        public FrmMain()
        {
            // Khởi tạo vùng vẽ
            InitializeComponent();
            InitGraphics();
            gp.Clear(Color.White);

            // Khởi tạo option mặc định
            SetBrushMenu();
            SetMenuDefult();
            ColorOptionButton();
            action = Action.Select;
            shapeDrawing = Shape.None;
            pnlMain.Focus();
        }

        /// <summary>
        /// Khởi tạo vùng đồ họa để vẽ
        /// </summary>
        public void InitGraphics()
        {
            bm = new Bitmap(pic.Width, pic.Height);
            gp = Graphics.FromImage(bm);
            gp.Clear(Color.White);
            pic.Image = bm;
            gp.SmoothingMode = SmoothingMode.AntiAlias;
        }


        #endregion

        #region Thiết lập menu
        /// <summary>
        /// Thiết lập menu mặc định khi bởi động chương trình mới
        /// </summary>
        public void SetMenuDefult()
        {
            // Xóa tất cả Items hiện có
            cbbStyleBrush.Items.Clear();
            cbbStylePen.Items.Clear();
            cbbHatchFill.Items.Clear();

            // Thêm dữ liệu và ComboBox
            cbbStylePen.Items.AddRange(new object[] { DashStyle.Solid, DashStyle.Dash, DashStyle.Dot, DashStyle.DashDot, DashStyle.DashDotDot, DashStyle.Custom });
            cbbStyleBrush.Items.AddRange(new object[] { PenType.SolidColor, PenType.HatchFill, PenType.TextureFill, PenType.LinearGradient });
            for (int i = 0; i < 53; i++) cbbHatchFill.Items.Add((HatchStyle)i);

            //Mặc định cho ComboBox
            cbbHatchFill.SelectedItem = cbbHatchFill.Items[0];
            cbbStyleBrush.SelectedItem = cbbStyleBrush.Items[0];
            cbbStylePen.SelectedItem = cbbStylePen.Items[0];

            // Khóa button Group
            btnGroup.Enabled = false;

            // Set button tag
            btnSelect.Tag = true;
            btnZoom.Tag = false;
            btnGroup.Tag = false;

            // Pen size default
            trbSize.Value = 5;

            // Action default
            action = Action.Select;


        }
        /// <summary>
        /// Load lại màu cho button
        /// </summary>
        /// <param name="sender">Button đang được focus</param>
        /// <param name="e"></param>
        public void ColorShapeButton(object sender, EventArgs e)
        {
            btnCircle.BackColor = Color.Silver;
            btnLine.BackColor = Color.Silver;
            btnEllipse.BackColor = Color.Silver;
            btnRectangle.BackColor = Color.Silver;
            btnSquare.BackColor = Color.Silver;
            btnCurve.BackColor = Color.Silver;
            btnPolygon.BackColor = Color.Silver;

            Button btn = sender as Button;
            if (btn == btnCircle) 
            {
                btnCircle.BackColor = Color.Peru;
            }
            if (btn == btnCurve)
            {
                btnCurve.BackColor = Color.Peru;
            }
            if (btn == btnEllipse)
            {
                btnEllipse.BackColor = Color.Peru;
            }
            if (btn == btnRectangle)
            {
                btnRectangle.BackColor = Color.Peru;
            }
            if (btn == btnSquare)
            {
                btnSquare.BackColor = Color.Peru;
            }
            if (btn == btnLine)
            {
                btnLine.BackColor = Color.Peru;
            }
            if (btn == btnPolygon)
            {
                btnPolygon.BackColor = Color.Peru;
            }
        }
        public void ColorOptionButton()
        {
            if ((bool)btnSelect.Tag == true)
            {
                btnSelect.BackColor = Color.Peru;
                btnGroup.Enabled = true;
            }
            else
            {
                btnGroup.Enabled = false;
                btnSelect.BackColor = Color.White;
            }
            if ((bool)btnGroup.Tag==true)
            {
                btnGroup.BackColor = Color.Peru;
            }
            else
                btnGroup.BackColor = Color.White;
            if((bool)btnZoom.Tag==true)
            {
                btnZoom.BackColor = Color.Peru;
            }    
            else
                btnZoom.BackColor = Color.White;
        }
        /// <summary>
        /// Set lại option cho menu 
        /// </summary>
        public void SetBrushMenu()
        {
            if (cbBrush.Checked)
            {
                pnlOptionBrush.Visible = true;
                cbBorder.Enabled = true;
                switch(cbbStyleBrush.SelectedItem)
                {
                    case PenType.HatchFill:
                        pnlHatchFill.Visible = true;
                        pnlLinearGradient.Visible = false;
                        pnlTextFill.Visible = false;
                        break;
                    case PenType.TextureFill:
                        pnlHatchFill.Visible = false;
                        pnlLinearGradient.Visible = false;
                        pnlTextFill.Visible = true;
                        break;
                    case PenType.LinearGradient:
                        pnlHatchFill.Visible = false;
                        pnlLinearGradient.Visible = true;
                        pnlTextFill.Visible = false;
                        break; 
                }    
            }
            else
            {
                cbBorder.Enabled = false;
                pnlOptionBrush.Visible = false;
                pnlHatchFill.Visible = false;
                pnlLinearGradient.Visible = false;
                pnlTextFill.Visible = false;
            }
            UpdateShape();
        }
        
        #endregion

        /*BUTTON-EVENT*/
        #region Button Select-Group-Zoom-New
        
        // Khởi tạo trang vẽ mới
        private void btnNew_Click(object sender, EventArgs e)
        {
            // Set lại cờ
            btnSelect.Tag = true;
            btnZoom.Tag = false;
            btnGroup.Tag = false;
            //isSelect = true;
            //isZoom = false;
            //isGroup = false;
            isStartClick = false;
            //Set lại shape và action
            action = Action.Select;
            shapeDrawing = Shape.None;
            // Gọi hàm để setup lại button và vùng vẽ
            ColorShapeButton(sender,e);
            ColorOptionButton();
            InitGraphics();
            lstDrawing.Clear();
        }
        // Lựa chọn chế độ zoom hình
        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (!isStartClick)
            {
                btnZoom.Tag = true;
                btnSelect.Tag = true;
                isZoom = true;
                shapeDrawing = Shape.None;
                action = Action.Select;
                ColorShapeButton( sender,e);
                ColorOptionButton();
            }
        }
        // Lựa chọn chế độ chọn hình
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (!isStartClick)
            {
                btnSelect.Tag = true;
                btnGroup.Tag = false;
                //isSelect = true;
                //isZoom= false;
                //isGroup = false;
                shapeDrawing = Shape.None;
                action = Action.Select;
                ColorShapeButton(sender, e);
                ColorOptionButton();
            }
        }
        // Truy cập file để lấy hình
        private void btnBrown_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Image (*.png)|*.png",
                Multiselect = false,
                InitialDirectory = Application.StartupPath + @"\Resources\TextFill"
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                ptbTextFill.BackgroundImage = Image.FromFile(@openFile.FileName);
                UpdateShape();
            }
        }
        // Nhóm nhiều hình
        private void btnGroup_Click(object sender, EventArgs e)
        {
            if ((bool)btnGroup.Tag == false)
            {
                if (Group() == true)
                {
                    Painting();
                    btnGroup.Tag = true;
                    ColorOptionButton();
                }
            }
            else
            {
                btnGroup.Tag = false;
                UnGroup();
                Painting();
                ColorOptionButton();
            }    
        }
        private bool Group()
        {
            if (lstDrawing.Count(shape => shape.isSelected) > 1)
            {
                lstDrawing.Add(new GroupShape(lstDrawing));
                return true;
            }
            else
                return false;
        }
        private void UnGroup()
        {
            for (int i = 0; i < lstDrawing.Count; i++)
            {
                if (lstDrawing[i].isSelected)
                    if (lstDrawing[i] is GroupShape)
                    {
                        GroupShape myGroup = lstDrawing[i] as GroupShape;
                        //Chèn mỗi hình trong group vào lại trong List lstDrawing
                        myGroup.lstShapeInGroup.ForEach(shape =>
                        {
                            lstDrawing.Add(shape);
                            shape.isSelected = true;
                        });
                        //Remove group khỏi list
                        lstDrawing.Remove(myGroup);
                    }
            }
        }
        #endregion
        #region ShapeButton
        // Làm nổi bật những Button shape được chọn
        private void btnShape_Click(object sender ,EventArgs e)
        {
            btnSelect.Tag = false;
            btnZoom.Tag = false;
            btnGroup.Tag= false;

            // Reset lại cờ isSelected 
            lstDrawing.ForEach(shape => shape.isSelected = false);
            
            //isSelect = false;
            //isGroup = false;
            //isZoom = false;
            if(!isStartClick)
            {
                Button btn = sender as Button;
                if(btn == btnLine)
                    shapeDrawing = Shape.Line;
                if(btn == btnEllipse)
                    shapeDrawing = Shape.Ellipse;
                if (btn == btnRectangle)
                    shapeDrawing = Shape.Retangle;
                if(btn==btnSquare)
                    shapeDrawing = Shape.Square;
                if(btn==btnCircle)
                    shapeDrawing = Shape.Circle;
                if(btn==btnCurve)
                    shapeDrawing = Shape.Curve;
                if(btn==btnPolygon)
                    shapeDrawing = Shape.Polygon;
                ColorShapeButton(sender, e);
            }
            ColorOptionButton();
        }
        #endregion

        /*CHECKBOX-EVENT*/
        #region CheckBox

        // Thay đổi bút vẽ
        private void cbBrush_CheckedChanged(object sender, EventArgs e)
        {
            SetBrushMenu();
            UpdateShape();
        }
        // Vẽ viền
        private void cbBorder_CheckedChanged(object sender, EventArgs e)
        {
            lstDrawing.ForEach(shape =>
            {
                if (shape.isSelected)
                {
                    if (cbBorder.Checked)
                        shape.isBordering = true;
                    else shape.isBordering = false;
                }
            });

            Painting();// Vẽ lại hình sau khi cập nhật thuộc tính
        }
        #endregion

        /*COMBOBOX-EVENT*/
        #region ComboBox
        /// Hiển thị menu phụ của Brush sau khi chọn kiểu tô
        private void cbbStyleBrush_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetBrushMenu();
        }
        #endregion

        /*FORM_EVENT*/
        #region Form
        #region Event key
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            isPressed_Ctrl = e.Control; // Nếu nhấn phím Ctrl thì cờ isPressed_Ctrl true
            if (action == Action.Select) // Kiểm tra nếu đang thực hiên select thì hoàn thiện các thao tác tiếp theo
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                    case Keys.Back: // Nếu nhấn phím Delete hoặc Backspace thì xóa những hình đã chọn
                        for (int i = 0; i < lstDrawing.Count; i++)
                        {
                            if (lstDrawing[i].isSelected)
                            {
                                lstDrawing.RemoveAt(i--);
                            }
                        }
                        break;
                    case Keys.A: // Nếu nhấn phím A thì kiểm tra xem có đang nhấn đồng thời phím Ctrl không nếu có thì thực hiện chọn tất cả các hình
                        if (isPressed_Ctrl)
                        {
                            lstDrawing.ForEach(shape => shape.isSelected = true);
                        }
                        break;
                }
                Painting();
            }
            //pic.Refresh();
        }

        private void FrmMain_KeyUp(object sender, KeyEventArgs e)
        {
            isPressed_Ctrl = e.Control;
        }
        #endregion

        // Đóng Form
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
        // Thay đổi kích thước trang
        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            InitGraphics();
            Painting();
        }
        #endregion

        
        /*PAINTING*/
        #region Paint

        /// <summary>
        /// Vẽ tất cả các hình trong list lstDrawing
        /// </summary>
        public void Painting()
        {
            gp.Clear(pic.BackColor);// Xóa toàn bộ hình
            lstDrawing.ForEach(shape => shape.Draw(gp));
            
            if (isRegion) // Nếu cờ isRegion true thì thực hiện vẽ vùng chọn để chọn nhiều hình một lúc
            {
                Pen pen = new Pen(Color.Black, 2)
                {
                    DashStyle = DashStyle.Dash
                };
                gp.DrawRectangle(pen, regionSelected);
            }

            // Làm mới picturebox để cập nhật hình vẽ
            pic.Refresh();
        }

        /// <summary>
        /// Hàm chọn màu
        /// </summary>
        /// <param name="sender">PictureBox sẽ hiển thị màu đại diện cho màu được chọn</param>
        /// <param name="e">Picture cần cập nhật màu được chọn</param>
        public void ChooseColor(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as PictureBox).BackColor = colorDialog1.Color;
            }
            UpdateShape();
        }

        /// <summary>
        /// Hàm cập nhật lại thuộc tính cho hình đang được thao tác
        /// </summary>
        public void UpdateShape()
        {
            lstDrawing.ForEach(shape =>
            {
                if (shape.isSelected)
                {
                    shape.Update
                    (
                    isBrush: cbBrush.Checked,
                    newbrush: CreateBrush(),
                    penSize: (int)trbSize.Value,
                    dashStyle: (DashStyle)cbbStylePen.SelectedItem,
                    penColor: ptbColorBorder.BackColor
                    );
                }
                

            });

            Painting();// Vẽ lại hình sau khi cập nhật thuộc tính
        }
        // Thay đổi kích thước
        private void trbSize_Scroll(object sender, EventArgs e)
        {
            Pen pen = new Pen(ptbColorBorder.BackColor, (float)trbSize.Value);
            lstDrawing.ForEach(shape =>
            {
                if (shape.isSelected)
                    shape.pen = pen;
            });
            Painting();
        }
        /// <summary>
        /// Dùng để cập nhật thông tin về hình được chọn lên menu
        /// </summary>
        public void ShapeInfo()
        {
            btnSelect.Tag = true;
            ColorOptionButton();
            cbBrush.Checked = shapeSelected.isBrushing;
            SetBrushMenu();
            cbBorder.Checked = shapeSelected.isBordering;
            cbBorder.Enabled = shapeSelected.isBrushing;
        }    

        /// <summary>
        /// Tạo Brush mới
        /// </summary>
        /// <returns>Brush mới có kiểu được chọn</returns>
        private Brush CreateBrush()
        {
            switch (cbbStyleBrush.SelectedItem)
            {
                case PenType.TextureFill:
                    return new TextureBrush(ptbTextFill.BackgroundImage);
                case PenType.LinearGradient:
                    return new LinearGradientBrush(new Rectangle(10,10,10,10),ptbForeColor.BackColor,ptbBackColor.BackColor,trbLinearGradient.Value);
                case PenType.HatchFill:
                    return new HatchBrush((HatchStyle)cbbHatchFill.SelectedIndex, ptbForeColor.BackColor, ptbBackColor.BackColor);
                case PenType.SolidColor:
                default:
                    return new SolidBrush(ptbForeColor.BackColor);
            }
        }


        #endregion

        
        /*MOUSE-EVENT*/
        #region Mouse

        /// <summary>
        /// Hàm chọn hình
        /// </summary>
        /// <param name="p">Điểm click chuột</param>
        public void MouseDown_Select(Point p)
        {
            // Kiểm tra xem có đang nhấn phím ctrl không, nếu có có thể chọn nhiều hình, chọn 2 lần sẽ bỏ hình
            if(isPressed_Ctrl)
            {
                lstDrawing.ForEach(shape =>
                {
                    if (shape.CheckSelected(p))
                    {
                        shape.isSelected = !shape.isSelected;
                    }
                });
            }    
            else
            {
                shapeSelected = null;
                fixedPoint = p;
                lstDrawing.ForEach(shape =>
                {
                    shape.isSelected = false;
                    if (shape.CheckSelected(p))
                    {
                        shape.isSelected = true;
                        shapeSelected = shape;
                    }
                });
                if (shapeSelected != null)
                {
                    ShapeInfo();
                    if (isZoom) 
                        shapeSelected.SelectPoint(p);
                    isRegion = false;
                }
                else
                {
                    isStartMove = true;
                    isRegion = true;
                    regionSelected = new Rectangle(p, new Size(0, 0));
                }
            }
            Painting();
        }
        /// Khi nhấn chuột hàm sẽ kiểm tra và khởi tạo hình được vẽ
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            btnGroup.Tag = false;
            // Khi isStartClick true có nghĩa Polygon hoặc Curve đang được vẽ
            // Không thể tạo thêm hình khi hình hiện tại chưa vẽ xong
            if (shapeDrawing != Shape.None && !isStartClick)
            {
                isStartMove = true;

                Pen pen = new Pen(ptbColorBorder.BackColor, (int)trbSize.Value)
                {
                    DashStyle = (DashStyle)cbbStylePen.SelectedItem
                };
                Brush brush = CreateBrush();
                action = Action.Draw;
                // Declare and add shape in lstDrawing
                switch (shapeDrawing)
                {
                    case Shape.Line:
                        lstDrawing.Add(new ClsDrawLine(pen, brush));
                        break;
                    case Shape.Ellipse:
                        lstDrawing.Add(new ClsDrawEllipse(pen, brush));
                        break;
                    case Shape.Retangle:
                        lstDrawing.Add(new ClsDrawRetangle(pen, brush));
                        break;
                    case Shape.Square:
                        lstDrawing.Add(new ClsDrawSquare(pen, brush));
                        break;
                    case Shape.Circle:
                        lstDrawing.Add(new clsDrawCircle(pen, brush));
                        break;
                    // Curve và Polygon có cách vẽ khác với những hình còn lại
                    // Curve và Polygon yêu cầu nhiều hơn 1 điểm để vẽ và nhiều hơn 2 điểm để có hình khác đường thẳng
                    case Shape.Curve:
                        action = Action.SpecialDraw;
                        lstDrawing.Add(new clsDrawCurve(pen, brush));
                        isStartClick = true;
                        break;
                    case Shape.Polygon:
                        action = Action.SpecialDraw;
                        lstDrawing.Add(new clsDrawPolygon(pen, brush));
                        isStartClick = true;
                        break;
                }
                int index = lstDrawing.Count - 1;
                lstDrawing[index].p1 = e.Location;
                lstDrawing[index].AddPoin(e.Location);
                lstDrawing[index].isBrushing = cbBrush.Checked;
                lstDrawing[index].isBordering = cbBorder.Checked;
                lstDrawing[index].isSelected = true;
            }else if(action == Action.Select)// Vẽ khung để xác định vùng chọn
            {
                MouseDown_Select(e.Location);
            }
        }

        /// <summary>
        /// Khi di chuyển chuột vị trí mới sẽ được cập nhật
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Dữ liệu chuột trong đó có e.Location là vị trí chuột</param>
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (action == Action.Draw && isStartMove)
            {
                int index = lstDrawing.Count - 1;
                if (isStartMove && index >= 0 && shapeDrawing != Shape.None)
                {
                    lstDrawing[index].p2 = e.Location;// Gán vị trí mới cho p2
                }
            }
            if(action==Action.SpecialDraw && isStartMove)
            {
                int index = lstDrawing.Count - 1;
                if (isStartMove && index >= 0 && shapeDrawing != Shape.None)
                {
                    if (shapeDrawing == Shape.Curve)
                    {
                        var shape = (lstDrawing[index] as clsDrawCurve);
                        shape.lstPoints[shape.lstPoints.Count - 1] = e.Location;
                    }
                    if (shapeDrawing == Shape.Polygon)
                    {
                        var shape = (lstDrawing[index] as clsDrawPolygon);
                        shape.lstPoints[shape.lstPoints.Count - 1] = e.Location;
                    }
                }
            }    
            if(action == Action.Select)
            {
                #region Set Cursor
                if (lstDrawing.Exists(shape => shape.CheckSelected(e.Location)))
                    pic.Cursor = Cursors.SizeAll;
                else pic.Cursor = Cursors.Cross;
                #endregion
                
                if(shapeSelected!=null)
                {
                    if (isZoom)
                        shapeSelected.Zoom(fixedPoint, e.Location);
                    else shapeSelected.Move(fixedPoint, e.Location);
                    fixedPoint = e.Location;
                }
                else if(isStartMove)
                {
                    regionSelected.Width = e.X - regionSelected.X;
                    regionSelected.Height = e.Y - regionSelected.Y;
                }
            }
            Painting();
        }

        /// <summary>
        /// Khi thả chuột vị trí cuối cùng của chuột sẽ là vị trí cuối cùng của hình và vẽ hình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            if (action == Action.Draw)
            {
                // Không cho vẽ hình khi điểm bắt đầu và điểm kết thúc trùng nhau (nếu hình phải di chuột)
                if (lstDrawing[lstDrawing.Count - 1].p1 != e.Location)
                {
                    Painting();
                    action = Action.Select;
                    shapeDrawing = Shape.None;

                    // Nhường quyền xử lí cho chức năng select
                    btnSelect.Tag = true;
                    ColorOptionButton();
                    ColorShapeButton(sender, e);
                    isStartMove = false;// Đặt lại cờ
                }
                else lstDrawing.RemoveAt(lstDrawing.Count - 1);// Xóa hình nếu vẽ thất bại
            }
            else if (action == Action.Select)
            {
                shapeSelected = null;
                if (isRegion)
                {
                    isRegion = false;
                    lstDrawing.ForEach((Action<DrawShape>)(shape =>
                    {
                        shape.isSelected = false;
                        if (shape.p1.X >= regionSelected.X
                        && shape.p1.Y >= regionSelected.Y
                        && shape.p2.X <= regionSelected.X + regionSelected.Width
                        && shape.p2.Y <= regionSelected.Y + regionSelected.Height)
                        {
                            shape.isSelected = true;
                        }
                    }));

                    regionSelected = new Rectangle();       // Đặt lại giá trị vùng chọn
                    Painting();
                }
                isStartMove = false;// Đặt lại cờ
            } 
            
        }

        /// <summary>
        /// Khi vẽ hình Polygon hoặc hình Curve thì hàm sẽ lưu lại các vị trí chuột được click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Chứa dữ liệu của chuột e.Location là vị trí của chuột</param>
        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            int index = lstDrawing.Count - 1;
            if (action == Action.SpecialDraw && index >= 0 && isStartClick)
            {
                lstDrawing[index].AddPoin(e.Location);
                // Vẽ hình nếu thất bại in ra Fail
                Painting();
            }

            
        }

        /// <summary>
        /// Dùng cho hình Polygon và hình Curve. Khi Click chuột 2 lần và vùng đồ họa để vẽ thì quá trình vẽ sẽ kết thúc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Chứa dữ liệu chuột e.Location là vị trí cuối cùng của chuột</param>
        private void pic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lstDrawing.Count - 1;// index của hình cuối cùng trong danh sách
            if (action == Action.SpecialDraw && index >= 0 && isStartClick)
            {
                lstDrawing[index].AddPoin(e.Location);
                // Vẽ hình. Nếu thất bại sẽ xóa hình và thông báo cho người dùng các vẽ hình đặc biệt
                try
                {
                    lstDrawing[index].Draw(gp);
                    shapeDrawing = Shape.None;
                    action = Action.Select;

                    btnSelect.Tag=true;
                    ColorOptionButton();
                    ColorShapeButton(sender, e);
                }
                catch (Exception)
                {
                    shapeDrawing = Shape.None;
                    lstDrawing.RemoveAt(index);
                    MessageBox.Show("Bạn vẽ sai cách!!!!" +
                        "\nHãy click chuột để chọn điểm" +
                        "\nKết thúc bằng double click chuột vào điểm cuối cùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            isStartMove = false;
            isStartClick = false;// Đặt lại cờ
        }



        #endregion

    }

}
