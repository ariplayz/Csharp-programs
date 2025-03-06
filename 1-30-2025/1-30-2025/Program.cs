//using Microsoft.VisualBasic;

namespace _1_30_2025
{
#nullable disable
  
    
    class Program
    {

        static void Main(string[] args)
        {

            int numberOfTrees = 10;

            if (numberOfTrees < 5)
            {
                Console.WriteLine("Plant more trees.");
            }
            else if (numberOfTrees == 5)
            {
                Console.WriteLine("You have 5 trees.");
            }
            else
            {
                Console.WriteLine("Very tree. Much green. Much wow.");
            }            
            
            Car jeep = new Car(1999);

            Console.WriteLine($"Year is: {jeep.Year}");

            while (jeep.Name == null)
            {
                Console.Write("Enter a name: ");
                jeep.Name = Console.ReadLine();
                Console.WriteLine($"Name is: {jeep.Name}");
            }
        }
   
    }
    class Car
    {

        int year;
        public int Year
        {
            get { return year; }
            set {
                if (value <= 2025 && value > 1950)
                {
                    year = value;
                }
                }
        }


        string name;
        public string Name
        {
            get { return name; }
            set {
                    if (value.Length <= 8 && value.Length >= 3)
                    {
                        name = value;
                    }
                    else
                    {
                    Console.WriteLine("Invalid Name.");
                    }
            }
        }


        public Car(int year)
        {
            this.year = year;
        }
      
        
        public void Stupidity()
        {
            Console.WriteLine("Do not eat the pistacio ice cream!! IT HAS TURNED!!!!");
        }
  
    
    }


}
