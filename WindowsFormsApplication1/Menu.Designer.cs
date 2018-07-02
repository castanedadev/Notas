namespace WindowsFormsApplication1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificarActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadroDeActividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadroFinalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.cuadroFinalToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.docenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeAlumnosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // registroDeAlumnosToolStripMenuItem
            // 
            this.registroDeAlumnosToolStripMenuItem.Name = "registroDeAlumnosToolStripMenuItem";
            this.registroDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.registroDeAlumnosToolStripMenuItem.Text = "Registro de alumnos";
            this.registroDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.registroDeAlumnosToolStripMenuItem_Click);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planificarActividadesToolStripMenuItem,
            this.cuadroDeActividadesToolStripMenuItem});
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            // 
            // planificarActividadesToolStripMenuItem
            // 
            this.planificarActividadesToolStripMenuItem.Name = "planificarActividadesToolStripMenuItem";
            this.planificarActividadesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);

            this.planificarActividadesToolStripMenuItem.Text = "Planificar actividades";
            this.planificarActividadesToolStripMenuItem.Click += new System.EventHandler(this.planificarActividadesToolStripMenuItem_Click);
            // 
            // cuadroDeActividadesToolStripMenuItem
            // 
            this.cuadroDeActividadesToolStripMenuItem.Name = "cuadroDeActividadesToolStripMenuItem";

            this.cuadroDeActividadesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cuadroDeActividadesToolStripMenuItem.Text = "Cuadro de notas";

            this.cuadroDeActividadesToolStripMenuItem.Click += new System.EventHandler(this.cuadroDeActividadesToolStripMenuItem_Click);
            // 
            // cuadroFinalToolStripMenuItem
            // 
            this.cuadroFinalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeNotasToolStripMenuItem});
            this.cuadroFinalToolStripMenuItem.Name = "cuadroFinalToolStripMenuItem";
            this.cuadroFinalToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.cuadroFinalToolStripMenuItem.Text = "Cuadro final";
            // 
            // reporteDeNotasToolStripMenuItem
            // 
            this.reporteDeNotasToolStripMenuItem.Name = "reporteDeNotasToolStripMenuItem";
            this.reporteDeNotasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.reporteDeNotasToolStripMenuItem.Text = "Reporte de notas";
            this.reporteDeNotasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeNotasToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelDocenteToolStripMenuItem});
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.docenteToolStripMenuItem.Text = "Docente";
            // 
            // datosDelDocenteToolStripMenuItem
            // 
            this.datosDelDocenteToolStripMenuItem.Name = "datosDelDocenteToolStripMenuItem";
            this.datosDelDocenteToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.datosDelDocenteToolStripMenuItem.Text = "Datos del docente";
            this.datosDelDocenteToolStripMenuItem.Click += new System.EventHandler(this.datosDelDocenteToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(570, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // lblusu
            // 
            this.lblusu.AutoSize = true;
            this.lblusu.Location = new System.Drawing.Point(64, 5);
            this.lblusu.Name = "lblusu";
            this.lblusu.Size = new System.Drawing.Size(35, 17);
            this.lblusu.TabIndex = 6;
            this.lblusu.Text = "label2";
            this.lblusu.UseCompatibleTextRendering = true;
            // 
            // button1
            // 

            this.button1.Location = new System.Drawing.Point(374, 24);

            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "GRÁFICOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(570, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblusu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificarActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadroDeActividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadroFinalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelDocenteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusu;
        private System.Windows.Forms.Button button1;
    }
}