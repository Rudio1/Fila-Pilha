using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Encadeada.Models
{
    class ListaEncadeadaModels
    {
        public Node primeiro { get; set; }
        public Node ultimo { get; set; }
        public int tamanho { get; set; }

        public ListaEncadeadaModels()
        {
            this.tamanho = 0;
            this.primeiro = null;
            this.ultimo = null;
        }
    }
}
