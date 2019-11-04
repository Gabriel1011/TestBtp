using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    /*
      * TODO
      * Implementar um sistema de supermercado onde:
         - Forneça as sacolas conforme a quantidade de itens comprados. A sacola Grande cabe 5 itens e a pequena apenas 1 item.
         Desenvolva um método que recebe a quantidade de 16 itens e retorne a quantidade de sacolas utilizadas. 
         Caso não exista a quantidade suficiente para atender a demanda, retorne -1.

         * Qtd disponível de sacolas Grandes: 2
         * Qtd disponível de sacolas Pequenas: 10
         * 
         * O método deve ser capaz de receber qualquer quantidade de itens
      */
    class Program
    {
        static void Main(string[] args)
        {
            int itens = 16;
            ChecarQuantidadePacotes(itens);
        }

        public static int ChecarQuantidadePacotes(int itens)
        {
            return 0;
        }
    }
}
