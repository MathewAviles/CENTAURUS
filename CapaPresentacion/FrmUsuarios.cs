using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtId.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtId.Text)
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtId.Text),
                Cedula = txtcedula.Text,
                NombreCompleto = txtnombreusuario.Text,
                Correo = txtcorreo.Text,
                Clave = txtcontrasena.Text,
                oRol = new Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cbrol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cbestado.SelectedItem).Valor) == 1 ? true : false
            };

            if (objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)

                {
                    dgvdata.Rows.Add(new object[] {"",idusuariogenerado,txtcedula.Text,txtnombreusuario.Text,txtcorreo.Text, txtcontrasena.Text,
                ((OpcionCombo)cbrol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cbrol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cbestado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cbestado.SelectedItem).Texto.ToString(),
                });

                    limpiar();
                }

                else
                {
                    MessageBox.Show(mensaje);
                }


            }

            else
            {
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtId.Text;
                    row.Cells["Cedula"].Value = txtcedula.Text;
                    row.Cells["NombreUsuario"].Value = txtnombreusuario.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Clave"].Value = txtcontrasena.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cbrol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cbrol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbestado.SelectedItem).Texto.ToString();

                    limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }



        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x,y,w,h));
                e.Handled = true;

            }
        }




        private void limpiar()
        {
            txtindice.Text = "-1";
            txtcedula.Text = "";
            txtcontrasena.Text = "";
            txtcorreo.Text = "";
            txtId.Text = "0";
            txtnombreusuario.Text = "";
            txtrepitacontrasena.Text = "";
            cbestado.SelectedIndex = 0;
            cbrol.SelectedIndex = 0;
            txtnombreusuario.Select();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            cbestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cbestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            cbestado.DisplayMember = "Texto";
            cbestado.ValueMember = "Valor";
            cbestado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();


            foreach (Rol item in listaRol)
            {

                cbrol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
                
            }


            cbrol.DisplayMember = "Texto";
            cbrol.ValueMember = "Valor";
            cbrol.SelectedIndex = 0;


            


            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText, });
                }

            }

            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;




            //List<Rol> listaRol= new CN_Rol().Listar();



            //Mostrar todos los Usuarios

            List<Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (Usuario item in listaUsuario)
            {

                dgvdata.Rows.Add(new object[] {"",item.IdUsuario, item.Cedula,item.NombreCompleto,item.Correo,item.Clave,
                item.oRol.IdRol,
                item.oRol.Descripcion,
                item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" : "No Activo"
                });
                
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text= indice.ToString();
                    txtId.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtcedula.Text = dgvdata.Rows[indice].Cells["Cedula"].Value.ToString();
                    txtnombreusuario.Text = dgvdata.Rows[indice].Cells["NombreUsuario"].Value.ToString();
                    txtcorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtcontrasena.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    txtrepitacontrasena.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo oc in cbrol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == (Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value)))
                            {
                            int indice_combo = cbrol.Items.IndexOf(oc);
                            cbrol.SelectedIndex=indice_combo;
                            break;
                        }
                    }


                    foreach (OpcionCombo oc in cbestado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == (Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value)))
                        {
                            int indice_combo = cbestado.Items.IndexOf(oc);
                            cbestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }




                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
