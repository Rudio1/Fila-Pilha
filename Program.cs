using Lista_Encadeada.Service;
using Lista_Encadeada.Models;
using System;

namespace Lista_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();

            //Adicionando na fila
            for(int i = 1; i <= 50; i ++) {
                fila.Append(i);
            }
            Console.WriteLine("Fila completa: " + fila);

            //Removendo 25 elementos da fila
            for(int i = 0; i < 25; i ++) {
                fila.Remove();
            }
            Console.WriteLine("Fila com -25 elementos: " + fila);

            Console.WriteLine("\n\n");

            Pilha pilha = new Pilha();

            //Adicionando na pilha
            for(int i = 1; i <= 50; i ++) {
                pilha.Append(i);
            }
            Console.WriteLine("Pilha completa: " + pilha);

            //Removendo 25 elementos da pilha
            for(int i = 0; i < 25; i ++) {
                pilha.Remove();
            }
            Console.WriteLine("Pilha com -25 elementos: " + pilha);


        }
    }
}
