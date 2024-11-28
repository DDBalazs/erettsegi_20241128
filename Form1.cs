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
                infoatlag = infoatlag + lista[i].Info/lista.Count;
            }
            lblegjobb.Text = "Legjobb átlagú tanuló: " + lista[max].Nev;
            lbinfoatlag.Text = "Informatika ismeretek átlaga: " + Math.Round(infoatlag,2);
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
    }
}
