namespace Sistema_Asistencia_Personal.Vistas
{
    partial class ControlAsist
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAsist));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarAsistencia = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridviewasistencia = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewasistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.dateTimeHasta);
            this.panel1.Controls.Add(this.dateTimeDesde);
            this.panel1.Controls.Add(this.panelBusqueda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 60);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Desde";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(468, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 26);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.clickAplicarFiltroFecha);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.CustomFormat = "yyyy-MM-dd";
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeHasta.Location = new System.Drawing.Point(262, 23);
            this.dateTimeHasta.MaxDate = new System.DateTime(2023, 3, 11, 0, 0, 0, 0);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHasta.TabIndex = 7;
            this.dateTimeHasta.Value = new System.DateTime(2023, 3, 10, 0, 0, 0, 0);
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.CustomFormat = "yyyy-MM-dd";
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDesde.Location = new System.Drawing.Point(43, 23);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDesde.TabIndex = 6;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.pictureBox1);
            this.panelBusqueda.Controls.Add(this.txtBuscarAsistencia);
            this.panelBusqueda.Controls.Add(this.panel3);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBusqueda.Location = new System.Drawing.Point(562, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(294, 60);
            this.panelBusqueda.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarAsistencia
            // 
            this.txtBuscarAsistencia.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBuscarAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAsistencia.Location = new System.Drawing.Point(62, 20);
            this.txtBuscarAsistencia.Name = "txtBuscarAsistencia";
            this.txtBuscarAsistencia.Size = new System.Drawing.Size(232, 16);
            this.txtBuscarAsistencia.TabIndex = 0;
            this.txtBuscarAsistencia.TextChanged += new System.EventHandler(this.txtBuscarAsistencia_TextChanged_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Olive;
            this.panel3.Location = new System.Drawing.Point(67, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 3);
            this.panel3.TabIndex = 1;
            // 
            // dataGridviewasistencia
            // 
            this.dataGridviewasistencia.AllowUserToAddRows = false;
            this.dataGridviewasistencia.AllowUserToDeleteRows = false;
            this.dataGridviewasistencia.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridviewasistencia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridviewasistencia.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridviewasistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridviewasistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridviewasistencia.Location = new System.Drawing.Point(0, 60);
            this.dataGridviewasistencia.Name = "dataGridviewasistencia";
            this.dataGridviewasistencia.ReadOnly = true;
            this.dataGridviewasistencia.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridviewasistencia.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridviewasistencia.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridviewasistencia.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridviewasistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridviewasistencia.Size = new System.Drawing.Size(856, 519);
            this.dataGridviewasistencia.TabIndex = 3;
            // 
            // ControlAsist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridviewasistencia);
            this.Controls.Add(this.panel1);
            this.Name = "ControlAsist";
            this.Size = new System.Drawing.Size(856, 579);
            this.Load += new System.EventHandler(this.ControlAsist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewasistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarAsistencia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridviewasistencia;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
