using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace SeniorDesign
{
    class CurrentUser
    {
        static string user, pass, level;

        public static string _user { get { return user; } set { user = value; } }

        public static string _pass { get { return pass; } set { pass = value; } }

        public static string _level { get { return level; } set { level = value; } }


        public static string GenerateHashWithSalt(string password)
        {
            string salt = "benton";
            string sHashWithSalt = password + salt;
            byte[] saltedHashBytes = Encoding.UTF8.GetBytes(sHashWithSalt);
            System.Security.Cryptography.HashAlgorithm algorithm = new System.Security.Cryptography.SHA256Managed();
            byte[] hash = algorithm.ComputeHash(saltedHashBytes);
            return Convert.ToBase64String(hash);
        }

        public static bool checkPassword(string user, string password)
        {
            string query = @"select username from users WHERE passowrd='" + GenerateHashWithSalt(password) + "';";
            List<string>res = DBConnection.Select(query);
            foreach(string s in res)
            {
                if (s == user)
                {
                    query = @"SELECT level FROM users WHERE username='" + s + "';";
                    List<string> level = DBConnection.Select(query);
                    _level = level[0];
                    return true;
                }
            }
            return false;
        }
    }
}
