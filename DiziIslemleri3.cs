using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace odev1_3
{
    class DiziIslemleri3
    {
        private int elemanSayısı;

        private string[] dizi;

        private int ElemanSayısı {
            get
            {
                return elemanSayısı;
            }
            set
            {
                if (value is int && value > 1)
                {
                    elemanSayısı = value;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş");
                    elemanSayısı = 2;
                }
            }
        }

        public DiziIslemleri3(int elemanSayısı) {
            this.ElemanSayısı = elemanSayısı;
            this.dizi = new string[elemanSayısı];                 
        }

        private void DiziOkuma() {

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write((i + 1) + ". Eleman: ");
                dizi[i] = Console.ReadLine();
            }    

        }

        private void DiziSıralama() {

            for (int i = dizi.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(dizi[i]);
            }
        }

        public void DiziIsleme() {
            DiziOkuma();
            DiziSıralama();
        }


    }
}