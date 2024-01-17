using Microsoft.EntityFrameworkCore;
using ShawarmaHousePortal.Data;
using ShawarmaHousePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.IRepository.ServicesRepository
{
    public class WorkService : IServicesRepository<Work>
    {
        private readonly ApplicationDbContext _dbContext;

        public WorkService(ApplicationDbContext dbContext)
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

        public Work? FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Work>? GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Work>? GetAllbyId(int id)
        {
            try
            {
                var newid = _dbContext.Employees.FirstOrDefault(x => x.EmpId == id);
                return (_dbContext.Works.Where(x => x.EmployNum == newid.RandomEmpid).ToList());
            }
            catch (Exception) { return null; }
        }

        public bool Save(Work entity, int userId)
        {
            try

            {
                _dbContext.Works.Add(entity);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Work entity, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
