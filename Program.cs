namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameImput;
            string symbol = "";

            char symbolImput;

            Console.Write("Введите имя: ");
            nameImput = Console.ReadLine();

            Console.Write("Введите символ: ");
            symbolImput = Convert.ToChar(Console.ReadLine());

            Console.SetCursorPosition(0, 3);

            for (int i = 0; i < nameImput.Length+2; i++)
            {
                symbol += symbolImput;
            }

            Console.WriteLine($"{symbol}\n{symbolImput}{nameImput}{symbolImput}\n{symbol}");
            Console.ReadKey();
        }
    }
}
    