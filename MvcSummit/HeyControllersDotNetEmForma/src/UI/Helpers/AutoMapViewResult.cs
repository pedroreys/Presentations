using System;
using System.Web.Mvc;
using AutoMapper;

namespace Exemplo.UI.Helpers
{
	public class AutoMapViewResult : ActionResult
	{
		public Type TipoOrigem { get; private set; }
		public Type TipoDestino { get; private set; }
		public ViewResult View { get; private set; }

		public AutoMapViewResult(Type tipoOrigem, Type tipoDestino, ViewResult view)
		{
			TipoOrigem = tipoOrigem;
			TipoDestino = tipoDestino;
			View = view;
		}

		public override void ExecuteResult(ControllerContext context)
		{
			var modelo = Mapper.Map(View.ViewData.Model, TipoOrigem, TipoDestino);

			View.ViewData.Model = modelo;

			View.ExecuteResult(context);
		}
	}
}