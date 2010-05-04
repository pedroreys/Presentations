using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IoC;
using StructureMap;

namespace ResolucaoDeDependencias
{
    public static class ServiceLocator
    {
        private static bool _dependenciasForamInicializadas;

        public static T Resolve<T>()
        {
            GaranteQueAsDependenciasEstaoRegistradas();
            return ObjectFactory.GetInstance<T>();
        }

        private static void GaranteQueAsDependenciasEstaoRegistradas()
        {
            if(!_dependenciasForamInicializadas)
                InicializaDependencias();
        }

        private static void InicializaDependencias()
        {
            ObjectFactory.Initialize(inicializador => inicializador.Scan(cfg =>
             {
                 cfg.AssemblyContainingType<MinhaAplicacao>();
                 cfg.WithDefaultConventions();
             }));
            _dependenciasForamInicializadas = true;
        }
    }
}
