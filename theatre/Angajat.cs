using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BL;

namespace theatre
{
    public partial class Angajat : Form
    {
        public BindingSource bSource = new BindingSource();
        DataTable dt = new DataTable();
        BiletSpectacol bilet = new BiletSpectacol();
        BiletService bs = new BiletService();
        Spectacol spec = new Spectacol();
        public int idAngajat;
        public SpectacolService ss = new SpectacolService();
        public Angajat()
        {
            InitializeComponent();
        }

        private void Angajat_Load(object sender, EventArgs e)
        {

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void bAddBilet_Click(object sender, EventArgs e)
        {
            int idSpectacol = Convert.ToInt32(tb_spectacol.Text);
            int rand = Convert.ToInt32(tb_rand.Text);
            int numar = Convert.ToInt32(tb_numar.Text);

            DataTable spec = new DataTable();
            spec = ss.viewSpectacolWithID(idSpectacol);

            //testam daca locul este liber

            int newStock = Convert.ToInt32(spec.Rows[0][5]) - 1;

            if (newStock < 0)
            {
                MessageBox.Show("Nu mai sunt bilete disponibile"); 
            }
            else
            {
                //verif daca este liber locu 
                if (bs.verifBilet(idSpectacol, rand, numar))
                {
                    if (ss.updateStock(newStock, idSpectacol) > 0)
                    {
                        MessageBox.Show("Bilet vandut!");
                        bs.addBilet(idSpectacol, rand, numar);
                    }
                    else
                    {
                        MessageBox.Show("Eroare vanzare");
                    }
                }
                else
                {
                    MessageBox.Show("Loc indisponibil!");
                }
            }
        }

        private void bLoadSoldTickets_Click(object sender, EventArgs e)
        {
            var bindingSource = new System.Windows.Forms.BindingSource();

            dt = bs.viewBileteVandute(Convert.ToInt32(tb_specIdSoldTickets.Text));
            bSource.DataSource = dt;
            dgv_soldTickets.DataSource = bSource;
        }
    }
}
