namespace WindowsFormsApplication1
{
    partial class Acti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acti));
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblnp = new System.Windows.Forms.Label();
            this.lblnn = new System.Windows.Forms.Label();
            this.txtnp = new System.Windows.Forms.TextBox();
            this.txtnn = new System.Windows.Forms.TextBox();
            this.dgvactividades = new System.Windows.Forms.DataGridView();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ponderacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbp35 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.rbs35 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.lbltotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPonderacion = new System.Windows.Forms.TextBox();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnactu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCargar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBorrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvactividades)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSeccion
            // 
            this.cbSeccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(291, 5);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(52, 28);
            this.cbSeccion.TabIndex = 57;
            this.cbSeccion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(226, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 56;
            this.label6.Text = "Sección";
            // 
            // lblnp
            // 
            this.lblnp.AutoSize = true;
            this.lblnp.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.lblnp.Location = new System.Drawing.Point(300, 146);
            this.lblnp.Name = "lblnp";
            this.lblnp.Size = new System.Drawing.Size(140, 18);
            this.lblnp.TabIndex = 55;
            this.lblnp.Text = "Nueva ponderación";
            this.lblnp.Visible = false;
            // 
            // lblnn
            // 
            this.lblnn.AutoSize = true;
            this.lblnn.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.lblnn.Location = new System.Drawing.Point(300, 111);
            this.lblnn.Name = "lblnn";
            this.lblnn.Size = new System.Drawing.Size(109, 18);
            this.lblnn.TabIndex = 54;
            this.lblnn.Text = "Nuevo nombre";
            this.lblnn.Visible = false;
            // 
            // txtnp
            // 
            this.txtnp.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.txtnp.Location = new System.Drawing.Point(455, 141);
            this.txtnp.Name = "txtnp";
            this.txtnp.Size = new System.Drawing.Size(72, 26);
            this.txtnp.TabIndex = 53;
            this.txtnp.Visible = false;
            // 
            // txtnn
            // 
            this.txtnn.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.txtnn.Location = new System.Drawing.Point(455, 103);
            this.txtnn.Name = "txtnn";
            this.txtnn.Size = new System.Drawing.Size(153, 26);
            this.txtnn.TabIndex = 52;
            this.txtnn.Visible = false;
            // 
            // dgvactividades
            // 
            this.dgvactividades.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvactividades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvactividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvactividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actividad,
            this.Ponderacion});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvactividades.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvactividades.Location = new System.Drawing.Point(357, 225);
            this.dgvactividades.Name = "dgvactividades";
            this.dgvactividades.ReadOnly = true;
            this.dgvactividades.Size = new System.Drawing.Size(240, 150);
            this.dgvactividades.TabIndex = 51;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbp35);
            this.panel1.Controls.Add(this.rb30);
            this.panel1.Controls.Add(this.rbs35);
            this.panel1.Location = new System.Drawing.Point(15, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 96);
            this.panel1.TabIndex = 50;
            // 
            // rbp35
            // 
            this.rbp35.AutoSize = true;
            this.rbp35.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.rbp35.Location = new System.Drawing.Point(15, 14);
            this.rbp35.Name = "rbp35";
            this.rbp35.Size = new System.Drawing.Size(104, 22);
            this.rbp35.TabIndex = 20;
            this.rbp35.TabStop = true;
            this.rbp35.Text = "Primer 35%";
            this.rbp35.UseVisualStyleBackColor = true;
            this.rbp35.CheckedChanged += new System.EventHandler(this.rbp35_CheckedChanged);
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.rb30.Location = new System.Drawing.Point(15, 66);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(165, 22);
            this.rb30.TabIndex = 22;
            this.rb30.TabStop = true;
            this.rb30.Text = "Prueba objetiva 30%";
            this.rb30.UseVisualStyleBackColor = true;
            this.rb30.CheckedChanged += new System.EventHandler(this.rb30_CheckedChanged);
            // 
            // rbs35
            // 
            this.rbs35.AutoSize = true;
            this.rbs35.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.rbs35.Location = new System.Drawing.Point(15, 40);
            this.rbs35.Name = "rbs35";
            this.rbs35.Size = new System.Drawing.Size(117, 22);
            this.rbs35.TabIndex = 21;
            this.rbs35.TabStop = true;
            this.rbs35.Text = "Segundo 35%";
            this.rbs35.UseVisualStyleBackColor = true;
            this.rbs35.CheckedChanged += new System.EventHandler(this.rbs35_CheckedChanged);
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.rbt3.Location = new System.Drawing.Point(291, 42);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(102, 22);
            this.rbt3.TabIndex = 49;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "Trimestre 3";
            this.rbt3.UseVisualStyleBackColor = true;
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.rbt2.Location = new System.Drawing.Point(165, 42);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(102, 22);
            this.rbt2.TabIndex = 48;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Trimestre 2";
            this.rbt2.UseVisualStyleBackColor = true;
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.rbt1.Location = new System.Drawing.Point(14, 42);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(102, 22);
            this.rbt1.TabIndex = 47;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Trimestre 1";
            this.rbt1.UseVisualStyleBackColor = true;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(481, 381);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 13);
            this.lbltotal.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(390, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 45;
            this.label5.Text = "Total: ";
            // 
            // cbMateria
            // 
            this.cbMateria.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(444, 5);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(153, 28);
            this.cbMateria.TabIndex = 44;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // cbGrado
            // 
            this.cbGrado.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(84, 6);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(121, 28);
            this.cbGrado.TabIndex = 43;
            this.cbGrado.SelectedIndexChanged += new System.EventHandler(this.cbGrado_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(365, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Grado";
            // 
            // txtPonderacion
            // 
            this.txtPonderacion.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.txtPonderacion.Location = new System.Drawing.Point(117, 260);
            this.txtPonderacion.Name = "txtPonderacion";
            this.txtPonderacion.Size = new System.Drawing.Size(71, 26);
            this.txtPonderacion.TabIndex = 40;
            // 
            // txtActividad
            // 
            this.txtActividad.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActividad.Location = new System.Drawing.Point(117, 225);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(150, 26);
            this.txtActividad.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ponderación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Actividad";
            // 
            // btnactu
            // 
            this.btnactu.Activecolor = System.Drawing.Color.Blue;
            this.btnactu.BackColor = System.Drawing.Color.Blue;
            this.btnactu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnactu.BorderRadius = 0;
            this.btnactu.ButtonText = "ACTULIZAR";
            this.btnactu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnactu.DisabledColor = System.Drawing.Color.Gray;
            this.btnactu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnactu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnactu.Iconimage")));
            this.btnactu.Iconimage_right = null;
            this.btnactu.Iconimage_right_Selected = null;
            this.btnactu.Iconimage_Selected = null;
            this.btnactu.IconMarginLeft = 0;
            this.btnactu.IconMarginRight = 0;
            this.btnactu.IconRightVisible = true;
            this.btnactu.IconRightZoom = 0D;
            this.btnactu.IconVisible = true;
            this.btnactu.IconZoom = 90D;
            this.btnactu.IsTab = false;
            this.btnactu.Location = new System.Drawing.Point(455, 174);
            this.btnactu.Margin = new System.Windows.Forms.Padding(4);
            this.btnactu.Name = "btnactu";
            this.btnactu.Normalcolor = System.Drawing.Color.Blue;
            this.btnactu.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnactu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnactu.selected = false;
            this.btnactu.Size = new System.Drawing.Size(151, 33);
            this.btnactu.TabIndex = 61;
            this.btnactu.Text = "ACTULIZAR";
            this.btnactu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnactu.Textcolor = System.Drawing.Color.White;
            this.btnactu.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnactu.Visible = false;
            this.btnactu.Click += new System.EventHandler(this.btnactu_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Activecolor = System.Drawing.Color.Blue;
            this.btnCargar.BackColor = System.Drawing.Color.Blue;
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.BorderRadius = 0;
            this.btnCargar.ButtonText = "Cargar Actividades";
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
            this.btnCargar.Location = new System.Drawing.Point(455, 40);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Normalcolor = System.Drawing.Color.Blue;
            this.btnCargar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnCargar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCargar.selected = false;
            this.btnCargar.Size = new System.Drawing.Size(179, 33);
            this.btnCargar.TabIndex = 60;
            this.btnCargar.Text = "Cargar Actividades";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Textcolor = System.Drawing.Color.White;
            this.btnCargar.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCargar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Activecolor = System.Drawing.Color.Blue;
            this.btnBorrar.BackColor = System.Drawing.Color.Blue;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.BorderRadius = 0;
            this.btnBorrar.ButtonText = "BORRAR";
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBorrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBorrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Iconimage")));
            this.btnBorrar.Iconimage_right = null;
            this.btnBorrar.Iconimage_right_Selected = null;
            this.btnBorrar.Iconimage_Selected = null;
            this.btnBorrar.IconMarginLeft = 0;
            this.btnBorrar.IconMarginRight = 0;
            this.btnBorrar.IconRightVisible = true;
            this.btnBorrar.IconRightZoom = 0D;
            this.btnBorrar.IconVisible = true;
            this.btnBorrar.IconZoom = 90D;
            this.btnBorrar.IsTab = false;
            this.btnBorrar.Location = new System.Drawing.Point(167, 307);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Normalcolor = System.Drawing.Color.Blue;
            this.btnBorrar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnBorrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBorrar.selected = false;
            this.btnBorrar.Size = new System.Drawing.Size(151, 33);
            this.btnBorrar.TabIndex = 59;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Textcolor = System.Drawing.Color.White;
            this.btnBorrar.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.Blue;
            this.btnAgregar.BackColor = System.Drawing.Color.Blue;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.ButtonText = "AGREGAR";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Iconimage")));
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 0;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = true;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = true;
            this.btnAgregar.IconZoom = 90D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(8, 307);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.Color.Blue;
            this.btnAgregar.OnHovercolor = System.Drawing.Color.RoyalBlue;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(151, 33);
            this.btnAgregar.TabIndex = 58;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Textcolor = System.Drawing.Color.White;
            this.btnAgregar.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Acti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 415);
            this.Controls.Add(this.btnactu);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbSeccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblnp);
            this.Controls.Add(this.lblnn);
            this.Controls.Add(this.txtnp);
            this.Controls.Add(this.txtnn);
            this.Controls.Add(this.dgvactividades);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbt3);
            this.Controls.Add(this.rbt2);
            this.Controls.Add(this.rbt1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbGrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPonderacion);
            this.Controls.Add(this.txtActividad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acti";
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.Actividades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvactividades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnactu;
        private Bunifu.Framework.UI.BunifuFlatButton btnCargar;
        private Bunifu.Framework.UI.BunifuFlatButton btnBorrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblnp;
        private System.Windows.Forms.Label lblnn;
        private System.Windows.Forms.TextBox txtnp;
        private System.Windows.Forms.TextBox txtnn;
        private System.Windows.Forms.DataGridView dgvactividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ponderacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbp35;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.RadioButton rbs35;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPonderacion;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}