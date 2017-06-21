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
    public partial class Dietetyk : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Dietetyk()
        {
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\klub.accdb;
Persist Security Info=False;";

            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fstart = new Form1();
            fstart.ShowDialog();
        }
    }
}
