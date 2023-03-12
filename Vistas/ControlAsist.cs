using Sistema_Asistencia_Personal.Controlador;
using Sistema_Asistencia_Personal.Diseño;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Asistencia_Personal.Vistas
{
    public partial class ControlAsist : UserControl
    {
        public ControlAsist()
        {
            InitializeComponent();
        }

        FuncionAsistencia functions = new FuncionAsistencia();

        private void ControlAsist_Load(object sender, EventArgs e)
        {
            mostrarAsistencias();
        }

        private void mostrarAsistencias()
        {
       
            DataTable dt = new DataTable();
            DataView dv = new DataView(dt);
            functions.mostrarTodo(dt);
            dataGridviewasistencia.DataSource = dt;
            Bases.diseñoDtv(ref dataGridviewasistencia);
            
        }

        private void mostrarAsistenciaPorPersonal()
        {

        }

        private void txtBuscarAsistencia_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataView dv = new DataView(dt);
            functions.mostrarTodo(dt);
            dataGridviewasistencia.DataSource = dt;
            Bases.diseñoDtv(ref dataGridviewasistencia);
            string filtro = string.Format("Identificación LIKE '%{0}%'", txtBuscarAsistencia.Text);
            dv.RowFilter = filtro;
            dataGridviewasistencia.DataSource = dv.ToTable();
        }

        private void clickAplicarFiltroFecha(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            DataView dv = new DataView(dt);
            functions.mostrarPorFecha(dateTimeDesde.Value, dateTimeHasta.Value,  dt);
            dataGridviewasistencia.DataSource = dt;
            Bases.diseñoDtv(ref dataGridviewasistencia);
        }
    }
}
