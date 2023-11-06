using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace CafeMenuProject.Entities.Admin
{
    public class Property : IEntity
    {

        
        public string Key { get; set; } = default;

        public int PropertyID { get; set; }

        public string Value { get; set; }

    }
}
