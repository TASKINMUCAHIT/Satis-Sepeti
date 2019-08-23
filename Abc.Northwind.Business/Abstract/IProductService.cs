using System;
using System.Collections.Generic;
using System.Text;
using Abc.Core;
using Abc.Northwind.DataAccess;
using Abc.Northwind.Entities;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        Product GetById(int productId);
    }
}
