using Exemplo.Dominio.Modelo;
using Exemplo.Dominio.Repositorios;

namespace Exemplo.UI.Helpers
{
	public interface IDummyDataLoader
	{
		void Load();
	}

	public class DummyDataLoader : IDummyDataLoader
	{
		private readonly IRepositorioDeConferencias _repositorio;

		public DummyDataLoader(IRepositorioDeConferencias repositorio)
		{
			_repositorio = repositorio;
		}

		public void Load()
		{
			var codeMash = new Conferencia("CodeMash");
			var mix10 = new Conferencia("MIX");
			var pdc = new Conferencia("PDC");

			codeMash.AdicionarPalestra(new Palestra("0-60 with Fluent NHibernate", "Fluent NHibernate is a framework, that sits on top of NHibernate, which helps to cut down on some of the headaches you will indubitably encounter with picking up such a mature ORM. We'll be discussing how FNH can help cut down the learning curve of using NHibernate as an ORM and how it can benefit existing NHibernate production environments long term by utilizing a convention over configuration approach.", new Palestrante("Hudson", "Akridge")));
			codeMash.AdicionarPalestra(new Palestra("Azure: Lessons from the field", "Come learn about Microsoft's Azure platform (and cloud computing in general) as we look at an application built to assist in the processing and publishing of large-scale scientific data. We will discuss architecture choices, benchmarking results, issues faced as well as the work-arounds implemented. This session will give you insight into the process of developing for the cloud, as well as tips and tricks to help you avoid some common pitfalls.", new Palestrante("Rob", "Gillen")));
			codeMash.AdicionarPalestra(new Palestra("Going Dynamic with C#", "C# might be looking a little long in the tooth, but C# 4.0 adds dynamic support to compete with all the young punks. In this session, based on material from Effective C#, 2nd edition, you’ll learn how to mix dynamic features into the safety and performance of static typing. It’s yet another tool in the toolbox that you can use with C#. You’ll learn techniques that are easier to implement using dynamic features. You’ll learn how to bridge the gap between dynamic and static typing. Most of all you’ll learn when dynamic typing is an advantage, and when static typing provides the best solution.", new Palestrante("Bill", "Wagner")));
			codeMash.AdicionarPalestra(new Palestra("Maintainable ASP.NET MVC", "Introduce software developers to Microsoft’s ASP.NET MVC framework and provide “beyond the bits” guidance to help teams get up to speed on this exciting alternative to WebForms development.", new Palestrante("Chris", "Patterson")));
			codeMash.AdicionarPalestra(new Palestra("Techniques for Programming Parallel Solutions", "Building multi-threaded applications can be hard work. So come learn a number of techniques for developing software solutions that take advantage of today’s multi-core processors. In true CodeMash fashion, the session starts by laying a foundation of concurrency basics using C++. The bulk of the session then looks at all of the various techniques for parallelizing “work” in .NET 3.5 using C#, while avoiding a number of “gotchas”. Finally, the session concludes with how these techniques will make it easy to develop parallel solutions with the changes coming in Visual Studio 2010, .NET 4.0, and F#.", new Palestrante("Michael", "Slade")));

			mix10.AdicionarPalestra(new Palestra("Treat Your Content Right", "Most the time, designers don’t publish napkin sketches as final designs. But the same is not true of content. We regularly cram last-minute, sketchy content into our otherwise thoughtfully planned websites. Learn why content strategy and web writing matter, what they are, how to incorporate them into your design process, and how they make meaningful websites that connect with people. Also look at a few case studies that show how content strategy and happy collaborations produce better web experiences. For Everyone.", new Palestrante("Tiffani", "Jones")));
			mix10.AdicionarPalestra(new Palestra("The Mono Project", "Mono is a free and open source implementation of .NET that runs on Windows, Unix, and Macintosh. In more than 5 years since the first version of Mono was released, the Mono project has continued to add support for new functionality, such as C# 3.0, LINQ, and Silverlight; and has continued to see adoption. Come hear about the latest developments and future plans from the founder of the Mono project.", new Palestrante("Miguel", "de Icaza")));

			pdc.AdicionarPalestra(new Palestra("Building Line of Business Applications with Microsoft Silverlight 4", "Learn about enhancements to data binding and data validation as well as new support for rich text & printing in the platform that allow you to build compelling LOB user experiences. In addition, you will see how you can incorporate webcam & microphone support into your applications using Silverlight 4.", new Palestrante("David", "Poll")));
			pdc.AdicionarPalestra(new Palestra("Building Java Applications with Windows Azure", "Come learn how to build large-scale applications in the cloud using Java, taking advantage of new Windows Azure features. This session will cover using Apache Tomcat and Java in Windows Azure.", new Palestrante("Steve", "Marx")));
			pdc.AdicionarPalestra(new Palestra("ASP.NET MVC 2: Ninjas Still on Fire Black Belt Tips", "Having the customer on your back to deliver features on time and under budget with tight deadlines can make you feel like you’re being chased by ninjas on fire. Join Scott Hanselman and he’ll walk through lots of tips and tricks to get the most out of the ASP.NET MVC 2 framework and deliver work quickly and with style. Come see ASP.NET MVC 2’s better productivity features as we make the most of several key features.", new Palestrante("Scott", "Hanselman")));
			pdc.AdicionarPalestra(new Palestra("Developing REST Applications with the .NET Framework", "Come hear an overview of the REST principles and why REST is becoming popular beyond traditional Web applications. Learn how to write applications that produce and consume RESTful services using the .NET Framework 4 and the improvements we have planned for future versions of the .NET Framework.", new Palestrante("Henrik", "Nielsen")));

			GeraParticipantes(codeMash);
			GeraParticipantes(mix10);
			GeraParticipantes(pdc);

			_repositorio.Salvar(codeMash);
			_repositorio.Salvar(mix10);
			_repositorio.Salvar(pdc);

		}

		private static void GeraParticipantes(Conferencia conferencia)
		{
			new Participante("Nelson", "Tischler").RegistrarPara(conferencia);
			new Participante("Allie", "Lemelin").RegistrarPara(conferencia);
			new Participante("Guy", "Brumback").RegistrarPara(conferencia);
			new Participante("Karina", "Lerman").RegistrarPara(conferencia);
			new Participante("Darryl", "Schwager").RegistrarPara(conferencia);
			new Participante("Mathew", "Blay").RegistrarPara(conferencia);
			new Participante("Nita", "Swicegood").RegistrarPara(conferencia);
			new Participante("Clinton", "Westra").RegistrarPara(conferencia);
			new Participante("Tyrone", "Grieve").RegistrarPara(conferencia);
			new Participante("Hugh", "Nowland").RegistrarPara(conferencia);
			new Participante("Katy", "Greenstein").RegistrarPara(conferencia);
			new Participante("Maricela", "Kisinger").RegistrarPara(conferencia);
			new Participante("Hugh", "Banach").RegistrarPara(conferencia);
			new Participante("Mallory", "Rexford").RegistrarPara(conferencia);
			new Participante("Earnestine", "Belvin").RegistrarPara(conferencia);
			new Participante("Kathrine", "Hamamoto").RegistrarPara(conferencia);
			new Participante("Clinton", "Rinker").RegistrarPara(conferencia);
			new Participante("Neil", "Groman").RegistrarPara(conferencia);
			new Participante("Christian", "Pineiro").RegistrarPara(conferencia);
			new Participante("Lance", "Cullum").RegistrarPara(conferencia);
			new Participante("Allan", "Fahnestock").RegistrarPara(conferencia);
			new Participante("Kelly", "Mcgrail").RegistrarPara(conferencia);
			new Participante("Jamie", "Geiser").RegistrarPara(conferencia);
			new Participante("Tameka", "Bercier").RegistrarPara(conferencia);
			new Participante("Clayton", "Torpey").RegistrarPara(conferencia);
			new Participante("Tyrone", "Nassif").RegistrarPara(conferencia);
			new Participante("Tanisha", "Hendrixson").RegistrarPara(conferencia);
			new Participante("Lilia", "Paskett").RegistrarPara(conferencia);
			new Participante("Lorrie", "Simonsen").RegistrarPara(conferencia);
			new Participante("Pearlie", "Host").RegistrarPara(conferencia);
		}
	}
}