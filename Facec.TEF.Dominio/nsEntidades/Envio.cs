using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.TEF.Dominio.nsEntidades
{
    public class Envio
    {
        public int NumeroCartao { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public int CSV { get; private set; }
        public int Parcelas { get; private set; }
        public decimal Valor { get; private set; }

        public Envio(int numeroCartao, DateTime dataVencimento, int csv, int parcelas, decimal valor)
        {
            NumeroCartao = numeroCartao;
            DataVencimento = dataVencimento;
            CSV = csv;
            Parcelas = parcelas;
            Valor = valor;
        }
    }
}