using Facec.TEF.Dominio.nsEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.TEF.Dominio.nsInterfaces
{
    public interface ITefServico
    {
        Transacao AutorizarPagamento(Envio envio);
        List<Transacao> GetTodasTransacoes();
    }
}