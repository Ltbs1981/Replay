using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoEscola.Enumeradores;
namespace AutoEscola.Entidades
{
    internal class Cliente : Pessoa
    {
        public DateTime DataCadastro { get; set; }
        public Genero Genero { get; set; }

        public void FazerCompras()
        {
            Console.WriteLine("Shoping");
        }

        public override string ImprimeDadosPessoais()
        {
            string partialDescription = base.ImprimeDadosPessoais();
            return partialDescription + $"\n DataCadastro: {DataCadastro} \nGenero: {Genero}";
        }
    }
}
