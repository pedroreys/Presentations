using System;
using System.Web.Mvc;
using Exemplo.Dominio.Modelo;

namespace Exemplo.UI.Helpers
{
	public class ConferenciaModelBinderProvider : IModelBinderProvider
	{
		private readonly ConferenciaModelBinder _modelBinder;

		public ConferenciaModelBinderProvider(ConferenciaModelBinder modelBinder)
		{
			_modelBinder = modelBinder;
		}

		public IModelBinder GetBinder(Type modelType)
		{
			return typeof(Conferencia) != modelType ? null : _modelBinder;
		}

	}
}