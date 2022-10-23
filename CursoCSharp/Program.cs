using CursoCSharp.Fundamentos;
using System;

// See https://aka.ms/new-console-template for more information

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() 
            {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência de Tipos - Fundamentos", Inferencia.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados do Console - Fundamentos", LendoDados.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}