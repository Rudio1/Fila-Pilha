using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lista_Encadeada.Models;

namespace Lista_Encadeada.Service
{
    class ListaEncadeadaService:Models.ListaEncadeadaModels
    {
        public void InsertNode(Node node)
        {
            if (this.tamanho == 0)
                this.primeiro = node;
            else
                this.ultimo.proximo = node;

            this.tamanho++;
            this.ultimo = node;
        }

        public int Length() {
            return this.tamanho;
        }
        
        public void Append(int value) {
            Node node = new Node(value);

            this.InsertNode(node);
        }
        
        public bool Remove(int index)
        {
            var no = this.primeiro;
            var no_anterior = no;
            for (int i = 0; i < this.tamanho; i++)
            {
                if (i == index)
                {
                    if (i == 0 && tamanho == 1)
                        this.primeiro = this.ultimo = no = null;
                    else if(i == 0)
                    {
                        var no_zerar = no;
                        no = no.proximo;
                        this.primeiro = no;
                        no_zerar = null;
                    }
                    else
                    {
                        var no_zerar = no;
                        no = no.proximo;
                        no_anterior.proximo = no;
                        no_zerar = null;
                    }
                    tamanho--;
                    return true;
                }
                else
                {
                    if (no.proximo == null)
                        return false;
                    no_anterior = no;
                    no = no.proximo;
                }
            }
            return false;
        }
        public bool SetValueForNode(int index, int value)
        {
            var no = this.primeiro;
            for (int i = 0; i < this.tamanho; i++)
            {
                if (i == index)
                {
                    no.numero = value;
                    return true;
                }
                else
                    no = no.proximo;
            }
            return false;
        }

        public override string ToString()
        {
            string retornar = "";

            var no = this.primeiro;

            if (no != null)
            {
                while (true)
                {
                    retornar += no.numero.ToString() + " ";

                    no = no.proximo;
                    if (no == null)
                        break;
                }
            }

            return retornar;
        }
    }
}
