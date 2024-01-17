using ShawarmaHousePortal.Data;
using ShawarmaHousePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.IRepository.ServicesRepository
{
    public class ServicesMaried : IServicesRepository<Maried>
    {
        private readonly ApplicationDbContext _dbContext;

        public ServicesMaried(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public List<Maried>? GetAllbyId(int id)
        {
            throw new NotImplementedException();
        }

        bool IServicesRepository<Maried>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        Maried IServicesRepository<Maried>.FindById(int id)
        {
            throw new NotImplementedException();
        }

        List<Maried> IServicesRepository<Maried>.GetAll()
        {
            try
            {
                return _dbContext.marieds.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        bool IServicesRepository<Maried>.Save(Maried entity, int userId)
        {
            throw new NotImplementedException();
        }

        bool IServicesRepository<Maried>.Update(Maried entity, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
