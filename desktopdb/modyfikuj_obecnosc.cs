using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopdb
{
    public partial class modyfikuj_obecnosc : Form
    {
        public modyfikuj_obecnosc()
        {
            InitializeComponent();
            FillCombo();
            FillCombo1();
        }

        private void FillCombo()
        {

            {
                string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
                string query = "select * from trening";
                SqlConnection condatabase = new SqlConnection(constring);
                SqlCommand cmddatabase = new SqlCommand(query, condatabase);
                SqlDataReader myreader;
                try
                {
                    condatabase.Open();
                    myreader = cmddatabase.ExecuteReader();
                    while (myreader.Read())
                    {
                        string sname = myreader.GetString(myreader.GetOrdinal("typ_treningu"));
                        comboBox1.Items.Add(sname);
                        comboBox1.Text = comboBox1.SelectedIndex.ToString();
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
            private void FillCombo1()
        {
            string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
            string query = "select * from zawodnik";
            SqlConnection condatabase = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(query, condatabase);
            SqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(myreader.GetOrdinal("nazwisko"));
                    comboBox2.Items.Add(sname);

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void rabatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();  

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pabDataSet.Zawodnicy_na_treningu' table. You can move, or remove it, as needed.
            this.zawodnicy_na_treninguTableAdapter.Fill(this.pabDataSet.Zawodnicy_na_treningu);
            // TODO: This line of code loads data into the 'pabDataSet.Zawodnicy_na_treningu' table. You can move, or remove it, as needed.
            this.zawodnicy_na_treninguTableAdapter.Fill(this.pabDataSet.Zawodnicy_na_treningu);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'komis.Rabat' . Możesz go przenieść lub usunąć.
           

        }

        private void zawodnicy_na_treninguBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zawodnicy_na_treninguBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pabDataSet);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
                string query = "select * from trening where CONVERT(VARCHAR,typ_treningu)='" + comboBox1.Text + "';";
                SqlConnection condatabase = new SqlConnection(constring);
                SqlCommand cmddatabase = new SqlCommand(query, condatabase);
                SqlDataReader myreader;
                try
                {
                    condatabase.Open();
                    myreader = cmddatabase.ExecuteReader();
                    while (myreader.Read())
                    {
                        Object sname = myreader.GetValue(myreader.GetOrdinal("id_trening"));
                        id_treningTextBox.Text = sname.ToString();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
                string query = "select * from zawodnik where CONVERT(VARCHAR,nazwisko)='" + comboBox2.Text + "';";
                SqlConnection condatabase = new SqlConnection(constring);
                SqlCommand cmddatabase = new SqlCommand(query, condatabase);
                SqlDataReader myreader;
                try
                {
                    condatabase.Open();
                    myreader = cmddatabase.ExecuteReader();
                    while (myreader.Read())
                    {
                        Object sname = myreader.GetValue(myreader.GetOrdinal("id_zawodnik"));
                       id_zawodnikTextBox.Text = sname.ToString();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
