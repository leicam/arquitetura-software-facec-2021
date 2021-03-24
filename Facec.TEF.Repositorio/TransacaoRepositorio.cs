using Facec.TEF.Dominio.nsEntidades;
using Facec.TEF.Dominio.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.TEF.Repositorio
{
    public class TransacaoRepositorio : ITransacaoRepositorio
    {
        private readonly List<Transacao> _lista = new List<Transacao>();

        public void Adicionar(Transacao transacao)
        {
            _lista.Add(transacao);
        }

        public List<Transacao> GetTodasTransacoes()
        {
            return _lista;
        }
    }
}