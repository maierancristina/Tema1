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
    public class biletDAO
    {
            public BiletSpectacol bilet = new BiletSpectacol();
            public Bilet bil = new Bilet();
            public Spectacol spec = new Spectacol();
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

            public int addBilet(int idSpec, int rand, int nr)
            {

                MySqlCommand command2 = new MySqlCommand();
                command2.CommandType = CommandType.Text;
                command2.CommandText = "INSERT INTO `teatru`.`bilet_la_spec` (`rand`, `numar`, `idspectacol`) VALUES (@rand, @nr, @idSpec);";
                command2.Parameters.AddWithValue("@rand", rand);
                command2.Parameters.AddWithValue("@nr", nr);
                command2.Parameters.AddWithValue("@idSpec", idSpec);

                return ExeNonQuery(command2);
            }

            public DataTable checkRandNr(int idSpec)
            {
                MySqlCommand command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM `teatru`.`bilet_la_spec` WHERE `idspectacol`=@idSpec;";
                command.Parameters.AddWithValue("@idSpec", idSpec);
                return ExeReader(command);
            }

            public DataTable viewBileteVandute(int idSpec)
            {
                MySqlCommand command = new MySqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM `teatru`.`bilet_la_spec` WHERE `idspectacol`=@idSpec;";
                command.Parameters.AddWithValue("@idSpec", idSpec);
                return ExeReader(command);
            }

        }
    
}
