using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alderwinforms
{
    public partial class Miniadd : Form
    {
        public string Navn;
        public string Efternavn;
        public string Alder;
        public Miniadd()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Johnnycola nyData = new Johnnycola();
            nyData.Opret(textBox1.Text, textBox2.Text, textBox3.Text);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            MessageBox.Show("Succesfuldt oprettet ny bruger");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Miniadd_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
