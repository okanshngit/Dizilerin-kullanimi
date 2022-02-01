using System;

namespace Dizilerin_kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar= new int[5];

            string[] isimler = {"Okan","Ozan"};


            //Dögülerle dizilerin kullanımı
            // Klavyeden girilen n sayıdaki sayıların ortalaması.

            Console.Write("Dizi uzunluğunu giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());

            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Dizinin {0}. elemanını giriniz: ", i+1);
                sayiDizisi[i]= int.Parse(Console.ReadLine());
            }

            int toplam=0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }

            Console.WriteLine("Ortalama= "+toplam/diziUzunlugu);
        }
    }
}
