//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace examenfinal1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visita
    {
        public int idVisita { get; set; }
        public string motivo_visita { get; set; }
        public string nombre_completo { get; set; }
        public Nullable<System.DateTime> h_entrada { get; set; }
        public Nullable<System.DateTime> h_salida { get; set; }
        public string m_recibio { get; set; }
        public Nullable<int> idMiembro { get; set; }
    
        public virtual Miembro Miembro { get; set; }
    }
}
