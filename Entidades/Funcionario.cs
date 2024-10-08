﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoEscola.Entidades
{
    internal class Funcionario : Pessoa
    {
        private static bool Entrada = true;
        public int Matricula { get; set; }
        public string Cargo { get; set; }

        public void BaterPonto()
        {
            if (Entrada)
            {
                Console.WriteLine($"Entrada as {DateTime.Now}");
                Entrada = false;
            }
            else
            {
                Console.WriteLine($"Saida as {DateTime.Now}");
                Entrada = true;
            }
        }

        public override string ImprimeDadosPessoais()
        {
            string dados = base.ImprimeDadosPessoais().ToString();
            return dados + $"\nMatricula: {Matricula}\nCargo: {Cargo}";
        }
    }
}
