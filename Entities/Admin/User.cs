using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace CafeMenuProject.Models.Admin
{
    public class User:IEntity
    {
        public int UserID { get; set; }

        public string Name { get; set; }

   
        public string Surname { get; set; }

        public string UserName { get; set; }

  
        public string HashPassword { get; set; }

  
        public string SaltPassword { get; set; }
    }
}
