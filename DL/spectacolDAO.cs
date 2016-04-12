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
    public class spectacolDAO
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

        public int addSpectacol(Spectacol spec)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO `teatru`.`spectacole` (`titlul`, `regia`, `distributia`, `data_premiera`, `bilete_vanzare`) VALUES (@titlu, @regie, @distrib, @premiera, @bileteVanzare);";
            command.Parameters.AddWithValue("@titlu", spec.titlu);
            command.Parameters.AddWithValue("@regie", spec.regie);
            command.Parameters.AddWithValue("@distrib", spec.distrib);
            command.Parameters.AddWithValue("@premiera", spec.premiera);
            command.Parameters.AddWithValue("@bileteVanzare", spec.bileteVanzare);
            return ExeNonQuery(command);
        }

        public DataTable viewSpectacol()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM teatru.spectacole";
            return ExeReader(command);
        }

        public DataTable viewSpectacolWithID(int idSpectacol)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM `teatru`.`spectacole` WHERE `idspectacole`=@idSpec;";
            command.Parameters.AddWithValue("@idSpec", idSpectacol);
            return ExeReader(command);
        }


        public int deleteSpectacol(int idSpec)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM `teatru`.`spectacole` WHERE `idspectacole`=@idSpec;";
            command.Parameters.AddWithValue("@idSpec", idSpec);
            return ExeNonQuery(command);
        }

        public int updateSpectacol(Spectacol spec, int idSpec)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE `teatru`.`spectacole` SET `titlul`=@titlu, `regia`=@regie, `distributia`=@distrib, `data_premiera`=@premiera, `bilete_vanzare`=@bilete WHERE `idspectacole`=@idSpec;";
            
            command.Parameters.AddWithValue("@titlu", spec.titlu);
            command.Parameters.AddWithValue("@regie", spec.regie);
            command.Parameters.AddWithValue("@distrib", spec.distrib);
            command.Parameters.AddWithValue("@premiera", spec.premiera);
            command.Parameters.AddWithValue("@bilete", spec.bileteVanzare);
            command.Parameters.AddWithValue("@idSpec", idSpec);
            return ExeNonQuery(command);
        }

        public int updateStock(int stocBilete, int idSpec)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "UPDATE `teatru`.`spectacole` SET `bilete_vanzare`=@newstock WHERE `idspectacole`=@idSpec;";
            command.Parameters.AddWithValue("@newstock", stocBilete);
            command.Parameters.AddWithValue("@idSpec", idSpec);
            return ExeNonQuery(command);
        }

    }
}
