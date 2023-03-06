using Sistema_Asistencia_Personal.ConexiónBDPostgresql;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
  
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            conection con = new conection();
            con.conect();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            panelPadre.Controls.Clear();
            Personal controlp = new Personal();
            controlp.Dock = DockStyle.Fill;
            panelPadre.Controls.Add(controlp);
        }
    }
}
