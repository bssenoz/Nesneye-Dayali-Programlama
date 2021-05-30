/****************************************************************************
**					   SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					  2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: BUSE ŞENÖZ
**				ÖĞRENCİ NUMARASI.......: B201210025
**              DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace B201210025_NDP_ODEV_1_SORU_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] dizi = new int[8, 8];//8x8lik dizi oluşturuldu
            Random rastgele = new Random();//random sayı için

            int sayac = 0;//oluşan bir hatayı önlemek için tanımlandı

            for (int sutundoldur = 0; sutundoldur < 8; sutundoldur++)
            {
                for (int satirdoldur = 0; satirdoldur < 8; satirdoldur++)
                {
                    dizi[satirdoldur, sutundoldur] = 0;//tüm diziye 0 atandı
                }
            }

            do
            {
                for (int sutun = 0; sutun < 8; sutun++)
                {
                    for (int satir = 0; satir < 8; satir++)
                    {
                        int sayi = rastgele.Next(0, 8);//0-8 arası random sayı atanır
                        int durum = 0;
 
                        for (int kontrol = 0; kontrol < 8; kontrol++)//burası kontrol amaçlı
                        {
                            if (dizi[sutun, kontrol] == 1)
                            {
                                durum = 1;
                            }
                            if (dizi[kontrol, sayi] == 1)
                            {
                                durum = 1;
                            }
                        }
                  
                        if (durum == 0)//consoldaki 1'lerin atandığı kısım burası
                        {
                            dizi[sutun, sayi] = 1;
                            sayac++;
                        }
                    }
                }
                
            } while (sayac!=8);//eğer 8 kere 1 değeri atanmadıysa tüm işlemler tekrarlanır

            Console.WriteLine("   A B C D E F G H ");
            Console.WriteLine("  ----------------");
            int i = 8;
            for (int sutunYazdir = 0; sutunYazdir < 8; sutunYazdir++)
            {
                Console.Write(i + "| ");//satrançta yanda bulunan sayılar için
                for (int satirYazdir = 0; satirYazdir < 8; satirYazdir++)
                {
                    Console.Write(dizi[satirYazdir, sutunYazdir] + " ");//consola yazdırılan kısım
                }
                Console.Write("|"+i);
                Console.WriteLine();
                i--;
            }
            Console.WriteLine("  ----------------");
            Console.WriteLine("   A B C D E F G H ");

        }
    }
}