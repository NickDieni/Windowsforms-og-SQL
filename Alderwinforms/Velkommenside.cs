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
    public partial class Velkommenside : Form
    {
        public string Navn;
        public string Efternavn;
        public string Alder;
        public Velkommenside()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Oprettelse nyOpret = new Oprettelse();
            nyOpret.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login nyLogin = new Login();
            nyLogin.Show();
        }

        private void Overskrift_Click(object sender, EventArgs e)
        {
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            Johnnycola class1 = new Johnnycola();
            class1.DataCheck();

        }


    }
}
