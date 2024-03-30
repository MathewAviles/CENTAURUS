using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using FontAwesome.Sharp;
namespace CapaPresentacion
{
    public partial class Inicio : Form
    {

        private static Usuario usuarioactual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario)
        {
            usuarioactual = objusuario;

            InitializeComponent();

        }

        private void TutuloSistema_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListaPermisos = new CN_Permiso().Listar(usuarioactual.IdUsuario);

            foreach (IconMenuItem iconMenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconMenu.Name);

                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }


            lbl_Usuario.Text = usuarioactual.NombreCompleto;
        }



        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            MenuActivo = menu;


            if (FormularioActivo != null)
            {
                FormularioActivo.Close();   
            }

            FormularioActivo=formulario;
            formulario.TopLevel=false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.Tomato;

            CONTENEDOR.Controls.Add(formulario);
            formulario.Show();
        }
        private void MENUUSUARIOS_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuarios());
        }

        private void submenuCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MENUMANTENEDOR, new FrmCategorias());
        }

        private void submenuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MENUMANTENEDOR, new FrmProductos());
        }

        private void submenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MENUVENTAS, new FrmVentas(usuarioactual));
        }

        private void submenuVerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MENUVENTAS, new FrmDetalleVenta());
        }

        private void MENUCLIENTES_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        }

        private void SubmenuNegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MENUMANTENEDOR, new FrmNegocio());
        }

        private void submenureporteventas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MENUREPORTES, new FrmReportes());
        }

        private void MENUACERCADE_Click(object sender, EventArgs e)
        {
            mdAcercaDe md=new mdAcercaDe();
            md.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
