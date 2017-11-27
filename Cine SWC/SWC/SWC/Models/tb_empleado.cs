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
    
    public partial class tb_empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_empleado()
        {
            this.tb_VentaBoleto = new HashSet<tb_VentaBoleto>();
            this.tb_VentaProducto = new HashSet<tb_VentaProducto>();
        }
    
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string dni { get; set; }
        public Nullable<decimal> sueldo { get; set; }
        public Nullable<System.DateTime> fecNac { get; set; }
        public string usuario { get; set; }
        public string contra { get; set; }
        public Nullable<int> idTipotrab { get; set; }
        public Nullable<int> idSexo { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual tb_Sexo tb_Sexo { get; set; }
        public virtual tb_tipotrabajador tb_tipotrabajador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_VentaBoleto> tb_VentaBoleto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_VentaProducto> tb_VentaProducto { get; set; }
    }
}