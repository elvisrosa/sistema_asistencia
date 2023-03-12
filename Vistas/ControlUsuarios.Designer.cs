namespace Sistema_Asistencia_Personal.Vistas
{
    partial class ControlUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuarios));
            this.panelControlUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarPersonal = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControlUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControlUsuario
            // 
            this.panelControlUsuario.Controls.Add(this.panel1);
            this.panelControlUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelControlUsuario.Name = "panelControlUsuario";
            this.panelControlUsuario.Size = new System.Drawing.Size(714, 545);
            this.panelControlUsuario.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panelBusqueda);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 60);
            this.panel1.TabIndex = 1;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.pictureBox1);
            this.panelBusqueda.Controls.Add(this.txtBuscarPersonal);
            this.panelBusqueda.Controls.Add(this.panel3);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBusqueda.Location = new System.Drawing.Point(420, 0);
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
            // txtBuscarPersonal
            // 
            this.txtBuscarPersonal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBuscarPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPersonal.Location = new System.Drawing.Point(62, 20);
            this.txtBuscarPersonal.Name = "txtBuscarPersonal";
            this.txtBuscarPersonal.Size = new System.Drawing.Size(232, 16);
            this.txtBuscarPersonal.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Olive;
            this.panel3.Location = new System.Drawing.Point(67, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 3);
            this.panel3.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(90, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mostrar Todos";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 47);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panelControlUsuario);
            this.Name = "ControlUsuarios";
            this.Size = new System.Drawing.Size(714, 545);
            this.panelControlUsuario.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarPersonal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
