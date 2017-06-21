using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SPA
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fstart = new Form1();
            fstart.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DodajKonto fdodaj_konto = new DodajKonto();
            fdodaj_konto.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EdytujKonto fedytuj_konto = new EdytujKonto();
            fedytuj_konto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsunKonto fusun_konto = new UsunKonto();
            fusun_konto.ShowDialog();
        }
    }
}

//OleDbConnection connection = new OleDbConnection();
//connection.Open();
//            // Info.Text = "Polaczono z baza";
//            OleDbCommand command = new OleDbCommand();
//command.Connection = connection;
//            command.CommandText = "select Osoba.rola from Osoba, Konto where Osoba.login='" + tbx_login.Text + "' and Konto.haslo='" + tbx_haslo.Text + "'";
//            OleDbDataReader reader = command.ExecuteReader();