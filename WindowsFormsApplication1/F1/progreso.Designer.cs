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
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(progreso));
            BunifuAnimatorNS.Animation animation7 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
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
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.Transition1.DefaultAnimation = animation5;
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
            this.Lbl1.Size = new System.Drawing.Size(487, 25);
            this.Lbl1.TabIndex = 12;
            this.Lbl1.Text = "Castaneda Hernández, Ricardo José   CH142568";
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
            this.Lbl2.Size = new System.Drawing.Size(492, 25);
            this.Lbl2.TabIndex = 13;
            this.Lbl2.Text = "González Mejía, Camilo Ernesto           GM160506";
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
            this.Lbl3.Size = new System.Drawing.Size(486, 25);
            this.Lbl3.TabIndex = 14;
            this.Lbl3.Text = "Palma Rosales, Imer Alfredo                 PR160001";
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
            this.Lbl4.Size = new System.Drawing.Size(485, 25);
            this.Lbl4.TabIndex = 15;
            this.Lbl4.Text = "Rivera López, Jorge Antonio                 RL160365";
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
            this.Lbl5.Size = new System.Drawing.Size(553, 25);
            this.Lbl5.TabIndex = 16;
            this.Lbl5.Text = "Velásquez Godoy Luis Alexis                VG160303          ";
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
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(50);
            animation7.RotateCoeff = 0.3F;
            animation7.RotateLimit = 0.2F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.Transition2.DefaultAnimation = animation7;
            // 
            // Transition3
            // 
            this.Transition3.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.Transition3.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 1F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 20;
            animation8.Padding = new System.Windows.Forms.Padding(30);
            animation8.RotateCoeff = 0F;
            animation8.RotateLimit = 0F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 0F;
            animation8.TransparencyCoeff = 0F;
            this.Transition3.DefaultAnimation = animation8;
            // 
            // Transition4
            // 
            this.Transition4.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.Transition4.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 1;
            animation6.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 2F;
            animation6.TransparencyCoeff = 0F;
            this.Transition4.DefaultAnimation = animation6;
            // 
            // progreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 556);
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
    }
}