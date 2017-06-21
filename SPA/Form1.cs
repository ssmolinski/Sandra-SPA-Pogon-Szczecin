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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            //tutaj zmienic lokalizacje pliku bazy danych
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\klub.accdb;
Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = but_login;
        }

       
        private void but_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            // Info.Text = "Polaczono z baza";
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select Osoba.rola from Osoba, Konto where Osoba.login='" + tbx_login.Text + "' and Konto.haslo='"+tbx_haslo.Text+"'";
            OleDbDataReader reader = command.ExecuteReader();

            

            int count = 0;
            while (reader.Read())
            {
                count++;
            }

            if (count==1)
            {
                login = tbx_login.Text;
                MessageBox.Show("Zalogowano!");
                reader.Close();
                string stanowisko = (string)command.ExecuteScalar();
                connection.Close();
                connection.Dispose();
                this.Hide();
                if (stanowisko=="trener")
                {
                    Trener ftrener = new Trener();
                    ftrener.ShowDialog();
                }
                else if (stanowisko=="menadżer")
                {
                    Menadzer fmenadzer = new Menadzer();
                    fmenadzer.ShowDialog();
                }

                else if (stanowisko == "fizjoterapeuta")
                {
                    Fizjoterapeuta ffizjoterapeuta = new Fizjoterapeuta();
                    ffizjoterapeuta.ShowDialog();
                }

                else if (stanowisko == "statystyk")
                {
                    Statystyk fstatystyk = new Statystyk();
                    fstatystyk.ShowDialog();
                }

                else if (stanowisko == "napastnik" || stanowisko == "obrońca" || stanowisko == "bramkarz" || stanowisko == "pomocnik")
                {
                    Zawodnik fzawodnik = new Zawodnik();
                    fzawodnik.ShowDialog();
                }

                else if (stanowisko == "administrator")
                {
                    Administrator fadministrator = new Administrator();
                    fadministrator.ShowDialog();
                }

                else if (stanowisko == "dietetyk")
                {
                    Dietetyk fdietetyk = new Dietetyk();
                    fdietetyk.ShowDialog();
                }

            }
            else if (count > 1)
            {
                MessageBox.Show("Duplikat?");
            }
            else
            {
                MessageBox.Show("Błędne dane logowania!");
            }
            

        }

        private void tbx_login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
