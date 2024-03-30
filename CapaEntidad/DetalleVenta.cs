using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {

        public int IdDetalleVenta { get; set; }

        public Producto oProducto { get; set; }

        public decimal Precioventa { get; set; }

        public int Cantidad { get; set; }

        public decimal subTotal { get; set; }

        public string Fecha_Registro { get; set; }
    }
}
