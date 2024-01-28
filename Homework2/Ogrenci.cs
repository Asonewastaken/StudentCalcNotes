using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Ogrenci
    {
        private string _ogrenciNo { get; set; }

        public double vize { get; set; }
        public double final { get; set; }

        public Ogrenci(string ogrenciNo)
        {
            if (string.IsNullOrEmpty(ogrenciNo))
            {
                throw new Exception("Ogrenic NO girilmelidir !");
            }

            if (ogrenciNo.Length < 9)
            {
                throw new Exception("Ogrenic NO 9 haneli olmalıdır !");
            }

            _ogrenciNo = ogrenciNo;
        }

        public string OgrenciNumarasi()
        {
            return _ogrenciNo;
        }

        public double OrtalamaBul()
        {
            double ortalama = vize * 0.4 + final * 0.7;

            return ortalama;
        }

        public string HarfNotuBul()
        {
            double ort = OrtalamaBul();

            if (ort >= 95 )
            {
                return "A1";
            }

            if (ort >= 85 && ort <= 94)
            {
                return "A2";
            }

            if(ort >= 75 && ort <= 84)
            {
                return "A3";
            }

            if (ort >= 65 && ort <= 74)
            {
                return "B1";
            }

            if (ort >= 55 && ort <= 64)
            {
                return "B2";
            }

            if (ort >= 45 && ort <= 54)
            {
                return "B3";
            }

            if (ort >= 35 && ort <= 44)
            {
                return "C1";
            }

            if (ort >= 25 && ort <= 34)
            {
                return "C2";
            }

            if (ort >= 15 && ort <= 24)
            {
                return "D1 - Şartlı Geçer";
            }

            return "FF";
        }
    }
}
