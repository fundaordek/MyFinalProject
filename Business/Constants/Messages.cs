using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //newlenmez
        public static string ProductAdded = "ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        internal static string MaintanceTime="sistem bakımda";
        internal static string ProductsListed;
        public static string UnitPriceInvalid;
        public static string ProductCountOfCtegoryError="bir kategoride 10 dan fazla ürün olamaz";
        public static string ProductNameAlreadyExists="ürün ismi zaten var";
        public static string CategoryLimitExceded="kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="yetkiniz yok";
        internal static string UserAlreadyExists;
        internal static string SuccessfulLogin;
        internal static User UserNotFound;
        internal static string UserRegistered;
        internal static User PasswordError;
        internal static string AccessTokenCreated;
    }
}
