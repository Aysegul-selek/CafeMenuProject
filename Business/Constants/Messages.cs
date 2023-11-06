using CafeMenuProject.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "sistem bakımda";
        public static string ProductsListed = "ürün listeyemedi";
        public static string AuthorizationDenied="yetkiniz yok";
        internal static string AccessTokenCreated;
        internal static string UserAlreadyExists;
        internal static string SuccessfulLogin;
        internal static string UserRegistered;

      
        public static string Success { get; internal set; }
        public static string Error { get; internal set; }
    }
}
