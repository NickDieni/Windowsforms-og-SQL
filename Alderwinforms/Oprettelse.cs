using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Alderwinforms
{
    public partial class Oprettelse : Form
    {
        public string Navn;
        public string Efternavn;
        public string Alder;
        public Oprettelse()
        {
            InitializeComponent();

        }

        private void Oprettelse_Load(object sender, EventArgs e)
        {

        }

        public void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Velkommenside form1 = new Velkommenside();
            form1.Show();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           Navn = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Efternavn = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Alder = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Johnnycola nyData = new Johnnycola();
            nyData.Opret(textBox1.Text, textBox2.Text, textBox3.Text);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            MessageBox.Show("Succesfuldt oprettet ny bruger");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
