using FiscoSystem.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FiscoSystem.Controllers
{
    public class NcmController : Controller
    {
        private readonly INcmRepository _ncmRepository;

        public NcmController(INcmRepository ncmRepository)
        {
            _ncmRepository = ncmRepository;
        }

        public IActionResult ListNcm()
        {
            var ncms = _ncmRepository.Ncms;
            return View(ncms);
        }
    }
}
