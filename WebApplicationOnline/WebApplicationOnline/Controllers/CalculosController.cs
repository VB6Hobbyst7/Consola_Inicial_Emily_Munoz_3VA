using Microsoft.AspNetCore.Mvc;

namespace WebApplicationOnline.Controllers
{
    public class CalculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sumar()
        {
            var primerNumero = int.Parse(Request.Form["primer-numero"]);
            var segundoNumero = int.Parse(Request.Form["segundo-numero"]);

            var resultado = primerNumero + segundoNumero;

            ViewData["Resultado"] = resultado;

            return View();
        }
    }
}
