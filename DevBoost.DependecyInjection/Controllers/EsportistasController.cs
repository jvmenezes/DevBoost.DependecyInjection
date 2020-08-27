using DevBoost.DependecyInjection.Domain.Interfaces.Services;
using DevBoost.DependecyInjection.Domain.Models.DI_Construtor;
using DevBoost.DependecyInjection.Domain.Models.DI_GetterSetter;
using DevBoost.DependecyInjection.Domain.Models.DI_Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DevBoost.DependecyInjection.Controllers
{
    [Route("api/[controller]")]
	public class EsportistasController : Controller
	{        

		[HttpGet("esportistas-di-construtor")]
		public ActionResult<List<Esportista_C>> GetAllEsportitas_C([FromServices] IEsportistas esportistasService)
		{ //Com o FromServices vc consegue injetar a classe JogadoresDAO diretamente, isso serve se vc for usar apenas em uma ActionResult
			var result = esportistasService.ObterTodos_C();
			return result.ToList();
		}

		[HttpGet("esportistas-di-gettersetter")]
		public ActionResult<List<Esportista_GS>> GetAllEsportitas_GS([FromServices] IEsportistas esportistasService)
		{ //Com o FromServices vc consegue injetar a classe JogadoresDAO diretamente, isso serve se vc for usar apenas em uma ActionResult
			var result = esportistasService.ObterTodos_GS();
			return result.ToList();
		}

		[HttpGet("esportistas-di-interface")]
		public ActionResult<List<Esportista_I>> GetAllEsportitas_I([FromServices] IEsportistas esportistasService)
		{ //Com o FromServices vc consegue injetar a classe JogadoresDAO diretamente, isso serve se vc for usar apenas em uma ActionResult
			var result = esportistasService.ObterTodos_I();
			return result.ToList();
		}
	}
}