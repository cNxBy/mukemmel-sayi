namespace mükemmel_sayı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mükemmel Sayı İçin Değer Giriniz ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine( toplam = toplam + i);

                }

            }
            if (toplam == sayi)
            {
                Console.WriteLine(toplam);
            }
            else 
            {
                Console.WriteLine("Sayı Mükemmel Değil");
            }


            Console.ReadLine();

        }
    }
}