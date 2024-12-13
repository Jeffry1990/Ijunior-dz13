namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameImput;
            string symbol = "";
            string middleString;

            char symbolImput;

            Console.Write("Введите имя: ");
            nameImput = Console.ReadLine();

            Console.Write("Введите символ: ");
            symbolImput = Convert.ToChar(Console.ReadLine());
            middleString = $"{symbolImput}{nameImput}{symbolImput}";

            Console.SetCursorPosition(0, 3);

            for (int i = 0; i < middleString.Length; i++)
            {
                symbol += symbolImput;
            }

            Console.WriteLine($"{symbol}\n{middleString}\n{symbol}");
            Console.ReadKey();
        }
    }
}
