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
    public class EducationService : IServicesRepository<Education>
    {
        private readonly ApplicationDbContext _dbContext;

        public EducationService(ApplicationDbContext dbContext)
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

        public Education? FindById(int id)
        {
            try
            {
                return _dbContext.Educations.Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Education>? GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Education>? GetAllbyId(int id)
        {
            try
            {
                var newid=_dbContext.Employees.FirstOrDefault(x=>x.EmpId == id);
              return (_dbContext.Educations.Include(y => y.EducationLevel).Where(x => x.EmployNum == newid.RandomEmpid).ToList());
            }catch(Exception) { return null; }
        }

        public bool Save(Education entity, int userId)
        {

            try

            {
                _dbContext.Educations.Add(entity);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Education entity, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
