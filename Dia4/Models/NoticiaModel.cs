using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace minicurso.Models
{
    public class NoticiaModel
    {
        [DisplayName("Identificação")]
        public int NOT_ID { get; set; }
        [DisplayName("Titulo")]
        [Required]
        [StringLength(255)]
        public string NOT_TITULO { get; set; }
        [DisplayName("Conteúdo")]
        [Required]
        public string NOT_TEXTO { get; set; }
        [DisplayName("Data")]
        public DateTime NOT_DATA { get; set; }
        [DisplayName("Categoria")]
        public CategoriaModel CAT { get; set; }
        [DisplayName("Autor")]
        public AutorModel AUT { get; set; }
    }
}