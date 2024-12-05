namespace ConsoleApp9
{
    internal class Program
    {
        public static int CountBits(int num)
        {
            string binarRepresentation = Convert.ToString(num, 2);

            int count = 0;

            for (int i = 0; i < binarRepresentation.Length; i++)
            {
                if (binarRepresentation[i] == '1')
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для подсчета значащих битов: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int num))
            {
                int count = CountBits(num);
                Console.WriteLine($"Количество значащих битов в числе {num} равно: {count}");
            }
            else
            {
                Console.WriteLine("Ошибка. Введено не коректное число.");
            }
        }
    }
}
