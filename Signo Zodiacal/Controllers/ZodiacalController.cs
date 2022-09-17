using LibraryModel.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Signo_Zodiacal.Controllers
{
    public class ZodiacalController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Resultado(DiaMesViewModel dato)
        {
            String resultado = DeterminaSignoViewModel.Signo(dato.Dia,dato.Mes);
            ViewData["message"] = resultado;
            return View();
        }


    }
}
