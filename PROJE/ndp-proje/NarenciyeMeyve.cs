/****************************************************************************
**					   SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					  2020-2021 BAHAR DÖNEMİ
**	
**				ÖĞRENCİ ADI............: BUSE ŞENÖZ
**				ÖĞRENCİ NUMARASI.......: B201210025
**              DERSİN ALINDIĞI GRUP...: 1A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vitamindeposuoyunu
{
    class NarenciyeMeyve : Meyve
    {
        private double _vitA;
        private double _vitC;
        private int _verim;
        private int _gram;


        public NarenciyeMeyve(string imageUrl) : base(imageUrl)
        {

            Random r = new Random();
            _verim = r.Next(30, 71);
        }
        public double VitA { get => _vitA; set => _vitA = value; }
        public double VitC { get => _vitC; set => _vitC = value; }
        public int Verim { get => _verim; set => _verim = value; }
        public int Gram { get => _gram; set => _gram = value; }

    }
}
