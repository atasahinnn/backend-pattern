using BackEnd.Core.DataAccess.EntityFramework;
using BackEnd.DataAccess.Abstract;
using BackEnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.DataAccess.Concrete.EntityFramework
{
    public class EntityFrameworkProductDal:EntityFrameworkRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
