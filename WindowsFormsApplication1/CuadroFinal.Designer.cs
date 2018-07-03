namespace WindowsFormsApplication1
{
    partial class CuadroFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuadroFinal));
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvcuadrofinal = new System.Windows.Forms.DataGridView();
            this.button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCargar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button2 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuadrofinal)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMateria
            // 
            this.cbMateria.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(456, 28);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(127, 28);
            this.cbMateria.TabIndex = 11;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // cbSeccion
            // 
            this.cbSeccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(272, 27);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(56, 28);
            this.cbSeccion.TabIndex = 10;
            this.cbSeccion.SelectedIndexChanged += new System.EventHandler(this.cbSeccion_SelectedIndexChanged);
            // 
            // cbGrado
            // 
            this.cbGrado.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(56, 27);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(121, 28);
            this.cbGrado.TabIndex = 9;
            this.cbGrado.SelectedIndexChanged += new System.EventHandler(this.cbGrado_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(375, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(204, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(2, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grado";
            // 
            // dgvcuadrofinal
            // 
            this.dgvcuadrofinal.AllowUserToAddRows = false;
            this.dgvcuadrofinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvcuadrofinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcuadrofinal.Location = new System.Drawing.Point(12, 119);
            this.dgvcuadrofinal.Name = "dgvcuadrofinal";
            this.dgvcuadrofinal.Size = new System.Drawing.Size(640, 269);
            this.dgvcuadrofinal.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.BorderRadius = 0;
            this.button1.ButtonText = "Exportar a PDF";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DisabledColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Iconcolor = System.Drawing.Color.Transparent;
            this.button1.Iconimage = ((System.Drawing.Image)(resources.GetObject("button1.Iconimage")));
            this.button1.Iconimage_right = null;
            this.button1.Iconimage_right_Selected = null;
            this.button1.Iconimage_Selected = null;
            this.button1.IconMarginLeft = 0;
            this.button1.IconMarginRight = 0;
            this.button1.IconRightVisible = true;
            this.button1.IconRightZoom = 0D;
            this.button1.IconVisible = true;
            this.button1.IconZoom = 90D;
            this.button1.IsTab = false;
            this.button1.Location = new System.Drawing.Point(133, 394);
            this.button1.Name = "button1";
            this.button1.Normalcolor = System.Drawing.Color.Teal;
            this.button1.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.button1.OnHoverTextColor = System.Drawing.Color.White;
            this.button1.selected = false;
            this.button1.Size = new System.Drawing.Size(195, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Exportar a PDF";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Textcolor = System.Drawing.Color.White;
            this.button1.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCargar
            // 
            this.btnCargar.Activecolor = System.Drawing.Color.Blue;
            this.btnCargar.BackColor = System.Drawing.Color.Green;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.BorderRadius = 0;
            this.btnCargar.ButtonText = "Cargar ";
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCargar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCargar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCargar.Iconimage")));
            this.btnCargar.Iconimage_right = null;
            this.btnCargar.Iconimage_right_Selected = null;
            this.btnCargar.Iconimage_Selected = null;
            this.btnCargar.IconMarginLeft = 0;
            this.btnCargar.IconMarginRight = 0;
            this.btnCargar.IconRightVisible = true;
            this.btnCargar.IconRightZoom = 0D;
            this.btnCargar.IconVisible = true;
            this.btnCargar.IconZoom = 90D;
            this.btnCargar.IsTab = false;
            this.btnCargar.Location = new System.Drawing.Point(520, 65);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Normalcolor = System.Drawing.Color.Green;
            this.btnCargar.OnHovercolor = System.Drawing.Color.Lime;
            this.btnCargar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCargar.selected = false;
            this.btnCargar.Size = new System.Drawing.Size(131, 33);
            this.btnCargar.TabIndex = 36;
            this.btnCargar.Text = "Cargar ";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Textcolor = System.Drawing.Color.White;
            this.btnCargar.TextFont = new System.Drawing.Font("Century", 14F, System.Drawing.FontStyle.Bold);
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // button2
            // 
            this.button2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.BorderRadius = 0;
            this.button2.ButtonText = "GRAFICOS";
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DisabledColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Iconcolor = System.Drawing.Color.Transparent;
            this.button2.Iconimage = ((System.Drawing.Image)(resources.GetObject("button2.Iconimage")));
            this.button2.Iconimage_right = null;
            this.button2.Iconimage_right_Selected = null;
            this.button2.Iconimage_Selected = null;
            this.button2.IconMarginLeft = 0;
            this.button2.IconMarginRight = 0;
            this.button2.IconRightVisible = true;
            this.button2.IconRightZoom = 0D;
            this.button2.IconVisible = true;
            this.button2.IconZoom = 90D;
            this.button2.IsTab = false;
            this.button2.Location = new System.Drawing.Point(334, 394);
            this.button2.Name = "button2";
            this.button2.Normalcolor = System.Drawing.Color.Teal;
            this.button2.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.button2.OnHoverTextColor = System.Drawing.Color.White;
            this.button2.selected = false;
            this.button2.Size = new System.Drawing.Size(195, 48);
            this.button2.TabIndex = 37;
            this.button2.Text = "GRAFICOS";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Textcolor = System.Drawing.Color.White;
            this.button2.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // CuadroFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(664, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvcuadrofinal);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbSeccion);
            this.Controls.Add(this.cbGrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CuadroFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuadroFinal";
            this.Load += new System.EventHandler(this.CuadroFinal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcuadrofinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvcuadrofinal;
        private Bunifu.Framework.UI.BunifuFlatButton button1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCargar;
        private Bunifu.Framework.UI.BunifuFlatButton button2;

    }
}