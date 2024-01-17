using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.IRepository
{
    public interface IServicesRepository<T> where T : class
    {
        List<T>? GetAll();
        List<T>? GetAllbyId(int id);
        T? FindById(int id);
        bool Save(T entity, int userId);
        bool Update(T entity, int userId);
        bool Delete(int id);
        int Count();


    }
}
