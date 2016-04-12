using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DL;
using BEL;

namespace BL
{
    public class BiletService
    {
        public biletDAO bd = new biletDAO();
        public BiletSpectacol bil = new BiletSpectacol();

        public int addBilet(int idSpec, int rand, int nr)
        {
            return bd.addBilet(idSpec, rand, nr);
        }

        public bool verifBilet(int idSpectacol, int rand,int numar)
        {
            bool ok = true;
            
            //select toate bilete ptspectacolul cu id idSpectacol
            DataTable checkBilete = bd.checkRandNr(idSpectacol);
            for (int i = 0; i < checkBilete.Rows.Count; i++)
            {
                if ((Convert.ToInt32(checkBilete.Rows[i][2]) == rand) && Convert.ToInt32(checkBilete.Rows[i][3]) == numar)
                {
                    ok = false;
                }
            }

            return ok;
        }

        public DataTable viewBileteVandute(int idSpec)
        {
            return bd.viewBileteVandute(idSpec);
        }
    }
}
