//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebChurchManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipos_Lancamentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipos_Lancamentos()
        {
            this.Lancamentos = new HashSet<Lancamentos>();
        }
    
        public int Id_Tpo_Lanc { get; set; }
        public string Desc_Lanc { get; set; }
        public Nullable<bool> Ativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lancamentos> Lancamentos { get; set; }
    }
}
