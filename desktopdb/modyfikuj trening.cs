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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Fillcombo1();
            Fillcombo2();
        }


        void Fillcombo1()
        {
            string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
            string query = "select * from Baza_treningowa";
            SqlConnection condatabase = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(query, condatabase);
            SqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(myreader.GetOrdinal("nazwa"));
                    comboBox1.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        void Fillcombo2()
        {
            string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
            string query = "select * from klub";
            SqlConnection condatabase = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(query, condatabase);
            SqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(myreader.GetOrdinal("nazwa"));
                    comboBox2.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void markiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
         

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pabDataSet.trening' table. You can move, or remove it, as needed.
            this.treningTableAdapter.Fill(this.pabDataSet.trening);
            // TODO: This line of code loads data into the 'pabDataSet.trening' table. You can move, or remove it, as needed.
            this.treningTableAdapter.Fill(this.pabDataSet.trening);
            
            

        }

        private void treningBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treningBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pabDataSet);

        }

        private void id_bazaLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //baza

            string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
            string query = "select * from baza_treningowa where CONVERT(VARCHAR,nazwa)='" + comboBox1.Text + "';";
            SqlConnection condatabase = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(query, condatabase);
            SqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {
                    Object sname = myreader.GetValue(myreader.GetOrdinal("ID_baza"));
                    id_bazaTextBox.Text = sname.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //klub

            string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
            string query = "select * from klub where CONVERT(VARCHAR,nazwa)='" + comboBox2.Text + "';";
            SqlConnection condatabase = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(query, condatabase);
            SqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {
                    Object sname = myreader.GetValue(myreader.GetOrdinal("id_klub"));
                    id_klubTextBox.Text = sname.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
