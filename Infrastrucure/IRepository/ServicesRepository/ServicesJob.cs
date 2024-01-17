using ShawarmaHousePortal.Data;
using ShawarmaHousePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.IRepository.ServicesRepository
{
    public class ServicesJob : IServicesRepository<Job>
    {
        private readonly ApplicationDbContext _dbContext;

        public ServicesJob(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Count()
        {
            try
            {
                return _dbContext.Jobs.Where(x => x.JobSatuse == true).Count();
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool Delete(int id)
        {
            if(id == 0) return false;
            var job = FindById(id);
            if(job == null) return false;
            _dbContext.Remove(job);
            _dbContext.SaveChanges();
            return true;
        }

        public Job FindById(int id)
        {
            try
            {
                return _dbContext.Jobs.Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Job> GetAll()
        {
            try
            {
                return (_dbContext.Jobs.ToList());  
            }
            catch(Exception)
            {
                return null;
            }
        }

        public List<Job>? GetAllbyId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Job entity, int userId)
        {
            try

            {
                entity.JobCreateDate=DateTime.Now;
                entity.JobSatuse = true;
                _dbContext.Jobs.Add(entity);
                _dbContext.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Update(Job entity, int userId)
        {
            try
            {
               // var job = _dbContext.Jobs.Find(entity.JobId);
                _dbContext.Jobs.Update(entity);
                _dbContext.SaveChanges();
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
