using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erettsegi_20241128
{
    internal class Erettsegi
    {
        string nev;
        int magyar;
        int matek;
        int tori;
        int nyelv;
        int info;

        public string Nev { get => nev; set => nev = value; }
        public int Magyar { get => magyar; set => magyar = value; }
        public int Matek { get => matek; set => matek = value; }
        public int Tori { get => tori; set => tori = value; }
        public int Nyelv { get => nyelv; set => nyelv = value; }
        public int Info { get => info; set => info = value; }

        public Erettsegi(string row)
        {
            string[] db = row.Split(';');

            nev = db[0];
            magyar = int.Parse(db[1]);
            matek = int.Parse(db[2]);
            tori = int.Parse(db[3]);
            nyelv = int.Parse(db[4]);
            info = int.Parse(db[5]);
        }
    }
    public double AtlagSzamitas()
    {

    }
}
