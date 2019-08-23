using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Abc.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Abc.Northwind.Entities.Concrete
{
    //Devart kullanılmış
   public class Product:IEntity
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public Decimal UnitPrice { get; set; }
        [Required]
        public short UnitsInStock { get; set; }
    }
}
