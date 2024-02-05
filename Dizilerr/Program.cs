using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizilerr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayi, kontrol = 0;
            int toplam = 0;
            Console.Write("Bir sayı giriniz :");
            sayi = Convert.ToInt32(Console.ReadLine());


            int[,] dizi = new int[10,10];
            for(int i = 0;i<10;i++)
            { 
              for(int j = 0;j<10;j++)
                {
                    dizi[i, j] = rnd.Next(100);
                    Console.Write(dizi[i, j]+"  ");
                }
              Console.WriteLine("     ");

            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (sayi == dizi[i, j])
                    {
                        kontrol++;
                        toplam = toplam + sayi;


                    }     

               
                }
               
            }
          
            if (kontrol == 0)
            {
                Console.WriteLine("Sayı dizi içinde bulunamadı...");
            }
            else
            {
                Console.WriteLine("Bu sayı dizide {0} adet var", kontrol);
                Console.WriteLine("Bu sayının dizideki toplamı:{0}", toplam);
            }
          

            Console.ReadKey();
      
        }
    }
}
