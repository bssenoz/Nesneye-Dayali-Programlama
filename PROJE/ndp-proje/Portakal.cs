
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
    class Portakal : NarenciyeMeyve
    {
        public Portakal(string resim) : base(resim)
        {
            VitA = 225;
            VitC = 45;
        }
    }
}
