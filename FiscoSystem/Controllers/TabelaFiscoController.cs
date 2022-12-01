using FiscoSystem.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace FiscoSystem.Controllers
{
    public class TabelaFiscoController : Controller
    {
        private readonly AppDbContext _context;

        public TabelaFiscoController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string filter, int pageindex = 1, string sort = "Ncm")
        {
            var resultado = _context.TabelaFiscoModel.AsNoTracking().AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                resultado = resultado.Where(n => n.Ncm.Contains(filter));
            }

            var model = await PagingList.CreateAsync(resultado, 20, pageindex, sort, "Ncm");
            model.RouteValue = new RouteValueDictionary { { "filter", filter } };

            return View(model);
        }

        // GET: ContasReceber/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TabelaFiscoModel == null)
            {
                return NotFound();
            }

            var tabelaFisco = await _context.TabelaFiscoModel
                .FirstOrDefaultAsync(m => m.FiscoId == id);
            if (tabelaFisco == null)
            {
                return NotFound();
            }

            return View(tabelaFisco);
        }
    }
}
