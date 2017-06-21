using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SPA
{
    public partial class Trener : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Trener()
        {

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\klub.accdb;
Persist Security Info=False;";
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Imię_Click(object sender, EventArgs e)
        {

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

        }
    }
}
