using Exemplo.Infraestrutura.ResolucaoDeDependencias;
using StructureMap;
namespace Exemplo.UI {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
										scan.AssemblyContainingType<RegistroDeDependenciasPrincipal>();
                                        scan.WithDefaultConventions();
                                    });
            
                        });
            return ObjectFactory.Container;
        }
    }
}