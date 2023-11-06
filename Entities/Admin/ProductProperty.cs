using Core.Entities;
using System;

namespace CafeMenuProject.Entities.Admin
{
    public class ProductProperty:IEntity
    {
        public int ProductPropertyId { get; set; }
        public int ProductId { get; set; }
        public int PropertyId { get; set; }
       
    }
}
