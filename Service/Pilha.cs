using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_Encadeada.Models;

namespace Lista_Encadeada.Service
{
    class Pilha : Service.ListaEncadeadaService
    {
        public void Remove() {
            if(base.Length() > 0) {
                base.Remove(base.Length()-1);
            }
        }
    }
}
