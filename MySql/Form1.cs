using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void HozzaadButton_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection("Server=localhost;Database=kutya13t;Uid=root;Pwd="))
            {
                conn.Open();

                string nev = nevtextBox.Text;
                string fajta = fajtaTextBox.Text;
                DateTime orokbe = orokbefogad_dateTimePicker.Value;

                var lekerdezesCommand = conn.CreateCommand();
                lekerdezesCommand.CommandText = @"
                    SELECT COUNT(*) FROM kutyak WHERE nev = @nev
                    ";
                lekerdezesCommand.Parameters.AddWithValue("@nev", nev);
                long db = (long)lekerdezesCommand.ExecuteScalar();
                if (db > 0)
                {
                    MessageBox.Show("Ilyen kutya mar van.");
                    return;
                }
                var command = conn.CreateCommand();
                command.CommandText = @"INSERT INTO kutyak 
                                    (nev, fajta, orokbefogadas_datum)
                                VALUES
                                   (@nev, @fajta, @orokbe) 
                                   ";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@fajta", fajta);
                command.Parameters.AddWithValue("@orokbe", orokbe);
                command.ExecuteNonQuery();


            }

        }

        private void torles_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection("Server=localhost;Database=kutya13t;Uid=root;Pwd="))
            {
                conn.Open();
                string nev = nevtextBox.Text;
                var lekerdezesCommand = conn.CreateCommand();
                lekerdezesCommand.CommandText = @"
                    SELECT COUNT(*) FROM kutyak WHERE nev = @nev
                    ";
                lekerdezesCommand.Parameters.AddWithValue("@nev", nev);
                long db = (long)lekerdezesCommand.ExecuteScalar();
                if (db == 0)
                {
                    MessageBox.Show("Nincs ilyen kutya.");
                    return;
                }
                var deleteComm = conn.CreateCommand();
                deleteComm.CommandText = @"DELETE FROM kutyak WHERE nev = @nev ";
                deleteComm.Parameters.AddWithValue("@nev", nev);
                 int num = deleteComm.ExecuteNonQuery();

                if (num == 0)
                {
                    MessageBox.Show("Nem volt törölhető kutya, amit megadtál.");
                    return;
                }
            };




        }
        private void Modositas_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection("Server=localhost;Database=kutya13t;Uid=root;Pwd="))
            {
                conn.Open();
                string nev = nevtextBox.Text;
                var lekerdezesCommand = conn.CreateCommand();
                string fajta = fajtaTextBox.Text;
                DateTime orokbe = orokbefogad_dateTimePicker.Value;

                var command = conn.CreateCommand();
                command.CommandText = @"UPDATE kutyak SET nev = @nev, fajta=@fajta, orokbefogadas_datum = @orokbe WHERE nev = @nev";
                command.Parameters.AddWithValue("@nev", nev);
                command.Parameters.AddWithValue("@fajta", fajta);
                command.Parameters.AddWithValue("@orokbe", orokbe);
                int num = command.ExecuteNonQuery();
                MessageBox.Show("Módosítva lett!");

                if (num == 0)
                {
                    MessageBox.Show("Nem volt ilyen kutya, amit módosíthattál volna.");
                    return;
                }

            };

        }
    }
    }
