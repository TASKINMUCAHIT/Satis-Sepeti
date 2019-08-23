using Abc.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.DataAccess.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {
        // store procedure çağırlabilir. örneğin joinli sorgu yazılabilir burada vs vs işte
        // custom operations for product


    }
}
