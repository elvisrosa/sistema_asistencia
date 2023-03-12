using Sistema_Asistencia_Personal.Controlador;
using Sistema_Asistencia_Personal.Modelo;
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
    public partial class TomarAsistencia : Form
    {
        public TomarAsistencia()
        {
            //txtCedula.Focus();
            InitializeComponent();
            linkObservacion.Visible = false;
            panelInicioAdmin.Visible = false;
            btnVolver.Visible = false;
            panelnicioSesionPersonal.Visible = false;
        }

        FuncionesPersonal functios = new FuncionesPersonal();
        FuncionAsistencia functios_asis = new FuncionAsistencia();
        public string identificacion;
        private Usuario user;


        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionesPersonal f = new FuncionesPersonal();
            f.buscar(txtCedula.Text);
        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registrarEntrada_Salida();
            }

        }

        private void changeEventTxtCeduña(object sender, EventArgs e)
        {
            buscarPersonalIdent();
        }

        private void buscarPersonalIdent()
        {
            PersonalM persona = new PersonalM();
            persona.Identificacion = txtCedula.Text;
            /*if(functios.buscarP(persona))
            {
                functios.buscarP(persona);
                panelObservacion.Visible = false;
            }
            else
            {
                functios.buscarP(persona);
                panelObservacion.Visible = true;

            }*/
            
            if (functios.buscarP(persona))
            {
                if (persona.Estado.Contains("ELIMINADO"))
                {
                    MessageBox.Show("Se encuentra en estado eliminado" + "\n"+"Pongase en contanto con recursos humanos", "System Message");
                    txtCedula.Clear();
                    linkObservacion.Visible = false;
                }
                else
                {
                    linkObservacion.Visible = true;
                    identificacion = persona.Identificacion;
                    lblIdentificacionNombre.Text = persona.Nombre;
                }
            }                 
        }

        private void registrarEntrada_Salida()
        {
            Asistencia asist = new Asistencia();
            asist.Hora_entrada = DateTime.Now;
            asist.Hora_salida = DateTime.Now;
            asist.Observacion = txtObservacion.Text;
            asist.Fecha = DateTime.Now.Date;
            asist.Identificacion_persona = identificacion;
            functios_asis.agregarAsistencia(asist);
            limpiarDatosRegistroAsistencia();
            lblIdentificacionNombre.Text = "************************************";

        }

        private void limpiarDatosRegistroAsistencia()
        {
            txtCedula.Clear();
            txtObservacion.Clear();
            linkObservacion.Visible = false;
            txtCedula.Enabled = true;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //panelTomarAsistencia.Controls.Clear();
            //InicioSesion inicio = new InicioSesion();
            //inicio.Dock = DockStyle.Fill;
            //panelTomarAsistencia.Controls.Add(inicio);
            //btnIniciarSesion.Visible = false;
            panelInicioAdmin.Visible = true;
            panelInicioAdmin.BringToFront();
            btnVolver.Visible = true;
            panelObservacion.Visible = false;
            btnIniciarSesion.Visible = false;
            panelnicioSesionPersonal.Visible = false;
            paneAsistencia.Visible = true;

        }

        private void TomarAsistencia_Load(object sender, EventArgs e)
        {
            panelObservacion.Visible = false;
        }

        private void btnAgregarObservacion_Click(object sender, EventArgs e)
        {
            registrarEntrada_Salida();
            panelObservacion.Visible = false;
        }

        private void linkObservacion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelObservacion.Visible = true;
            txtCedula.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            paneAsistencia.Visible = true;
            panelInicioAdmin.Visible=false;
            btnVolver.Visible=false;
            btnIniciarSesion.Visible = true;
            btnSesionPersonal.Visible = true;
            panelnicioSesionPersonal.Visible = false;
        }

        private void bntIniciarSesion_Click(object sender, EventArgs e)
        {
            FuncionesUsuarios functios = new FuncionesUsuarios();
            user = new Usuario();
            user.Contrsenna = txtContraseña.Text;
            user.IdentificacionPersonal = textCedula.Text;


            if (functios.iniciarSesion(user))
            {
                if (user.Tipo.Contains("EMPLEADO"))
                {
                    vistaEmpleado();
                    limpiarTextInicioSesion();
                }
                else if (user.Tipo.Contains("ADMIN"))
                {
                    vistaAdmin();
                    limpiarTextInicioSesion();
                }
                else
                {
                    MessageBox.Show("No existe un tipo");
                    limpiarTextInicioSesion();
                }
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
                limpiarTextInicioSesion();
            }
        }

        private void vistaEmpleado()
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.btnPersonal.Enabled = false;
            menu.btnPrePlanilla.Enabled = false;
            menu.btnRestaurar.Enabled = false;
            menu.lblNombreUsuario.Text = user.Nombre;
            menu.Show();
        }

        private void vistaAdmin()
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.lblNombreUsuario.Text = user.Nombre;
            menu.Show();
        }

        public void limpiarTextInicioSesion()
        {
            textCedula.Clear();
            txtContraseña.Clear();
        }



        private void btnSesionPersonal_Click(object sender, EventArgs e)
        {
            paneAsistencia.Visible = false;
            panelnicioSesionPersonal.Visible = true;
            panelnicioSesionPersonal.BringToFront();
            panelInicioAdmin.Visible = false;
            txtObservacion.Visible= false;
            btnSesionPersonal.Visible= false;
            btnVolver.Visible = true;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            txtCedulaPersonal.Text += "1";

        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            txtCedulaPersonal.Text += "2";

        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            txtCedulaPersonal.Text += "3";

        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            txtCedulaPersonal.Text += "4";

        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            txtCedulaPersonal.Text += "5";

        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            txtCedulaPersonal.Text += "6";

        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            txtCedulaPersonal.Text += "7";

        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            txtCedulaPersonal.Text += "8";

        }


        private void btn9_Click(object sender, EventArgs e)
        {
            txtCedulaPersonal.Text += "9";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCedulaPersonal.Text += "0";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCedulaPersonal.Clear();
        }

        private void btnBorrarAnterior_Click(object sender, EventArgs e)
        {
            int contador;
            contador = txtCedulaPersonal.Text.Count();
            if (contador > 0)
            {
                txtCedulaPersonal.Text = txtCedulaPersonal.Text.Substring(0, txtCedulaPersonal.Text.Count() - 1);
            }
        }

        private void iniciarSesionKeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {

                FuncionesUsuarios functios = new FuncionesUsuarios();
                user = new Usuario();
                user.IdentificacionPersonal = txtCedulaPersonal.Text;
                if (functios.inicioSesionPersona(user))
                {
                    if (user.Tipo.Contains("EMPLEADO"))
                    {
                        vistaEmpleado();
                        limpiarTextInicioSesion();
                    }
                    else
                    {
                        MessageBox.Show("Este usuario es administrador, dirijase al inicio de sesion correspondiente","System Message",  MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        limpiarTextInicioSesion();
                    }
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas","System Message",  MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    limpiarTextInicioSesion();
                }
            }
        }

        private void panelBarAsistencia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInicioAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LinkOcultar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelObservacion.Visible = false;
            txtCedula.Enabled = true;
            txtCedula.Focus();
        }
    }
}