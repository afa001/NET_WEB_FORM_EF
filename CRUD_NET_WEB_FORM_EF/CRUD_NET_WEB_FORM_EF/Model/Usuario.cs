//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_NET_WEB_FORM_EF.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.PeriodosVacacionesFuncionario = new HashSet<PeriodosVacacionesFuncionario>();
            this.Solicitud = new HashSet<Solicitud>();
        }
    
        public int IdUsuario { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public int DocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
        public string LugarExpedicion { get; set; }
        public System.DateTime FechaExpedicion { get; set; }
        public int CargoId { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public int TipoContratoId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdRol { get; set; }
    
        public virtual Cargo Cargo { get; set; }
        public virtual Documento Documento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PeriodosVacacionesFuncionario> PeriodosVacacionesFuncionario { get; set; }
        public virtual Rol Rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitud> Solicitud { get; set; }
        public virtual Tipo_Contrato Tipo_Contrato { get; set; }
    }
}