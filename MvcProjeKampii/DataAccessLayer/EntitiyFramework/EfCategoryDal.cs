using DataAccessLayer.Abstrack;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiyFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public Category Get(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
