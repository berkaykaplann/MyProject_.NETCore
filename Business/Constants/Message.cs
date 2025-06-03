using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Message
    {
        // Product
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Kategoride en fazla 10 ürün olabilir.";

        // Order
        public static string OrderAdded = "Sipariş eklendi.";
        public static string OrderListed = "Siparişler listelendi.";

        // Customer
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz.";
        public static string CustomersListed = "Müşteriler listelendi.";


        // Category
        public static string CategoryLimitExceded = "Kategori limiti aşıldı, yeni kategori eklenemiyor.";
    }
}
