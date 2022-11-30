using FiscoSystem.Context;
using FiscoSystem.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace FiscoSystem.Controllers
{
    public class NcmController : Controller
    {
        private readonly INcmRepository _ncmRepository;
        private readonly AppDbContext _context;

        //public NcmController(INcmRepository ncmRepository)
        //{
        //    _ncmRepository = ncmRepository;
        //}

        public NcmController(AppDbContext context)
        {
            _context = context;
        }


        //public IActionResult ListNcm()
        //{
        //    var ncms = _ncmRepository.Ncms;
        //    return View(ncms);
        //}

        public async Task<IActionResult> Index(string filter, int pageindex = 1, string sort = "CodigoNcm")
        {
            var resultado = _context.NcmModel.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                resultado = resultado.Where(n => n.CodigoNcm.Contains(filter));
            }

            var model = await PagingList.CreateAsync(resultado, 5, pageindex, sort, "CodigoNcm");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };

            return View(model);
        }
    }
}
