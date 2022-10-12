using System;

namespace odev1_2{
    class DiziIslemleri2 {

        private int diziBoyut;
        private int mod; 
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

        private int Mod {
            set{
                if(value is int) {
                    mod = value;
                }
                else {
                    mod = 2;
                }
            }
        }

        public DiziIslemleri2(int diziBoyut, int mod) {
            this.DiziBoyut = diziBoyut;
            this.Mod = mod;
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
                if (item % mod == 0)
                {
                    Console.WriteLine(item + " % " + mod + " = 0");
                }
            }
        }

        public void veriIsleme() {
            veriAlma();
            veriModIslemi();
        }
    }
}