using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    class randombime
    {
        public int sayıbul(int x)
        {
            Random random = new Random();
            int rastgeleSayi = random.Next(1, 11);
            int tahmin = 0;
            int tahminhakki = 3;
            Console.WriteLine("1 ile 10 arasında bir sayıyı tahmin edin:");
            while (tahminhakki > 0)
            {
                if (tahmin == rastgeleSayi)
                {
                    Console.WriteLine("Tebrikler!Doğru tahmin ettiniz");
                    break;
                }
                else
                    tahminhakki--;
                if (tahminhakki < 0)
                {
                    Console.WriteLine("Yanlış tahmin ettiniz.Kalan tahmin hakkınız:" + tahminhakki);
                }
                else
                {
                    Console.WriteLine("Tahmin hakkınız bitti.Doğru cevap:" + rastgeleSayi);
                }
            
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                }
            }
            Console.WriteLine("Oyun bitti .İyi günler!");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}

