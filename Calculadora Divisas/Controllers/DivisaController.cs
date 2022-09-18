using LibraryModel.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora_Divisas.Controllers
{
    public class DivisaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Autor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Home(DivisaViewModel dato)
        {

            /* DOLAR A DOP 55
             * EU A DOP 54
             * DOLAR A EU 1.00175
             */
            ViewData["message"] = CalcularDivisaViewModel.Calcular(dato).ToString();
            return View();
        }
    }
}
