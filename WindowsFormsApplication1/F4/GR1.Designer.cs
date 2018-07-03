namespace WindowsFormsApplication1.F4
{
    partial class GR1
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GR1));
            this.año = new System.Windows.Forms.ComboBox();
            this.grado = new System.Windows.Forms.ComboBox();
            this.seccion = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Actualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.año2 = new System.Windows.Forms.ComboBox();
            this.VgRAF = new Bunifu.Framework.UI.BunifuThinButton2();
            this.trimestres = new System.Windows.Forms.ComboBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.regresar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.regre1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // año
            // 
            this.bunifuTransition1.SetDecoration(this.año, BunifuAnimatorNS.DecorationType.None);
            this.año.FormattingEnabled = true;
            this.año.Location = new System.Drawing.Point(15, 13);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(121, 21);
            this.año.TabIndex = 0;
            this.año.SelectedIndexChanged += new System.EventHandler(this.año_SelectedIndexChanged);
            // 
            // grado
            // 
            this.bunifuTransition1.SetDecoration(this.grado, BunifuAnimatorNS.DecorationType.None);
            this.grado.FormattingEnabled = true;
            this.grado.Location = new System.Drawing.Point(171, 13);
            this.grado.Name = "grado";
            this.grado.Size = new System.Drawing.Size(121, 21);
            this.grado.TabIndex = 1;
            this.grado.SelectedIndexChanged += new System.EventHandler(this.grado_SelectedIndexChanged);
            // 
            // seccion
            // 
            this.bunifuTransition1.SetDecoration(this.seccion, BunifuAnimatorNS.DecorationType.None);
            this.seccion.FormattingEnabled = true;
            this.seccion.Location = new System.Drawing.Point(344, 13);
            this.seccion.Name = "seccion";
            this.seccion.Size = new System.Drawing.Size(121, 21);
            this.seccion.TabIndex = 2;
            this.seccion.SelectedIndexChanged += new System.EventHandler(this.seccion_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.dataGridView1, BunifuAnimatorNS.DecorationType.None);
            this.dataGridView1.Location = new System.Drawing.Point(244, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(400, 266);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Actualizar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 80);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(839, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Location = new System.Drawing.Point(589, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Materia";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.materia);
            this.panel3.Controls.Add(this.seccion);
            this.panel3.Controls.Add(this.grado);
            this.panel3.Controls.Add(this.año);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(73, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(663, 53);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // materia
            // 
            this.bunifuTransition1.SetDecoration(this.materia, BunifuAnimatorNS.DecorationType.None);
            this.materia.FormattingEnabled = true;
            this.materia.Location = new System.Drawing.Point(519, 13);
            this.materia.Name = "materia";
            this.materia.Size = new System.Drawing.Size(121, 21);
            this.materia.TabIndex = 3;
            this.materia.SelectedIndexChanged += new System.EventHandler(this.materia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(414, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seccion";
            // 
            // Actualizar
            // 
            this.Actualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Actualizar.BorderRadius = 0;
            this.Actualizar.ButtonText = "bunifuFlatButton1";
            this.Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.Actualizar, BunifuAnimatorNS.DecorationType.None);
            this.Actualizar.DisabledColor = System.Drawing.Color.Gray;
            this.Actualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.Actualizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("Actualizar.Iconimage")));
            this.Actualizar.Iconimage_right = null;
            this.Actualizar.Iconimage_right_Selected = null;
            this.Actualizar.Iconimage_Selected = null;
            this.Actualizar.IconMarginLeft = 0;
            this.Actualizar.IconMarginRight = 0;
            this.Actualizar.IconRightVisible = true;
            this.Actualizar.IconRightZoom = 0D;
            this.Actualizar.IconVisible = true;
            this.Actualizar.IconZoom = 90D;
            this.Actualizar.IsTab = false;
            this.Actualizar.Location = new System.Drawing.Point(796, 24);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Actualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Actualizar.OnHoverTextColor = System.Drawing.Color.White;
            this.Actualizar.selected = false;
            this.Actualizar.Size = new System.Drawing.Size(37, 34);
            this.Actualizar.TabIndex = 4;
            this.Actualizar.Text = "bunifuFlatButton1";
            this.Actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Actualizar.Textcolor = System.Drawing.Color.White;
            this.Actualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(241, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.año2);
            this.panel2.Controls.Add(this.VgRAF);
            this.panel2.Controls.Add(this.trimestres);
            this.panel2.Controls.Add(this.bunifuThinButton21);
            this.panel2.Controls.Add(this.regresar);
            this.panel2.Controls.Add(this.regre1);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 86);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(402, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Año 2";
            this.label5.Visible = false;
            // 
            // año2
            // 
            this.bunifuTransition1.SetDecoration(this.año2, BunifuAnimatorNS.DecorationType.None);
            this.año2.FormattingEnabled = true;
            this.año2.Location = new System.Drawing.Point(396, 40);
            this.año2.Name = "año2";
            this.año2.Size = new System.Drawing.Size(121, 21);
            this.año2.TabIndex = 8;
            this.año2.Visible = false;
            this.año2.SelectedIndexChanged += new System.EventHandler(this.año2_SelectedIndexChanged);
            // 
            // VgRAF
            // 
            this.VgRAF.ActiveBorderThickness = 1;
            this.VgRAF.ActiveCornerRadius = 20;
            this.VgRAF.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.VgRAF.ActiveForecolor = System.Drawing.Color.White;
            this.VgRAF.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.VgRAF.BackColor = System.Drawing.Color.White;
            this.VgRAF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VgRAF.BackgroundImage")));
            this.VgRAF.ButtonText = "Ver gráficos";
            this.VgRAF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.VgRAF, BunifuAnimatorNS.DecorationType.None);
            this.VgRAF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VgRAF.ForeColor = System.Drawing.Color.SeaGreen;
            this.VgRAF.IdleBorderThickness = 1;
            this.VgRAF.IdleCornerRadius = 20;
            this.VgRAF.IdleFillColor = System.Drawing.Color.Silver;
            this.VgRAF.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.VgRAF.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.VgRAF.Location = new System.Drawing.Point(663, 19);
            this.VgRAF.Margin = new System.Windows.Forms.Padding(5);
            this.VgRAF.Name = "VgRAF";
            this.VgRAF.Size = new System.Drawing.Size(186, 42);
            this.VgRAF.TabIndex = 3;
            this.VgRAF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VgRAF.Visible = false;
            this.VgRAF.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // trimestres
            // 
            this.trimestres.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bunifuTransition1.SetDecoration(this.trimestres, BunifuAnimatorNS.DecorationType.None);
            this.trimestres.FormattingEnabled = true;
            this.trimestres.Location = new System.Drawing.Point(145, 52);
            this.trimestres.Name = "trimestres";
            this.trimestres.Size = new System.Drawing.Size(186, 21);
            this.trimestres.TabIndex = 1;
            this.trimestres.Visible = false;
            this.trimestres.SelectedIndexChanged += new System.EventHandler(this.trimestres_SelectedIndexChanged);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Ver por trimestre";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuThinButton21, BunifuAnimatorNS.DecorationType.None);
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(145, 10);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(186, 42);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // regresar
            // 
            this.regresar.ActiveBorderThickness = 1;
            this.regresar.ActiveCornerRadius = 20;
            this.regresar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.regresar.ActiveForecolor = System.Drawing.Color.White;
            this.regresar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.regresar.BackColor = System.Drawing.Color.White;
            this.regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regresar.BackgroundImage")));
            this.regresar.ButtonText = "Regresar";
            this.regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.regresar, BunifuAnimatorNS.DecorationType.None);
            this.regresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ForeColor = System.Drawing.Color.SeaGreen;
            this.regresar.IdleBorderThickness = 1;
            this.regresar.IdleCornerRadius = 20;
            this.regresar.IdleFillColor = System.Drawing.Color.Silver;
            this.regresar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.regresar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.regresar.Location = new System.Drawing.Point(145, 10);
            this.regresar.Margin = new System.Windows.Forms.Padding(5);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(186, 42);
            this.regresar.TabIndex = 2;
            this.regresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regresar.Visible = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // regre1
            // 
            this.regre1.ActiveBorderThickness = 1;
            this.regre1.ActiveCornerRadius = 20;
            this.regre1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.regre1.ActiveForecolor = System.Drawing.Color.White;
            this.regre1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.regre1.BackColor = System.Drawing.Color.White;
            this.regre1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regre1.BackgroundImage")));
            this.regre1.ButtonText = "Ver datos";
            this.regre1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.regre1, BunifuAnimatorNS.DecorationType.None);
            this.regre1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regre1.ForeColor = System.Drawing.Color.SeaGreen;
            this.regre1.IdleBorderThickness = 1;
            this.regre1.IdleCornerRadius = 20;
            this.regre1.IdleFillColor = System.Drawing.Color.Silver;
            this.regre1.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.regre1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.regre1.Location = new System.Drawing.Point(663, 19);
            this.regre1.Margin = new System.Windows.Forms.Padding(5);
            this.regre1.Name = "regre1";
            this.regre1.Size = new System.Drawing.Size(186, 42);
            this.regre1.TabIndex = 4;
            this.regre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regre1.Visible = false;
            this.regre1.Click += new System.EventHandler(this.regre1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.dataGridView2, BunifuAnimatorNS.DecorationType.None);
            this.dataGridView2.Location = new System.Drawing.Point(165, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(600, 293);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.Visible = false;
            // 
            // panel4
            // 
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(37, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(66, 100);
            this.panel4.TabIndex = 7;
            this.panel4.Visible = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.Interval = 1;
            this.bunifuTransition1.MaxAnimationTime = 15000;
            // 
            // GR1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 542);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "GR1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GR1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox año;
        private System.Windows.Forms.ComboBox grado;
        private System.Windows.Forms.ComboBox seccion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox materia;
        private Bunifu.Framework.UI.BunifuFlatButton Actualizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox trimestres;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 regresar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuThinButton2 VgRAF;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuThinButton2 regre1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox año2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}