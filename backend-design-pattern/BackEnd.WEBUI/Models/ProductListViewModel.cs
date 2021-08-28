using BackEnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.WEBUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public PageInfo PageInfo { get; set; }
    }

    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int PageCount { get; set; }
        public int CurrentCategory { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int ItemsPerPage { get; set; }
        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }
    }


}
