using Microsoft.AspNetCore.Mvc;

namespace WebApplicationOnline.Controllers
{
    public class CalculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sumar(int primerNumero, int segundoNumero)
        {
            var resultadoSuma = primerNumero + segundoNumero;

            ViewData["ResultadoSuma"] = resultadoSuma;

            return View();
        }

        public IActionResult Restar(int primerNumero, int segundoNumero)
        {
            var resultadoResta = primerNumero - segundoNumero;

            ViewData["ResultadoResta"] = resultadoResta;

            return View();
        }

        public IActionResult Multiplicar(int primerNumero, int segundoNumero)
        {
            var resultadoMultiplicacion = primerNumero * segundoNumero;

            ViewData["ResultadoMultiplicacion"] = resultadoMultiplicacion;

            return View();
        }

        public IActionResult Dividir(int primerNumero, int segundoNumero)
        {
            var resultadoDividido = primerNumero / segundoNumero;

            ViewData["ResultadoDivision"] = resultadoDividido;
            return View();
        }
    }
}
