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
    class KatiSikacak : ISikacak
    {
        private KatiMeyve meyve;

        public void meyveEkle(Meyve meyve)
        {
            this.meyve = (KatiMeyve)meyve;
        }
        public double getVitA()
        {
            return getGramSon() * meyve.VitA / 100000;
        }

        public double getVitC()
        {
            return getGramSon() * meyve.VitC / 100000;
        }

        public int getGramSon()
        {
            Console.WriteLine(meyve.Gram);
            return meyve.getGram() * meyve.Verim / 100;
        }
    }
}
