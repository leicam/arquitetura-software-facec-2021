using Facec.TEF.Dominio.nsEntidades;
using Facec.TEF.Dominio.nsInterfaces;
using Facec.TEF.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.TEF.Apresentacao.AplicativoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var servico = Installer.Factory().GetInstance<ITefServico>();
            var envio = new Envio(00000000000000000, DateTime.Today.AddYears(5), 000, 10, 1000.00m);
            var transacao = servico.AutorizarPagamento(envio);

            Console.WriteLine(transacao.ToString());
            Console.ReadLine();
        }
    }
}