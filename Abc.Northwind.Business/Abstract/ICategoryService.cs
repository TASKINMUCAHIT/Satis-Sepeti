using System;
using System.Collections.Generic;
using System.Text;
using Abc.Core;
using Abc.Northwind.DataAccess;
using Abc.Northwind.Entities;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
