using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospedagemDeHotel.Models
{
    internal class Reserva
    {
        private  List<Pessoa> Hospedes = [];
        private Suite Suite { get; set; }
        private int DiasReservados { get; set; }

        public void AtribuirDias(int dias)
        {
            DiasReservados = dias;
        }


        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Hospedes.AddRange(hospedes);
        }

        public void CadastrarSuite (Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {

            return Suite.ValorDiaria * DiasReservados;
        }


    }
}
