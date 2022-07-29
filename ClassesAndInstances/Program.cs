using System;

namespace ClassesAndInstances
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //var car = new Transport();

            //car.RoadType = "Ground";

            //car.BodyType = "Jeep";

            //car.Transmission = "Mehcanic";

            //car.Color = "Green";

            //car.Model = "Wrangler";

            //car.WheelCount = 4;
            //var newCar = new Transport();

            //var car = new Transport("Ground", "Jeep", 4, "Mehcanic", "Green", "Wrangler");



            //var aleksandre = new Human("Aleksandre", 180, "Developer", 23, "Male", true, new Transport());

            //aleksandre.BuyCar(car);

            //aleksandre.AskIfHasTransport();

            //var humanWithOnlyCar = new Human("Ground", "Jeep", 4, "Mehcanic", "Green", "Wrangler");

            //humanWithOnlyCar.HasCar = true;

            //humanWithOnlyCar.AskIfHasTransport();

            //Console.WriteLine($"Car model is : {car.Model}");

            //car.StartEngine();

            //car.Honk();

            //car.EndEngine();





            //var mercedes = new Transport("Ground", "Sedan", 4, "Mechanic", "Blue", "CLS");

            //var oldMercedes = new Transport(mercedes);


            //var defaultCar = new Transport();



            //var aleksandre = new Human("Aleksandre", 180, "Developer", 23, "Male", true, new Transport());
            //aleksandre.HumanProfession();


            var mercedes = new Transport("Sea", "Sedan", 4, "Mechanic", "Blue", "CLS");


            Console.WriteLine(mercedes.getRoadType());
        }
    }

    public class Transport
    {
        private string RoadType { get; set; } = "Ground";

        private string BodyType { get; set; }

        public int WheelCount { get; set; }

        public string Transmission { get; set; }

        public string Color { get; set; }

        public string Model { get; set; }

        public Transport()
        {
        }

        public Transport(string roadType, 
                         string bodyType, 
                         int wheelCount, 
                         string transmission, 
                         string color, 
                         string model)
        {
            RoadType = roadType;
            BodyType = bodyType;
            WheelCount = wheelCount;
            Transmission = transmission;
            Color = color;
            Model = model;
        }

        public Transport(Transport transport)
        {
            RoadType = transport.RoadType;
            WheelCount = transport.WheelCount;
            Transmission = transport.Transmission;
        }

        public void Honk()
        {
            Console.WriteLine(" Honk Sound!!! ");
        }

        public void StartEngine()
        {
            Console.WriteLine(" Engine Started ");
        }

        public void EndEngine()
        {
            Console.WriteLine(" Engine Shutted down");
        }

        public string getRoadType()
        {
            return RoadType;
        }

        public void setRoadType(string roadType)
        {
            RoadType = roadType;
        }

        public string getBodyType()
        {
            return BodyType;
        }

        public void setBodyType(string bodyType)
        {
            BodyType = bodyType;
        }

        ~Transport()
        {
            
        }
    }

    public class Human
    {
        public string Name { get; set; }
        public const string Profession = "Developer";
        public int Height { get; set; }
        //public string Profession { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool HasCar { get; set; }
        public Transport Transport { get; set; }

        public string Email { get; set; }

        public Human()
        {
        }

        public Human(string name, int height, string profession, int age, string gender, bool hasCar, Transport car)
        {
            Name = name;
            Height = height;
            //Profession = profession;
            Age = age;
            Gender = gender;
            HasCar = hasCar;
            Transport = new Transport(car.getRoadType(), 
                                      car.getBodyType(), 
                                      car.WheelCount, 
                                      car.Transmission, 
                                      car.Color, 
                                      car.Model);
        }

        public void Speak(string word)
        {
            Console.WriteLine($"{ Name } Said {word}");
        }

        public void AskIfHasTransport()
        {
            Console.WriteLine(HasCar ? $"Yes i have a Car Model {Transport.Model}" : "No, I dont have a car");
        }

        public void BuyCar(Transport car)
        {
            HasCar = true;

            Transport = car;
        }

        public void HumanProfession()
        {
            Console.WriteLine(Profession);
        }
    }
}