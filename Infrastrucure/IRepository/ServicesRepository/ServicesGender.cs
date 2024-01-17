using ShawarmaHousePortal.Data;
using ShawarmaHousePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.IRepository.ServicesRepository
{
    public class ServicesGender : IServicesRepository<Gender>
    {
        private readonly ApplicationDbContext _dbContext;

        public ServicesGender(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Gender FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Gender> GetAll()
        {
            try
            {
                return _dbContext.Genders.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Gender>? GetAllbyId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Gender entity, int userId)
        {
            throw new NotImplementedException();
        }

        public bool Update(Gender entity, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
