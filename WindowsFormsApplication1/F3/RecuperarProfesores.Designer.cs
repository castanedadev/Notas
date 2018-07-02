namespace WindowsFormsApplication1.F3
{
    partial class RecuperarProfesores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarProfesores));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRmulti = new System.Windows.Forms.Button();
            this.btnRsimple = new System.Windows.Forms.Button();
            this.btnAgregarMulti = new System.Windows.Forms.Button();
            this.btnAgregarSimple = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnVer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnContinuar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnContinuar);
            this.bunifuGradientPanel1.Controls.Add(this.btnVer);
            this.bunifuGradientPanel1.Controls.Add(this.comboBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnRmulti);
            this.bunifuGradientPanel1.Controls.Add(this.btnRsimple);
            this.bunifuGradientPanel1.Controls.Add(this.btnAgregarMulti);
            this.bunifuGradientPanel1.Controls.Add(this.btnAgregarSimple);
            this.bunifuGradientPanel1.Controls.Add(this.listBox2);
            this.bunifuGradientPanel1.Controls.Add(this.listBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(232)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(232)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(232)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Empty;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(719, 725);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // btnRmulti
            // 
            this.btnRmulti.BackColor = System.Drawing.SystemColors.Window;
            this.btnRmulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRmulti.Location = new System.Drawing.Point(316, 374);
            this.btnRmulti.Name = "btnRmulti";
            this.btnRmulti.Size = new System.Drawing.Size(90, 38);
            this.btnRmulti.TabIndex = 11;
            this.btnRmulti.Text = "<<";
            this.toolTip1.SetToolTip(this.btnRmulti, "Pasar todos los elementos a la izquierda");
            this.btnRmulti.UseVisualStyleBackColor = false;
            // 
            // btnRsimple
            // 
            this.btnRsimple.BackColor = System.Drawing.SystemColors.Window;
            this.btnRsimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRsimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRsimple.Location = new System.Drawing.Point(316, 317);
            this.btnRsimple.Name = "btnRsimple";
            this.btnRsimple.Size = new System.Drawing.Size(90, 38);
            this.btnRsimple.TabIndex = 10;
            this.btnRsimple.Text = "<-";
            this.toolTip1.SetToolTip(this.btnRsimple, "Pasar un elemento a la izquierda");
            this.btnRsimple.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMulti
            // 
            this.btnAgregarMulti.BackColor = System.Drawing.SystemColors.Window;
            this.btnAgregarMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMulti.Location = new System.Drawing.Point(316, 259);
            this.btnAgregarMulti.Name = "btnAgregarMulti";
            this.btnAgregarMulti.Size = new System.Drawing.Size(90, 38);
            this.btnAgregarMulti.TabIndex = 9;
            this.btnAgregarMulti.Text = ">>";
            this.toolTip1.SetToolTip(this.btnAgregarMulti, "Pasar todos los elementos a la derecha");
            this.btnAgregarMulti.UseVisualStyleBackColor = false;
            // 
            // btnAgregarSimple
            // 
            this.btnAgregarSimple.BackColor = System.Drawing.SystemColors.Window;
            this.btnAgregarSimple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSimple.Location = new System.Drawing.Point(316, 193);
            this.btnAgregarSimple.Name = "btnAgregarSimple";
            this.btnAgregarSimple.Size = new System.Drawing.Size(90, 38);
            this.btnAgregarSimple.TabIndex = 8;
            this.btnAgregarSimple.Text = "->";
            this.toolTip1.SetToolTip(this.btnAgregarSimple, "Pasar un elemento a la derecha");
            this.btnAgregarSimple.UseVisualStyleBackColor = false;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(442, 130);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(265, 382);
            this.listBox2.TabIndex = 7;
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(21, 130);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(265, 382);
            this.listBox1.TabIndex = 1;
            // 
            // btnVer
            // 
            this.btnVer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.BorderRadius = 0;
            this.btnVer.ButtonText = "Ver perfil  (avanzado)";
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.DisabledColor = System.Drawing.Color.Gray;
            this.btnVer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVer.Iconimage")));
            this.btnVer.Iconimage_right = null;
            this.btnVer.Iconimage_right_Selected = null;
            this.btnVer.Iconimage_Selected = null;
            this.btnVer.IconMarginLeft = 0;
            this.btnVer.IconMarginRight = 0;
            this.btnVer.IconRightVisible = true;
            this.btnVer.IconRightZoom = 0D;
            this.btnVer.IconVisible = true;
            this.btnVer.IconZoom = 90D;
            this.btnVer.IsTab = false;
            this.btnVer.Location = new System.Drawing.Point(442, 530);
            this.btnVer.Name = "btnVer";
            this.btnVer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnVer.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnVer.selected = false;
            this.btnVer.Size = new System.Drawing.Size(265, 48);
            this.btnVer.TabIndex = 13;
            this.btnVer.Text = "Ver perfil  (avanzado)";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Textcolor = System.Drawing.Color.Black;
            this.btnVer.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnContinuar
            // 
            this.btnContinuar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContinuar.BorderRadius = 0;
            this.btnContinuar.ButtonText = "Continuar";
            this.btnContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinuar.DisabledColor = System.Drawing.Color.Gray;
            this.btnContinuar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnContinuar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnContinuar.Iconimage")));
            this.btnContinuar.Iconimage_right = null;
            this.btnContinuar.Iconimage_right_Selected = null;
            this.btnContinuar.Iconimage_Selected = null;
            this.btnContinuar.IconMarginLeft = 0;
            this.btnContinuar.IconMarginRight = 0;
            this.btnContinuar.IconRightVisible = true;
            this.btnContinuar.IconRightZoom = 0D;
            this.btnContinuar.IconVisible = true;
            this.btnContinuar.IconZoom = 90D;
            this.btnContinuar.IsTab = false;
            this.btnContinuar.Location = new System.Drawing.Point(238, 615);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnContinuar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnContinuar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnContinuar.selected = false;
            this.btnContinuar.Size = new System.Drawing.Size(265, 48);
            this.btnContinuar.TabIndex = 14;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinuar.Textcolor = System.Drawing.Color.Black;
            this.btnContinuar.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // RecuperarProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 725);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "RecuperarProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RecuperarProfesores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRmulti;
        private System.Windows.Forms.Button btnAgregarMulti;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAgregarSimple;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRsimple;
        private Bunifu.Framework.UI.BunifuFlatButton btnVer;
        private Bunifu.Framework.UI.BunifuFlatButton btnContinuar;
    }
}