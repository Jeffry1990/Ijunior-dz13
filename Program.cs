namespace ConsoleApp52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameImput;

            char symbolImput;

            Console.Write("Введите имя: ");
            nameImput = Console.ReadLine();

            Console.Write("Введите символ: ");
            symbolImput = Convert.ToChar(Console.ReadLine());

            Console.SetCursorPosition(0, 3); 

            for (int i = 0; i < nameImput.Length + 2; i++)
            {
                Console.Write(symbolImput);
            }

            Console.WriteLine($"\n{symbolImput}{nameImput}{symbolImput}");

            for (int i = 0; i < nameImput.Length + 2; i++)
            {
                Console.Write(symbolImput);
            }

            Console.ReadKey();
        }
    }
}
