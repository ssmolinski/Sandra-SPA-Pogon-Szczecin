using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPA
{
    public partial class Menadzer : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Menadzer()
        {
            InitializeComponent();
            Info.Visible = false;
            panel1.Visible = false;
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\klub.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info.Visible = true;
            panel1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Info.Visible = false;

            textBox1.Text = "KOMUNIKATY NA DZIŚ:";
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select nazwa, opis, termin from AkcjaPromocyjna";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                textBox1.Text = "KOMUNIKATY:";
                textBox1.AppendText(Environment.NewLine);
                while (reader.Read())
                {
                    textBox1.Text = String.Concat(textBox1.Text, reader["nazwa"].ToString());
                    textBox1.AppendText(Environment.NewLine);
                    textBox1.Text = String.Concat(textBox1.Text, "Data: ");
                    textBox1.Text = String.Concat(textBox1.Text, reader["termin"].ToString());
                    textBox1.Text = String.Concat(textBox1.Text, ": ");
                    textBox1.AppendText(Environment.NewLine);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fstart = new Form1();
            fstart.ShowDialog();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "insert into AkcjaPromocyjna (nazwa,termin,opis) values ('" + textBox2.Text + "','" + dateTimePicker2.Text + "','" + textBox3.Text + "')";
            command.ExecuteNonQuery();
            MessageBox.Show("Dodano");
            connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
