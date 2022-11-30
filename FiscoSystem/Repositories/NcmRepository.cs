using FiscoSystem.Context;
using FiscoSystem.Models.NcmModels;
using FiscoSystem.Repositories.Interfaces;

namespace FiscoSystem.Repositories
{
    public class NcmRepository : INcmRepository
    {
        private readonly AppDbContext _context;

        public NcmRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<NcmModel> Ncms => _context.NcmModel;
    }
}
