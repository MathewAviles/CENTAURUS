﻿using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
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

namespace CapaPresentacion
{
    public partial class FrmVentas : Form
    {

        private Usuario _Usuario;
        public FrmVentas(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            cbtipodocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbtipodocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbtipodocumento.DisplayMember = "Texto";
            cbtipodocumento.ValueMember = "Valor";
            cbtipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtidproducto.Text = "0";

            txtpagacon.Text = "";
            txtcambio.Text = "";
            txttotalapagar.Text = "0";
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnbuscarcli_Click(object sender, EventArgs e)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtnumerodocumento.Text = modal._Cliente.Cedula;
                    txtnombrecompleto.Text = modal._Cliente.NombreCompleto;
                    txtcodproducto.Select();
                }
                else
                {
                    txtnumerodocumento.Select();
                }

            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscarinfoproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.Codigo;
                    txtproducto.Text = modal._Producto.Nombre;
                    txtprecio.Text = modal._Producto.Precio.ToString("0.00");
                    txtcantidad.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }

            }
        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodproducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtcodproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtproducto.Text = oProducto.Nombre;
                    txtprecio.Text = oProducto.Precio.ToString("0.00");
                    txtcantidad.Select();
                }
                else
                {
                    txtcodproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                    txtprecio.Text = "";
                    txtcantidad.Value = 1;
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal precio = 0;
            bool producto_existe = false;

            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtprecio.Text, out precio))
            {
                MessageBox.Show("Precio - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecio.Select();
                return;
            }


            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if (!producto_existe)
            {

                /*bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtidproducto.Text),
                    Convert.ToInt32(txtcantidad.Value.ToString())
                    );

                if (respuesta)
                {*/
                    dgvdata.Rows.Add(new object[] {
                        txtidproducto.Text,
                        txtproducto.Text,
                        precio.ToString("0.00"),
                        txtcantidad.Value.ToString(),
                        (txtcantidad.Value * precio).ToString("0.00")
                    });

                    calcularTotal();
                    limpiarProducto();
                    txtcodproducto.Select();
                //}
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txttotalapagar.Text = total.ToString("0.00");
        }

        private void limpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Text = "";
            txtproducto.Text = "";
            txtprecio.Text = "";
            txtcantidad.Value = 1;
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.cancel.Width;
                var h = Properties.Resources.cancel.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.cancel, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminarproducto")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    /*bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvdata.Rows[index].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvdata.Rows[index].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {*/
                        dgvdata.Rows.RemoveAt(index);
                        calcularTotal();
                    //}

                }
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }

            }
        }

        private void txtpagacon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagacon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }

            }
        }



        private void calcularcambio()
        {

            if (txttotalapagar.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            decimal pagacon;
            decimal total = Convert.ToDecimal(txttotalapagar.Text);

            if (txtpagacon.Text.Trim() == "")
            {
                txtpagacon.Text = "0";
            }

            if (decimal.TryParse(txtpagacon.Text.Trim(), out pagacon))
            {

                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00");

                }
            }



        }

        private void txtpagacon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void icnCrearventa_Click(object sender, EventArgs e)
        {
            if (txtnumerodocumento.Text == "")
            {
                MessageBox.Show("Debe ingresar documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (txtnombrecompleto.Text == "")
            {
                MessageBox.Show("Debe ingresar nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));


            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_venta.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Precio"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()
                });
            }


            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);
            calcularcambio();

            Venta oVenta = new Venta()
            {

                oUsuario = new Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cbtipodocumento.SelectedItem).Texto,
                NumeroDocumento = numeroDocumento,
                CedulaCliente = txtnumerodocumento.Text,
                NombreCliente = txtnombrecompleto.Text,
                Montopago = Convert.ToDecimal(txtpagacon.Text),
                MontoCambio = Convert.ToDecimal(txtcambio.Text),
                MontoTotal = Convert.ToDecimal(txttotalapagar.Text)
            };


            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                txtnumerodocumento.Text = "";
                txtnombrecompleto.Text = "";
                dgvdata.Rows.Clear();
                calcularTotal();
                txtpagacon.Text = "";
                txtcambio.Text = "";
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
    
}
