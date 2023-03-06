using Npgsql;
using Sistema_Asistencia_Personal.ConexiónBDPostgresql;
using Sistema_Asistencia_Personal.Controlador;
using Sistema_Asistencia_Personal.Diseño;
using Sistema_Asistencia_Personal.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Asistencia_Personal.Vistas
{
    public partial class Personal : UserControl

    {
        private int idCargo;
        private string persona_id;
        private string estado;
        FuncionesPersonal functions = new FuncionesPersonal();
        FuncionesControl control = new FuncionesControl();


        public Personal()
        {
            InitializeComponent();
            panelRegistro.Visible = false;
            panelCargo.Visible = false;
            btnActualizarPersonal.Visible = false;
            mostrarCargos();
            mostrarPersonal();
            //txtCargo.TextChanged += new EventHandler(txtCargo_TextChanged);


        }

        private void localizarDataCargos()
        {
            dataGvCargos.Location = new Point(panel8.Location.X, panel8.Location.Y);
            dataGvCargos.Size = new Size(279, 99);
            dataGvCargos.Visible = true;
        }

        private PersonalM personal;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelCargo.Visible = true;
            panelCargo.Dock = DockStyle.Fill;
            panelCargo.BringToFront();
            txtNombreCargo.Clear();
            txtSueldoHora.Clear();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombreCargo.Text))
                {
                    if (!string.IsNullOrEmpty(txtSueldoHora.Text))
                    {
                        Cargo c = new Cargo();
                        c.Nombrecargo = txtNombreCargo.Text;
                        c.SueldoHora = float.Parse(txtSueldoHora.Text);

                        FuncionesControl functionn = new FuncionesControl();
                        functionn.agregar(c);
                        txtNombreCargo.Clear();
                        txtSueldoHora.Clear();
                        mostrarCargos();
                        panelCargo.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Campos sueldo vacio", "System Messague", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Campos Cargo vacio", "System Messague", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mostrarCargos()
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView(dt);
            control.mostrar(dt);
            dataGvCargos.DataSource = dt;
            Bases.diseñoDtv(ref dataGvCargos);
            string filtro = string.Format("Cargo LIKE '%{0}%'", txtCargo.Text);
            dv.RowFilter = filtro;
            dataGvCargos.DataSource = dv.ToTable();
            dataGvCargos.Columns[1].Visible = false;
            dataGvCargos.Columns[3].Visible = false;

            dataGvCargos.Visible = true; //Debes solucionar este error

        }

        private void filtrarPersonal()
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView(dt);
            functions.mostrarTodo(dt);
            dataGvCargos.DataSource = dt;
            Bases.diseñoDtv(ref dataGvCargos);
            string filtro = string.Format("Nombres LIKE '%{0}%'", txtBuscarPersonal.Text);
            dv.RowFilter = filtro;
            dataGridPersonal.DataSource = dv.ToTable();

            //data.Visible = true; //Debes solucionar este error

        }

        private void mostrarPersonal()
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView(dt);
            functions.mostrarTodo(dt);
            Bases.diseñoDtv(ref dataGridPersonal);
            dataGridPersonal.DataSource = dt;
        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                personal = new PersonalM();
                personal.Nombre = txtNombre.Text;
                personal.Cargo = idCargo;
                personal.Identificacion = txtIdentificacion.Text;
                personal.Pais = txtPais.Text;
                functions.agregar(personal);
                limpiarcampos();


            } catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCargo.Visible = false;
            panelPaginado.Visible = false;
            panelRegistro.Visible = true;
            panelRegistro.Dock = DockStyle.Fill;
            limpiarcampos();
            localizarDataCargos();
        }

        private void limpiarcampos()
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtCargo.Clear();
        }

        private void txtSueldoHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.manejoDecimal(txtSueldoHora, e);
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            mostrarCargos(); //Vuelve a establecer los datos del dataGridView

        }

        private void eventoClickCelda(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGvCargos.Columns["editarC"].Index)
            {
                editarDatos();
            }
            if (e.ColumnIndex == dataGvCargos.Columns["Cargo"].Index)
            {
                obtenerDatosCargo();
            }
        }

        private void obtenerDatosCargo()
        {
            idCargo = Convert.ToInt32(dataGvCargos.SelectedCells[1].Value);
            txtSueldo.Text = dataGvCargos.SelectedCells[3].Value.ToString();
            txtCargo.Text = dataGvCargos.SelectedCells[2].Value.ToString();
            //MessageBox.Show(idCargo.ToString());
            dataGvCargos.Visible = false;
            //mostrar panel de los botones

        }

        private void editarDatos()
        {
            idCargo = Convert.ToInt32(dataGvCargos.SelectedCells[1].Value);
            txtNombreCargo.Text = dataGvCargos.SelectedCells[2].Value.ToString();
            txtSueldoHora.Text = dataGvCargos.SelectedCells[3].Value.ToString();
            btnAgregarCargo.Visible = false;
            txtNombreCargo.Focus();
            txtNombreCargo.SelectAll();
            panelCargo.Visible = true;
            panelCargo.Dock = DockStyle.Fill;
            panelCargo.BringToFront();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelCargo.Visible = false;
        }

        private void btnActualizarCargo_Click(object sender, EventArgs e)
        {
            Cargo cargo = new Cargo();
            cargo.SueldoHora = float.Parse(txtSueldoHora.Text);
            cargo.Nombrecargo = txtNombreCargo.Text;
            cargo.ID = idCargo;
            control.actualizar(cargo);
            panelCargo.Visible = false;
            mostrarCargos();

        }

        private void Personal_Load(object sender, EventArgs e)
        {
        }

        private void eliminarPersonal()
        {
            persona_id = dataGridPersonal.SelectedCells[2].Value.ToString();            
            PersonalM modelo = new PersonalM();
            //modelo.Identificacion = persona_id.ToString();
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cambiar el estado a eliminado\n"+persona_id+"?", 
                "Confirmar cambio de estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                functions.cambiarEstado(persona_id, "ELIMINADO");
                mostrarPersonal();
            }
     
        }

        private void restaurarBdPersoa()
        {
            persona_id = dataGridPersonal.SelectedCells[2].Value.ToString();
            DialogResult result = MessageBox.Show("Este usuario ha sido suspendido, Desea restaurarlo ? ", "Mensaje del sistema",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                functions.cambiarEstado(persona_id, "ACTIVO");
                mostrarPersonal();
            }
        }

        private void obtenerDatosPersonal() {
            //Estado de la persona actual
            estado = dataGridPersonal.SelectedCells[7].Value.ToString();
            txtIdentificacion.Text = dataGridPersonal.SelectedCells[2].Value.ToString();

            if (estado.Contains("ACTIVO")) { 
            
                    txtNombre.Text = dataGridPersonal.SelectedCells[3].Value.ToString();
                    txtPais.Text = dataGridPersonal.SelectedCells[4].Value.ToString();
                    txtCargo.Text = dataGridPersonal.SelectedCells[6].Value.ToString();
                    txtSueldo.Text = dataGridPersonal.SelectedCells[5].Value.ToString();
                    panelRegistro.Visible = true;
                    dataGvCargos.Visible = false;
                    btnAgregarPersonal.Visible = false;
                    panelRegistro.Dock = DockStyle.Fill;
                    panelPaginado.Visible = false;
                    dataGridPersonal.Visible = false;
                    txtIdentificacion.ForeColor = Color.Red;
                    btnActualizarPersonal.Visible = true;

            }
            else
            {
                restaurarBdPersoa();
            }
        }

        private void eventTableCustomer(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridPersonal.Columns["Eliminar"].Index)
            {
                eliminarPersonal();
            }

            if (e.ColumnIndex == dataGridPersonal.Columns["Editar"].Index)
            {
                obtenerDatosPersonal();
            }
           
        }

        private void btnActualizarPersonal_Click(object sender, EventArgs e)
        {
            PersonalM modelo = new PersonalM();
            DialogResult result = MessageBox.Show("¿Está seguro de que desea actualizar este registro\n" + persona_id + "?",
                "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            modelo.Identificacion = txtIdentificacion.Text;
            modelo.Nombre = txtNombre.Text;
            modelo.Pais = txtPais.Text;
            modelo.Cargo = 6;

            if (result == DialogResult.Yes)
            {
                functions.actualizar(modelo);
                mostrarPersonal();
            }
        }

        private void txtChangedShare(object sender, EventArgs e)
        {
            filtrarPersonal();
        }
    }
}
