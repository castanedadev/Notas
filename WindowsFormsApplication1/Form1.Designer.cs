namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.rbp35 = new System.Windows.Forms.RadioButton();
            this.rbs35 = new System.Windows.Forms.RadioButton();
            this.rb30 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvauxiliar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauxiliar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(220, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(391, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materia";
            // 
            // cbGrado
            // 
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(72, 30);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(121, 21);
            this.cbGrado.TabIndex = 3;
            this.cbGrado.SelectedIndexChanged += new System.EventHandler(this.cbGrado_SelectedIndexChanged);
            // 
            // cbSeccion
            // 
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(288, 30);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(56, 21);
            this.cbSeccion.TabIndex = 4;
            this.cbSeccion.SelectedIndexChanged += new System.EventHandler(this.cbSeccion_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(472, 31);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(127, 21);
            this.cbMateria.TabIndex = 5;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.cbMateria_SelectedIndexChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(644, 62);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dgvRegistro
            // 
            this.dgvRegistro.AllowUserToAddRows = false;
            this.dgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(12, 195);
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.Size = new System.Drawing.Size(733, 233);
            this.dgvRegistro.TabIndex = 7;
            this.dgvRegistro.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistro_CellEndEdit);
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rbt1.Location = new System.Drawing.Point(24, 68);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(147, 21);
            this.rbt1.TabIndex = 9;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Primer Trimestre";
            this.rbt1.UseVisualStyleBackColor = true;
            this.rbt1.CheckedChanged += new System.EventHandler(this.rbp1_CheckedChanged);
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rbt2.Location = new System.Drawing.Point(214, 68);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(164, 21);
            this.rbt2.TabIndex = 10;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Segundo Trimestre";
            this.rbt2.UseVisualStyleBackColor = true;
            this.rbt2.CheckedChanged += new System.EventHandler(this.rbp2_CheckedChanged);
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.rbt3.Location = new System.Drawing.Point(394, 68);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(148, 21);
            this.rbt3.TabIndex = 11;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "Tercer Trimestre";
            this.rbt3.UseVisualStyleBackColor = true;
            this.rbt3.CheckedChanged += new System.EventHandler(this.rbp3_CheckedChanged);
            // 
            // rbp35
            // 
            this.rbp35.AutoSize = true;
            this.rbp35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbp35.Location = new System.Drawing.Point(3, 3);
            this.rbp35.Name = "rbp35";
            this.rbp35.Size = new System.Drawing.Size(87, 17);
            this.rbp35.TabIndex = 13;
            this.rbp35.TabStop = true;
            this.rbp35.Text = "Primer 35%";
            this.rbp35.UseVisualStyleBackColor = true;
            this.rbp35.CheckedChanged += new System.EventHandler(this.rbp35_CheckedChanged);
            // 
            // rbs35
            // 
            this.rbs35.AutoSize = true;
            this.rbs35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbs35.Location = new System.Drawing.Point(3, 26);
            this.rbs35.Name = "rbs35";
            this.rbs35.Size = new System.Drawing.Size(102, 17);
            this.rbs35.TabIndex = 14;
            this.rbs35.TabStop = true;
            this.rbs35.Text = "Segundo 35%";
            this.rbs35.UseVisualStyleBackColor = true;
            this.rbs35.CheckedChanged += new System.EventHandler(this.rbs35_CheckedChanged);
            // 
            // rb30
            // 
            this.rb30.AutoSize = true;
            this.rb30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb30.Location = new System.Drawing.Point(3, 55);
            this.rb30.Name = "rb30";
            this.rb30.Size = new System.Drawing.Size(141, 17);
            this.rb30.TabIndex = 15;
            this.rb30.TabStop = true;
            this.rb30.Text = "Prueba objetiva 30%";
            this.rb30.UseVisualStyleBackColor = true;
            this.rb30.CheckedChanged += new System.EventHandler(this.rb30_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbp35);
            this.panel1.Controls.Add(this.rb30);
            this.panel1.Controls.Add(this.rbs35);
            this.panel1.Location = new System.Drawing.Point(21, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 87);
            this.panel1.TabIndex = 16;
            // 
            // btnExcel
            // 
            this.btnExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnExcel.BackColor = System.Drawing.Color.Teal;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.BorderRadius = 0;
            this.btnExcel.ButtonText = "Exportar a Excel";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcel.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExcel.Iconimage")));
            this.btnExcel.Iconimage_right = null;
            this.btnExcel.Iconimage_right_Selected = null;
            this.btnExcel.Iconimage_Selected = null;
            this.btnExcel.IconMarginLeft = 0;
            this.btnExcel.IconMarginRight = 0;
            this.btnExcel.IconRightVisible = true;
            this.btnExcel.IconRightZoom = 0D;
            this.btnExcel.IconVisible = true;
            this.btnExcel.IconZoom = 90D;
            this.btnExcel.IsTab = false;
            this.btnExcel.Location = new System.Drawing.Point(119, 434);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Normalcolor = System.Drawing.Color.Teal;
            this.btnExcel.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcel.selected = false;
            this.btnExcel.Size = new System.Drawing.Size(195, 48);
            this.btnExcel.TabIndex = 19;
            this.btnExcel.Text = "Exportar a Excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Textcolor = System.Drawing.Color.White;
            this.btnExcel.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPDF.BackColor = System.Drawing.Color.Teal;
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPDF.BorderRadius = 0;
            this.btnPDF.ButtonText = "Exportar a PDF";
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.DisabledColor = System.Drawing.Color.Gray;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPDF.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPDF.Iconimage")));
            this.btnPDF.Iconimage_right = null;
            this.btnPDF.Iconimage_right_Selected = null;
            this.btnPDF.Iconimage_Selected = null;
            this.btnPDF.IconMarginLeft = 0;
            this.btnPDF.IconMarginRight = 0;
            this.btnPDF.IconRightVisible = true;
            this.btnPDF.IconRightZoom = 0D;
            this.btnPDF.IconVisible = true;
            this.btnPDF.IconZoom = 90D;
            this.btnPDF.IsTab = false;
            this.btnPDF.Location = new System.Drawing.Point(310, 434);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Normalcolor = System.Drawing.Color.Teal;
            this.btnPDF.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnPDF.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPDF.selected = false;
            this.btnPDF.Size = new System.Drawing.Size(195, 48);
            this.btnPDF.TabIndex = 20;
            this.btnPDF.Text = "Exportar a PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Textcolor = System.Drawing.Color.White;
            this.btnPDF.TextFont = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "Importar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvauxiliar
            // 
            this.dgvauxiliar.AllowUserToAddRows = false;
            this.dgvauxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvauxiliar.Location = new System.Drawing.Point(12, 195);
            this.dgvauxiliar.Name = "dgvauxiliar";
            this.dgvauxiliar.Size = new System.Drawing.Size(733, 150);
            this.dgvauxiliar.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(761, 481);
            this.Controls.Add(this.dgvauxiliar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbt3);
            this.Controls.Add(this.rbt2);
            this.Controls.Add(this.rbt1);
            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbSeccion);
            this.Controls.Add(this.cbGrado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadro de Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauxiliar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.RadioButton rbp35;
        private System.Windows.Forms.RadioButton rbs35;
        private System.Windows.Forms.RadioButton rb30;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcel;
        private Bunifu.Framework.UI.BunifuFlatButton btnPDF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvauxiliar;
    }
}

