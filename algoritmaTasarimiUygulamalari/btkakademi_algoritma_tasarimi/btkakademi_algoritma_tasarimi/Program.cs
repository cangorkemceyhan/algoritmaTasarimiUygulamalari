using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace btkakademi_algoritma_tasarimi
{
    internal class Program
    {
        public static class StringExtension
        {
        }
        static void Main(string[] args)
        {
            /*
            var mC = new SampleClass(11, 22);
            Console.WriteLine($"x={mC.x}, y={mC.y}");
            Console.WriteLine($"C1= {SampleClass.C1},C2= {SampleClass.C2}");
            */



            /* TEK ÇİFT SAYI KONTROLÜ
            int n=Convert.ToInt32(Console.ReadLine());
            if (ciftSayi(n))
                Console.WriteLine("Girilen sayi={0} cift sayidir", n);
            else Console.WriteLine("Girilen sayi={0} tek sayidir", n);
            */



            /* MUTLAK DEĞER
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("|{0}|={1}",n,mutlakDeger(n));
            */



            /* ASAL SAYI KONTROLÜ
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}",asalSayi(n)?"Asal sayi":"Asal degil");
            */



            /* GİRİLEN SAYININ RAKAMLARI TOPLAMI
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} sayinin rakamlari toplami= {1}",n,rakamlarToplami(n));
            */



            /* 1'den n'e KADAR OLAN SAYILARIN TOPLAMI
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Birden {0}'e kadar olan sayilarin toplami={1,5}",n,nSayisinaKadarOlanSayilarinToplami(n));
            */



            /* BELİRTİLEN DİZİNİN EN BÜYÜK VE EN KÜÇÜK ELEMANINI BULMA
            Console.Write("n: ");
            int limit=Convert.ToInt32(Console.ReadLine());
            int[] sayilar=new int[limit];
            for(int i=0; i < limit; i++)
            {
                sayilar[i]=new Random().Next(1, 100);
                Console.Write("{0,5}", sayilar[i]);
            }
            Console.WriteLine("\nDizinin en buyuk elemani: {0}",EnBuyuk(sayilar));
            Console.WriteLine("\nDizinin en kucuk elemani: {0}", EnKucuk(sayilar));
            */



            /* KLAVYEDEKİ KARAKTERLERİ YAZDIRMA
            for(int i=1; i<=300;i++)
            {
                Console.Write("{0,5}", (char)i);
                if(i%5==0)
                    Console.WriteLine();
            }
            */



            /* 1.DESEN ÇIKTISI
            Desen1();
            Desen1('!');
            Desen1('?', 10);
            */



            /* 2.DESEN ÇIKTISI
            Desen2();
            Desen2('!');
            Desen2('?', 10);
            */



            /* STRİNG IFADELER
            stringIfadeler();
            */



            /* ÜST ALMA
            double s1=Convert.ToDouble(Console.ReadLine());
            double s2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}^{1}={2}",s1,s2,ustAlma(s1,s2));
            */



            /* ASAL ÇARPANLAR
            int[] asalCarpan = asalCarpanlar(60);
            for(int i=0;i<asalCarpan.Length;i++)
                Console.WriteLine(asalCarpan[i]);
            */



            /* ASAL ÇARPANLARIN TOPLAMI
            Console.WriteLine("{0} sayisinin asal carpanlari toplami: {1}", 60, asalToplami(60));
            */



            /* OKEK
            int s1=Convert.ToInt32(Console.ReadLine());
            int s2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("OKEK({0},{1})={2}",s1,s2,OKEK(s1,s2));
            */



            /* OBEB
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("OBEB({0},{1})={2}", s1, s2, OBEB(s1, s2));
            */



            /* FAKTORİYEL
            int n = 5;
            Console.WriteLine("{0}! = {1}", n, faktoriyel(n));
            */



            /* MATRİS OLUŞTURMA
            int[,] X = Matris.Olustur();
            */



            /* MATRİS YAZDIRMA
            int[,] X = Matris.Olustur(10,5,9,25);
            Matris.Yazdir(X);
            */



            /* SIFIR MATRİSİ OLUŞTURMA
            int[,] X = Matris.sifirMatrisi(3, 3);
            Matris.Yazdir(X);
            */



            /* OLUŞTURULAN MATRİSİN KARE MATRİS OLUP OLMADIĞINI BULMA
            int[,] X = Matris.birlerMatrisi(3, 4);
            Matris.Yazdir(X);
            Console.WriteLine();
            Console.WriteLine("{0}", Matris.kareMatris(X) ? "Kare matris" : "Kare natris değil");
            */



            /* MATRİS İÇERİSİNDE SKALER ÇARPIM
            int[,] X = Matris.Olustur();
            Matris.Yazdir(X);
            X = Matris.skaler(2, X);
            Matris.Yazdir(X);
            */



            /* MATRİS İÇERİSİNDEKİ ELEMANLARIN TOPLAMI
            int[,] X = Matris.Olustur();
            Matris.Yazdir(X);
            Console.WriteLine();
            Console.WriteLine("{0}",Matris.elemanlarToplami(X));
            */



            /* KÖŞEGEN MATRİS OLUŞTURMA
            int[,] X = Matris.Olustur(5, 3, 1, 3);
            Matris.Yazdir(X);
            Console.WriteLine("{0}",Matris.kareMatris(X)?"Kosegen matris":"Kosegen matris degildir");
            */



            /* DOSYA OLUŞTURMA
            dosyaOlusturma();
            */



            /* DOSYA OKUMA
            dosyaOkuma();
            */



            /* OOP ÖRNEK
            Kisi k = new Kisi("Ahmet", 18);
            Console.WriteLine(k.Adi + " : " + k.Yas);
            */



            /* OOP ÖRNEK-2
            string s = "Merhaba dunya";
            Console.WriteLine($"{s.KelimeSayisi()}");
            */

            

            Console.ReadKey();
        }
        private static void verikapasite()
        {
            int maks16 = System.Int16.MaxValue;
            int mins16=System.Int16.MinValue;
            int maks32=System.Int32.MaxValue;
            int mins32=System.Int32.MinValue;
            byte maxByte=System.Byte.MaxValue;
            int minByte=System.Byte.MinValue;
            Console.WriteLine("Byte  -> Min: {0} \t\t Max: {1}",minByte,maxByte);
            Console.WriteLine("Int16 -> Min: {0} \t\t Max: {1}", mins16, maks16);
            Console.WriteLine("Int32 -> Min: {0} \t Max: {1}", mins32, maks32);
        }
        private static void kutulama()
        {
            int i = 23;
            object o = i; //Kutulama - Boxing
            i *= 2; //i=i*2
            i = (int)o; //Kutudan çıkarma - Unboxing
            Console.WriteLine("Deger turu: {0}", i);
            Console.WriteLine("Referans turu: {0}", o);
        }
        private static void dairealan()
        {
            const double pi = 3.1428;
            Double alan, r;
            Console.Write("r= ");
            r=Convert.ToDouble(Console.ReadLine());
            alan = pi * r * r;
            Console.WriteLine("r={0} icin alan={1}",r,alan);
        }
        private static void diziOrnegi()
        {
            string[] meyveler = { "elma", "armut", "muz", "uzum", "seftali" };
            var meyve = from m in meyveler where m[0] == 'a' select m;
            foreach(string m in meyve)
            {
                Console.WriteLine(m);
            }
        }
        private static void kararIfadeleri()
        {
            Console.Write("Bir karakter giriniz: ");
            char ch = (char)Console.Read();
            if (Char.IsUpper(ch))
            {
                Console.WriteLine("Girilen karakter buyuk bir karakterdir");
            }
            else if (Char.IsLower(ch))
            {
                Console.WriteLine("Girilen karakter kucuk bir karakterdir");
            }
            else if (Char.IsDigit(ch))
            {
                Console.WriteLine("Girilen karakter rakamdir");
            }
            else
            {
                Console.WriteLine("Girilen karakter alfanumerik bir karakter degildir");
            }
        }
        private static void switchcase()
        {
            Random rnk=new Random();
            int caseSwitch = rnk.Next(1, 10);
            switch(caseSwitch)
            {
                case 1: Console.WriteLine("Durum 1");
                    break;
                case 2:
                case 3: Console.WriteLine($"Case {caseSwitch}");
                    break;
                default: Console.WriteLine($"Beklenmeyen durum {caseSwitch}");
                    break;
            }
        }
        public static bool tekSayi(int n)
        {
            if(n%2==1)
                return true;
            return false;
        }
        public static bool ciftSayi(int n)
        {
            if(n%2==0)
                return true;
            return false;
        }
        public static int mutlakDeger(int n)
        {
            if (n > 0)
                return n;
            else if (n < 0)
                return -1 * n;
            else
                return 0;
        }
        public static bool asalSayi(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("En kucuk asal sayi 2'dir");
                return false;
            }
            bool kontrol = true;
            for(int i=2; i<n; i++)
            {
                if (n % i == 0)
                {
                    kontrol = false;
                    break;
                }
            }
            return kontrol;
        }
        public static int rakamlarToplami(int n)
        {
            int toplam = 0, rakam = 0;
            while(n> 0)
            {
                rakam = n % 10;
                toplam += rakam;
                n = n / 10;
            }
            return toplam;
        }
        public static int nSayisinaKadarOlanSayilarinToplami(int n)
        {
            return n * (n + 1) / 2;
        }
        private static void kareHesapla()
        {
            for(int i=1; i<=100; i++)
            {
                Console.WriteLine("{0} -> {1}", i, i * i);
            }
        }
        private static void tekCiftToplam()
        {
            int tekToplam = 0, ciftToplam = 0;
            Console.Write("Limit: ");
            int limit=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tek Sayilar");
            for(int i = 1; i < limit; i += 2)
            {
                Console.Write("{0,5}", i);
                tekToplam += i;
            }
            Console.WriteLine("\n\nCift Sayilar");
            for (int i = 2; i < limit; i += 2)
            {
                Console.Write("{0,5}", i);
                ciftToplam += i;
            }
            Console.WriteLine("\n\n Tek toplam: {0,5} \n Cift toplam: {1,5}", tekToplam, ciftToplam);
        }
        private static void carpimTablosu()
        {
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0,5} \tx {1,5} \t= {2,5}",i,j,i * j);
                }
                Console.WriteLine("\n\n --------------------------------- \n\n");
            }
        }
        public static int EnBuyuk(int[] dizi)
        {
            int eb = dizi[0];
            for(int i =1;i<dizi.Length;i++)
            {
                if (dizi[i]>eb)
                    eb = dizi[i];
            }
            return eb;
        }
        public static int EnKucuk(int[] dizi)
        {
            int ek = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < ek)
                    ek = dizi[i];
            }
            return ek;
        }
        public static void Desen1(char c='*',int n = 5)
        {
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0,10}", new string(c, i));
            }
        }
        public static void Desen2(char c='!', int n = 4)
        {
            for(int i = n; i >= 0; i--)
            {
                Console.WriteLine("{0}",new string(c, i));
            }
        }
        private static void stringIfadeler()
        {
            string ifade = "Görkem";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.Trim());
            Console.WriteLine(ifade.Trim().Length);
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.Replace('ö', 'e'));
        }
        private static double ustAlma(double taban, double kuvvet)
        {
            double s = 1;
            for(int i=1;i<=kuvvet;i++)
                s *= taban;
            return s;
        }
        public static int[] asalCarpanlar(int n)
        {
            string carpanListesi = "";
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    carpanListesi = i.ToString() + ",";
                }
                else
                    i++;
            }
            carpanListesi=carpanListesi.Substring(0,carpanListesi.Length - 1);
            string[] carpanlar = carpanListesi.Split(',');
            string s = carpanlar[0];
            string y = s;
            for(i=0;i<carpanlar.Length;i++)
            {
                if (!(s == carpanlar[i]))
                {
                    y = y + "," + carpanlar[i];
                    s = carpanlar[i];
                }
            }
            carpanlar = y.Split(',');
            int[] asalCarpan= new int[carpanlar.Length];
            for (i = 0; i < asalCarpan.Length; i++)
                asalCarpan[i] = Convert.ToInt32(carpanlar[i]);
            return asalCarpan;
        }
        private static int asalToplami(int n)
        {
            int[] asal = asalCarpanlar(60);
            int t = 0;
            for (int i = 0; i < asal.Length; i++)
                t += asal[i];
            return t;
        }
        private static int OKEK(int s1,int s2)
        {
            int s = 1;
            while(s1!=1&&s2!=1)
            {
                int bol = 2;
                for(int i = 1; i <= (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bol == 0 || s2 % bol == 0)
                    {
                        s *= bol;
                        if (s1 % bol == 0)
                            s1 /= bol;
                        if (s2 % bol == 0)
                            s2 /= bol;
                    }
                    else
                        bol++;
                }
            }
            return s;
        }
        private static int OBEB(int s1,int s2)
        {
            int s = 1;
            int bolen = 2;
            while(s1!=1&& s2!=1)
            {
                for(int i = 2; i < (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % bolen == 0 || s2 % bolen == 0)
                    {
                        if (s1 % bolen == 0 && s2 % bolen == 0)
                            s *= bolen;
                        if(s1%bolen==0)
                            s1 /= bolen;
                        if(s2%bolen==0)
                            s2 /= bolen;
                    }
                    else
                        bolen++;
                }
            }
            return s;
        }
        private static int faktoriyel(int n)
        {
            if (n <= 1)
                return 1;
            int f = 1;
            for (int i = 2; i <= n; i++)
                f *= i;
            return f;
        }
        public class Matris //Matris uygulamaları
        {
            public static int[,] Olustur(int satir=3, int sutun=3, int min=1, int maks = 9)
            {
                int[,] X = new int[satir, sutun];
                for (int i = 0; i < satir; i++)
                    for (int j = 0; j < sutun; j++)
                        X[i, j] = new Random().Next(min, maks);
                return X;
            }
            public static void Yazdir(int[,] X)
            {
                for(int i = 0; i < X.GetLength(0); i++)
                {
                    for(int j=0;j<X.GetLength(1);j++)
                        Console.Write("{0,3}", X[i,j]);
                    Console.WriteLine();
                }
            }
            public static int[,] sifirMatrisi(int satir, int sutun)
            {
                return Olustur(satir, sutun, 0, 0);
            }
            public static int[,] birlerMatrisi(int satir, int sutun)
            {
                return Olustur(satir, sutun, 1, 1);
            }
            public static bool kareMatris(int[,] X)
            {
                return X.GetLength(0)==X.GetLength(1)?true:false;
            }
            public static int[,] skaler(int c, int[,] X)
            {
                for(int i=0;i<X.GetLength(0);i++)
                    for(int j=0;j<X.GetLength(1);j++)
                        X[i, j] = c * X[i,j];
                return X;
            }
            public static int elemanlarToplami(int[,] X)
            {
                int toplam = 0;
                for (int i = 0; i < X.GetLength(0); i++)
                    for (int j = 0; j < X.GetLength(0); j++)
                        toplam += X[i, j];
                return toplam;
            }
            public static bool kosegenMatris(int[,] X)
            {
                bool s = true;
                if (Matris.kareMatris(X))
                {
                    for(int i=0;i<X.GetLength(0);i++)
                        for(int j=0;j<X.GetLength(1);j++)
                            if (!(X[i,j]==0))
                                if (i != j)
                                {
                                    s = false;
                                    break;
                                }
                }
                else
                {
                    Console.WriteLine("Kare matris değildir");
                    s = false;
                }
                return s;
            }
        }
        private static void dosyaOlusturma()
        {
            try
            {
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = "";
                for (int i = 0; i < yol.Length - 3; i++)
                    dosyaYol += yol[i] + '\\';
                dosyaYol += "Rakamlar.txt";
                using (StreamReader sr = new StreamReader(dosyaYol))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void dosyaOkuma()
        {
            try
            {
                string[] yol=Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = "";
                for (int i = 0; i < yol.Length - 3; i++)
                    dosyaYol += yol[i] + "\\";
                dosyaYol = "Adlar.txt";
                string[] adlar = new string[] { "Zara", "Ayca", "Mehmet", "Selim", "Kaan" };
                using(StreamWriter sw=new StreamWriter(dosyaYol))
                {
                    foreach(string s in adlar)
                        sw.WriteLine(s);
                    Console.WriteLine("\n Adlar.txt dosyasi basarili bir sekilde olusturuldu");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public class Kisi
        {
            public Kisi() { }
            public Kisi(string adi) { Adi = adi; }
            public Kisi(string adi, int yas) { Adi = adi; Yas = yas; }
            public string Adi { get; set; }
            public int Yas { get; set; }
        }
        private static void arraylar()
        {
            Array dizi = Array.CreateInstance(typeof(Int32), 3);
            dizi.SetValue(23,0);
            dizi.SetValue(58, 1);
            dizi.SetValue(21,2);
            for(int i=0;i<dizi.Length;i++)
                Console.WriteLine(dizi.GetValue(i));
        }
    }
    class SampleClass
    {
        public int x;
        public int y;
        public const int C1 = 5; //Sabitlere oluşturulduğu yerde değeri verilmelidir
        public const int C2 = C1 + 5;
        public SampleClass(int p1,int p2)
        {
            x= p1;
            y= p2;
        }
    }
}
