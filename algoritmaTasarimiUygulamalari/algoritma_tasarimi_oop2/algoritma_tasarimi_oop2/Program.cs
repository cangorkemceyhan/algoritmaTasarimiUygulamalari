using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritma_tasarimi_oop2
{
    internal class Program
    {
        public sealed class Pozisyon //Pozisyon classı sealed ile kitlenmiştir
        {
            public int X { get; set; }
            public int Y { get; set; }
            public override string ToString() => $"X: {X} Y: {Y}";
        }
        public class Boyut
        {
            public int Genislik { get; set; }
            public int Yukseklik { get; set; }
            public override string ToString() => $"Genislik: {Genislik}, Yukseklik: {Yukseklik}";
        }
        public class Sekil
        {
            public Pozisyon Pozisyon { get; } = new Pozisyon();
            public Boyut Boyut { get;} = new Boyut();
            public virtual void Ciz()=>Console.WriteLine($"Sekil {Pozisyon}-{Boyut}");
        }
        public class Dikdortgen : Sekil
        {
            public override void Ciz() => Console.Write($"Dikdortgen {Pozisyon}-{Boyut}");
        }
        public static void SekilCiz(Sekil sekil) => sekil.Ciz();
        static void Main(string[] args)
        {
            var r=new Sekil();
            r.Pozisyon.X = 23;
            r.Pozisyon.Y = 43;
            r.Boyut.Genislik = 100;
            r.Boyut.Yukseklik = 50;
            r.Ciz();

            Console.WriteLine();

            var y=new Dikdortgen();
            y.Pozisyon.X = 55;
            y.Pozisyon.Y = 25;
            y.Boyut.Genislik = 200;
            y.Boyut.Yukseklik = 100;
            SekilCiz(y);



            Console.ReadKey();
        }
    }
}
