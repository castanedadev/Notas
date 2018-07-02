namespace WindowsFormsApplication1
{
    partial class Actividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actividades));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.txtPonderacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.rbp35 = new System.Windows.Forms.RadioButton();
            this.rbs35 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvactividades = new System.Windows.Forms.DataGridView();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ponderacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnn = new System.Windows.Forms.TextBox();
            this.txtnp = new System.Windows.Forms.TextBox();
            this.lblnn = new System.Windows.Forms.Label();
            this.lblnp = new System.Windows.Forms.Label();
            this.btnactu = new System.Windows.Forms.Button();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvactividades)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actividad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ponderación";
            // 
            // txtActividad
            // 
            this.txtActividad.Location = new System.Drawing.Point(115, 203);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(150, 20);
            this.txtActividad.TabIndex = 2;
            // 
            // txtPonderacion
            // 
            this.txtPonderacion.Location = new System.Drawing.Point(115, 253);
            this.txtPonderacion.Name = "txtPonderacion";
            this.txtPonderacion.Size = new System.Drawing.Size(71, 20);
            this.txtPonderacion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(361, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Materia";
            // 
            // cbGrado
            // 
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(69, 31);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(121, 21);
            this.cbGrado.TabIndex = 6;
            this.cbGrado.SelectedIndexChanged += new System.EventHandler(this.cbGrado_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(429, 30);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(153, 21);
            this.cbMateria.TabIndex = 7;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 290);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total: ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(411, 356);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 13);
            this.lbltotal.TabIndex = 11;
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt1.Location = new System.Drawing.Point(16, 58);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(87, 19);
            this.rbt1.TabIndex = 12;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Trimestre 1";
            this.rbt1.UseVisualStyleBackColor = true;
            this.rbt1.CheckedChanged += new System.EventHandler(this.rbp1_CheckedChanged);
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbt2.Location = new System.Drawing.Point(156, 63);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(87, 19);
            this.rbt2.TabIndex = 13;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Trimestre 2";
            this.rbt2.UseVisualStyleBackColor = true;
            this.rbt2.CheckedChanged += new System.EventHandler(this.rbp2_CheckedChanged);
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rbt3.Location = new System.Drawing.Point(289, 63);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(87, 19);
            this.rbt3.TabIndex = 14;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "Trimestre 3";
            this.rbt3.UseVisualStyleBackColor = true;
            this.rbt3.CheckedChanged += new System.EventHandler(this.rbp3_CheckedChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(416, 60);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(118, 23);
            this.btnCargar.TabIndex = 15;
            this.btnCargar.Text = "Cargar Actividades";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(144, 290);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 23);
            this.btnborrar.TabIndex = 19;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbp35
            // 
            this.rbp35.AutoSize = true;
            this.rbp35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbp35.Location = new System.Drawing.Point(15, 14);
            this.rbp35.Name = "rbp35";
            this.rbp35.Size = new System.Drawing.Size(100, 19);
            this.rbp35.TabIndex = 20;
            this.rbp35.TabStop = true;
            this.rbp35.Text = "Primer 35%";
            this.rbp35.UseVisualStyleBackColor = true;
            this.rbp35.CheckedChanged += new System.EventHandler(this.rbp35_CheckedChanged);
            // 
            // rbs35
            // 
            this.rbs35.AutoSize = true;
            this.rbs35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rbs35.Location = new System.Drawing.Point(15, 40);
            this.rbs35.Name = "rbs35";
            this.rbs35.Size = new System.Drawing.Size(114, 19);
            this.rbs35.TabIndex = 21;
            this.rbs35.TabStop = true;
            this.rbs35.Text = "Segundo 35%";
            this.rbs35.UseVisualStyleBackColor = true;
            this.rbs35.CheckedChanged += new System.EventHandler(this.rbs35_CheckedChanged);
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.rb30.Location = new System.Drawing.Point(15, 66);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(157, 19);
            this.rb30.TabIndex = 22;
            this.rb30.TabStop = true;
            this.rb30.Text = "Prueba objetiva 30%";
            this.rb30.UseVisualStyleBackColor = true;
            this.rb30.CheckedChanged += new System.EventHandler(this.rb30_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbp35);
            this.panel1.Controls.Add(this.rb30);
            this.panel1.Controls.Add(this.rbs35);
            this.panel1.Location = new System.Drawing.Point(13, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 96);
            this.panel1.TabIndex = 23;
            // 
            // dgvactividades
            // 
            this.dgvactividades.AllowUserToAddRows = false;
            this.dgvactividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvactividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actividad,
            this.Ponderacion});
            this.dgvactividades.Location = new System.Drawing.Point(323, 187);
            this.dgvactividades.Name = "dgvactividades";
            this.dgvactividades.ReadOnly = true;
            this.dgvactividades.Size = new System.Drawing.Size(240, 150);
            this.dgvactividades.TabIndex = 24;
            this.dgvactividades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvactividades_CellDoubleClick);
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            // 
            // Ponderacion
            // 
            this.Ponderacion.HeaderText = "Ponderación";
            this.Ponderacion.Name = "Ponderacion";
            this.Ponderacion.ReadOnly = true;
            // 
            // txtnn
            // 
            this.txtnn.Location = new System.Drawing.Point(429, 117);
            this.txtnn.Name = "txtnn";
            this.txtnn.Size = new System.Drawing.Size(153, 20);
            this.txtnn.TabIndex = 25;
            this.txtnn.Visible = false;
            // 
            // txtnp
            // 
            this.txtnp.Location = new System.Drawing.Point(429, 143);
            this.txtnp.Name = "txtnp";
            this.txtnp.Size = new System.Drawing.Size(72, 20);
            this.txtnp.TabIndex = 26;
            this.txtnp.Visible = false;
            // 
            // lblnn
            // 
            this.lblnn.AutoSize = true;
            this.lblnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblnn.Location = new System.Drawing.Point(271, 117);
            this.lblnn.Name = "lblnn";
            this.lblnn.Size = new System.Drawing.Size(113, 17);
            this.lblnn.TabIndex = 27;
            this.lblnn.Text = "Nuevo nombre";
            this.lblnn.Visible = false;
            // 
            // lblnp
            // 
            this.lblnp.AutoSize = true;
            this.lblnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblnp.Location = new System.Drawing.Point(274, 144);
            this.lblnp.Name = "lblnp";
            this.lblnp.Size = new System.Drawing.Size(149, 17);
            this.lblnp.TabIndex = 28;
            this.lblnp.Text = "Nueva ponderación";
            this.lblnp.Visible = false;
            // 
            // btnactu
            // 
            this.btnactu.Location = new System.Drawing.Point(521, 149);
            this.btnactu.Name = "btnactu";
            this.btnactu.Size = new System.Drawing.Size(75, 23);
            this.btnactu.TabIndex = 29;
            this.btnactu.Text = "Actualizar";
            this.btnactu.UseVisualStyleBackColor = true;
            this.btnactu.Visible = false;
            this.btnactu.Click += new System.EventHandler(this.btnactu_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Blue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Actualizar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(389, 240);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Blue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(130, 33);
            this.bunifuFlatButton1.TabIndex = 30;
            this.bunifuFlatButton1.Text = "Actualizar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Sección";
            // 
            // cbSeccion
            // 
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(274, 28);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(52, 21);
            this.cbSeccion.TabIndex = 32;
            this.cbSeccion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 379);
            this.Controls.Add(this.cbSeccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnactu);
            this.Controls.Add(this.lblnp);
            this.Controls.Add(this.lblnn);
            this.Controls.Add(this.txtnp);
            this.Controls.Add(this.txtnn);
            this.Controls.Add(this.dgvactividades);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.rbt3);
            this.Controls.Add(this.rbt2);
            this.Controls.Add(this.rbt1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbGrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPonderacion);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.Actividades_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvactividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.TextBox txtPonderacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.RadioButton rbp35;
        private System.Windows.Forms.RadioButton rbs35;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvactividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ponderacion;
        private System.Windows.Forms.TextBox txtnn;
        private System.Windows.Forms.TextBox txtnp;
        private System.Windows.Forms.Label lblnn;
        private System.Windows.Forms.Label lblnp;
        private System.Windows.Forms.Button btnactu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSeccion;
    }
}