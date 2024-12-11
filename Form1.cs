using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erettsegi_20241128
{
    public partial class Form1 : Form
    {
        List<Erettsegi> lista = new List<Erettsegi>();

        void betoltes()
        {
            lista.Clear();
            dtvtablazat.Rows.Clear();
            FileStream fs = new FileStream("..\\..\\src\\erettsegi.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                Erettsegi e = new Erettsegi(sr.ReadLine());
                lista.Add(e);
                dtvtablazat.Rows.Add(e.Nev,e.Magyar,e.Matek,e.Nyelv,e.Info);
            }
            sr.Close();
            fs.Close();

            int max = 0;
            double infoatlag = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].AtlagSzamitas() > lista[max].AtlagSzamitas())
                {
                    lista[max] = lista[i];
                }
                infoatlag = infoatlag + lista[i].Info; 
            }
            lblegjobb.Text = "Legjobb átlagú tanuló: " + lista[max].Nev;
            lbinfoatlag.Text = "Informatika ismeretek átlaga: " + Math.Round(infoatlag/lista.Count,1);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void chbujeredmeny_CheckedChanged(object sender, EventArgs e)
        {
            if (chbujeredmeny.Checked)
            {
                lbnev.Visible = true;
                lbmagyar.Visible = true;
                lbmatek.Visible = true;
                lbtori.Visible = true;
                lbnyelv.Visible = true;
                lbinfo.Visible = true;
                txnev.Visible = true;
                cbmagyar.Visible = true;
                cbmatek.Visible = true;
                cbtori.Visible = true;
                cbidegennyelv.Visible = true;
                cbinfo.Visible = true;
                btsave.Visible = true;
            }
            else
            {
                lbnev.Visible = false;
                lbmagyar.Visible = false;
                lbmatek.Visible = false;
                lbtori.Visible = false;
                lbnyelv.Visible = false;
                lbinfo.Visible = false;
                cbmagyar.Visible = false;
                cbmatek.Visible = false;
                cbtori.Visible = false;
                cbidegennyelv.Visible = false;
                cbinfo.Visible = false;
                txnev.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if(txnev.Text.Length == 0)
            {
                MessageBox.Show("Nem adtad meg a nevet!", "BAJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txnev.Focus();
            }
            else if(cbmagyar.SelectedItem == null)
            {
                MessageBox.Show("Nem választottad ki a magyar jegyeket!", "BAJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbmatek.SelectedItem == null)
            {
                MessageBox.Show("Nem választottad ki a matek jegyeket!", "BAJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbtori.SelectedItem == null)
            {
                MessageBox.Show("Nem választottad ki a töri jegyeket!", "BAJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbidegennyelv.SelectedItem == null)
            {
                MessageBox.Show("Nem választottad ki a idegennyelv jegyeket!", "BAJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbinfo.SelectedItem == null)
            {
                MessageBox.Show("Nem választottad ki a info jegyeket!", "BAJ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileStream fs = new FileStream("..\\..\\src\\erettsegi.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                sw.Write("\n" + txnev.Text + ";" + cbmagyar.SelectedItem.ToString() + ";" + cbmatek.SelectedItem.ToString() + ";" + cbtori.SelectedItem.ToString() + ";" + cbidegennyelv.SelectedItem.ToString() + ";" + cbinfo.SelectedItem.ToString());

                sw.Close();
                fs.Close();

                betoltes();

                txnev.Clear();
                cbmagyar.SelectedItem = null;
                cbidegennyelv.SelectedItem = null;
                cbmatek.SelectedItem = null;
                cbinfo.SelectedItem = null;
                cbtori.SelectedItem = null;
            }
        }

        private void txnev_TextChanged(object sender, EventArgs e)
        {
            if (txnev.Text.Length > 0)
            {
                if(int.TryParse(txnev.Text, out _))
                {
                        MessageBox.Show("Ne számot adjál meg more!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txnev.Clear();
                        txnev.Focus();
                }
            }
        }
    }
}
