using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades{
    public class Autor{
        public int AUT_ID {get; set;}
        public string AUT_NOME {get; set;}
        public int AUT_IDADE {get; set;}
        public Cidade CID { get; set; }
    }
}