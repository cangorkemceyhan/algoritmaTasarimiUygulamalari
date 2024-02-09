using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritma_tasarimi_oop
{
    internal class Program
    {
        public class Tasit
        {
            public string Motor { get; set; }
            public double Hacim { get; set; }
        }
        public enum Motor
        {
            Dizel,
            Benzin,
            LPG,
            Elektrik,
            Jet
        }
        public enum Renk
        {
            Beyaz,
            Siyah,
            Gri,
            Kirmizi,
            Lacivert
        }
        public class Arac:Tasit
        {
            private string marka, model, renk;
            private int yil;
            public string Marka { get => marka; set => marka = value; }
            public string Model { get => model; set => model = value; }
            public string Renk { get => renk; set => renk = value; }
            public int Yil { get => yil; set => yil = value; }
            public Arac() { }
            public Arac(string marka, string model, string renk, int yil)
            {
                Marka = marka;
                Model = model;
                Renk = renk;
                Yil = yil;
            }
            public void Calistir() => Console.WriteLine("Arac calisti");
            public void Durdur() => Console.WriteLine("Arac durduruldu");
            public override string ToString()
            {
                Console.WriteLine(new string('-', 30));
                Console.WriteLine($"{Marka}");
                Console.WriteLine($"{Model}");
                Console.WriteLine($"{Renk}");
                Console.WriteLine($"{Yil}");
                Console.WriteLine($"{Motor}");
                Console.WriteLine($"{Hacim}");
                Console.WriteLine("");
                return Marka + " " + Model;
            }
            static void Main(string[] args)
            {
                List<Arac> filo= new List<Arac>();
                filo.Add(new Arac
                {
                    Marka="Mercedes Benz",
                    Model="CLA 180D",
                    Renk="Lacivert",
                    Yil=2017,
                    Motor="Dizel",
                    Hacim=1.4
                });
                filo.Add(new Arac
                {
                    Marka = "Skoda",
                    Model = "Octavia",
                    Renk = "Beyaz",
                    Yil = 2018,
                    Motor = "Dizel",
                    Hacim = 1.6
                });
                filo.Add(new Arac
                {
                    Marka = "Audi",
                    Model = "A6",
                    Renk = "Kirmizi",
                    Yil = 2017,
                    Motor = "Dizel",
                    Hacim = 1.9
                });
                filo.RemoveAt(1);
                foreach(Arac a in filo) { a.ToString(); }
                Arac benimAracim= new Arac("Volkswagen","Passat CC","Siyah",2016);
                benimAracim.Hacim=1.6;
                Console.WriteLine($"{benimAracim.Marka}");
                Console.WriteLine($"{benimAracim.Model}");
                Console.WriteLine($"{benimAracim.Renk}");
                Console.WriteLine($"{benimAracim.Yil}");
                Console.WriteLine($"{benimAracim.Motor}");
                Console.WriteLine($"{benimAracim.Hacim}");

                Arac seninAracin = new Arac //Alternatif tanimlama
                {
                    Marka = "Skoda",
                    Model = "SuperB",
                    Renk = "Gri",
                    Yil = 2020,
                    Motor="Dizel",
                    Hacim=1.6
                };
                benimAracim.ToString();
                seninAracin.ToString();



                Console.ReadKey();
            }
        }
    }
}
