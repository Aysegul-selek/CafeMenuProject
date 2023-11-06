using System;

namespace WebApp.UI.ViewsModel
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ParentCategoryID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorUserID { get; set; }
    }
}
