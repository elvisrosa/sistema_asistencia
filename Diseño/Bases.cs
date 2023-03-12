using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Asistencia_Personal.Diseño
{
    public class Bases
    {
        public static void diseñoDtv(ref DataGridView listado)
        {
            listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            listado.BackgroundColor = SystemColors.ControlDarkDark;
            listado.EnableHeadersVisualStyles = false;
            listado.BorderStyle = BorderStyle.None;
            listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
            listado.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            listado.RowHeadersVisible= false;//?
            listado.ReadOnly=true;
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = SystemColors.ControlDarkDark;
            cabecera.ForeColor = Color.White;
            cabecera.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            listado.ColumnHeadersDefaultCellStyle = cabecera;
        }
        public static void diseñoDtvEliminado(ref DataGridView listado)
        {
            foreach (DataGridViewRow row in listado.Rows)
            {
                string estado = row.Cells["Estado"].Value.ToString();
                if (estado.Contains("ELIMINADO"))
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(225, 128, 128);
                }
            }   
        }

        public static object manejoDecimal(TextBox texto, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];

            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && (~texto.Text.IndexOf(".")) != 0)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return null;
        }


    }

}
