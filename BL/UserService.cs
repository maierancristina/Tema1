using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using DL;
using BEL;

namespace BL
{
    public class UserService
    {
        public UserDAO ud = new UserDAO();
        public string login(string user, string pass)
        {
            DataTable dt = new DataTable();
            dt = ud.getUser(user, getMd5Hash(pass));
            string role = dt.Rows[0][4].ToString();
            return role;
        }

        public int getIdUser(string user, string pass)
        {
            DataTable dt = new DataTable();
            dt = ud.getIdUser(user, getMd5Hash(pass));
            int id = Convert.ToInt32(dt.Rows[0][0]);
            return id;
        }

        public int addAngajat(User usr)
        {
            User usr2 = new User();
            usr2 = usr;
            usr2.pass = getMd5Hash(usr.pass);
            return ud.addAngajat(usr2);
        }

        public int updatePass(string us, string pass)
        {
            return ud.updatePass(us,getMd5Hash(pass));
        }
        static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
