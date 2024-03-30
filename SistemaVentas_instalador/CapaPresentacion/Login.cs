using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_cedula.Focus(); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNINGRESAR_Click(object sender, EventArgs e)
        {
            List<Usuario> test = new CN_Usuario().Listar();

            Usuario oUsuario = new CN_Usuario().Listar().Where(u=> u.Cedula == txt_cedula.Text && u.Clave == txt_contraseña.Text).FirstOrDefault();

            if (oUsuario != null)
            {
                Inicio form = new Inicio(oUsuario);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontró al usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txt_cedula.Focus();
            txt_cedula.Text =null;
            txt_contraseña.Text =null;
            
            this.Show();    
        }
        private void BTN_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
