using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaRestoran
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kave_Click(object sender, EventArgs e)
        {
            Kava kava =new Kava() { TopLevel = false, TopMost = true };
            kava.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(kava);
            kava.Show();

        }

        private void juha_Click(object sender, EventArgs e)
        {
            Juha juha = new Juha() { TopLevel = false, TopMost = true };
            juha.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(juha);
            juha.Show();
        }

        private void bezAlkPica_Click(object sender, EventArgs e)
        {
            BezalkoholnaPica bezalkoholnaPica=new BezalkoholnaPica() { TopLevel = false,TopMost = true };
            bezalkoholnaPica.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(bezalkoholnaPica);
            bezalkoholnaPica.Show();
        }

        private void predjelo_Click(object sender, EventArgs e)
        {
            Predjelo predjelo = new Predjelo() { TopLevel = false, TopMost = true };
            predjelo.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(predjelo);
            predjelo.Show();
        }

        private void alkPica_Click(object sender, EventArgs e)
        {
            AlkoholnaPica alkoholnaPica= new AlkoholnaPica() { TopLevel = false,TopMost = true};
            alkoholnaPica.FormBorderStyle= FormBorderStyle.None;
            panel.Controls.Add(alkoholnaPica);
            alkoholnaPica.Show();
        }

        private void glJelo_Click(object sender, EventArgs e)
        {
            GlJelo glJelo = new GlJelo() { TopLevel = false,TopMost=true};
            glJelo.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(glJelo);
            glJelo.Show();
        }

        private void desert_Click(object sender, EventArgs e)
        {
            Desert desert = new Desert() { TopLevel = false, TopMost = true };
            desert.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(desert);
            desert.Show();
        }

        private void salate_Click(object sender, EventArgs e)
        {
            Salata salata = new Salata() { TopLevel = false, TopMost = true };
            salata.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(salata);
            salata.Show();
        }
    }
}
