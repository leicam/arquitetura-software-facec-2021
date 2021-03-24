using Facec.TEF.Aplicacao.Servico;
using Facec.TEF.Dominio.nsInterfaces;
using Facec.TEF.Repositorio;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.TEF.IoC
{
    public static class Installer
    {
        public static Container Factory()
        {
            var container = new Container();

            container.Register<ITransacaoRepositorio, TransacaoRepositorio>(Lifestyle.Singleton);
            container.Register<ITefServico, TefServico>(Lifestyle.Singleton);

            return container;
        }
    }
}