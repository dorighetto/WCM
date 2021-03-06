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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Tipos_Lancamentos")]
    public partial class TipoLancamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoLancamento()
        {
            this.Lancamentos = new HashSet<Lancamento>();
        }

        [Key]
        public int Id_Tpo_Lanc { get; set; }
        [Required(ErrorMessage = "Campo n�o pode ser nulo.")]
        [MaxLength(15, ErrorMessage = "Campo deve conter no m�ximo 15 caracteres.")]
        public string Desc_Lanc { get; set; }
        [DefaultValue(true)]
        public bool Ativo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
