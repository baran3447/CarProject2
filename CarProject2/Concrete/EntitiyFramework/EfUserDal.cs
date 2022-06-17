using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entitis.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntitiyFramework
{
    public  class EfUserDal:EfEntityRepositoryBase<User,ReCapDBContext>,IUserDal
    {
    }
}


