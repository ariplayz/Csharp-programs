namespace Whatefveryouwant;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        Car jeep = new Car("red", 2020, "Jeep", "Wrangler");
        Car italy = new Car("red_green_white", 1974, "Autobella", "Piccolina");
        Car honda = new Car("blue", 2000, "Honda", "Civic");
        Car ford = new Car("black", 2010, "Ford", "Fusion");
        Car chevy = new Car("red", 2015, "Chevy", "Cruze");
        Car toyota = new Car("green", 2018, "Toyota", "Corolla");
        Car tesla = new Car("white", 2021, "Tesla", "Model S");
        Car subaru = new Car("blue", 2019, "Subaru", "Outback");
        Car mazda = new Car("red", 2017, "Mazda", "3");
        Car nissan = new Car("black", 2016, "Nissan", "Altima");
        Car volvo = new Car("blue", 2014, "Volvo", "S60");
        Car audi = new Car("red", 2013, "Audi", "A4");
        Car bmw = new Car("black", 2012, "BMW", "3 Series");
        Car mercedes = new Car("blue", 2011, "Mercedes", "C-Class");
        Car lexus = new Car("red", 2009, "Lexus", "IS");
        Car acura = new Car("black", 2008, "Acura", "TL");
        Car infiniti = new Car("blue", 2007, "Infiniti", "G35");
        Car kia = new Car("red", 2006, "Kia", "Optima");
        Car hyundai = new Car("black", 2005, "Hyundai", "Sonata");
        Car volkswagen = new Car("blue", 2004, "Volkswagen", "Passat");

        Car.HowMany();
    }
}
class Car 
{
    string color;
    int year;
    string make;
    string model;
    static int count = 0;
    public Car(string color, int year, string make, string model)
    {
        this.color = color;
        this.year = year;
        this.make = make;
        this.model = model;
        count++;
        Console.WriteLine($"Color: {this.color}. Year: {this.year}. Make: {this.make}. Model: {this.model}.");
    }
    public static void HowMany()
    {
        Console.WriteLine($"Cars Made: {count}");
    }
    public void Honk()
    {
        Console.WriteLine("Beep beep!");
    }
}
