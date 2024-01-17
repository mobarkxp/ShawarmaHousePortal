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
    public class EmployeeRepository : IServicesRepository<Employee>
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Count()
        {
            try
            {
                return _dbContext.Employees.Count();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool Delete(int id)
        {
            try
            {

                if (id == 0) return false;
                var employee = FindById(id);
                if (employee == null) return false;
                _dbContext.Remove(employee);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Employee FindById(int id)
        {
            try
            {
                return _dbContext.Employees.Include(x => x.Gender)
                    .Include(y => y.City)
                    .Include(z => z.Maried).FirstOrDefault(m => m.EmpId == id);
                    
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Employee> GetAll()
        {
            try
            {
                return _dbContext.Employees.Include(x=>x.Gender)
                    .Include(y=>y.City)
                    .Include(z=>z.Maried)
                    .ToList();
                
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Employee>? GetAllbyId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Employee entity, int userId)
        {

            try
            {
                entity.DateSubmit=DateTime.Now;
                _dbContext.Employees.Add(entity);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception) { 
                return false;
            }
        }

        public bool Update(Employee entity, int userId)
        {
            throw new NotImplementedException();
        }
    }
}

