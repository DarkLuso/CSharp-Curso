﻿using CursoCSharp.Fundamentos;
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
            });

            central.SelecionarEExecutar();
        }
    }
}