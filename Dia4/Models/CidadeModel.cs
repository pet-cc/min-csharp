using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace minicurso.Models
{
    public class CidadeModel{
        [DisplayName("Indentificação")]
        public int CID_ID { get; set; }
        [DisplayName("Cidade")]
        [Required]
        [StringLength(255)]
        public string CID_NOME { get; set; }
        [DisplayName("Estado")]
        [Required]
        [StringLength(2)]
        public string CID_UF { get; set; }
    }
}