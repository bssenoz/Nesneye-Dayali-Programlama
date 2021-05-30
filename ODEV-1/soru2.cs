/****************************************************************************
**					      SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				     BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					     2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1
**				ÖĞRENCİ ADI............:BUSE ŞENÖZ
**				ÖĞRENCİ NUMARASI.......:B201210025
**              DERSİN ALINDIĞI GRUP...:A
****************************************************************************/

using System;

namespace B201210025_NDP_ODEV_1_SORU_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1-String bir değişkende, string değeri substring kullanmadan ara");
            Console.WriteLine("2-String bir değişkende, string değeri substring kullanarak ara");
            Console.WriteLine("3-Alfabenin karakterlerini bir stringde ara kaç adet geçiyor bul ve çiz");
           
            Console.WriteLine(); Console.Write("Seçiminiz: "); 
            int secim = Convert.ToInt32(Console.ReadLine());
     
            Console.WriteLine("-----------------------------------------------------------------------\n");

            string karakterDizini;
            string aranan;

                switch (secim)//Ana menü oluşturmak için switch-case yapısı kullanıldı
                {
                    case 1:
                        {
                            Console.Write("Karakter dizini : ");
                            karakterDizini = Console.ReadLine().ToUpper();//arama yaparken sorun yaşamamak için ToUpper ile hepsi büyük harfe çevrildi
                            Console.Write("Aranacak kelime : ");
                            aranan = Console.ReadLine().ToUpper();
                            int indis = karakterDizini.IndexOf(aranan);

                            while (indis != -1)
                            {
                                Console.WriteLine("Kelime {0} indis: {1}", aranan, indis);
                                indis = karakterDizini.IndexOf(aranan, indis + 1);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Karakter dizini : ");
                            karakterDizini = Console.ReadLine().ToUpper();
                            Console.Write("Aranacak kelime : ");
                            aranan = Console.ReadLine().ToUpper();

                            int karakterDiziniUzunluk = karakterDizini.Length;//uzunluğu bulundu
                            int arananuzunluk = aranan.Length;
                            int sayac = 0;
                            for (int indis = 0; indis <= (karakterDiziniUzunluk - arananuzunluk); indis++)
                            {
                                if (karakterDizini.Substring(indis, arananuzunluk) == aranan)//Substring ile metinden parça parça alınıp aranan ile karşılaştırıldı
                                {
                                    Console.WriteLine("Kelime {0} indis: {1}", aranan, indis);
                                    sayac++;
                                }

                            }
                            if (sayac == 0)
                            {
                                Console.WriteLine("\n-->Aranan kelime girilen karakter dizininde bulunamadı!");
                            }

                            break;
                        }
                    case 3:
                        {
                            Console.Write("Cümleyi Giriniz: ");
                            karakterDizini = Console.ReadLine().ToUpper();
                            Console.WriteLine("\nKarakter Sayısı    Grafik Gösterimi");
                            Console.WriteLine("-----------------------------------");

                            char[] harf = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };

                            for (int a = 0; a < harf.Length; a++)
                            {
                                int sayac = 0;
                                for (int i = 0; i < karakterDizini.Length; i++)//girilen kelimenin her bir karakterinin kontrol edilmesi için kelime.Length kullanimi ideal.
                                {
                                    if (karakterDizini[i] == harf[a])//harfin bulunması durumu
                                    {
                                        sayac++;//eğer bulduysa bir artacak
                                    }

                                }
                                Console.Write(string.Format("{0} , sayisi : {1}    ", harf[a], sayac));
                                for (int j = 0; j < sayac; j++)
                                {
                                    Console.Write(" * ");
                                }
                                Console.WriteLine();

                            }
                            break;
                        }
                        default:
                           Console.WriteLine("--> Hatalı seçim!");
                           break;

                }
        }
    }
}



