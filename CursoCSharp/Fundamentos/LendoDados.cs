using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua Idade ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu salario? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
