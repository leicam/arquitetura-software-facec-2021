using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.TEF.Dominio.nsEntidades
{
    public class Retorno
    {
        public string NSU { get; private set; }
        public string CodigoAutorizacao { get; private set; }
        public int Parcelas { get; private set; }
        public decimal Valor { get; private set; }

        public Retorno(string nsu, string codigoAutorizacao, int parcelas, decimal valor)
        {
            NSU = nsu;
            CodigoAutorizacao = codigoAutorizacao;
            Parcelas = parcelas;
            Valor = valor;
        }
    }
}