using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var notas = 6.0;
            bool bomComportamento = true;

            string resultado = notas >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);

            string resultado2;
            if (notas >= 7.0 && bomComportamento) resultado2 = "Aprovado";
            else resultado2 = "Reprovado";
            Console.WriteLine(resultado2);
        }
    }
}
