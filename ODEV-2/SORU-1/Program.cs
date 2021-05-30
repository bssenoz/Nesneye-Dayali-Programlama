/****************************************************************************
**					          SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				         BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				        NESNEYE DAYALI PROGRAMLAMA DERSİ
**
**				ÖDEV NUMARASI....:2
**				ÖĞRENCİ ADI......:BUSE ŞENÖZ
**				ÖĞRENCİ NUMARASI.:B201210025
**				DERS GRUBU.......:A
****************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B201210025_NDP_ODEV_2_SORU_1
{
    class BenimString
    {
        public static string karakterDizini;
        public static char[] ch;
        static void Menu()
        {
            Console.WriteLine("METODLAR");
            Console.WriteLine("1-ElemanSayisi");
            Console.WriteLine("2-Birlestir");
            Console.WriteLine("3-ArayaGir");
            Console.WriteLine("4-DegerAl");
            Console.WriteLine("5-DiziyeAyir");
            Console.WriteLine("6-CharDiziyeDonustur");
            Console.WriteLine("7-DegerIndıs");
            Console.WriteLine("8-SiralaAZ");
            Console.WriteLine("9-SiralaZA");
            Console.WriteLine("10-TersCevir\n");
        }
        static int ElemanSayisi(string dizin)
        {
            int sayac = 0;
            foreach (var tmp in dizin)//tüm dizini tarar
            {
                sayac++;//her bir indiste sayacın değeri artar
            }
            return sayac;
        }
        public static string Birlestir(string string1, string string2)
        {
            return string1 + string2;//stringleri birleştirip geri döndürür
        }
        public static string ArayaGir(int index, string birlesme)
        {
            char[] ch1 = new char[index];
            char[] ch2 = new char[ElemanSayisi(karakterDizini) - index];
            for (int i = 0; i < index; i++)//araya girecek stringten önceki kisim
            {
                ch1[i] = karakterDizini[i];
            }
            int sayac = index;
            for (int i = 0; i < ElemanSayisi(karakterDizini) - index; i++)//araya girecek stringten sonraki kisim
            {
                ch2[i] = karakterDizini[sayac++];
            }
      
            return new string(ch1) + birlesme + new string(ch2);
        }
        public static string DegerAl(int karakterBasi, int karakterSonu)
        {
            ch = new char[karakterSonu];
    
            for (int i = 0; i < karakterSonu; i++)
            {
                ch[i] = karakterDizini[karakterBasi++];//degeri ch'ye atar
            }

            return new string(ch);//charı stringe donusturerek dondurur
        }
        public void DiziyeAyir()
        {
            ArrayList arrayList = new ArrayList();
            string Temp = "";
            for (int i = 0; i < ElemanSayisi(karakterDizini); i++)
            {
                if (karakterDizini[i] != ' ')
                {
                    Temp = Temp + karakterDizini[i];//bosluga kadar olan kismi alir
                }
                else//eger bosluk varsa kelimeye harf eklemeyi birakir
                {
                    arrayList.Add(Temp);//Add: Temp'i arrayList'e ekler
                    Temp = "";
                }
                if (i == (ElemanSayisi(karakterDizini) -1))//son dizi icin
                {
                    arrayList.Add(Temp);
                }

            }
            
            foreach(var item in arrayList)//diziyi yazdirir
            {
                Console.WriteLine(item);
            }

        }
        public static char[] CharDiziyeDonustur()
        {
           ch = new char[ElemanSayisi(karakterDizini)];
            for (int i = 0; i < ElemanSayisi(karakterDizini); i++)
            {
                ch[i] = karakterDizini[i];
            }
            return ch;
        }
        static void DegerIndıs()
        {
            Console.Write("\nAranılacak ifadeyi giriniz : "); string aranan = Console.ReadLine();
            string kelime = "";

            for (int i = 0; i <= ElemanSayisi(karakterDizini) - ElemanSayisi(aranan); i++)
            {
                for (int j = i; j < ElemanSayisi(aranan) + i; j++)
                {
                    kelime = kelime + karakterDizini[j];
                }
                if (kelime.ToUpper() == aranan.ToUpper())//dogru sonuc icin hepsi buyuk harfe donusturuldu
                {
                    Console.WriteLine(i);
                }
                kelime = "";
            }

        }
        public static char[] SiralaAZ()
        {
            char temp;
            int elemanSayisi = ElemanSayisi(karakterDizini);
            char[] sirali = CharDiziyeDonustur();

            for (int i = 0; i <= elemanSayisi - 1; i++)
            {
                for (int j = i + 1; j < elemanSayisi; j++)
                {
                    if ((int)sirali[i] > (int)sirali[j])
                    {
                        temp = sirali[i];
                        sirali[i] = sirali[j];
                        sirali[j] = temp;
                    } 
                } 
            }
            
            return sirali;
        }
        public static char[] SiralaZA()
        {
            char temp;
            int elemanSayisi = ElemanSayisi(karakterDizini);
            char[] sirali = CharDiziyeDonustur();

            for (int i = 0; i <= elemanSayisi - 1; i++)
            {
                for (int j = i + 1; j < elemanSayisi; j++)
                {
                    if ((int)sirali[i] < (int)sirali[j])
                    {
                        temp = sirali[i];
                        sirali[i] = sirali[j];
                        sirali[j] = temp;
                    }
                }
            }
  
            return sirali;
        }
        public static char[] TersCevir()
        {
            int elemanSayisi = ElemanSayisi(karakterDizini);
            char[] tersi = CharDiziyeDonustur();
            for (int i = 0, j = elemanSayisi - 1; i < j; i++, j--)
            {
                tersi[i] = karakterDizini[j];
                tersi[j] = karakterDizini[i];
            }
      
            return tersi;
        }
        static void Main(string[] args)
        {
            Console.Write("Karakter dizinini giriniz : "); karakterDizini = Console.ReadLine();
            char devam;
            do
            {
                Console.Clear();//consolu temizler
                Menu();
                Console.Write("Seçiminiz : "); int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("\nEleman sayısı: " + ElemanSayisi(karakterDizini));
                        break;
                    case 2:
                        Console.Write("\nEklenecek stringi giriniz : "); string eklenecekString = Console.ReadLine();
                        Console.WriteLine(BenimString.Birlestir(karakterDizini, eklenecekString));
                        break;
                    case 3:
                        Console.Write("\nEklenecek nesne değerini giriniz : "); string arayaString = Console.ReadLine();
                        Console.Write("Eklemek istediğiniz indisi giriniz : "); int indis = Convert.ToInt32(Console.ReadLine());
                        if (indis > ElemanSayisi(karakterDizini))
                            Console.WriteLine("0-{0} arası sayılar giriniz!", ElemanSayisi(karakterDizini));

                        Console.WriteLine(BenimString.ArayaGir(indis, arayaString));
                        break;
                    case 4:
                        Console.WriteLine("\nAlmak istediğiniz karakterin sırayla indislerini giriniz : ");
                        int karakterBasi = Convert.ToInt32(Console.ReadLine()); int karakterSonu = Convert.ToInt32(Console.ReadLine());
                        if (karakterBasi > ElemanSayisi(karakterDizini) || karakterSonu > ElemanSayisi(karakterDizini))
                            Console.WriteLine("0-{0} arası sayılar giriniz!", ElemanSayisi(karakterDizini));

                        Console.WriteLine(BenimString.DegerAl(karakterBasi, karakterSonu));
                        break;
                    case 5:
                        BenimString a1 = new BenimString();
                        a1.DiziyeAyir();
                        break;
                    case 6:
                        BenimString.CharDiziyeDonustur();
                        foreach (char c in ch)
                            Console.WriteLine(c);
                        break;
                    case 7:
                        DegerIndıs();
                        break;
                    case 8:
                        Console.WriteLine(BenimString.SiralaAZ());
                        break;
                    case 9:
                        Console.WriteLine(BenimString.SiralaZA());
                        break;
                    case 10:
                        Console.WriteLine(BenimString.TersCevir());
                        break;
                }
                Console.Write("\nDevam etmek istiyor musunuz?(E/e) : ");
                devam=Convert.ToChar(Console.ReadLine());

            } while (devam == 'E' || devam == 'e');      
        }
    }
}
