using BackEnd.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackEnd.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveToCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
