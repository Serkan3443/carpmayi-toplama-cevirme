namespace Toplama_İslemiyle_İki_Sayinin_Carpimini_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Birinci sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int carpimsonucu = 0;
            for (int i = 0; i < sayi2; i++)
            {
                carpimsonucu += sayi1;
            }
            Console.WriteLine($" for ile {sayi1} X {sayi2} sayılarının = {carpimsonucu}");



            Console.WriteLine("Birinci sayıyı giriniz:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi4 = Convert.ToInt32(Console.ReadLine());
            int carpimsonucuwhile = 0;
            while (sayi3 > 0)
            {
                carpimsonucuwhile += sayi4;
                sayi3--;
            }
            Console.WriteLine($" While ile sayıların sonucu = {carpimsonucuwhile}");



            Console.WriteLine("Birinci sayıyı giriniz:");
            int sayi5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi6 = Convert.ToInt32(Console.ReadLine());
            int carpimsonucudowhile = 0;
            do
            {
                carpimsonucudowhile += sayi5;
                sayi6--;

            } while (sayi6 > 0);
            Console.WriteLine($" Do While ile sayıların sonucu= {carpimsonucudowhile}");
            Console.Read();
        }
    }
}