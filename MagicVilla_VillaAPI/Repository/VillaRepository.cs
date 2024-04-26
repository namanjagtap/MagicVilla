using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Modals;
using MagicVilla_VillaAPI.Repository.IRepository;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaRepository : IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) { }

        public Task Create(Villa enitity)
        {
            throw new NotImplementedException();
        }

        public Task<Villa> Get(Expression<Func<Villa>> filter = null, bool tracked = true)
        {
            throw new NotImplementedException();
        }

        public Task<List<Villa>> GetAll(Expression<Func<Villa>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Villa enitity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}