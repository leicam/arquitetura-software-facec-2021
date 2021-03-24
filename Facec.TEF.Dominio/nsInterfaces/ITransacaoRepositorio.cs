using Facec.TEF.Dominio.nsEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.TEF.Dominio.nsInterfaces
{
    public interface ITransacaoRepositorio
    {
        void Adicionar(Transacao transacao);
        List<Transacao> GetTodasTransacoes();
    }
}