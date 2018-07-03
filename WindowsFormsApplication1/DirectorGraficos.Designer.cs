namespace WindowsFormsApplication1
{
    partial class DirectorGraficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TriA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TriB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TotalA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TotalB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.dgvauxiliar = new System.Windows.Forms.DataGridView();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.button1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.TriA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauxiliar)).BeginInit();
            this.SuspendLayout();
            // 
            // TriA
            // 
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.TriA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TriA.Legends.Add(legend1);
            this.TriA.Location = new System.Drawing.Point(-3, 143);
            this.TriA.Name = "TriA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.TriA.Series.Add(series1);
            this.TriA.Size = new System.Drawing.Size(300, 300);
            this.TriA.TabIndex = 0;
            this.TriA.Text = "chart1";
            // 
            // TriB
            // 
            chartArea2.AxisY.Maximum = 10D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.TriB.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.TriB.Legends.Add(legend2);
            this.TriB.Location = new System.Drawing.Point(295, 143);
            this.TriB.Name = "TriB";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.TriB.Series.Add(series2);
            this.TriB.Size = new System.Drawing.Size(303, 300);
            this.TriB.TabIndex = 1;
            this.TriB.Text = "chart2";
            // 
            // TotalA
            // 
            chartArea3.AxisY.Maximum = 10D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.TotalA.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.TotalA.Legends.Add(legend3);
            this.TotalA.Location = new System.Drawing.Point(67, 449);
            this.TotalA.Name = "TotalA";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.TotalA.Series.Add(series3);
            this.TotalA.Size = new System.Drawing.Size(230, 226);
            this.TotalA.TabIndex = 2;
            this.TotalA.Text = "chart3";
            // 
            // TotalB
            // 
            chartArea4.AxisY.Maximum = 10D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.TotalB.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.TotalB.Legends.Add(legend4);
            this.TotalB.Location = new System.Drawing.Point(295, 449);
            this.TotalB.Name = "TotalB";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.TotalB.Series.Add(series4);
            this.TotalB.Size = new System.Drawing.Size(230, 226);
            this.TotalB.TabIndex = 3;
            this.TotalB.Text = "chart4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sección A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seccion B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(269, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Materia:";
            // 
            // cbGrado
            // 
            this.cbGrado.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(98, 12);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(149, 28);
            this.cbGrado.TabIndex = 8;
            this.cbGrado.SelectedIndexChanged += new System.EventHandler(this.cbGrado_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(362, 12);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(163, 28);
            this.cbMateria.TabIndex = 9;
            // 
            // dgvauxiliar
            // 
            this.dgvauxiliar.AllowUserToAddRows = false;
            this.dgvauxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvauxiliar.Location = new System.Drawing.Point(535, 89);
            this.dgvauxiliar.Name = "dgvauxiliar";
            this.dgvauxiliar.Size = new System.Drawing.Size(43, 49);
            this.dgvauxiliar.TabIndex = 11;
            // 
            // cbSeccion
            // 
            this.cbSeccion.Font = new System.Drawing.Font("Microsoft PhagsPa", 11F);
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(535, 53);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(44, 28);
            this.cbSeccion.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.BorderRadius = 0;
            this.button1.ButtonText = "Comparativa de Rendimiento";
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DisabledColor = System.Drawing.Color.Gray;
            this.button1.Iconcolor = System.Drawing.Color.Transparent;
            this.button1.Iconimage = null;
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
            this.button1.Location = new System.Drawing.Point(108, 53);
            this.button1.Name = "button1";
            this.button1.Normalcolor = System.Drawing.Color.Gray;
            this.button1.OnHovercolor = System.Drawing.Color.DimGray;
            this.button1.OnHoverTextColor = System.Drawing.Color.White;
            this.button1.selected = false;
            this.button1.Size = new System.Drawing.Size(344, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Comparativa de Rendimiento";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.Textcolor = System.Drawing.Color.White;
            this.button1.TextFont = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DirectorGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 732);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSeccion);
            this.Controls.Add(this.dgvauxiliar);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbGrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalB);
            this.Controls.Add(this.TotalA);
            this.Controls.Add(this.TriB);
            this.Controls.Add(this.TriA);
            this.Name = "DirectorGraficos";
            this.Text = "DirectorGraficos";
            this.Load += new System.EventHandler(this.DirectorGraficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TriA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauxiliar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart TriA;
        private System.Windows.Forms.DataVisualization.Charting.Chart TriB;
        private System.Windows.Forms.DataVisualization.Charting.Chart TotalA;
        private System.Windows.Forms.DataVisualization.Charting.Chart TotalB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGrado;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.DataGridView dgvauxiliar;
        private System.Windows.Forms.ComboBox cbSeccion;
        private Bunifu.Framework.UI.BunifuFlatButton button1;
    }
}