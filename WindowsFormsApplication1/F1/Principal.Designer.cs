namespace WindowsFormsApplication1.F1
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.principal1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.completo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.izquierda = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.weaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topa = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.principal1.SuspendLayout();
            this.izquierda.SuspendLayout();
            this.menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.topa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // principal1
            // 
            this.principal1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("principal1.BackgroundImage")));
            this.principal1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.principal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.principal1.Controls.Add(this.completo);
            this.principal1.Controls.Add(this.izquierda);
            this.principal1.Controls.Add(this.menu);
            this.principal1.Controls.Add(this.topa);
            this.bunifuTransition1.SetDecoration(this.principal1, BunifuAnimatorNS.DecorationType.None);
            this.principal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.principal1.GradientBottomLeft = System.Drawing.Color.White;
            this.principal1.GradientBottomRight = System.Drawing.Color.White;
            this.principal1.GradientTopLeft = System.Drawing.Color.White;
            this.principal1.GradientTopRight = System.Drawing.Color.White;
            this.principal1.Location = new System.Drawing.Point(0, 0);
            this.principal1.Name = "principal1";
            this.principal1.Quality = 10;
            this.principal1.Size = new System.Drawing.Size(891, 610);
            this.principal1.TabIndex = 0;
            // 
            // completo
            // 
            this.completo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("completo.BackgroundImage")));
            this.completo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.completo, BunifuAnimatorNS.DecorationType.None);
            this.completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completo.GradientBottomLeft = System.Drawing.Color.White;
            this.completo.GradientBottomRight = System.Drawing.Color.White;
            this.completo.GradientTopLeft = System.Drawing.Color.White;
            this.completo.GradientTopRight = System.Drawing.Color.White;
            this.completo.Location = new System.Drawing.Point(179, 61);
            this.completo.Name = "completo";
            this.completo.Quality = 10;
            this.completo.Size = new System.Drawing.Size(710, 547);
            this.completo.TabIndex = 3;
            // 
            // izquierda
            // 
            this.izquierda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("izquierda.BackgroundImage")));
            this.izquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.izquierda.Controls.Add(this.bunifuFlatButton2);
            this.izquierda.Controls.Add(this.bunifuFlatButton1);
            this.bunifuTransition1.SetDecoration(this.izquierda, BunifuAnimatorNS.DecorationType.None);
            this.izquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.izquierda.GradientBottomLeft = System.Drawing.Color.White;
            this.izquierda.GradientBottomRight = System.Drawing.Color.White;
            this.izquierda.GradientTopLeft = System.Drawing.Color.White;
            this.izquierda.GradientTopRight = System.Drawing.Color.White;
            this.izquierda.Location = new System.Drawing.Point(0, 61);
            this.izquierda.Name = "izquierda";
            this.izquierda.Quality = 10;
            this.izquierda.Size = new System.Drawing.Size(179, 547);
            this.izquierda.TabIndex = 2;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "bunifuFlatButton2";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(11, 105);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(151, 59);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "bunifuFlatButton2";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Visible = false;
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(11, 31);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(151, 59);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // menu
            // 
            this.menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu.BackgroundImage")));
            this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu.Controls.Add(this.menuStrip1);
            this.bunifuTransition1.SetDecoration(this.menu, BunifuAnimatorNS.DecorationType.None);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.GradientBottomLeft = System.Drawing.Color.White;
            this.menu.GradientBottomRight = System.Drawing.Color.White;
            this.menu.GradientTopLeft = System.Drawing.Color.White;
            this.menu.GradientTopRight = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(0, 38);
            this.menu.Name = "menu";
            this.menu.Quality = 10;
            this.menu.Size = new System.Drawing.Size(889, 23);
            this.menu.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.bunifuTransition1.SetDecoration(this.menuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.weaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // weaToolStripMenuItem
            // 
            this.weaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCuentaToolStripMenuItem,
            this.algoToolStripMenuItem});
            this.weaToolStripMenuItem.Name = "weaToolStripMenuItem";
            this.weaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.weaToolStripMenuItem.Text = "Archivo";
            // 
            // verCuentaToolStripMenuItem
            // 
            this.verCuentaToolStripMenuItem.Name = "verCuentaToolStripMenuItem";
            this.verCuentaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.verCuentaToolStripMenuItem.Text = "Ver Profesores";
            this.verCuentaToolStripMenuItem.Click += new System.EventHandler(this.verCuentaToolStripMenuItem_Click);
            // 
            // algoToolStripMenuItem
            // 
            this.algoToolStripMenuItem.Name = "algoToolStripMenuItem";
            this.algoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.algoToolStripMenuItem.Text = "Algo";
            // 
            // topa
            // 
            this.topa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topa.BackgroundImage")));
            this.topa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topa.Controls.Add(this.pictureBox4);
            this.topa.Controls.Add(this.pictureBox3);
            this.topa.Controls.Add(this.pictureBox2);
            this.topa.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.topa, BunifuAnimatorNS.DecorationType.None);
            this.topa.Dock = System.Windows.Forms.DockStyle.Top;
            this.topa.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(173)))));
            this.topa.GradientBottomRight = System.Drawing.Color.White;
            this.topa.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(173)))));
            this.topa.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(109)))), ((int)(((byte)(173)))));
            this.topa.Location = new System.Drawing.Point(0, 0);
            this.topa.Name = "topa";
            this.topa.Quality = 10;
            this.topa.Size = new System.Drawing.Size(889, 38);
            this.topa.TabIndex = 0;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = System.Windows.Forms.Cursors.AppStarting;
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
            this.bunifuTransition1.Interval = 45;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(824, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(763, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 24);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Location = new System.Drawing.Point(712, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 24);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Location = new System.Drawing.Point(670, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 24);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 610);
            this.Controls.Add(this.principal1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.principal1.ResumeLayout(false);
            this.izquierda.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.topa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel principal1;
        private Bunifu.Framework.UI.BunifuGradientPanel topa;
        private Bunifu.Framework.UI.BunifuGradientPanel completo;
        private Bunifu.Framework.UI.BunifuGradientPanel izquierda;
        private Bunifu.Framework.UI.BunifuGradientPanel menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem weaToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.ToolStripMenuItem verCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoToolStripMenuItem;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}