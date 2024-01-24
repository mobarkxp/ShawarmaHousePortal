using ShawarmaHousePortal.Data;
using ShawarmaHousePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.IRepository.ServicesRepository
{
    public class ServiceCity : IServicesRepository<City>
    {
        private readonly ApplicationDbContext _dbContext;

        public ServiceCity(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public List<City>? GetAllbyId(int id)
        {
            throw new NotImplementedException();
        }

        bool IServicesRepository<City>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        City IServicesRepository<City>.FindById(int id)
        {
            throw new NotImplementedException();
        }

        List<City> IServicesRepository<City>.GetAll()
        {
            try
            {
                return _dbContext.Cities.OrderBy(x=>x.CityName).ToList();
            }
            catch(Exception)
            {
                return null;
            }
        }

        bool IServicesRepository<City>.Save(City entity, int userId)
        {
            throw new NotImplementedException();
        }

        bool IServicesRepository<City>.Update(City entity, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
