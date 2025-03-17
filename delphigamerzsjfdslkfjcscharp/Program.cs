namespace delphigamerzsjfdslkfjcscharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print("Hello, World!");
            print(5);
            print(10 > 2);
        }
    
        static void print(string message)
        {
            Console.WriteLine(message);
        }
        static void print(int num)
        {
            Console.WriteLine(num);
        }
        static void print(bool yesno)
        {
            if (yesno)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
