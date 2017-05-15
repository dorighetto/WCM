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

    [Table("Departamentos")]
    public partial class Departamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Departamento()
        {
            this.Principal = true;
            this.Ativo = true;
            this.Agendas = new HashSet<Agenda>();
            this.Lancamentos = new HashSet<Lancamento>();
            this.Lancamentos1 = new HashSet<Lancamento>();
            this.Memb_Depto = new HashSet<MembroDepto>();
        }

        [Key]
        public int Id_Deptos { get; set; }
        [Required(ErrorMessage = "Campo n�o pode ser nulo.")]
        [MaxLength(30, ErrorMessage = "Campo deve conter no m�ximo 30 caracteres.")]
        public string Nm_Deptos { get; set; }
        [DefaultValue(true)]
        public bool Principal { get; set; }
        [DefaultValue(true)]
        public bool Ativo { get; set; }
        public int IdMembros { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agenda> Agendas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lancamento> Lancamentos1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembroDepto> Memb_Depto { get; set; }
    }
}
