namespace WindowsFormsApplication1.F3
{
    partial class DocenteR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocenteR));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboBNGS = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.DGV_g_m = new System.Windows.Forms.DataGridView();
            this.ComBMateria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ComBGrado2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GB_tutor = new System.Windows.Forms.GroupBox();
            this.ComBSeccion = new System.Windows.Forms.ComboBox();
            this.ComBGrado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChecBTutor = new System.Windows.Forms.CheckBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeFecha = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_g_m)).BeginInit();
            this.GB_tutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(554, 340);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(79, 66);
            this.btnRegistrar.TabIndex = 52;
            this.btnRegistrar.Text = "Aceptar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComboBNGS);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.DGV_g_m);
            this.groupBox2.Controls.Add(this.ComBMateria);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ComBGrado2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(117, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 236);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grado y materia";
            // 
            // ComboBNGS
            // 
            this.ComboBNGS.Enabled = false;
            this.ComboBNGS.FormattingEnabled = true;
            this.ComboBNGS.Location = new System.Drawing.Point(137, 60);
            this.ComboBNGS.Name = "ComboBNGS";
            this.ComboBNGS.Size = new System.Drawing.Size(80, 21);
            this.ComboBNGS.TabIndex = 53;
            this.ComboBNGS.SelectedIndexChanged += new System.EventHandler(this.cmb1seccion_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(90, 63);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 13);
            this.label29.TabIndex = 52;
            this.label29.Text = "Sección:";
            // 
            // DGV_g_m
            // 
            this.DGV_g_m.AllowUserToAddRows = false;
            this.DGV_g_m.AllowUserToDeleteRows = false;
            this.DGV_g_m.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_g_m.Location = new System.Drawing.Point(9, 87);
            this.DGV_g_m.Name = "DGV_g_m";
            this.DGV_g_m.ReadOnly = true;
            this.DGV_g_m.Size = new System.Drawing.Size(342, 131);
            this.DGV_g_m.TabIndex = 18;
            this.DGV_g_m.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_g_m_CellMouseClick);
            // 
            // ComBMateria
            // 
            this.ComBMateria.Enabled = false;
            this.ComBMateria.FormattingEnabled = true;
            this.ComBMateria.Location = new System.Drawing.Point(194, 17);
            this.ComBMateria.Name = "ComBMateria";
            this.ComBMateria.Size = new System.Drawing.Size(89, 21);
            this.ComBMateria.TabIndex = 51;
            this.ComBMateria.SelectedIndexChanged += new System.EventHandler(this.ComBMateria_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Materia:";
            // 
            // ComBGrado2
            // 
            this.ComBGrado2.FormattingEnabled = true;
            this.ComBGrado2.Location = new System.Drawing.Point(47, 17);
            this.ComBGrado2.Name = "ComBGrado2";
            this.ComBGrado2.Size = new System.Drawing.Size(89, 21);
            this.ComBGrado2.TabIndex = 50;
            this.ComBGrado2.SelectedIndexChanged += new System.EventHandler(this.ComBGrado2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grado:";
            // 
            // GB_tutor
            // 
            this.GB_tutor.Controls.Add(this.ComBSeccion);
            this.GB_tutor.Controls.Add(this.ComBGrado);
            this.GB_tutor.Controls.Add(this.label6);
            this.GB_tutor.Controls.Add(this.label7);
            this.GB_tutor.Location = new System.Drawing.Point(239, 242);
            this.GB_tutor.Name = "GB_tutor";
            this.GB_tutor.Size = new System.Drawing.Size(268, 52);
            this.GB_tutor.TabIndex = 56;
            this.GB_tutor.TabStop = false;
            this.GB_tutor.Text = "Tutor";
            this.GB_tutor.Visible = false;
            // 
            // ComBSeccion
            // 
            this.ComBSeccion.FormattingEnabled = true;
            this.ComBSeccion.Location = new System.Drawing.Point(205, 17);
            this.ComBSeccion.Name = "ComBSeccion";
            this.ComBSeccion.Size = new System.Drawing.Size(55, 21);
            this.ComBSeccion.TabIndex = 49;
            this.ComBSeccion.SelectedIndexChanged += new System.EventHandler(this.ComBSeccion_SelectedIndexChanged);
            // 
            // ComBGrado
            // 
            this.ComBGrado.FormattingEnabled = true;
            this.ComBGrado.Location = new System.Drawing.Point(47, 17);
            this.ComBGrado.Name = "ComBGrado";
            this.ComBGrado.Size = new System.Drawing.Size(97, 21);
            this.ComBGrado.TabIndex = 48;
            this.ComBGrado.SelectedIndexChanged += new System.EventHandler(this.ComBGrado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Grado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Seccion:";
            // 
            // ChecBTutor
            // 
            this.ChecBTutor.AutoSize = true;
            this.ChecBTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChecBTutor.Location = new System.Drawing.Point(103, 260);
            this.ChecBTutor.Name = "ChecBTutor";
            this.ChecBTutor.Size = new System.Drawing.Size(58, 20);
            this.ChecBTutor.TabIndex = 47;
            this.ChecBTutor.Text = "Tutor";
            this.ChecBTutor.UseVisualStyleBackColor = true;
            this.ChecBTutor.CheckedChanged += new System.EventHandler(this.ChecBTutor_CheckedChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(241, 195);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(242, 20);
            this.txtDireccion.TabIndex = 44;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(241, 162);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(127, 20);
            this.txtTelefono.TabIndex = 43;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(241, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // txtDui
            // 
            this.txtDui.Enabled = false;
            this.txtDui.Location = new System.Drawing.Point(241, 53);
            this.txtDui.MaxLength = 10;
            this.txtDui.Name = "txtDui";
            this.txtDui.ReadOnly = true;
            this.txtDui.Size = new System.Drawing.Size(127, 20);
            this.txtDui.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID";
            // 
            // TimeFecha
            // 
            this.TimeFecha.Location = new System.Drawing.Point(241, 126);
            this.TimeFecha.Name = "TimeFecha";
            this.TimeFecha.ReadOnly = true;
            this.TimeFecha.Size = new System.Drawing.Size(275, 20);
            this.TimeFecha.TabIndex = 80;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DocenteR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(673, 664);
            this.Controls.Add(this.TimeFecha);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GB_tutor);
            this.Controls.Add(this.ChecBTutor);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDui);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocenteR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docente";
            this.Load += new System.EventHandler(this.Docente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_g_m)).EndInit();
            this.GB_tutor.ResumeLayout(false);
            this.GB_tutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGV_g_m;
        private System.Windows.Forms.ComboBox ComBMateria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ComBGrado2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GB_tutor;
        private System.Windows.Forms.ComboBox ComBSeccion;
        private System.Windows.Forms.ComboBox ComBGrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ChecBTutor;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBNGS;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox TimeFecha;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}