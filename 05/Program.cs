using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                while (0 == 0)
                {



                    Console.WriteLine("(Dikdörtgenin Alanını Hesaplamak İçin 1'e Basınız) / (Dikdörtgenin Çevresini Hesaplamak İçin 2'ye Basınız)");
                    int secenek = Convert.ToInt32(Console.ReadLine());

                    dikdortgen dikdörtgen = new dikdortgen();

                    if (secenek == 1)
                    {
                        Console.WriteLine("Yüksekliğini ve Uzunluğunu Giriniz ;");
                        dikdörtgen.b = Convert.ToInt32(Console.ReadLine());
                        dikdörtgen.h = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Dikdörtgenin Alanı : " + alanhesapla(dikdörtgen.b, dikdörtgen.h));
                    }

                    else if (secenek == 2)
                    {
                        Console.WriteLine("Yüksekliği ve Uzunluğunu Giriniz ;");
                        dikdörtgen.b = Convert.ToInt32(Console.ReadLine());
                        dikdörtgen.h = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Dikdörtgenin Çevresi :  " + cevrehesapla(dikdörtgen.b, dikdörtgen.h));
                    }

                    {
                        break;
                    }

                }

                static int alanhesapla(int b, int h)
                {
                    return b * h;
                }

                static int cevrehesapla(int b, int h)
                {
                    int c = 2 * b + 2 * h;
                    return c;
                }

            }
        }



    }
}
