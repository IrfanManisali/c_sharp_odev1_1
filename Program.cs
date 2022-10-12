using System;

namespace odev1{
    class Program {
        // Main Method
        static public void Main(String[] args)
        {
            Console.Write("Pozitif bir sayı girin:");
            int girilenSayi = Convert.ToInt32(Console.ReadLine());
            DiziIslemleri dIslem = new DiziIslemleri(girilenSayi);
            dIslem.veriIsleme();
            Console.ReadLine();
        }
    }
}
