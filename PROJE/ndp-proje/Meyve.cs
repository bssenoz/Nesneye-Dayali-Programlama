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
using System.Drawing;


namespace vitamindeposuoyunu
{
    abstract class Meyve
    {
        protected int Gram { get; set; }
        protected Image Resim { get; set; }

        public Meyve(string imageUrl)
        {
            Random r = new Random();
            Gram = r.Next(70, 121);

            Resim = Image.FromFile(imageUrl);
        }

        public Image getImage()
        {
            return Resim;
        }
        public int getGram()
        {
            return Gram;
        }
    }
}
