using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace minicurso.Models
{
    public class AutorModel
    {
        [DisplayName("Identificação")]
        public int AUT_ID { get; set; }
        [DisplayName("Nome")]
        [Required]
        [StringLength(255)]
        public string AUT_NOME { get; set; }
        [Required]
        [DisplayName("Idade")]
        public int AUT_IDADE { get; set; }
        [DisplayName("Cidade")]
        public CidadeModel CID { get; set; }
    }
}