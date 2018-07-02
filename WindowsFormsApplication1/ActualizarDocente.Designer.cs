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
            this.btnUpdate = new System.Windows.Forms.Button();
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
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBDocentes = new System.Windows.Forms.ListBox();
            this.chEstado = new System.Windows.Forms.CheckBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GB_NGMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_g_m)).BeginInit();
            this.GB_tutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(586, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(173, 54);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Registrar";
            this.btnUpdate.UseVisualStyleBackColor = true;
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
            this.GB_NGMS.Location = new System.Drawing.Point(425, 122);
            this.GB_NGMS.Name = "GB_NGMS";
            this.GB_NGMS.Size = new System.Drawing.Size(334, 236);
            this.GB_NGMS.TabIndex = 61;
            this.GB_NGMS.TabStop = false;
            this.GB_NGMS.Text = "Grado y materia";
            // 
            // CB_TNGMS
            // 
            this.CB_TNGMS.Enabled = false;
            this.CB_TNGMS.FormattingEnabled = true;
            this.CB_TNGMS.Location = new System.Drawing.Point(137, 60);
            this.CB_TNGMS.Name = "CB_TNGMS";
            this.CB_TNGMS.Size = new System.Drawing.Size(80, 21);
            this.CB_TNGMS.TabIndex = 53;
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
            this.DGV_g_m.Size = new System.Drawing.Size(301, 131);
            this.DGV_g_m.TabIndex = 18;
            // 
            // CB_TMateria
            // 
            this.CB_TMateria.Enabled = false;
            this.CB_TMateria.FormattingEnabled = true;
            this.CB_TMateria.Location = new System.Drawing.Point(194, 17);
            this.CB_TMateria.Name = "CB_TMateria";
            this.CB_TMateria.Size = new System.Drawing.Size(89, 21);
            this.CB_TMateria.TabIndex = 51;
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
            // CB_Grado
            // 
            this.CB_Grado.FormattingEnabled = true;
            this.CB_Grado.Location = new System.Drawing.Point(47, 17);
            this.CB_Grado.Name = "CB_Grado";
            this.CB_Grado.Size = new System.Drawing.Size(89, 21);
            this.CB_Grado.TabIndex = 50;
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
            this.GB_tutor.Controls.Add(this.CB_TSeccion);
            this.GB_tutor.Controls.Add(this.CB_TGrado);
            this.GB_tutor.Controls.Add(this.label6);
            this.GB_tutor.Controls.Add(this.label7);
            this.GB_tutor.Location = new System.Drawing.Point(443, 38);
            this.GB_tutor.Name = "GB_tutor";
            this.GB_tutor.Size = new System.Drawing.Size(268, 52);
            this.GB_tutor.TabIndex = 60;
            this.GB_tutor.TabStop = false;
            this.GB_tutor.Text = "Tutor";
            this.GB_tutor.Visible = false;
            // 
            // CB_TSeccion
            // 
            this.CB_TSeccion.Enabled = false;
            this.CB_TSeccion.FormattingEnabled = true;
            this.CB_TSeccion.Location = new System.Drawing.Point(205, 17);
            this.CB_TSeccion.Name = "CB_TSeccion";
            this.CB_TSeccion.Size = new System.Drawing.Size(55, 21);
            this.CB_TSeccion.TabIndex = 49;
            // 
            // CB_TGrado
            // 
            this.CB_TGrado.FormattingEnabled = true;
            this.CB_TGrado.Location = new System.Drawing.Point(47, 17);
            this.CB_TGrado.Name = "CB_TGrado";
            this.CB_TGrado.Size = new System.Drawing.Size(97, 21);
            this.CB_TGrado.TabIndex = 48;
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
            // chTutor
            // 
            this.chTutor.AutoSize = true;
            this.chTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chTutor.Location = new System.Drawing.Point(550, 12);
            this.chTutor.Name = "chTutor";
            this.chTutor.Size = new System.Drawing.Size(58, 20);
            this.chTutor.TabIndex = 58;
            this.chTutor.Text = "Tutor";
            this.chTutor.UseVisualStyleBackColor = true;
            this.chTutor.CheckedChanged += new System.EventHandler(this.chTutor_CheckedChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(118, 240);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 67;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 124);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 70;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 15);
            this.label3.TabIndex = 69;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nombre";
            // 
            // LBDocentes
            // 
            this.LBDocentes.FormattingEnabled = true;
            this.LBDocentes.Location = new System.Drawing.Point(12, 12);
            this.LBDocentes.Name = "LBDocentes";
            this.LBDocentes.Size = new System.Drawing.Size(381, 95);
            this.LBDocentes.TabIndex = 74;
            this.LBDocentes.SelectedIndexChanged += new System.EventHandler(this.LBDocentes_SelectedIndexChanged);
            // 
            // chEstado
            // 
            this.chEstado.AutoSize = true;
            this.chEstado.Checked = true;
            this.chEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chEstado.Location = new System.Drawing.Point(118, 291);
            this.chEstado.Name = "chEstado";
            this.chEstado.Size = new System.Drawing.Size(64, 20);
            this.chEstado.TabIndex = 94;
            this.chEstado.Text = "Activo";
            this.chEstado.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(162, 168);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 20);
            this.txtFecha.TabIndex = 95;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(118, 202);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(242, 20);
            this.txtDireccion.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 97;
            this.label5.Text = "Direccion:";
            // 
            // ActualizarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(782, 430);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.chEstado);
            this.Controls.Add(this.LBDocentes);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.GB_NGMS);
            this.Controls.Add(this.GB_tutor);
            this.Controls.Add(this.chTutor);
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

        private System.Windows.Forms.Button btnUpdate;
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
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LBDocentes;
        private System.Windows.Forms.CheckBox chEstado;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
    }

}