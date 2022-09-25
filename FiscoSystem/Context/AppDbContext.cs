using Microsoft.EntityFrameworkCore;
using FiscoSystem.Models.CfopModels;
using FiscoSystem.Models.NcmModels;
using FiscoSystem.Models.PessoaModels;
using FiscoSystem.Models.TelefoneModels;

namespace FiscoSystem.Context
{
    public class AppDbContext : DbContext
    {  
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<NcmModel> NcmNodel { get; set; }
        public DbSet<CfopModel> CfopModel { get; set; }
        public DbSet<PessoaModel> PessoaModel { get; set; }
        public DbSet<TelefoneModel> TelefoneModel { get; set; }
    }
}

