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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvauxiliar = new System.Windows.Forms.DataGridView();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TriA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvauxiliar)).BeginInit();
            this.SuspendLayout();
            // 
            // TriA
            // 
            chartArea5.AxisY.Maximum = 10D;
            chartArea5.AxisY.Minimum = 0D;
            chartArea5.Name = "ChartArea1";
            this.TriA.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.TriA.Legends.Add(legend5);
            this.TriA.Location = new System.Drawing.Point(-3, 143);
            this.TriA.Name = "TriA";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.TriA.Series.Add(series5);
            this.TriA.Size = new System.Drawing.Size(300, 300);
            this.TriA.TabIndex = 0;
            this.TriA.Text = "chart1";
            // 
            // TriB
            // 
            chartArea6.AxisY.Maximum = 10D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.Name = "ChartArea1";
            this.TriB.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.TriB.Legends.Add(legend6);
            this.TriB.Location = new System.Drawing.Point(295, 143);
            this.TriB.Name = "TriB";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.TriB.Series.Add(series6);
            this.TriB.Size = new System.Drawing.Size(303, 300);
            this.TriB.TabIndex = 1;
            this.TriB.Text = "chart2";
            // 
            // TotalA
            // 
            chartArea7.AxisY.Maximum = 10D;
            chartArea7.AxisY.Minimum = 0D;
            chartArea7.Name = "ChartArea1";
            this.TotalA.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.TotalA.Legends.Add(legend7);
            this.TotalA.Location = new System.Drawing.Point(67, 449);
            this.TotalA.Name = "TotalA";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.TotalA.Series.Add(series7);
            this.TotalA.Size = new System.Drawing.Size(230, 226);
            this.TotalA.TabIndex = 2;
            this.TotalA.Text = "chart3";
            // 
            // TotalB
            // 
            chartArea8.AxisY.Maximum = 10D;
            chartArea8.AxisY.Minimum = 0D;
            chartArea8.Name = "ChartArea1";
            this.TotalB.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.TotalB.Legends.Add(legend8);
            this.TotalB.Location = new System.Drawing.Point(295, 449);
            this.TotalB.Name = "TotalB";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.TotalB.Series.Add(series8);
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
            this.label3.Location = new System.Drawing.Point(53, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Materia:";
            // 
            // cbGrado
            // 
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(98, 12);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(149, 21);
            this.cbGrado.TabIndex = 8;
            this.cbGrado.SelectedIndexChanged += new System.EventHandler(this.cbGrado_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(328, 13);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(163, 21);
            this.cbMateria.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Comparativa de rendimiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cbSeccion.FormattingEnabled = true;
            this.cbSeccion.Location = new System.Drawing.Point(534, 62);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(44, 21);
            this.cbSeccion.TabIndex = 12;
            // 
            // DirectorGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 732);
            this.Controls.Add(this.cbSeccion);
            this.Controls.Add(this.dgvauxiliar);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvauxiliar;
        private System.Windows.Forms.ComboBox cbSeccion;
    }
}