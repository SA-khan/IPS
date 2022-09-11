using System.Threading.Tasks;

using IPS.Domain.Models;
using IPS.Domain.Interfaces;
using IPS.Infra.Data.Context;
using System.Collections;

namespace IPS.Infra.Data.Repositories;

public class AssetTypeRepository : IAssetTypeRepository {
    private IIPSDbContext _context;
    public AssetTypeRepository(IIPSDbContext ctx)
    {
        _context = ctx;
    }
    public async Task<IEnumerable<PmsAssetType>> GetAllAssetTypes(){
        return await Task.FromResult(_context.PmsAssetTypes);
    }
}