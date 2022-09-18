using LibraryModel.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora_de_Prestamos.Controllers
{
    public class PrestamosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PrestamosViewModel pv)
        {
            ViewData["message"] =  CalcularCuoutaViewModel.Calcular(pv).ToString("n2");
            return View();
        }
    }
}
