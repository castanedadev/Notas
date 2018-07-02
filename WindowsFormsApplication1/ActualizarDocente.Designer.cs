namespace WindowsFormsApplication1
{
    partial class ActualizarDocente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarDocente));
            this.GB_NGMS = new System.Windows.Forms.GroupBox();
            this.CB_TNGMS = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.DGV_g_m = new System.Windows.Forms.DataGridView();
            this.CB_TMateria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_Grado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GB_tutor = new System.Windows.Forms.GroupBox();
            this.CB_TSeccion = new System.Windows.Forms.ComboBox();
            this.CB_TGrado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chTutor = new System.Windows.Forms.CheckBox();
            this.LBDocentes = new System.Windows.Forms.ListBox();
            this.chEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GB_NGMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_g_m)).BeginInit();
            this.GB_tutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_NGMS
            // 
            this.GB_NGMS.Controls.Add(this.CB_TNGMS);
            this.GB_NGMS.Controls.Add(this.label29);
            this.GB_NGMS.Controls.Add(this.DGV_g_m);
            this.GB_NGMS.Controls.Add(this.CB_TMateria);
            this.GB_NGMS.Controls.Add(this.label9);
            this.GB_NGMS.Controls.Add(this.CB_Grado);
            this.GB_NGMS.Controls.Add(this.label8);
            this.GB_NGMS.Location = new System.Drawing.Point(399, 134);
            this.GB_NGMS.Name = "GB_NGMS";
            this.GB_NGMS.Size = new System.Drawing.Size(379, 236);
            this.GB_NGMS.TabIndex = 61;
            this.GB_NGMS.TabStop = false;
            this.GB_NGMS.Text = "Grado y materia";
            // 
            // CB_TNGMS
            // 
            this.CB_TNGMS.Enabled = false;
            this.CB_TNGMS.FormattingEnabled = true;
            this.CB_TNGMS.Location = new System.Drawing.Point(150, 59);
            this.CB_TNGMS.Name = "CB_TNGMS";
            this.CB_TNGMS.Size = new System.Drawing.Size(80, 21);
            this.CB_TNGMS.TabIndex = 53;
            this.CB_TNGMS.SelectedIndexChanged += new System.EventHandler(this.CB_TNGMS_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(74, 63);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(63, 18);
            this.label29.TabIndex = 52;
            this.label29.Text = "Sección:";
            // 
            // DGV_g_m
            // 
            this.DGV_g_m.AllowUserToAddRows = false;
            this.DGV_g_m.AllowUserToDeleteRows = false;
            this.DGV_g_m.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_g_m.Location = new System.Drawing.Point(20, 86);
            this.DGV_g_m.Name = "DGV_g_m";
            this.DGV_g_m.ReadOnly = true;
            this.DGV_g_m.Size = new System.Drawing.Size(341, 131);
            this.DGV_g_m.TabIndex = 18;
            this.DGV_g_m.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_g_m_CellMouseDoubleClick);
            // 
            // CB_TMateria
            // 
            this.CB_TMateria.Enabled = false;
            this.CB_TMateria.FormattingEnabled = true;
            this.CB_TMateria.Location = new System.Drawing.Point(247, 19);
            this.CB_TMateria.Name = "CB_TMateria";
            this.CB_TMateria.Size = new System.Drawing.Size(89, 21);
            this.CB_TMateria.TabIndex = 51;
            this.CB_TMateria.SelectedIndexChanged += new System.EventHandler(this.CB_TMateria_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(172, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Materia:";
            // 
            // CB_Grado
            // 
            this.CB_Grado.FormattingEnabled = true;
            this.CB_Grado.Location = new System.Drawing.Point(70, 21);
            this.CB_Grado.Name = "CB_Grado";
            this.CB_Grado.Size = new System.Drawing.Size(89, 21);
            this.CB_Grado.TabIndex = 50;
            this.CB_Grado.SelectedIndexChanged += new System.EventHandler(this.CB_Grado_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Grado:";
            // 
            // GB_tutor
            // 
            this.GB_tutor.Controls.Add(this.CB_TSeccion);
            this.GB_tutor.Controls.Add(this.CB_TGrado);
            this.GB_tutor.Controls.Add(this.label6);
            this.GB_tutor.Controls.Add(this.label7);
            this.GB_tutor.Location = new System.Drawing.Point(433, 76);
            this.GB_tutor.Name = "GB_tutor";
            this.GB_tutor.Size = new System.Drawing.Size(302, 52);
            this.GB_tutor.TabIndex = 60;
            this.GB_tutor.TabStop = false;
            this.GB_tutor.Text = "Tutor";
            this.GB_tutor.Visible = false;
            // 
            // CB_TSeccion
            // 
            this.CB_TSeccion.Enabled = false;
            this.CB_TSeccion.FormattingEnabled = true;
            this.CB_TSeccion.Location = new System.Drawing.Point(239, 21);
            this.CB_TSeccion.Name = "CB_TSeccion";
            this.CB_TSeccion.Size = new System.Drawing.Size(55, 21);
            this.CB_TSeccion.TabIndex = 49;
            // 
            // CB_TGrado
            // 
            this.CB_TGrado.FormattingEnabled = true;
            this.CB_TGrado.Location = new System.Drawing.Point(65, 21);
            this.CB_TGrado.Name = "CB_TGrado";
            this.CB_TGrado.Size = new System.Drawing.Size(97, 21);
            this.CB_TGrado.TabIndex = 48;
            this.CB_TGrado.SelectedIndexChanged += new System.EventHandler(this.CB_TGrado_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Grado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(167, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Seccion:";
            // 
            // chTutor
            // 
            this.chTutor.AutoSize = true;
            this.chTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.chTutor.Location = new System.Drawing.Point(433, 51);
            this.chTutor.Name = "chTutor";
            this.chTutor.Size = new System.Drawing.Size(81, 21);
            this.chTutor.TabIndex = 58;
            this.chTutor.Text = "TUTOR";
            this.chTutor.UseVisualStyleBackColor = true;
            this.chTutor.CheckedChanged += new System.EventHandler(this.chTutor_CheckedChanged);
            // 
            // LBDocentes
            // 
            this.LBDocentes.FormattingEnabled = true;
            this.LBDocentes.Location = new System.Drawing.Point(12, 45);
            this.LBDocentes.Name = "LBDocentes";
            this.LBDocentes.Size = new System.Drawing.Size(381, 329);
            this.LBDocentes.TabIndex = 74;
            this.LBDocentes.SelectedIndexChanged += new System.EventHandler(this.LBDocentes_SelectedIndexChanged);
            // 
            // chEstado
            // 
            this.chEstado.AutoSize = true;
            this.chEstado.Checked = true;
            this.chEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.chEstado.Location = new System.Drawing.Point(537, 12);
            this.chEstado.Name = "chEstado";
            this.chEstado.Size = new System.Drawing.Size(93, 24);
            this.chEstado.TabIndex = 94;
            this.chEstado.Text = "ACTIVO";
            this.chEstado.UseVisualStyleBackColor = true;
            this.chEstado.CheckedChanged += new System.EventHandler(this.chEstado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 95;
            this.label1.Text = "ESCOGA UN DOCENTE";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.Gray;
            this.btnUpdate.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "ACTUALIZAR";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Iconimage")));
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(399, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.DimGray;
            this.btnUpdate.OnHovercolor = System.Drawing.Color.SlateGray;
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(183, 48);
            this.btnUpdate.TabIndex = 96;
            this.btnUpdate.Text = "ACTUALIZAR";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.Gray;
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.ButtonText = "ELIMINAR";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Iconimage")));
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 90D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(595, 370);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.OrangeRed;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(183, 48);
            this.btnEliminar.TabIndex = 97;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Textcolor = System.Drawing.Color.White;
            this.btnEliminar.TextFont = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ActualizarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 430);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chEstado);
            this.Controls.Add(this.LBDocentes);
            this.Controls.Add(this.GB_NGMS);
            this.Controls.Add(this.GB_tutor);
            this.Controls.Add(this.chTutor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActualizarDocente";
            this.Text = "ActualizarDocente";
            this.Load += new System.EventHandler(this.ActualizarDocente_Load);
            this.GB_NGMS.ResumeLayout(false);
            this.GB_NGMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_g_m)).EndInit();
            this.GB_tutor.ResumeLayout(false);
            this.GB_tutor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GB_NGMS;
        private System.Windows.Forms.ComboBox CB_TNGMS;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView DGV_g_m;
        private System.Windows.Forms.ComboBox CB_TMateria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CB_Grado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GB_tutor;
        private System.Windows.Forms.ComboBox CB_TSeccion;
        private System.Windows.Forms.ComboBox CB_TGrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chTutor;
        private System.Windows.Forms.ListBox LBDocentes;
        private System.Windows.Forms.CheckBox chEstado;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
    }
}