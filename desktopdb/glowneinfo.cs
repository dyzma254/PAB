using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace desktopdb
{
    public partial class glowneinfo : Form
    {

        string Polaczenie = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";

        public glowneinfo()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }







        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtPojazdy = new DataTable();
            using (SqlConnection connection = new SqlConnection(Polaczenie))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * from Liga", connection))
                {
                    connection.Open();
                    SqlDataReader czytaj = cmd.ExecuteReader();

                    dtPojazdy.Load(czytaj);

                    dataGridView1.DataSource = dtPojazdy;
                    dataGridView1.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dtKolory = new DataTable();
            using (SqlConnection connection = new SqlConnection(Polaczenie))
            {
                //kluby
                using (SqlCommand cmd = new SqlCommand("select id_klub, Liga.nazwa, Klub.nazwa, Klub.kraj, ile_tytulow, miasto from Klub INNER JOIN Liga on Klub.Id_liga = Liga.Id_liga", connection))
                {
                    connection.Open();
                    SqlDataReader czytaj = cmd.ExecuteReader();

                    dtKolory.Load(czytaj);

                    dataGridView1.DataSource = dtKolory;
                    dataGridView1.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dtModel = new DataTable();
            using (SqlConnection connection = new SqlConnection(Polaczenie))
            {
                using (SqlCommand cmd = new SqlCommand("select * from baza_treningowa", connection))
                {
                    connection.Open();
                    SqlDataReader czytaj = cmd.ExecuteReader();

                    dtModel.Load(czytaj);

                    dataGridView1.DataSource = dtModel;
                    dataGridView1.Visible = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dtMarka = new DataTable();
            using (SqlConnection connection = new SqlConnection(Polaczenie))
            {
                using (SqlCommand cmd = new SqlCommand("select id_trening, baza_treningowa.nazwa, Klub.nazwa,  obciazenie, typ_treningu, data_treningu from trening INNER JOIN baza_treningowa on  trening.id_baza = baza_treningowa.id_baza INNER JOIN Klub on trening.id_klub = Klub.id_klub", connection))
                {
                    connection.Open();
                    SqlDataReader czytaj = cmd.ExecuteReader();

                    dtMarka.Load(czytaj);

                    dataGridView1.DataSource = dtMarka;
                    dataGridView1.Visible = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dtRodzajTransakcji = new DataTable();
            using (SqlConnection connection = new SqlConnection(Polaczenie))
            {
                using (SqlCommand cmd = new SqlCommand("select * from Zawodnik", connection))
                {
                    connection.Open();
                    SqlDataReader czytaj = cmd.ExecuteReader();

                    dtRodzajTransakcji.Load(czytaj);

                    dataGridView1.DataSource = dtRodzajTransakcji;
                    dataGridView1.Visible = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dtRabat = new DataTable();
            using (SqlConnection connection = new SqlConnection(Polaczenie))
            {
                //" kluby select id_klub, Liga.nazwa, Klub.nazwa, Klub.kraj, ile_tytulow, miasto from Klub INNER JOIN Liga on Klub.Id_liga = Liga.Id_liga"
                using (SqlCommand cmd = new SqlCommand("select trening.typ_treningu, Zawodnik.nazwisko, obecny from Zawodnicy_na_treningu INNER JOIN trening on Zawodnicy_na_treningu.id_trening = trening.id_trening INNER JOIN Zawodnik on Zawodnicy_na_treningu.id_zawodnik = Zawodnik.id_zawodnik", connection))
                {
                    connection.Open();
                    SqlDataReader czytaj = cmd.ExecuteReader();

                    dtRabat.Load(czytaj);

                    dataGridView1.DataSource = dtRabat;
                    dataGridView1.Visible = true;
                }
            }
        }



        private void button9_Click(object sender, EventArgs e)
        {

            //this.Hide();
            dataGridView1.Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            modyfikuj_kluby form4 = new modyfikuj_kluby();
            //this.Hide();
            dataGridView1.Visible = false;
            form4.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            modyfikuj_baza form6 = new modyfikuj_baza();
            //this.Hide();
            dataGridView1.Visible = false;
            form6.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            //this.Hide();
            dataGridView1.Visible = false;
            form5.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            modyfikuj_zawodnicy form7 = new modyfikuj_zawodnicy();
            dataGridView1.Visible = false;
            form7.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            modyfikuj_obecnosc form8 = new modyfikuj_obecnosc();
            dataGridView1.Visible = false;
            form8.ShowDialog();
        }


        private void button13_Click(object sender, EventArgs e)
        {
            modyfikuj_liga form10 = new modyfikuj_liga();
            dataGridView1.Visible = false;
            form10.ShowDialog();
        }
    }
}
