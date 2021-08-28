using BackEnd.Business.Abstract;
using BackEnd.DataAccess.Abstract;
using BackEnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
