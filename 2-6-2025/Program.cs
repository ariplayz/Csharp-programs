namespace AdventOfCodeComputer
{
#nullable disable
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the program: ");
            string program = Console.ReadLine();

            Console.WriteLine("Do you want the output of value 0 or noun and verb? (Enter 'value' or 'grammar'): ");
            string outputPreference = Console.ReadLine().ToLower();

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Computer computer = new Computer(program);
                    computer.Run();

                    if (computer.GetValue(0) == 19690720)
                    {
                        if (outputPreference == "value")
                        {
                            Console.WriteLine(computer.GetValue(0));
                        }
                        else if (outputPreference == "index")
                        {
                            Console.WriteLine(i * 100 + j);
                        }
                        return;
                    }
                }
            }
        }
    }
}
