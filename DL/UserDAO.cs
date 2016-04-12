using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace DL
{
    public class UserDAO
    {
        public MySqlConnection con = new MySqlConnection("Server=localhost; Port=3306; Database=teatru; Uid=root;Convert Zero Datetime=True");

        public MySqlConnection getConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public int ExeNonQuery(MySqlCommand command)
        {
            command.Connection = getConnection();
            int rowsAffected = -1;
            rowsAffected = command.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }

        public DataTable ExeReader(MySqlCommand command)
        {
            command.Connection = getConnection();
            MySqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = command.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;
        }

        public int addAngajat(User usr)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO `teatru`.`useri` (`nume`, `username`, `parola`, `rol`) VALUES (@nume, @user, @pass, @role);";
            command.Parameters.AddWithValue("@nume", usr.name);
            command.Parameters.AddWithValue("@user", usr.username);
            command.Parameters.AddWithValue("@pass", usr.pass);
            command.Parameters.AddWithValue("@role", "u");
            return ExeNonQuery(command);
        }

        public DataTable getUser(string user, string pass)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM teatru.useri where `username`=@user and `parola`=@pass;";
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            return ExeReader(command);
        }

        public DataTable getIdUser(string user, string pass)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT idUseri FROM teatru.useri where `username`=@user and `parola`=@pass;";
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            return ExeReader(command);
        }

        public int updatePass(string us, string pass)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE `teatru`.`useri` SET `parola`=@pass WHERE `username`=@username;";

            command.Parameters.AddWithValue("@pass", pass);
            command.Parameters.AddWithValue("@username", us);
            return ExeNonQuery(command);
        }
    }
}
