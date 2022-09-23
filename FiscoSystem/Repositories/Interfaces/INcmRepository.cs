using FiscoSystem.Models.NcmModels;

namespace FiscoSystem.Repositories.Interfaces
{
    public interface INcmRepository
    {
        IEnumerable<NcmModel> Ncms { get; }
    }
}
