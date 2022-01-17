using System;

namespace cs11_paskaita_Structs_NUnits
{
    class Program
    {
        #region TEORIJA - YouTube

        struct Car
        {
            public string Brand;
            public string Model;
            public int Year;
            public float Price;
        }


        struct Employee
        {
            public string FristName;
            public string LastName;
            public float HourlyWage;
            public bool CompletedTraining;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("cs11_PASKAITA!");
            Console.WriteLine("Structures!");
            Console.WriteLine("NUnit tests!");

        #region TEORIJA - STRUCTURES (YouTube)

        https://www.youtube.com/watch?v=1UV1Pd20akM

            // What they are?
            // Easyest way to explain structs is to think of them as custom data
            // types;
            // Example – a car. You cant just use a string to represent a car,
            // Car can have:
            // * Brand (string)
            // * Model (string)
            // * Brand (int)
            // * Brand (float)
            // What makes a car is much more complicated, here comes a struct

            Car car1; 
            Car car2;
            Car car3;

            //Console.WriteLine("What's the brand?");
            //car1.Brand = Console.ReadLine();
            //Console.WriteLine("Whats the model?");
            //car1.Model = Console.ReadLine();
            //Console.WriteLine("Whats the manufacture year?");
            //car1.Year = int.Parse(Console.ReadLine());
            //Console.WriteLine("Whats the price?");
            //car1.Price = float.Parse(Console.ReadLine());

            Employee employee1;

            employee1.FristName = "Vytautas";
            employee1.LastName = "Surkus";
            employee1.HourlyWage = 10f;
            employee1.CompletedTraining = true;


            // 
            // 
            // 

            #endregion
        }
    }
}

