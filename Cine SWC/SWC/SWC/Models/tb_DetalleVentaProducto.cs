//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_DetalleVentaProducto
    {
        public int idDetalleVP { get; set; }
        public Nullable<int> idTipopro { get; set; }
        public Nullable<int> idProducto { get; set; }
        public Nullable<int> idTamaño { get; set; }
        public Nullable<decimal> total { get; set; }
    
        public virtual tb_producto tb_producto { get; set; }
        public virtual tb_tamaño tb_tamaño { get; set; }
        public virtual tb_tipoProducto tb_tipoProducto { get; set; }
    }
}
