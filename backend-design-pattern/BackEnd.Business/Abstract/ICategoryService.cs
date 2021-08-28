using BackEnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
