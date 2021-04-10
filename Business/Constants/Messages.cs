using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string BrandsListed = "Markalar listelendi.";
        public static string CarAdded = "Araç eklendi.";
        public static string CarDeleted = "Araç silindi.";
        public static string CarUpdated = "Araç güncellendi.";
        public static string CarGetted = "Tüm araçlar getirildi.";
        public static string ColorGetted = "Tüm renkler getirildi.";
        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri başarıyla güncellendi.";
        public static string CustomerGetted = "Tüm müşteriler getirildi.";
        public static string RentaCarAdded = "Kiralık araç başarıyla eklendi.";
        public static string RentaCarDeleted = "Kiralık araç silindi.";
        public static string RentaCarUpdated = "Kiralık araç başarıyla güncellendi.";
        public static string RentaCarGetted = "Kiralık araçlar başarıyla getirildi.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarError = "Bir Hata Oluştu.";
        public static string CarImageLimitExceded = "En fazla 5 tane fotoğraf yüklenebilir.";
        public static string CarImageUpdated = "Araç resmi güncellendi.";
        public static string CarImageDeleted = "Araç resmi silindi.";
        public static string CarImageAdded = "Araç resmi eklendi.";
        public static string UserAvailable = "Girdiğiniz Email adresi daha önceden kullanılmıştır.";
        public static string UserNotFound = "Girdiğiniz email adresine kayıtlı bir kullanıcı bulunamamıştır!!";
        public static string ErrorPassword = "Hatalı şifre girişi.";
        public static string SuccessLogin = "Giriş başarılı. Hoşgeldiniz..";
        public static string RegisterSuccess = "Kullanıcı kaydı başarıyla tamamlanmıştır.";
        public static string TokenCreated = "Token oluşturulmuştur.";
        public static string AuthorizationDenied = "yetkiniz yok";
        public static string CardExist = "Bu kart zaten kayıtlı";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string CustomerFindeksScoreAdded = "Findeks puanı eklendi";
        public static string CustomerFindeksScoreUpdated = "Findeks puanı güncellendi";
    }
}
