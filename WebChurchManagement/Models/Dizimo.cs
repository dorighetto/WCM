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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Dizimos")]
    public partial class Dizimo
    {
        [Key]
        public int Id_Dizimo { get; set; }
        [Required(ErrorMessage = "Campo n�o pode ser nulo.")]
        public int Id_Memb { get; set; }
        public DateTime Mes_Ref { get; set; }
        public DateTime Dt_Mov { get; set; }
        [Required(ErrorMessage = "Campo n�o pode ser nulo.")]
        public decimal Vl_Dizimo { get; set; }

        public virtual Membro Membros { get; set; }
    }
}
