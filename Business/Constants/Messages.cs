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
        internal static string CustomerAdded = "Customer added";
        internal static string CustomerDeleted = "Customer Deleted";
        internal static string CustomerListed = "Customer Listed";
        internal static string CustomerUpdated = "Customer updated";
        internal static string CarDeleted = "Car Deleted";
        internal static string CarUpdated = "Car updated";
        internal static string BrandAdded = "Brand added";
        internal static string BrandDeleted = "Brand deleted";
        internal static string BrandUpdated = "Brand updated";
        internal static string BrandListed = "Brand listed";
        internal static string BrandListedById = "Brand listed by Brand Id ";
        internal static string ColorAdded = "Color added";
        internal static string ColorDeleted = "Color deleted";
        internal static string ColorUpdated = "Color updated";
        internal static string ColorListed = "Color listed";
    }
}
