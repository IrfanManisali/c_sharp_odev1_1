using System;

namespace odev1{
    class DiziIslemleri {

        private int diziBoyut;
        private int[] dizi;
        private int DiziBoyut {
            set{
                if(value is int) {
                    diziBoyut = value;
                }
                else {
                    diziBoyut = 2;
                }
            }
        }

        public DiziIslemleri(int diziBoyut) {
            this.DiziBoyut = diziBoyut;
        }

        private void veriAlma() {
            dizi = new int[diziBoyut];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write((i + 1) + ". sayı: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                dizi[i] = sayi;
            }
        }

        private void veriModIslemi() {
            foreach (int item in dizi)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine("Çift sayı: " + item);
                }
            }
        }

        public void veriIsleme() {
            veriAlma();
            veriModIslemi();
        }
    }
}