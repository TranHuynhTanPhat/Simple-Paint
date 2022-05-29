namespace Simple_Paint
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOption1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tlpOptionBrush = new System.Windows.Forms.TableLayoutPanel();
            this.pnlOptionBrush = new System.Windows.Forms.Panel();
            this.ptbBackColor = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ptbForeColor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbStyleBrush = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlLinearGradient = new System.Windows.Forms.Panel();
            this.trbLinearGradient = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTextFill = new System.Windows.Forms.Panel();
            this.btnBrown = new System.Windows.Forms.Button();
            this.ptbTextFill = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlHatchFill = new System.Windows.Forms.Panel();
            this.cbbHatchFill = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlOptionPen = new System.Windows.Forms.Panel();
            this.cbBorder = new System.Windows.Forms.CheckBox();
            this.ptbColorBorder = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.trbSize = new System.Windows.Forms.TrackBar();
            this.lbPen = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbStylePen = new System.Windows.Forms.ComboBox();
            this.pnlOption2 = new System.Windows.Forms.Panel();
            this.cbBrush = new System.Windows.Forms.CheckBox();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlOption1.SuspendLayout();
            this.tlpOptionBrush.SuspendLayout();
            this.pnlOptionBrush.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbForeColor)).BeginInit();
            this.pnlLinearGradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLinearGradient)).BeginInit();
            this.pnlTextFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTextFill)).BeginInit();
            this.pnlHatchFill.SuspendLayout();
            this.pnlOptionPen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSize)).BeginInit();
            this.pnlOption2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pic);
            this.pnlMain.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(198, 5);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(861, 663);
            this.pnlMain.TabIndex = 0;
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(861, 663);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDoubleClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlOption1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpOptionBrush, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pnlOptionPen, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlOption2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(189, 665);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlOption1
            // 
            this.pnlOption1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOption1.Controls.Add(this.btnNew);
            this.pnlOption1.Controls.Add(this.btnZoom);
            this.pnlOption1.Controls.Add(this.btnGroup);
            this.pnlOption1.Controls.Add(this.btnSelect);
            this.pnlOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOption1.Location = new System.Drawing.Point(3, 4);
            this.pnlOption1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlOption1.Name = "pnlOption1";
            this.pnlOption1.Size = new System.Drawing.Size(183, 72);
            this.pnlOption1.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(2, 37);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(177, 30);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.BackColor = System.Drawing.Color.White;
            this.btnZoom.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoom.Location = new System.Drawing.Point(124, 4);
            this.btnZoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(55, 30);
            this.btnZoom.TabIndex = 1;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = false;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.White;
            this.btnGroup.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroup.Location = new System.Drawing.Point(63, 4);
            this.btnGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(55, 30);
            this.btnGroup.TabIndex = 1;
            this.btnGroup.Text = "Group";
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(2, 4);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(55, 30);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tlpOptionBrush
            // 
            this.tlpOptionBrush.ColumnCount = 1;
            this.tlpOptionBrush.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptionBrush.Controls.Add(this.pnlOptionBrush, 0, 0);
            this.tlpOptionBrush.Controls.Add(this.pnlLinearGradient, 0, 3);
            this.tlpOptionBrush.Controls.Add(this.pnlTextFill, 0, 2);
            this.tlpOptionBrush.Controls.Add(this.pnlHatchFill, 0, 1);
            this.tlpOptionBrush.Location = new System.Drawing.Point(3, 408);
            this.tlpOptionBrush.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpOptionBrush.Name = "tlpOptionBrush";
            this.tlpOptionBrush.RowCount = 4;
            this.tlpOptionBrush.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptionBrush.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptionBrush.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptionBrush.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptionBrush.Size = new System.Drawing.Size(183, 379);
            this.tlpOptionBrush.TabIndex = 14;
            // 
            // pnlOptionBrush
            // 
            this.pnlOptionBrush.AutoSize = true;
            this.pnlOptionBrush.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOptionBrush.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptionBrush.Controls.Add(this.ptbBackColor);
            this.pnlOptionBrush.Controls.Add(this.label8);
            this.pnlOptionBrush.Controls.Add(this.ptbForeColor);
            this.pnlOptionBrush.Controls.Add(this.label5);
            this.pnlOptionBrush.Controls.Add(this.label4);
            this.pnlOptionBrush.Controls.Add(this.cbbStyleBrush);
            this.pnlOptionBrush.Controls.Add(this.label6);
            this.pnlOptionBrush.Location = new System.Drawing.Point(3, 4);
            this.pnlOptionBrush.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlOptionBrush.Name = "pnlOptionBrush";
            this.pnlOptionBrush.Size = new System.Drawing.Size(177, 139);
            this.pnlOptionBrush.TabIndex = 13;
            // 
            // ptbBackColor
            // 
            this.ptbBackColor.BackColor = System.Drawing.Color.Black;
            this.ptbBackColor.Location = new System.Drawing.Point(121, 83);
            this.ptbBackColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbBackColor.Name = "ptbBackColor";
            this.ptbBackColor.Size = new System.Drawing.Size(50, 50);
            this.ptbBackColor.TabIndex = 19;
            this.ptbBackColor.TabStop = false;
            this.ptbBackColor.Click += new System.EventHandler(this.ChooseColor);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "BackColor";
            // 
            // ptbForeColor
            // 
            this.ptbForeColor.BackColor = System.Drawing.Color.Black;
            this.ptbForeColor.Location = new System.Drawing.Point(5, 83);
            this.ptbForeColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbForeColor.Name = "ptbForeColor";
            this.ptbForeColor.Size = new System.Drawing.Size(50, 50);
            this.ptbForeColor.TabIndex = 17;
            this.ptbForeColor.TabStop = false;
            this.ptbForeColor.Click += new System.EventHandler(this.ChooseColor);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "ForeColor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, -4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Brush";
            // 
            // cbbStyleBrush
            // 
            this.cbbStyleBrush.FormattingEnabled = true;
            this.cbbStyleBrush.Location = new System.Drawing.Point(1, 33);
            this.cbbStyleBrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbStyleBrush.Name = "cbbStyleBrush";
            this.cbbStyleBrush.Size = new System.Drawing.Size(174, 27);
            this.cbbStyleBrush.TabIndex = 0;
            this.cbbStyleBrush.Text = "Style";
            this.cbbStyleBrush.SelectedIndexChanged += new System.EventHandler(this.cbbStyleBrush_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Brush Style";
            // 
            // pnlLinearGradient
            // 
            this.pnlLinearGradient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLinearGradient.Controls.Add(this.trbLinearGradient);
            this.pnlLinearGradient.Controls.Add(this.label7);
            this.pnlLinearGradient.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLinearGradient.Location = new System.Drawing.Point(3, 302);
            this.pnlLinearGradient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLinearGradient.Name = "pnlLinearGradient";
            this.pnlLinearGradient.Size = new System.Drawing.Size(177, 75);
            this.pnlLinearGradient.TabIndex = 15;
            // 
            // trbLinearGradient
            // 
            this.trbLinearGradient.Location = new System.Drawing.Point(-1, 19);
            this.trbLinearGradient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trbLinearGradient.Maximum = 90;
            this.trbLinearGradient.Name = "trbLinearGradient";
            this.trbLinearGradient.Size = new System.Drawing.Size(176, 56);
            this.trbLinearGradient.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "LinearGradient";
            // 
            // pnlTextFill
            // 
            this.pnlTextFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTextFill.Controls.Add(this.btnBrown);
            this.pnlTextFill.Controls.Add(this.ptbTextFill);
            this.pnlTextFill.Controls.Add(this.label9);
            this.pnlTextFill.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTextFill.Location = new System.Drawing.Point(3, 225);
            this.pnlTextFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTextFill.Name = "pnlTextFill";
            this.pnlTextFill.Size = new System.Drawing.Size(177, 69);
            this.pnlTextFill.TabIndex = 15;
            // 
            // btnBrown
            // 
            this.btnBrown.Location = new System.Drawing.Point(65, 19);
            this.btnBrown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(100, 40);
            this.btnBrown.TabIndex = 3;
            this.btnBrown.Text = "Brown";
            this.btnBrown.UseVisualStyleBackColor = true;
            this.btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // ptbTextFill
            // 
            this.ptbTextFill.BackColor = System.Drawing.Color.Black;
            this.ptbTextFill.BackgroundImage = global::Simple_Paint.Properties.Resources._0;
            this.ptbTextFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbTextFill.Location = new System.Drawing.Point(15, 19);
            this.ptbTextFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbTextFill.Name = "ptbTextFill";
            this.ptbTextFill.Size = new System.Drawing.Size(40, 40);
            this.ptbTextFill.TabIndex = 2;
            this.ptbTextFill.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "TextFill";
            // 
            // pnlHatchFill
            // 
            this.pnlHatchFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHatchFill.Controls.Add(this.cbbHatchFill);
            this.pnlHatchFill.Controls.Add(this.label10);
            this.pnlHatchFill.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHatchFill.Location = new System.Drawing.Point(3, 151);
            this.pnlHatchFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHatchFill.Name = "pnlHatchFill";
            this.pnlHatchFill.Size = new System.Drawing.Size(177, 66);
            this.pnlHatchFill.TabIndex = 1;
            // 
            // cbbHatchFill
            // 
            this.cbbHatchFill.FormattingEnabled = true;
            this.cbbHatchFill.Location = new System.Drawing.Point(0, 25);
            this.cbbHatchFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbHatchFill.Name = "cbbHatchFill";
            this.cbbHatchFill.Size = new System.Drawing.Size(173, 27);
            this.cbbHatchFill.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "HatchFill";
            // 
            // pnlOptionPen
            // 
            this.pnlOptionPen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOptionPen.Controls.Add(this.cbBorder);
            this.pnlOptionPen.Controls.Add(this.ptbColorBorder);
            this.pnlOptionPen.Controls.Add(this.label12);
            this.pnlOptionPen.Controls.Add(this.label13);
            this.pnlOptionPen.Controls.Add(this.trbSize);
            this.pnlOptionPen.Controls.Add(this.lbPen);
            this.pnlOptionPen.Controls.Add(this.label11);
            this.pnlOptionPen.Controls.Add(this.cbbStylePen);
            this.pnlOptionPen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptionPen.Location = new System.Drawing.Point(3, 224);
            this.pnlOptionPen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlOptionPen.Name = "pnlOptionPen";
            this.pnlOptionPen.Size = new System.Drawing.Size(183, 176);
            this.pnlOptionPen.TabIndex = 14;
            // 
            // cbBorder
            // 
            this.cbBorder.AutoSize = true;
            this.cbBorder.Location = new System.Drawing.Point(96, 132);
            this.cbBorder.Name = "cbBorder";
            this.cbBorder.Size = new System.Drawing.Size(73, 23);
            this.cbBorder.TabIndex = 1;
            this.cbBorder.Text = "Border";
            this.cbBorder.UseVisualStyleBackColor = true;
            this.cbBorder.CheckedChanged += new System.EventHandler(this.cbBorder_CheckedChanged);
            // 
            // ptbColorBorder
            // 
            this.ptbColorBorder.BackColor = System.Drawing.Color.Black;
            this.ptbColorBorder.Location = new System.Drawing.Point(14, 117);
            this.ptbColorBorder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbColorBorder.Name = "ptbColorBorder";
            this.ptbColorBorder.Size = new System.Drawing.Size(50, 50);
            this.ptbColorBorder.TabIndex = 14;
            this.ptbColorBorder.TabStop = false;
            this.ptbColorBorder.Click += new System.EventHandler(this.ChooseColor);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Color";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(76, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Size";
            // 
            // trbSize
            // 
            this.trbSize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trbSize.Location = new System.Drawing.Point(0, 67);
            this.trbSize.Maximum = 40;
            this.trbSize.Name = "trbSize";
            this.trbSize.Size = new System.Drawing.Size(178, 56);
            this.trbSize.TabIndex = 1;
            this.trbSize.Value = 5;
            this.trbSize.Scroll += new System.EventHandler(this.trbSize_Scroll);
            // 
            // lbPen
            // 
            this.lbPen.AutoSize = true;
            this.lbPen.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPen.Location = new System.Drawing.Point(-1, -2);
            this.lbPen.Name = "lbPen";
            this.lbPen.Size = new System.Drawing.Size(41, 25);
            this.lbPen.TabIndex = 11;
            this.lbPen.Text = "Pen";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Pen Style";
            // 
            // cbbStylePen
            // 
            this.cbbStylePen.FormattingEnabled = true;
            this.cbbStylePen.Location = new System.Drawing.Point(3, 27);
            this.cbbStylePen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbStylePen.Name = "cbbStylePen";
            this.cbbStylePen.Size = new System.Drawing.Size(173, 27);
            this.cbbStylePen.TabIndex = 0;
            this.cbbStylePen.Text = "Style";
            // 
            // pnlOption2
            // 
            this.pnlOption2.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlOption2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOption2.Controls.Add(this.cbBrush);
            this.pnlOption2.Controls.Add(this.btnPolygon);
            this.pnlOption2.Controls.Add(this.btnCurve);
            this.pnlOption2.Controls.Add(this.btnCircle);
            this.pnlOption2.Controls.Add(this.btnSquare);
            this.pnlOption2.Controls.Add(this.btnEllipse);
            this.pnlOption2.Controls.Add(this.btnRectangle);
            this.pnlOption2.Controls.Add(this.btnLine);
            this.pnlOption2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOption2.Location = new System.Drawing.Point(3, 84);
            this.pnlOption2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlOption2.Name = "pnlOption2";
            this.pnlOption2.Size = new System.Drawing.Size(183, 132);
            this.pnlOption2.TabIndex = 0;
            // 
            // cbBrush
            // 
            this.cbBrush.AutoSize = true;
            this.cbBrush.Location = new System.Drawing.Point(96, 102);
            this.cbBrush.Name = "cbBrush";
            this.cbBrush.Size = new System.Drawing.Size(66, 23);
            this.cbBrush.TabIndex = 1;
            this.cbBrush.Text = "Brush";
            this.cbBrush.UseVisualStyleBackColor = true;
            this.cbBrush.CheckedChanged += new System.EventHandler(this.cbBrush_CheckedChanged);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.Silver;
            this.btnPolygon.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolygon.Location = new System.Drawing.Point(-1, 95);
            this.btnPolygon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(86, 34);
            this.btnPolygon.TabIndex = 14;
            this.btnPolygon.Text = "Polygon";
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.BackColor = System.Drawing.Color.Silver;
            this.btnCurve.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurve.Location = new System.Drawing.Point(96, 63);
            this.btnCurve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(86, 34);
            this.btnCurve.TabIndex = 13;
            this.btnCurve.Text = "Curve";
            this.btnCurve.UseVisualStyleBackColor = false;
            this.btnCurve.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.Silver;
            this.btnCircle.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircle.Location = new System.Drawing.Point(-1, 63);
            this.btnCircle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(86, 34);
            this.btnCircle.TabIndex = 12;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Silver;
            this.btnSquare.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(96, 32);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(86, 34);
            this.btnSquare.TabIndex = 11;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Silver;
            this.btnEllipse.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEllipse.Location = new System.Drawing.Point(96, -1);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(86, 34);
            this.btnEllipse.TabIndex = 9;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Silver;
            this.btnRectangle.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangle.Location = new System.Drawing.Point(-1, 32);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(86, 34);
            this.btnRectangle.TabIndex = 10;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Silver;
            this.btnLine.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLine.Location = new System.Drawing.Point(-1, 0);
            this.btnLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(86, 34);
            this.btnLine.TabIndex = 8;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnlMain, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1062, 673);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.tableLayoutPanel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlOption1.ResumeLayout(false);
            this.tlpOptionBrush.ResumeLayout(false);
            this.tlpOptionBrush.PerformLayout();
            this.pnlOptionBrush.ResumeLayout(false);
            this.pnlOptionBrush.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbForeColor)).EndInit();
            this.pnlLinearGradient.ResumeLayout(false);
            this.pnlLinearGradient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbLinearGradient)).EndInit();
            this.pnlTextFill.ResumeLayout(false);
            this.pnlTextFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTextFill)).EndInit();
            this.pnlHatchFill.ResumeLayout(false);
            this.pnlHatchFill.PerformLayout();
            this.pnlOptionPen.ResumeLayout(false);
            this.pnlOptionPen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColorBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbSize)).EndInit();
            this.pnlOption2.ResumeLayout(false);
            this.pnlOption2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlOption1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Panel pnlOptionBrush;
        private System.Windows.Forms.PictureBox ptbBackColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ptbForeColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbStyleBrush;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlLinearGradient;
        private System.Windows.Forms.TrackBar trbLinearGradient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlTextFill;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.PictureBox ptbTextFill;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlHatchFill;
        private System.Windows.Forms.ComboBox cbbHatchFill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlOptionPen;
        private System.Windows.Forms.PictureBox ptbColorBorder;
        private System.Windows.Forms.Label lbPen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbStylePen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlOption2;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox cbBrush;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar trbSize;
        private System.Windows.Forms.TableLayoutPanel tlpOptionBrush;
        private System.Windows.Forms.CheckBox cbBorder;
    }
}

