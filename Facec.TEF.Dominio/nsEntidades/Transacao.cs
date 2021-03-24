using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.TEF.Dominio.nsEntidades
{
    public class Transacao
    {
        public Guid Id { get; private set; }
        public Envio Envio { get; private set; }
        public Retorno Retorno { get; private set; }

        public Transacao(Envio envio, Retorno retorno)
        {
            Id = Guid.NewGuid();
            Envio = envio;
            Retorno = retorno;
        }

        public override string ToString()
        {
            return $"NSU: {Retorno.NSU} Código Autorização: {Retorno.CodigoAutorizacao}" +
                $"Parcelas: {Retorno.Parcelas} Valor: {Retorno.Valor}";
        }
    }
}