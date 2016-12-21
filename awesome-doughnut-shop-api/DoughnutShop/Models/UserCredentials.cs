using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace DoughnutShop.Models
{
    public class UserCredentials
    {
        public static string EncryptSHA512Managed(string password)
        {
            UnicodeEncoding uEncode = new UnicodeEncoding();
            byte[] bytPassword = uEncode.GetBytes(password);
            SHA512Managed sha = new SHA512Managed();
            byte[] hash = sha.ComputeHash(bytPassword);
            return Convert.ToBase64String(hash);
        }

        public string Email { get; set; }
        public string Password { get; set; }

        public UserCredentials() { }

        public UserCredentials(User u)
        {
            Email = u.Email;
            Password = UserCredentials.EncryptSHA512Managed(u.Password);
        }

        public bool Compare(User u)
        {
            return (Email == u.Email) && (Password == u.Password);
        }

    }
}