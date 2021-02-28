using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme İşlemi Tamamlandı";
        public static string Updated = "Güncelle İşlemi Tamamlandı";
        public static string Deleted = "Silme İşlemi Tamamlandı";
        public static string NameInvalid = "isim geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string BrandsListed = "Markalar listelendi";
        public static string ColorsListed = "Renkler listelendi";
        internal static string CustomerListed = "Müşteriler listelendi";
        internal static string RentalListed = "Kiralık Arabalar listelendi";
        internal static string SuccessfullOperation = "İşlem Başarılı";
        internal static string ImageLimitAlert = "Yükleme limiti 5'tir.";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ClaimsListed = "Roller Listelendi";
    }
}
