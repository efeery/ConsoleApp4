namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string e, f, g;
            Console.WriteLine("Bir dil seçiniz/Select a language(E/T)");
            string cev = Console.ReadLine().ToUpper();
            Random rnd = new Random();
            if (cev == "E")
            {
                e = "Enter the first number:";
                f = "Enter the ending number:";
                 g = "Enter the count of numbers:";

            }
            else
            {
                e = "1. sayısını giriniz:";
               f = "son sayıyı giriniz:";
                g = "Sayı adeti giriniz:";
            }

            Console.WriteLine(e);
            byte start = byte.Parse(Console.ReadLine());
            Console.WriteLine(f);
            byte end = byte.Parse(Console.ReadLine());

            Console.WriteLine(g);
            byte count = byte.Parse(Console.ReadLine());


            int[] numbers = new int[count];
            int num;
            for (int i = 0; i < numbers.Length; i++)
                // diğer elemanları başlatır.
            {
                num = rnd.Next(start, end);
                if (i == 0)
                // 0 olup olmadığını kontrol eder
                {
                    numbers[i] = num;
                }
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == num)
                    {
                        i--;
                        break;
                        //dizide tekrarlanan bir sayı bukduğunda döngüyü sonlandırmak için kullanılır. 
                    }
                    else
                    {
                        numbers[i] = num;
                    }
                    // iç içe forla sayının tekrarlanmaması sağlanır.
                }
            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}