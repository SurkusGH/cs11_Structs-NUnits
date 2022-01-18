using cs11_paskaita_Structs_NUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test_If_Lists_Work()
        {
            // Arange
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
            // Act
            int counter = studentDict.Count();

            // Asert
            Assert.Equal(5, counter);
        }

        [Fact]
        public void Test_if_Calculation_is_correct()
        {
            // Arange
            var sq1 = new Problem3_StuctCtor(1, 2);
            var sq2 = new Problem3_StuctCtor(2, 3);
            var sq3 = new Problem3_StuctCtor(3, 4);
            // Act
            float A = sq1.AreaCalc(1, 2);
            float B = sq2.AreaCalc(2, 3);
            float C = sq3.AreaCalc(3, 4);
            // Asert
            Assert.Equal(2f, A);
            Assert.Equal(6f, B);
            Assert.Equal(12f, C);
        }
        [Fact]

        public void Test_If_String_Reverse_Is_Working()
        {
            // Arange
            string word1 = Problem10_12.Problem10("Labas");
            string word2 = Problem10_12.Problem10("a");
            string word3 = Problem10_12.Problem10("");

            // Act
            char[] chars1 = word1.ToCharArray();
            Array.Reverse(chars1);
            char[] chars2 = word2.ToCharArray();
            Array.Reverse(chars2);
            char[] chars3 = word3.ToCharArray();
            Array.Reverse(chars3);

            // Asert
            Assert.Equal("sabaL", word1);
            Assert.Equal("a", word2);
            Assert.Equal("", word3);

        }
    }
}
