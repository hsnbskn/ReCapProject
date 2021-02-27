using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        //publicler pascalcase ile yazılır.
        public static string CarAdded = "Car added";
        public static string CarNameInvalid = "Car name is invalid";
        public static string MaintenanceTime = "System is maintenance";
        public static string CarListed = "Car Listed";
        public static string UserAdded = "User added";
        public static string RentalNotAvailable = "Car is not available";
        public static string SuccessRentCar = "The car was successfully rented";
        public static string UserDeleted = "User Deleted";
        public static string UserUpdated = "User Updated";
        public static string RentalDeleted = "Rental Deleted";
        public static string RentalUpdated = "Rental Updated";
        public static string ReturnDateNotNull = "The car has already been delivered";
        public static string CustomerAdded = "Customer added";
        public static string CustomerDeleted = "Customer Deleted";
        public static string CustomerListed = "Customer Listed";
        public static string CustomerUpdated = "Customer updated";
        public static string CarDeleted = "Car Deleted";
        public static string CarUpdated = "Car updated";
        public static string BrandAdded = "Brand added";
        public static string BrandDeleted = "Brand deleted";
        public static string BrandUpdated = "Brand updated";
        public static string BrandListed = "Brand listed";
        public static string BrandListedById = "Brand listed by Brand Id ";
        public static string ColorAdded = "Color added";
        public static string ColorDeleted = "Color deleted";
        public static string ColorUpdated = "Color updated";
        public static string ColorListed = "Color listed";
        public static string RentalListed = "Rental listed";
        public static string CarCountOfBrandError = "Bu markada en fazla 10 adet araç olabilir";
        public static string CarNameAlreadyExists = "Bu isimde zaten bir araç var";
        public static string BrandLimitExceded = "Marka limitine ulaşıldığı için yeni araç eklenemiyor";
        public static string ErrorAddedImageLimit = "En fazla 5 fotoğraf eklenebilir";
        internal static string CarImageLimitExceeded;
    }
}