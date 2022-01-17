using System;
using System.Collections.Generic;

namespace cs11_paskaita_Structs_NUnits
{
	public struct Problem3_StuctCtor
	{
        // Sukurti struktūrą Stačiakampis su laukais ilgis ir plotis.
        // Struktūroje sukurti metodą Plotas().
        // Sukurti 3 kintamuosius stačiakampis 1, 2, 3 užpildyti laukus
        // ir išvesti plotus į konsolę.

        public float Lenght;
        public float Width;

        public Problem3_StuctCtor(float lenght, float width)
        {
            Lenght = lenght;
            Width = width;
        }
        public void PrintValues()
        {
            Console.WriteLine($"lenght is {Lenght}");
            Console.WriteLine($" width is {Width}");
            Console.WriteLine($"  area is {AreaCalc(Lenght, Width)}");
            Console.WriteLine();
        }
        public float AreaCalc(float lenght, float width)
        {
            return lenght * width;
        }
    }

    public struct Problem4_StructCtor
    {
        // Sukurti struktūrą Studentas, su laukais ID ir įskaitos rezultatas (bool).
        // Sukurti studentų sąrašą (List<Studentas>,
        // pridėi 5 studentus į sąrašą.
        // Atskiroje funkcijoje išvesti sąrašą į konsolę.

        public string ID;
        public bool Result;
        

        public Problem4_StructCtor(string iD, bool result)
        {
            ID = iD;
            Result = result;
        }

    }
}

