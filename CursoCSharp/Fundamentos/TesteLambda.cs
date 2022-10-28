using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class TesteLambda
    {
        public delegate int Operacao(int x, int y);
        public static string Calculadora (Operacao op, int x, int y) => op(x, y).ToString();
        
        public static void Executar()
        {
            Operacao soma = (x, y) => x + y;

            Console.WriteLine(Calculadora(soma, 5, 7));
        }
    }
}
