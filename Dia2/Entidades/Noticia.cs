using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades{
    public class Noticia{
        public int NOT_ID {get; set;}
        public string NOT_TITULO {get; set;}
        public string NOT_TEXTO {get; set;}
        public DateTime NOT_DATA {get; set;}
        public Categoria CAT {get; set;}
        public Autor AUT {get; set;}
    }
}