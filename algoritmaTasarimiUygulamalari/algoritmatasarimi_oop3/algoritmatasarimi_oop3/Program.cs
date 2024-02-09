using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmatasarimi_oop3
{
    public interface IBankaHesap
    {
        void Yatir(decimal miktar);
        bool Cek(decimal miktar);
        decimal Bakiye { get; }
    }
    public class MevduatHesabi : IBankaHesap
    {
        private decimal _bakiye;
        public decimal Bakiye => _bakiye;
        public bool Cek(decimal miktar)
        {
            if(_bakiye>=miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\a Bakiye yetersiz!");
            return false;
        }
        public void Yatir(decimal miktar)
        {
            _bakiye += miktar;
        }
        public override string ToString() => $"Mevdauat hesabi bakiye bilgisi: {_bakiye,6:C}";
    }
    public class YatirimHesabi : IBankaHesap
    {
        private decimal _bakiye;
        public decimal Bakiye => _bakiye;
        public bool Cek(decimal miktar)
        {
            if (_bakiye >= miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\a Bakiye yetersiz!");
            return false;
        }
        public void Yatir(decimal miktar)=>_bakiye+= miktar;
        public override string ToString() => $"Yatirim hesabi bakiye bilgisi: {_bakiye,6:C}";
    }
    public interface ITransfer : IBankaHesap
    {
        bool TransferYap(IBankaHesap aliciHesap, decimal miktar);
    }
    public class AktifHesap : ITransfer
    {
        private decimal _bakiye;
        public decimal Bakiye => _bakiye;
        public bool Cek(decimal miktar)
        {
            if(_bakiye>= miktar)
            {
                _bakiye -= miktar;
                return true;
            }
            Console.WriteLine("\a Bakiye yetersiz!");
            return false;
        }
        public bool TransferYap(IBankaHesap aliciHesap, decimal miktar)
        {
            bool sonuc=Cek(miktar);
            if (sonuc)
            {
                aliciHesap.Yatir(miktar);
            }
            return sonuc;
        }
        public void Yatir(decimal miktar)=>_bakiye+= miktar;
        public override string ToString() => $"Aktif hesap bakiye bilgisi: {_bakiye,6:C}";
    }
    internal class Program
    {
        static void Main(string[] args) 
        {

        /*
            IBankaHesap mevduatHesabi=new MevduatHesabi();
            mevduatHesabi.Yatir(100);
            mevduatHesabi.Cek(500);
            mevduatHesabi.Cek(50);
            Console.WriteLine(mevduatHesabi.ToString());

            IBankaHesap yatirimHesabi=new YatirimHesabi();
            yatirimHesabi.Yatir(100);
            yatirimHesabi.Cek(500);
            yatirimHesabi.Cek(50);
            Console.WriteLine(yatirimHesabi.ToString());
        */



            IBankaHesap mevduatHesabi=new MevduatHesabi();
            ITransfer aktifHesap=new AktifHesap();
            aktifHesap.Yatir(250);
            mevduatHesabi.Yatir(500);
            aktifHesap.TransferYap(mevduatHesabi, 200);
            Console.WriteLine(aktifHesap.ToString());
            Console.WriteLine(mevduatHesabi.ToString());

            Console.ReadKey();
        }
    }
}
