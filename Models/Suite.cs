using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedagemDeHotel.Models
{
    public class Suite
    {
        public string TipoSuite { get; private set; }
        public int Capacidade { get; private set; }
        public decimal ValorDiaria{ get; private set; }


        public void DefineParameters(string tipo, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipo;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }



        

    }
}
