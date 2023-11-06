using System;

namespace WebApp.UI.ViewsModel
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }

        public string ProductName { get; set; }
        public string Price { get; set; }
        public string ImagePath { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreateDate { get; set; }
        public int CreatoruserID { get; set; }
    }
}
