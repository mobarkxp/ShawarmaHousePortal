using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucure.IRepository
{
    public interface INewServices<Entity> where Entity : class
    {
        Entity FindById(int id);
        Entity FindByName(string name);
        List<Entity> FindAll();


    }
}
