using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class Araba
    {
        public string marka = null;
        public string model = null;
        public double yakitTuketimi = 0.0;
        public double toplamMesafe = 0.0;

        public Araba(string marka, string model, double yakitTuketimi, double toplamMesafe)
        {
            this.marka = marka;
            this.model = model;
            this.yakitTuketimi = yakitTuketimi;
            this.toplamMesafe = toplamMesafe;
        }

        public double ToplamYakitTuketimiHesapla()
        {
            return (toplamMesafe / 100) * yakitTuketimi;
        }
    }
}
