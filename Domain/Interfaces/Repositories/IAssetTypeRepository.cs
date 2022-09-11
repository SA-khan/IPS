using IPS.Domain.Models;

namespace IPS.Domain.Interfaces;

public interface IAssetTypeRepository {
    public Task<IEnumerable<PmsAssetType>> GetAllAssetTypes();
}