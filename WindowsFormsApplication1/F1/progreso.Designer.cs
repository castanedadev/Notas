namespace WindowsFormsApplication1.F1
{
    partial class progreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(progreso));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.Transition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.progressBar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.PLogoUDB = new System.Windows.Forms.PictureBox();
            this.PLogoES = new System.Windows.Forms.PictureBox();
            this.LblUDB = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblMateria = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LblProyect = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Transition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Transition3 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Transition4 = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PLogoUDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLogoES)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Transition1
            // 
            this.Transition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Transition1.Cursor = null;
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
            this.Transition1.DefaultAnimation = animation1;
            // 
            // progressBar1
            // 
            this.progressBar1.animated = true;
            this.progressBar1.animationIterval = 1;
            this.progressBar1.animationSpeed = 1;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBar1.BackgroundImage")));
            this.Transition4.SetDecoration(this.progressBar1, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.progressBar1, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.progressBar1, BunifuAnimatorNS.DecorationType.None);
            this.Transition3.SetDecoration(this.progressBar1, BunifuAnimatorNS.DecorationType.None);
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progressBar1.ForeColor = System.Drawing.Color.Teal;
            this.progressBar1.LabelVisible = true;
            this.progressBar1.LineProgressThickness = 15;
            this.progressBar1.LineThickness = 15;
            this.progressBar1.Location = new System.Drawing.Point(660, 420);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressBar1.MaxValue = 100;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressBackColor = System.Drawing.Color.SkyBlue;
            this.progressBar1.ProgressColor = System.Drawing.Color.Blue;
            this.progressBar1.Size = new System.Drawing.Size(135, 135);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 0;
            // 
            // PLogoUDB
            // 
            this.Transition3.SetDecoration(this.PLogoUDB, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.PLogoUDB, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.PLogoUDB, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.PLogoUDB, BunifuAnimatorNS.DecorationType.None);
            this.PLogoUDB.Image = ((System.Drawing.Image)(resources.GetObject("PLogoUDB.Image")));
            this.PLogoUDB.Location = new System.Drawing.Point(411, 1);
            this.PLogoUDB.Name = "PLogoUDB";
            this.PLogoUDB.Size = new System.Drawing.Size(167, 177);
            this.PLogoUDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PLogoUDB.TabIndex = 2;
            this.PLogoUDB.TabStop = false;
            // 
            // PLogoES
            // 
            this.Transition3.SetDecoration(this.PLogoES, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.PLogoES, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.PLogoES, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.PLogoES, BunifuAnimatorNS.DecorationType.None);
            this.PLogoES.Image = ((System.Drawing.Image)(resources.GetObject("PLogoES.Image")));
            this.PLogoES.Location = new System.Drawing.Point(294, 44);
            this.PLogoES.Name = "PLogoES";
            this.PLogoES.Size = new System.Drawing.Size(260, 185);
            this.PLogoES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PLogoES.TabIndex = 3;
            this.PLogoES.TabStop = false;
            // 
            // LblUDB
            // 
            this.LblUDB.AutoSize = true;
            this.LblUDB.BackColor = System.Drawing.Color.Transparent;
            this.Transition3.SetDecoration(this.LblUDB, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.LblUDB, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.LblUDB, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.LblUDB, BunifuAnimatorNS.DecorationType.None);
            this.LblUDB.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUDB.ForeColor = System.Drawing.Color.Gold;
            this.LblUDB.Location = new System.Drawing.Point(10, 11);
            this.LblUDB.Name = "LblUDB";
            this.LblUDB.Size = new System.Drawing.Size(395, 32);
            this.LblUDB.TabIndex = 5;
            this.LblUDB.Text = "Universidad Don Bosco UDB";
            // 
            // LblMateria
            // 
            this.LblMateria.AutoSize = true;
            this.LblMateria.BackColor = System.Drawing.Color.Transparent;
            this.Transition3.SetDecoration(this.LblMateria, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.LblMateria, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.LblMateria, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.LblMateria, BunifuAnimatorNS.DecorationType.None);
            this.LblMateria.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMateria.Location = new System.Drawing.Point(312, 232);
            this.LblMateria.Name = "LblMateria";
            this.LblMateria.Size = new System.Drawing.Size(234, 29);
            this.LblMateria.TabIndex = 6;
            this.LblMateria.Text = "PROGRAMACIÓN 4";
            // 
            // LblProyect
            // 
            this.LblProyect.AutoSize = true;
            this.LblProyect.BackColor = System.Drawing.Color.Transparent;
            this.Transition3.SetDecoration(this.LblProyect, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.LblProyect, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.LblProyect, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.LblProyect, BunifuAnimatorNS.DecorationType.None);
            this.LblProyect.Font = new System.Drawing.Font("Arial", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProyect.Location = new System.Drawing.Point(238, 274);
            this.LblProyect.Name = "LblProyect";
            this.LblProyect.Size = new System.Drawing.Size(457, 90);
            this.LblProyect.TabIndex = 7;
            this.LblProyect.Text = "SISTEMAS DE ALMACENAMIENTO \r\n                         Y\r\n          CONTROL DE NOT" +
    "AS";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Transition3.SetDecoration(this.Lbl1, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.Lbl1, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.Lbl1, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.Lbl1, BunifuAnimatorNS.DecorationType.None);
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(13, 374);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(384, 25);
            this.Lbl1.TabIndex = 12;
            this.Lbl1.Text = "Castaneda Hernández, Ricardo José   ";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Transition3.SetDecoration(this.Lbl2, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.Lbl2, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.Lbl2, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.Lbl2, BunifuAnimatorNS.DecorationType.None);
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Lbl2.Location = new System.Drawing.Point(13, 412);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(368, 25);
            this.Lbl2.TabIndex = 13;
            this.Lbl2.Text = "González Mejía, Camilo Ernesto        ";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Transition3.SetDecoration(this.Lbl3, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.Lbl3, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.Lbl3, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.Lbl3, BunifuAnimatorNS.DecorationType.None);
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Lbl3.Location = new System.Drawing.Point(13, 446);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(374, 25);
            this.Lbl3.TabIndex = 14;
            this.Lbl3.Text = "Palma Rosales, Imer Alfredo               ";
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Transition3.SetDecoration(this.Lbl4, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.Lbl4, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.Lbl4, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.Lbl4, BunifuAnimatorNS.DecorationType.None);
            this.Lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Lbl4.Location = new System.Drawing.Point(13, 482);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(375, 25);
            this.Lbl4.TabIndex = 15;
            this.Lbl4.Text = "Rivera López, Jorge Antonio               ";
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Transition3.SetDecoration(this.Lbl5, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.Lbl5, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.Lbl5, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.Lbl5, BunifuAnimatorNS.DecorationType.None);
            this.Lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Lbl5.Location = new System.Drawing.Point(13, 516);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(372, 25);
            this.Lbl5.TabIndex = 16;
            this.Lbl5.Text = "Velásquez Godoy Luis Alexis             ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.PLogoUDB);
            this.panel1.Controls.Add(this.LblUDB);
            this.Transition4.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.Transition3.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(203, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 181);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Transition3.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(380, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Universidad Don Bosco Derechos reservados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Transition3.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Desarrolladores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.Transition3.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Realizado: 3/Julio/2018";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Transition2
            // 
            this.Transition2.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlideAndRotate;
            this.Transition2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(50);
            animation3.RotateCoeff = 0.3F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.Transition2.DefaultAnimation = animation3;
            // 
            // Transition3
            // 
            this.Transition3.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.Transition3.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.Transition3.DefaultAnimation = animation4;
            // 
            // Transition4
            // 
            this.Transition4.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.Transition4.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.Transition4.DefaultAnimation = animation2;
            // 
            // progreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 556);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Lbl5);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.LblProyect);
            this.Controls.Add(this.LblMateria);
            this.Controls.Add(this.PLogoES);
            this.Controls.Add(this.panel1);
            this.Transition3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Transition4.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Transition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Transition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "progreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.Load += new System.EventHandler(this.progreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PLogoUDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLogoES)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition Transition1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressBar1;
        private System.Windows.Forms.PictureBox PLogoUDB;
        private System.Windows.Forms.PictureBox PLogoES;
        private Bunifu.Framework.UI.BunifuCustomLabel LblUDB;
        private Bunifu.Framework.UI.BunifuCustomLabel LblMateria;
        private Bunifu.Framework.UI.BunifuCustomLabel LblProyect;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl5;
        private BunifuAnimatorNS.BunifuTransition Transition2;
        private System.Windows.Forms.Panel panel1;
        private BunifuAnimatorNS.BunifuTransition Transition3;
        private BunifuAnimatorNS.BunifuTransition Transition4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}