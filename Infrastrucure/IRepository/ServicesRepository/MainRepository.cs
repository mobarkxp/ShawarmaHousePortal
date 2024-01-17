using ShawarmaHousePortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.IRepository.ServicesRepository
{
    public class MainRepository<Entity> : INewServices<Entity> where Entity : class
    {
        private readonly ApplicationDbContext _dbContext;

        public MainRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Entity> FindAll()
        {
            try
            {
                return _dbContext.Set<Entity>().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Entity FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Entity FindByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
