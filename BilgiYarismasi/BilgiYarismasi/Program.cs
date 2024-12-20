using System;

namespace BilgiYarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Kim Milyoner Olmak İster'e Hoşgeldiniz!\n");
            Console.WriteLine($"Kızınca tüküren hayvan hangisidir?\n a) Lama\n b) Deve");

            string answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                
                case "a":
                    Console.WriteLine("Doğru Cevap!");
                    score++;
                    break;
                case "b":
                    Console.WriteLine("Yanlış Cevap!");
                    break;

                default:
                    Console.WriteLine("Geçersiz bir şık seçtiniz.");
                    break;
            }

            Console.WriteLine($"Dünya'ya en yakın gezegen hangisidir?\n a) Merkür\n b) Venüs");

            string answer2 = Console.ReadLine().ToLower();



            switch (answer2)
            {

                case "a":
                    Console.WriteLine("Doğru Cevap!");
                    score++;
                    break;
                case "b":
                    Console.WriteLine("Yanlış Cevap!");
                    break;

                default:
                    Console.WriteLine("Geçersiz bir şık seçtiniz.");
                    break;
            }

            Console.WriteLine($"5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?\n a) 12\n b) 7");

            string answer3 = Console.ReadLine().ToLower();



            switch (answer3)
            {

                case "a":
                    Console.WriteLine("Doğru Cevap!");
                    score++;
                    break;
                case "b":
                    Console.WriteLine("Yanlış Cevap!");
                    break;

                default:
                    Console.WriteLine("Geçersiz bir şık seçtiniz.");
                    break;
            }



            if (score >= 2)
            {
                Console.WriteLine("Tebrikler! 1 Milyon TL kazandınız!");
            }
            else
            {
                Console.WriteLine("Üzgünüz, büyük ödülü kazanamadınız.");
            }


































        }
    }
}