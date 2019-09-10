using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades{
    public class Categoria{
        private int cat_id;
        private string cat_nome;

        public int CAT_ID {
            get { return cat_id; }
            set { cat_id = value; }
        }
        public String CAT_NOME {
            get { return cat_nome; }
            set { cat_nome = value; }
        }
    }
}