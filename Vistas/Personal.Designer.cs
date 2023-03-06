namespace Sistema_Asistencia_Personal.Vistas
{
    partial class Personal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.txtBuscarPersonal = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelPaginado = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.dataGvCargos = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAgregarPersonal = new System.Windows.Forms.Button();
            this.panelCargo = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnActualizarCargo = new System.Windows.Forms.Button();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtSueldoHora = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtNombreCargo = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPersonal = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.editarC = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnActualizarPersonal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPaginado.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvCargos)).BeginInit();
            this.panelCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(748, 60);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.Controls.Add(this.pictureBox1);
            this.panelBusqueda.Controls.Add(this.txtBuscarPersonal);
            this.panelBusqueda.Controls.Add(this.panel3);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBusqueda.Location = new System.Drawing.Point(454, 0);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(294, 60);
            this.panelBusqueda.TabIndex = 5;
            // 
            // txtBuscarPersonal
            // 
            this.txtBuscarPersonal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtBuscarPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarPersonal.Location = new System.Drawing.Point(62, 20);
            this.txtBuscarPersonal.Name = "txtBuscarPersonal";
            this.txtBuscarPersonal.Size = new System.Drawing.Size(232, 13);
            this.txtBuscarPersonal.TabIndex = 0;
            this.txtBuscarPersonal.TextChanged += new System.EventHandler(this.txtChangedShare);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Olive;
            this.panel3.Location = new System.Drawing.Point(67, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 3);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.panelPaginado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 54);
            this.panel2.TabIndex = 1;
            // 
            // panelPaginado
            // 
            this.panelPaginado.Controls.Add(this.label9);
            this.panelPaginado.Controls.Add(this.button6);
            this.panelPaginado.Controls.Add(this.label8);
            this.panelPaginado.Controls.Add(this.label7);
            this.panelPaginado.Controls.Add(this.button5);
            this.panelPaginado.Controls.Add(this.label6);
            this.panelPaginado.Controls.Add(this.button3);
            this.panelPaginado.Controls.Add(this.button4);
            this.panelPaginado.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPaginado.Location = new System.Drawing.Point(0, 0);
            this.panelPaginado.Name = "panelPaginado";
            this.panelPaginado.Size = new System.Drawing.Size(748, 54);
            this.panelPaginado.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(451, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "0";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(635, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Ultima pagina";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "de";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "0";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(516, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Primera pagina";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pagina";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Pagina anterior";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Pagina siguiente";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panelRegistro
            // 
            this.panelRegistro.AutoSize = true;
            this.panelRegistro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelRegistro.Controls.Add(this.btnActualizarPersonal);
            this.panelRegistro.Controls.Add(this.dataGvCargos);
            this.panelRegistro.Controls.Add(this.comboBox2);
            this.panelRegistro.Controls.Add(this.btnAgregarPersonal);
            this.panelRegistro.Controls.Add(this.panelCargo);
            this.panelRegistro.Controls.Add(this.button7);
            this.panelRegistro.Controls.Add(this.panel9);
            this.panelRegistro.Controls.Add(this.txtSueldo);
            this.panelRegistro.Controls.Add(this.panel8);
            this.panelRegistro.Controls.Add(this.txtCargo);
            this.panelRegistro.Controls.Add(this.panel7);
            this.panelRegistro.Controls.Add(this.txtIdentificacion);
            this.panelRegistro.Controls.Add(this.panel6);
            this.panelRegistro.Controls.Add(this.txtPais);
            this.panelRegistro.Controls.Add(this.panel5);
            this.panelRegistro.Controls.Add(this.txtNombre);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Controls.Add(this.label3);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Controls.Add(this.label1);
            this.panelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRegistro.Location = new System.Drawing.Point(0, 77);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(748, 430);
            this.panelRegistro.TabIndex = 3;
            // 
            // dataGvCargos
            // 
            this.dataGvCargos.AllowUserToAddRows = false;
            this.dataGvCargos.AllowUserToDeleteRows = false;
            this.dataGvCargos.AllowUserToResizeRows = false;
            this.dataGvCargos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvCargos.ColumnHeadersVisible = false;
            this.dataGvCargos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editarC});
            this.dataGvCargos.Location = new System.Drawing.Point(454, 320);
            this.dataGvCargos.Name = "dataGvCargos";
            this.dataGvCargos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGvCargos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGvCargos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGvCargos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.dataGvCargos.RowTemplate.Height = 30;
            this.dataGvCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGvCargos.Size = new System.Drawing.Size(291, 99);
            this.dataGvCargos.TabIndex = 20;
            this.dataGvCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventoClickCelda);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(314, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(91, 28);
            this.comboBox2.TabIndex = 19;
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.Location = new System.Drawing.Point(90, 287);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(97, 48);
            this.btnAgregarPersonal.TabIndex = 17;
            this.btnAgregarPersonal.Text = "Agregar Personal";
            this.btnAgregarPersonal.UseVisualStyleBackColor = true;
            this.btnAgregarPersonal.Click += new System.EventHandler(this.btnAgregarPersonal_Click);
            // 
            // panelCargo
            // 
            this.panelCargo.Controls.Add(this.btnVolver);
            this.panelCargo.Controls.Add(this.btnActualizarCargo);
            this.panelCargo.Controls.Add(this.btnAgregarCargo);
            this.panelCargo.Controls.Add(this.panel15);
            this.panelCargo.Controls.Add(this.txtSueldoHora);
            this.panelCargo.Controls.Add(this.panel14);
            this.panelCargo.Controls.Add(this.txtNombreCargo);
            this.panelCargo.Location = new System.Drawing.Point(454, 45);
            this.panelCargo.Name = "panelCargo";
            this.panelCargo.Size = new System.Drawing.Size(291, 269);
            this.panelCargo.TabIndex = 16;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(15, 116);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(71, 31);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnActualizarCargo
            // 
            this.btnActualizarCargo.Location = new System.Drawing.Point(187, 178);
            this.btnActualizarCargo.Name = "btnActualizarCargo";
            this.btnActualizarCargo.Size = new System.Drawing.Size(88, 75);
            this.btnActualizarCargo.TabIndex = 18;
            this.btnActualizarCargo.Text = "Actualizar";
            this.btnActualizarCargo.UseVisualStyleBackColor = true;
            this.btnActualizarCargo.Click += new System.EventHandler(this.btnActualizarCargo_Click);
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.Location = new System.Drawing.Point(67, 179);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(88, 75);
            this.btnAgregarCargo.TabIndex = 17;
            this.btnAgregarCargo.Text = "Agregar";
            this.btnAgregarCargo.UseVisualStyleBackColor = true;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Olive;
            this.panel15.Location = new System.Drawing.Point(98, 96);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(127, 2);
            this.panel15.TabIndex = 16;
            // 
            // txtSueldoHora
            // 
            this.txtSueldoHora.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSueldoHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoHora.Location = new System.Drawing.Point(98, 71);
            this.txtSueldoHora.Name = "txtSueldoHora";
            this.txtSueldoHora.Size = new System.Drawing.Size(127, 19);
            this.txtSueldoHora.TabIndex = 15;
            this.txtSueldoHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoHora_KeyPress);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Olive;
            this.panel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel14.Location = new System.Drawing.Point(12, 55);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(290, 2);
            this.panel14.TabIndex = 5;
            // 
            // txtNombreCargo
            // 
            this.txtNombreCargo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNombreCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCargo.Location = new System.Drawing.Point(22, 30);
            this.txtNombreCargo.Name = "txtNombreCargo";
            this.txtNombreCargo.Size = new System.Drawing.Size(275, 19);
            this.txtNombreCargo.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(430, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 75);
            this.button7.TabIndex = 15;
            this.button7.Text = "Agregar cargo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Olive;
            this.panel9.Location = new System.Drawing.Point(143, 242);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(263, 2);
            this.panel9.TabIndex = 14;
            // 
            // txtSueldo
            // 
            this.txtSueldo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldo.Location = new System.Drawing.Point(143, 223);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(262, 19);
            this.txtSueldo.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Olive;
            this.panel8.Location = new System.Drawing.Point(143, 198);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(262, 2);
            this.panel8.TabIndex = 12;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Location = new System.Drawing.Point(143, 179);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(262, 19);
            this.txtCargo.TabIndex = 11;
            this.txtCargo.TextChanged += new System.EventHandler(this.txtCargo_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Olive;
            this.panel7.Location = new System.Drawing.Point(143, 151);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(261, 2);
            this.panel7.TabIndex = 10;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.ForeColor = System.Drawing.Color.Black;
            this.txtIdentificacion.Location = new System.Drawing.Point(143, 132);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(262, 19);
            this.txtIdentificacion.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Olive;
            this.panel6.Location = new System.Drawing.Point(143, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(165, 2);
            this.panel6.TabIndex = 8;
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPais.Location = new System.Drawing.Point(143, 89);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(162, 19);
            this.txtPais.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Olive;
            this.panel5.Location = new System.Drawing.Point(143, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 2);
            this.panel5.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(143, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 19);
            this.txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo por hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "País";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // dataGridPersonal
            // 
            this.dataGridPersonal.AllowUserToOrderColumns = true;
            this.dataGridPersonal.AllowUserToResizeRows = false;
            this.dataGridPersonal.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.dataGridPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPersonal.Location = new System.Drawing.Point(0, 60);
            this.dataGridPersonal.Name = "dataGridPersonal";
            this.dataGridPersonal.ReadOnly = true;
            this.dataGridPersonal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dataGridPersonal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridPersonal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.dataGridPersonal.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPersonal.Size = new System.Drawing.Size(748, 453);
            this.dataGridPersonal.TabIndex = 2;
            this.dataGridPersonal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventTableCustomer);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Sistema_Asistencia_Personal.Properties.Resources.updated__1_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Sistema_Asistencia_Personal.Properties.Resources.remove;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::Sistema_Asistencia_Personal.Properties.Resources.editar_texto;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // editarC
            // 
            this.editarC.HeaderText = "";
            this.editarC.Image = global::Sistema_Asistencia_Personal.Properties.Resources.editar_texto;
            this.editarC.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editarC.Name = "editarC";
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::Sistema_Asistencia_Personal.Properties.Resources.updated__1_;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::Sistema_Asistencia_Personal.Properties.Resources.remove;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // btnActualizarPersonal
            // 
            this.btnActualizarPersonal.Location = new System.Drawing.Point(227, 287);
            this.btnActualizarPersonal.Name = "btnActualizarPersonal";
            this.btnActualizarPersonal.Size = new System.Drawing.Size(92, 48);
            this.btnActualizarPersonal.TabIndex = 21;
            this.btnActualizarPersonal.Text = "Registrar Cambios";
            this.btnActualizarPersonal.UseVisualStyleBackColor = true;
            this.btnActualizarPersonal.Click += new System.EventHandler(this.btnActualizarPersonal_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.dataGridPersonal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(748, 567);
            this.Load += new System.EventHandler(this.Personal_Load);
            this.panel1.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelBusqueda.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelPaginado.ResumeLayout(false);
            this.panelPaginado.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvCargos)).EndInit();
            this.panelCargo.ResumeLayout(false);
            this.panelCargo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBuscarPersonal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelBusqueda;
        private System.Windows.Forms.Panel panelPaginado;
        private System.Windows.Forms.Panel panelCargo;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtSueldoHora;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtNombreCargo;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridPersonal;
        private System.Windows.Forms.Button btnAgregarPersonal;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGvCargos;
        private System.Windows.Forms.DataGridViewImageColumn editarC;
        private System.Windows.Forms.Button btnActualizarCargo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Button btnActualizarPersonal;
    }
}
