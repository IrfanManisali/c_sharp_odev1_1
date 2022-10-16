using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace odev1_4
{
    class DiziIslemleri4
    {
        private string giris;

        private int kelimeSayisi;

        private int harfSayisi;

        public DiziIslemleri4(string giris) {
            this.giris = giris;
        }

        public void SayiIslemleri()
        {
            kelimeSayisi = 1;
            harfSayisi = 0;

            for (int i = 0; i < giris.Length; i++)
            {
                harfSayisi++;

                if (giris[i] == ' ')
                {
                    kelimeSayisi++;
                    harfSayisi--;
                }
            }

        }

        public void Sonuc() {
            SayiIslemleri();
            Console.WriteLine("Kelime Sayısı: " + kelimeSayisi);
            Console.WriteLine("Harf Sayısı: " + harfSayisi);
        }

    }
}