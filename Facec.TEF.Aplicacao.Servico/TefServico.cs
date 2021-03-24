using Facec.TEF.Dominio.nsEntidades;
using Facec.TEF.Dominio.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.TEF.Aplicacao.Servico
{
    public class TefServico : ITefServico
    {
        private readonly Random randomico = new Random();
        private readonly ITransacaoRepositorio _repositorio;

        public TefServico(ITransacaoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Transacao AutorizarPagamento(Envio envio)
        {
            var retorno = new Retorno(randomico.Next(1, 9999).ToString(), randomico.Next(1, 9999999).ToString(), envio.Parcelas, envio.Valor);
            var transacao = new Transacao(envio, retorno);

            _repositorio.Adicionar(transacao);

            return transacao;
        }

        public List<Transacao> GetTodasTransacoes()
        {
            return _repositorio.GetTodasTransacoes();
        }
    }
}