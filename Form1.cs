using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
