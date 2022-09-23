using FiscoSystem.Models.CfopModels;

namespace FiscoSystem.Repositories.Interfaces
{
    public interface ICfopRepository
    {
        IEnumerable<CfopModel> Cfops { get; } 
    }
}
