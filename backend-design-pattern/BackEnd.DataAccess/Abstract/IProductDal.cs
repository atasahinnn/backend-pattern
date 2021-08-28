using BackEnd.Core.DataAccess;
using BackEnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
        // PROJEYE ÖZEL OPERASYONLAR YAZILABİLİR. 
    }
}
