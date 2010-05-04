using IoC.Aplicacao;
using StructureMap.Configuration.DSL;

namespace IoC.ResolucaoDeDependencias
{
    public class RegistroDeExemplo : Registry
    {
        public RegistroDeExemplo()
        {
            Scan(cfg =>
                     {
                         cfg.TheCallingAssembly();
                        //cfg.AddAllTypesOf<IRegraDeFormatacao>();
                         cfg.WithDefaultConventions();
                     });

            For(typeof(IRepositorio<>)).Use(typeof(Repositorio<>));

            For<IEnviadorDeEmail>().EnrichAllWith(x => new LoggerDoEnviadorDeEmail(x));

            For<IFormatadorDeEmail>().Use<FormatadorDeEmail>()
                .EnumerableOf<IRegraDeFormatacao>()
                .Contains(x =>
                         {
                             x.Type<ParaMaiusculaRegraDeFormatacao>();
                             x.Type<AvisoRegraDeFormatacao>();
                         });
        }
    }
}