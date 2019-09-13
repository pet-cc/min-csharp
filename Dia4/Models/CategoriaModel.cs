using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace minicurso.Models
{
    public class CategoriaModel
    {
        [DisplayName("Indentificação")]
        public int CAT_ID { get; set; }
        [DisplayName("Categoria")]
        [Required]
        [StringLength(255)]
        public String CAT_NOME { get; set; }
    }
}