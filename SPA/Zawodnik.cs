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
    public partial class Zawodnik : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Zawodnik()
        {

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\klub.accdb;
Persist Security Info=False;";

            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fstart = new Form1();
            fstart.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            textBox1.Text = "KOMUNIKATY NA DZIŚ:";
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select nazwa, opis from AkcjaPromocyjna";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                textBox1.Text = "KOMUNIKATY:";
                textBox1.AppendText(Environment.NewLine);
                while (reader.Read())
                {
                    textBox1.Text = String.Concat(textBox1.Text, reader["nazwa"].ToString());
                    textBox1.Text = String.Concat(textBox1.Text, ": ");
                    textBox1.Text = String.Concat(textBox1.Text, reader["opis"].ToString());
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.AppendText(Environment.NewLine);
                }
            }
            else
                textBox1.Text = "Brak wiadomości";
            reader.Close();
            connection.Close();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        
        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select dieta_rozpoczecie, dieta_koniec, dieta_opis from Osoba where login='" + Form1.login + "'";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                textBox1.Text = "DIETA:";
                textBox1.AppendText(Environment.NewLine);
                while (reader.Read())
                {
                    textBox1.Text = String.Concat(textBox1.Text, "Początek diety: ");
                    textBox1.Text = String.Concat(textBox1.Text, reader["dieta_rozpoczecie"].ToString());
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.Text = String.Concat(textBox1.Text, "Koniec diety: ");
                    textBox1.Text = String.Concat(textBox1.Text, reader["dieta_koniec"].ToString());
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.Text = String.Concat(textBox1.Text, "Opis: ");
                    textBox1.Text = String.Concat(textBox1.Text, reader["dieta_opis"].ToString());
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.AppendText(Environment.NewLine);
                }
            }
            else
                textBox1.Text = "Brak wiadomości";
            reader.Close();
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select liczba_goli, liczba_meczy, liczba_asyst, liczba_fauli from Osoba where login='" + Form1.login + "'";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                textBox1.Text = "Statystyki:";
                textBox1.AppendText(Environment.NewLine);
                while (reader.Read())
                {
                    textBox1.Text = String.Concat(textBox1.Text, "Zdobyte gole: ");
                    textBox1.Text = String.Concat(textBox1.Text, reader["liczba_goli"].ToString());
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.Text = String.Concat(textBox1.Text, "Rozegrane mecze: ");
                    textBox1.Text = String.Concat(textBox1.Text, reader["liczba_meczy"].ToString());
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.Text = String.Concat(textBox1.Text, "Liczba asyst: ");
                    textBox1.Text = String.Concat(textBox1.Text, reader["liczba_asyst"].ToString());
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.Text = String.Concat(textBox1.Text, "Liczba fauli: ");
                    textBox1.Text = String.Concat(textBox1.Text, reader["liczba_fauli"].ToString());
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.AppendText(Environment.NewLine);
                }
            }
            else
                textBox1.Text = "Brak wiadomości";
            reader.Close();
            connection.Close();
        }
    }
    }

