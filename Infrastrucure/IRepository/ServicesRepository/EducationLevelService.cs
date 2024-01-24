using Domin.Models;
using ShawarmaHousePortal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.IRepository.ServicesRepository
{
    public class EducationLevelService : IServicesRepository<EducationLevel>
    {
        private readonly ApplicationDbContext _services;

        public EducationLevelService(ApplicationDbContext  dbContext)
        {
            _services = dbContext;
        }
        public int Count()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            if(id == 0) return false;
            try
            {
                var educcationl = _services.EducationLevels.Find(id);
                if (educcationl != null)
                {
                    _services.EducationLevels.Remove(educcationl);
                    _services.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception) {
                return false;
            }
        }

        public EducationLevel? FindById(int id)
        {
            return _services.EducationLevels.Find(id);
        }

        public List<EducationLevel>? GetAll()
        {
           return _services.EducationLevels.ToList();
        }

        public List<EducationLevel>? GetAllbyId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(EducationLevel entity, int userId)
        {
            try
            {
                _services.EducationLevels.Add(entity);
                _services.SaveChanges();
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        public bool Update(EducationLevel entity, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
