namespace U3_W1_D1
{
    class Athlete
    {
        string name;
        string surname;
        int age;
        string sport;
        public string Name {  get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } } 
        public string Sport { get { return sport; } set { sport = value; } }

    }
    class Employee 
    {
        string name;
        string surname;
        int age;
        string company;
        public string Name { get { return name; } set { name= value; } }
        public string Surname { get {return surname; } set {surname = value; } }
        public int Age { get { return age;} set { age = value; } }
        public string Company { get { return company; } set { company = value; } }
   

    }
    class Animal 
    {
        string name;
        string race;
        public string Name { get { return name; } set{ name= value; } }
        public string Race { get { return race; } set { race = value; } }

    }

    class Car 
    {
        string brand;
        string model;
        string color;
        public string Brand { get { return brand; } set { brand = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Color { get { return color; } set { color = value; } }    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Athlete athlete = new Athlete();
            athlete.Name = "Pippo";
            athlete.Surname = "Pelo";
            athlete.Age = 22;
            athlete.Sport = "Volley";

            Console.WriteLine($"Name: {athlete.Name}, Surname: {athlete.Surname}, Age: {athlete.Age}, Sport: {athlete.Sport}");


            Employee employee = new Employee();
            employee.Name = "Pippo";
            employee.Surname = "Pelo";
            employee.Age = 22;
            employee.Company = "Epicode";

            Console.WriteLine($"Name: {employee.Name}, Surname: {employee.Surname}, Age: {employee.Age}, Sport: {employee.Company}");


            Animal animal = new Animal();
            animal.Name = "Pippo";
            animal.Race = "Cane";

            Console.WriteLine($"Name: {animal.Name}, Race: {animal.Race}");

            
            Car car = new Car();
            car.Brand = "Fiat";
            car.Model = "Panda";
            car.Color = "red";

            Console.WriteLine($"Brand: {car.Brand}, Model: {car.Model}, Color {car.Color}");
        }
    }
}
