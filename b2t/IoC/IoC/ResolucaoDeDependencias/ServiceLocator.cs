using StructureMap;

namespace ResolucaoDeDependencias
{
    public static class ServiceLocator
    {
        
        public static T BuscaInstanciaDe<T>()
        {
            Registrador.GaranteQueAsDependenciasEstaoRegistradas();
            return ObjectFactory.GetInstance<T>();
        }
    }
}
