using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopdb
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                glowneinfo form2 = new glowneinfo();
                this.Hide();
                form2.ShowDialog();
                
            }
            else
            {
                MessageBoxButtons nieprawidlowe = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Bledne haslo lub login", "Blad", nieprawidlowe, MessageBoxIcon.Error);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
