namespace Fisrt_General_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер строки: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            char[] arr = new char[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }



            for (int j = 0; j < size; j++)
            {
                Console.Write("{0} ", arr[j]);
            }
            Console.ReadLine();
        }
    }
}