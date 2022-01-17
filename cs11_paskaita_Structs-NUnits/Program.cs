﻿using System;
using System.Collections.Generic;

namespace cs11_paskaita_Structs_NUnits
{
    public class Program
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

        #region Problem1_STRUCT
        // Sukurti struktūrą Mokinys su laukais vardas, pavardė, kurso pradžia
        // ir kurso pabaiga.Sukurti kintamąjį mokinys, užpildyti laukus
        // ir išvesti į konsolę

        struct Mokinys
        {
            public string name;
            public string lastName;
            public DateTime courseStart;
            public DateTime courseEnd;
        }
        #endregion

        #region Problem2_STRUCT
        // Sukurti struktūrą BibliotekosKnyga su laukais
        // ID, pavadinimas, skaitytojo vardas, paėmimo data.
        // Struktūroje sukuti metodą, kuris gražina kiek dienų knyga jau pas
        // skaitytoją. Padaryti kintamąjį rezultatą išvesti į konsolę.

        struct BibliotekosKnyga
        {
            public string ID;
            public string pavadinimas;
            public string skaitytojoVardas;
            public DateTime paemimoData;
        }
        #endregion

        #region Problem3_STRUCT
        // Sukurti struktūrą Stačiakampis su laukais ilgis ir plotis.
        // Struktūroje sukurti metodą Plotas().
        // Sukurti 3 kintamuosius stačiakampis 1, 2, 3 užpildyti laukus
        // ir išvesti plotus į konsolę.

        struct Rectangle
        {
            public float lenght;
            public float width;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("cs11_PASKAITA!");
            Console.WriteLine("Structures!");
            Console.WriteLine("NUnit tests!");

            #region TEORIJA - STRUCTURES (YouTube)

            // https://www.youtube.com/watch?v=1UV1Pd20akM

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

            //Car car1; 
            //Car car2;
            //Car car3;

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

            #region TEORIJA - STRUCTURES
            // Tai value tipo duomenų tipas
            // Leidžia sukurti paprastą kintamąjį, kuris savyje laiko kitus duomenų tipus
            // Struktūra prasideda žodžiu struct
            //
            // Struktūra - tai naujas duomenų tipas
            // 
            // Konstruktorius

            //var Student1 = new Student();
            //Student1.Name = "What?";
            //Student1.LastName = "xoxo";

            //var Student2 = new Student("Vilmantas", "Neviera", new List<int>
            //{
            //    1,2,3,4,5,6
            //});
            ////Console.WriteLine(GetAverage());
            ////
            ////
            ////Uždavinys1
            //var MokinysH = new MokinysX("Vytautas", "Surkus", DateTime.Today, DateTime.Today.AddDays(15));
            // 
            // 
            // 
            // 
            // 


            #endregion

            #region TEORIJA - NUnit tests

            #endregion

            //Problem1();
            //Problem2();
            //Problem3();
            //Problem4();
            //Problem5();
            //Problem6();
            //Problem7();
            //Problem8();
            //Problem9("Labas");
            Problem10_12.Problem10("Labas");
            Problem10_12.Problem11(10);
            //Problem12();


            #region TEORIJA - NUnit
            // Tai kodo parašymas, tam kad būtų ištestuotas kitas kodas
            // Sukurtų testų paleidimas automatiniu būdu
            // 

            #endregion
        }

        public static void Problem1()
        {
            // Sukurti struktūrą Mokinys su laukais vardas, pavardė, kurso pradžia
            // ir kurso pabaiga.Sukurti kintamąjį mokinys, užpildyti laukus
            // ir išvesti į konsolę

            Mokinys mokinys1;
            mokinys1.name = "Vytautas";
            mokinys1.lastName = "Surkus";
            mokinys1.courseStart = new DateTime(2021, 12, 20);
            mokinys1.courseEnd = new DateTime(2022, 07, 20);

            Console.WriteLine($"{mokinys1.name}, {mokinys1.lastName}, {mokinys1.courseStart}, {mokinys1.courseEnd}");

        }

        public static void Problem2()
        {
            // Sukurti struktūrą BibliotekosKnyga su laukais
            // ID, pavadinimas, skaitytojo vardas, paėmimo data.
            // Struktūroje sukuti metodą, kuris gražina kiek dienų knyga jau pas
            // skaitytoją. Padaryti kintamąjį rezultatą išvesti į konsolę.

            BibliotekosKnyga bibliotekosKnyga1;
            bibliotekosKnyga1.ID = "111";
            bibliotekosKnyga1.pavadinimas = "Whateva";
            bibliotekosKnyga1.skaitytojoVardas = "Vytautas";
            bibliotekosKnyga1.paemimoData = new DateTime (2021, 12, 31);

            Console.WriteLine($"{bibliotekosKnyga1.ID}, {bibliotekosKnyga1.pavadinimas}," +
                $"{bibliotekosKnyga1.skaitytojoVardas}, {bibliotekosKnyga1.paemimoData}");
            //Console.WriteLine(Problem2_addOn(bibliotekosKnyga1.paemimoData));
            Problem2_addOn(bibliotekosKnyga1.paemimoData);

        }

        public static void Problem2_addOn(DateTime paemimoData)
        {
            System.TimeSpan diff = DateTime.Today.Subtract(paemimoData);
            Console.WriteLine(diff.ToString("dd"));
        }

        public static void Problem3()
        {
            // Sukurti struktūrą Stačiakampis su laukais ilgis ir plotis.
            // Struktūroje sukurti metodą Plotas().
            // Sukurti 3 kintamuosius stačiakampis 1, 2, 3 užpildyti laukus
            // ir išvesti plotus į konsolę.

            var sq1 = new Problem3_StuctCtor(1, 2);
            sq1.PrintValues();

            var sq2 = new Problem3_StuctCtor(2, 3);
            sq2.PrintValues();

            var sq3 = new Problem3_StuctCtor(3, 4);
            sq3.PrintValues();
        }

        public static void Problem4()
        {
            // Sukurti struktūrą Studentas, su laukais ID ir įskaitos rezultatas (bool).
            // Sukurti studentų sąrašą (List<Studentas>,
            // pridėti 5 studentus į sąrašą.
            // Atskiroje funkcijoje išvesti sąrašą į konsolę.

            var student1 = new Problem4_StructCtor("101", true);
            var student2 = new Problem4_StructCtor("102", true);
            var student3 = new Problem4_StructCtor("103", false);
            var student4 = new Problem4_StructCtor("104", true);
            var student5 = new Problem4_StructCtor("105", false);

            Dictionary<String, bool> studentDict = new Dictionary<string, bool>();
            studentDict.Add(student1.ID, student1.Result);
            studentDict.Add(student2.ID, student2.Result);
            studentDict.Add(student3.ID, student3.Result);
            studentDict.Add(student4.ID, student4.Result);
            studentDict.Add(student5.ID, student5.Result);

            Problem4_addOn(studentDict);
        }
        public static void Problem4_addOn(Dictionary<string, bool> valuePairs)
        {
            foreach (var item in valuePairs)
            {
                Console.WriteLine(item);
            }
            
        } 

    }
}

