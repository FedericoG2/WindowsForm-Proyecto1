using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" && txtContraseña.Text == "adm135$") || (txtUsuario.Text == "Operador" && txtContraseña.Text == "ope246$"))
            {
                this.Hide(); // oculta este formualrio
                frmInicio f = new frmInicio(); // crea el frmInicio, f es de tipo frmInicio
                f.Text = txtUsuario.Text; // asigna el texto de título
                f.ShowDialog(); // visualiza y ejecuta el frmInicio
                this.Show(); // visualiza nuevamente este formulario
            } 
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++; // incrementa el contador de intentos fallidos
                if (intentos == 3) // si es 3 se cierra el formulario
                {
                    this.Close();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra el formulario
        }
    }
}
