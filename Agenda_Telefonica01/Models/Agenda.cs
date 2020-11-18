using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Telefonica01.Models
{
    [Table("Agenda")]
    public class Agenda
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por Favor, Informar seu Nome..!")]
        [Display(Name = "Nome")]
        [StringLength(40)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por Favor, Informar seu Telefone..!")]
        [Display(Name = "Telefone")]
        [StringLength(40)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Por Favor, Informar seu Estado..!")]
        [Display(Name = "Estado")]
        [StringLength(2, ErrorMessage = "O Estado deve Possuir no máximo 2 caracteres",MinimumLength =2)]
        public string UF { get; set; }


        [Required(ErrorMessage = "Por Favor, Informar seu Endereço..!")]
        [Display(Name = "Endereço")]
        [StringLength(30)]
        public string Endereco { get; set; }
       
    }
}
