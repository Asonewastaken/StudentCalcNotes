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
    }
}
