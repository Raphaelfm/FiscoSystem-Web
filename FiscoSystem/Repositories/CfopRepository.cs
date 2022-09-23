using FiscoSystem.Models.CfopModels;
using FiscoSystem.Repositories.Interfaces;
using FiscoSystem.Context;

namespace FiscoSystem.Repositories
{
    public class CfopRepository : ICfopRepository
    {
        private readonly AppDbContext _context;

        public CfopRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CfopModel> Cfops => _context.CfopModel;
    }
}
