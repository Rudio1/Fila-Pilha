using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Encadeada.Models
{
    class Node
    {
        public Node proximo { get; set; }
        public int numero { get; set; }

        public Node(int value)
        {
            this.numero = value;
        }
    }
}
