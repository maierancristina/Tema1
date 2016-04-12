using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BEL;
using BL;

namespace theatre
{
    public partial class Admin : Form
    {
        public SpectacolService ss = new SpectacolService();
        public Spectacol spec = new Spectacol();
        public UserService us = new UserService();
        public BindingSource bSource = new BindingSource();
        public DataGridView dgvSpectacol = new DataGridView();
        public DataTable dt = new DataTable();
        public int idAdmin;

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void bBackAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void bLoad_Click(object sender, EventArgs e)
        {
            User addUser = new User();
            addUser.name = tb_nameAng.Text;
            addUser.pass = tb_passAng.Text;
            addUser.username = tb_usernameAng.Text;

            if (us.addAngajat(addUser) > 0)
            {
                MessageBox.Show("Angajat inserted");
            }
            else
            {
                MessageBox.Show("Angajat not inserted");
            }
        }

        private void bAddSpec_Click(object sender, EventArgs e)
        {
            Spectacol addSpec = new Spectacol();
            addSpec.titlu = tb_titlu.Text;
            addSpec.regie = tb_regia.Text;
            addSpec.distrib = tb_distrib.Text;
            addSpec.premiera = tb_data.Text;
            addSpec.bileteVanzare = tb_bilete.Text;

            if (ss.addSpectacol(addSpec) > 0)
            {
                MessageBox.Show("Spectacol inserted");
            }
            else
            {
                MessageBox.Show("Spectacol not inserted");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bViewSpec_Click(object sender, EventArgs e) 
        {
            int poz = dgv_spec.SelectedRows[0].Index;

            tb_titlu.Text = Convert.ToString(dgv_spec.Rows[poz].Cells[1].Value);
            tb_regia.Text = Convert.ToString(dgv_spec.Rows[poz].Cells[2].Value);
            tb_distrib.Text = Convert.ToString(dgv_spec.Rows[poz].Cells[3].Value);
            tb_data.Text = Convert.ToString(dgv_spec.Rows[poz].Cells[4].Value);
            tb_bilete.Text = Convert.ToString(dgv_spec.Rows[poz].Cells[5].Value);
            

        }

        private void bLoadSpec_Click(object sender, EventArgs e)
        {
            var bindingSource = new System.Windows.Forms.BindingSource();

            dt = ss.viewSpectacol();
            bSource.DataSource = dt;
            dgv_spec.DataSource = bSource;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bDeleteSpec_Click(object sender, EventArgs e)
        {
            int poz = dgv_spec.SelectedRows[0].Index;

            if (dgv_spec.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one row");
            }
            else
                if (dgv_spec.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select one row");
                }
                else
                {
                    int id_delete = Convert.ToInt32(dgv_spec.Rows[poz].Cells[0].Value);
                    int rows = ss.deleteSpectacol(id_delete);
                    if (rows > 0)
                    {
                        MessageBox.Show("You have successfully deleted a show");
                    }
                }

        }

        private void bUpdateSpec_Click(object sender, EventArgs e)
        {
            Spectacol spec = new Spectacol();
            int poz = dgv_spec.SelectedRows[0].Index;
            int id_delete = Convert.ToInt32(dgv_spec.Rows[poz].Cells[0].Value);

            spec.titlu = tb_titlu.Text;
            spec.regie = tb_regia.Text;
            spec.distrib = tb_distrib.Text;
            spec.premiera = tb_data.Text;
            spec.bileteVanzare = tb_bilete.Text;
            tb_titlu.Text = "";
            tb_regia.Text = "";
            tb_distrib.Text = "";
            tb_data.Text = "";
            tb_bilete.Text = "";

            int rows = ss.updateSpectacol(spec, id_delete);
            if (rows > 0)
            {
                MessageBox.Show("You have successfully updated a show");
            }

        }
    }
}
