using IoC.ResolucaoDeDependencias;
using StructureMap;

namespace ResolucaoDeDependencias
{
    public static class Registrador
    {
        private static bool _dependenciasForamInicializadas;


        public static void GaranteQueAsDependenciasEstaoRegistradas()
        {
            if(!_dependenciasForamInicializadas)
                InicializaDependencias();
        }

        private static void InicializaDependencias()
        {
            ObjectFactory.Initialize(x => 
                                     x.AddRegistry<RegistroDeExemplo>());
            _dependenciasForamInicializadas = true;
        }
    }
}