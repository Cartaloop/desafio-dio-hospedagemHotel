using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HospedagemDeHotel.Models
{
    internal class Pessoa
    {
        private string Nome { get; set; }
        private string Sobrenome { get; set; }


        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }



    }
}
