using System;

namespace integerAlgoritma
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Çift Sayı  Giriniz:");
            int Sayı = Convert.ToInt32(Console.ReadLine());
            int[] sayıListesi = new int[Sayı];

            if (Sayı % 2 == 0)
            {
                Console.WriteLine($" {Sayı}. tane sayı Giriniz: ");
                for (int i = 0; i < sayıListesi.Length; i++)
                {
                    Console.WriteLine("{0}.sayısını giriniz:", i + 1);
                    sayıListesi[i] = Convert.ToInt32(Console.ReadLine());

                }
                for (int i = 0; i < sayıListesi.Length; i+=2)
                {
                    if (sayıListesi[i]==sayıListesi[i+1])
                    {
                        int Toplam = sayıListesi[1] + sayıListesi[i+1];
                        Console.WriteLine(" "+Toplam*Toplam +" ");
                    }
                    
                    else
                    {
                        int toplam = sayıListesi[i] + sayıListesi[i + 1];
                        Console.WriteLine(" " + toplam + "");
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatalı Tuşlama Yaptınız.");
            }
        }
    }
}