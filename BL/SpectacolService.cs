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
using System.Security.Cryptography;

namespace BL
{
    public class SpectacolService
    {
        public spectacolDAO sd = new spectacolDAO();

        public int addSpectacol(Spectacol spec)
        {
            return sd.addSpectacol(spec);
        }

        public DataTable viewSpectacol()
        {
            return sd.viewSpectacol();
        }

        public int deleteSpectacol(int idSpec)
        {
            return sd.deleteSpectacol(idSpec);
        }

        public int updateSpectacol(Spectacol spec, int idSpec)
        {
            return sd.updateSpectacol(spec, idSpec);
        }

        public int updateStock(int stocBilete, int idSpec)
        {
            return sd.updateStock(stocBilete,idSpec);
        }

        public DataTable viewSpectacolWithID(int idSpectacol)
        {
            return sd.viewSpectacolWithID(idSpectacol);
        }

        
    }
}
