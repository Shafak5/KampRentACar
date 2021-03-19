using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string Added = "Added successfully";
        public static string Deleted = "Deleted successfully";
        public static string Updated = "Updated successfully";
        public static string Listed = "Listed succcessfullly";
        public static string DetailsListed = "Details listed";
        public static string AuthorizationDenied = "Authorization denied";
        public static string UserNotFound = "User not found";
        public static string SuccessfullLogin = "Login successfully";
        public static string PasswordError = "Password error";
        public static string UserRegistered = "Registered successfully";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access token created";
    }
}
