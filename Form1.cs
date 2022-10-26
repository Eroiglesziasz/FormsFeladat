using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hazifeladat
{
    public partial class Feladat : Form
    {
        public Feladat()
        {
            InitializeComponent();
        }

        private void gomb_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nev.Text) || azonosito.Value == 0 || szuletett.Value > DateTime.Today || holszuletett.SelectedIndex == -1 || nyelv.SelectedIndex == -1)
            {
                MessageBox.Show("Üres adat");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void azonosito_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            azonosito.ResetText();
            nev.Clear();
            szuletett.ResetText();
            holszuletett.ResetText();
            nyelv.ResetText();
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
