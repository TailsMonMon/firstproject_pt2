using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //      Program assumes what datatype it is
            var intVal = 1234;  // 32bit
            Console.WriteLine("{0} is a : {1}", 
                intVal, intVal.GetType());      // To know what datatype it is.

            var intVal2 = 3.14159265359; // Double
            Console.WriteLine("{0} is a : {1}", 
                intVal2, intVal2.GetType());

            var intVal3 = 12345654321; // 64bit
            Console.WriteLine("{0} is a : {1}", 
                intVal3, intVal3.GetType());

            var intVal4 = "Hellu"; // String
            Console.WriteLine("{0} is a : {1}", 
                intVal4, intVal4.GetType());

            var intVal5 = true; // Boolean
            Console.WriteLine("{0} is a : {1}",
                intVal5, intVal5.GetType());
            
            Console.WriteLine(""); 


            //      Arrays 
            int[] favNums = new int[3];
            favNums[0] = 12;    // 0 = 12
            Console.WriteLine("favNum 0 : {0}", favNums[0]);
            Console.WriteLine("");


            object[] randomArray = { "Anna", 23, 3.14 };    // Several datatypes in one array. String, int, double/decimal.

            Console.WriteLine("randomArray Anna : {0}", randomArray[0].GetType());  // First datatype
            Console.WriteLine("randomArray 23 : {0}",   randomArray[1].GetType());  // Second datatype
            Console.WriteLine("randomArray 3.14 : {0}", randomArray[2].GetType());  // Third datatype
            Console.WriteLine("Array Size : {0}",       randomArray.Length);

            for (int i = 0; i < randomArray.Length; i++)    // i++ is a loop
            {
                Console.WriteLine("Array {0} : Value : {1}", i, randomArray[i]);
            }
            Console.WriteLine();



            //      1D Array     //  0        1       2       3       4     5
            string[] array1D = { "Pelle", "Nemi", "Stig", "Berra", "My", "Ina" };
            for (int i = 0; i < array1D.GetLength(0); i++)  // i is equal to 0; When array1D is bigger than i; do i++.
            {                                               // i is what object the console will start write. 
                Console.Write(" {0} ", array1D[i]);
            }
            Console.WriteLine();
            Console.WriteLine();


            var another1DArray = new[] { "Pelle", "Nemi", "Stig", "Berra", "My", "Ina" };
            for (int i = 2; i < another1DArray.GetLength(0); i++)   // "Hides" int 0 and 1 since i = 2.
            {
                Console.Write(" {0} ", another1DArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine();


            //      2D Array
            String[,] array2D = new string[3, 4]
            {
                { " AA ", " AB ", " AC ", " AD " },
                { " BA ", " BB ", " BC ", " BD " },
                { " CA ", " CB ", " CC ", " CD " }
            };

            for (int i = 0; i < array2D.GetLength(0); i++)  // 
            {
                for (int j = 0; j < array2D.GetLength(0); j++)  //
                {
                    Console.Write(" {0} ", array2D[i, j]);         //
                }// Console.WriteLine... Will "break" the table.
                Console.WriteLine();
            }
            Console.WriteLine("a value: {0}", array2D.GetValue(1, 1));   // AA = 00,  BB = 11, CC = 22, etc.
            Console.WriteLine();
            Console.WriteLine();
            // It is possible to make 3D arrays and even 4D arrays.


            /*//    3D Array
            String[,,] array3D = new string[3, 4, 2]
            {
                { { " AA ", "1" }, { " AB ", "2" },  { " AC ", "3" },  { " AD ", "4" } },
                { { " BA ", "5" }, { " BB ", "6" },  { " BC ", "7" },  { " BD ", "8" } },
                { { " CA ", "9" }, { " CB ", "10" }, { " CC ", "11" }, { " CD ", "12" } }
            };

            for (int i = 0; i < array3D.GetLength(0); i++)  // 
            {
                for (int j = 0; j < array3D.GetLength(0); j++)  //
                {
                    for (int k = 0; k < array3D.GetLength(0); k++)  //
                    {
                        Console.Write(" {0} ", array3D[i, j, k]);         // Error: System.IndexOutOfRangeException
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            */


            //      For each
            int[] randomNumbers = { 3, 5, 2, 1, 4 };    // (0, 1, 2, 3, 4)
            PrintArray(randomNumbers, "ForEach");
            Console.WriteLine("1 is at Index : {0}", Array.IndexOf(randomNumbers, 1));

            randomNumbers.SetValue(0, 1);   // Value 1 -> 0. So 5 -> 0

            Array.Reverse(randomNumbers);
            PrintArray(randomNumbers, "Reverse");   // Reverse the order of the integers

            Array.Sort(randomNumbers);
            PrintArray(randomNumbers, "Sort");  // Sort the order of the integers
            Console.WriteLine();


            //      Copy arrays
            int[] originalArray = { 01, 02, 03, 04, 05 };  // The original array. Obviosly.
            int[] copiedArray = new int[2];     //
            int   startIndex = 0;               // At what index it will start to copy.
            int   length = 2;                   // 
            Array.Copy(originalArray, startIndex, copiedArray, startIndex, length); // It _has_ to be in that order.
            PrintArray(originalArray, "Original");
            PrintArray(copiedArray, "Copy");

            Array anotherArray = Array.CreateInstance(typeof(int), 10); // Creates and interger-array with a total of 10 spaces
            originalArray.CopyTo(anotherArray, 3);    // Number of spaces, aka 0 before the actual copy.

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyAnother : {0}", m);
            }
            Console.WriteLine();


            int[] numArray = { 1, 5, 7, 11, 15, 22 };
            var result = Array.FindAll(numArray, GT10);     // To first fint all the numbers
            Console.WriteLine("All: 10 < {0}", string.Join(" ", result));   // Joins all matching values
            Console.WriteLine("First: 10 < {0}", Array.Find(numArray, GT10));    // Returns the first matching value
            Console.WriteLine("Index: 10 < x : {0}", Array.FindIndex(numArray, GT10));    // Returns an index of matching value
            Console.WriteLine();


                // String builder
            StringBuilder sb = new StringBuilder("Random Text");    // 16 characters of space
            Console.WriteLine("Capacity sb : {0}", sb.Capacity);    
            Console.WriteLine("Length sb   : {0}", sb.Length);      // Givess the amout of assigned characters.
            Console.WriteLine();

            StringBuilder sb2 = new StringBuilder("More random text", 256);     // Foced to have bigger capacity
            Console.WriteLine("Capacity sb2 : {0}", sb2.Capacity);
            Console.WriteLine("Length sb2   : {0}", sb2.Length);
            Console.WriteLine();

            StringBuilder sb3 = new StringBuilder("Random Text that is longer than 16 characters.");    // When not forcing a bigger capacity, it automaticly gets bigger anyway.
            Console.WriteLine("Capacity sb3 : {0}", sb3.Capacity);
            Console.WriteLine("Length sb3   : {0}", sb3.Length);
            Console.WriteLine();
            
            sb2.AppendLine("\nEven more random text under the original");  // Writes the original string and then the new string below.
            Console.WriteLine();
            

            CultureInfo svSE = CultureInfo.CreateSpecificCulture("sv-SE");
            string bestCustomer = "Flask-Janne Jansson";
            sb2.AppendFormat(svSE, "Bästa kunden : {0}", bestCustomer);     // append = Lägg till
            Console.WriteLine(sb2.ToString());  // StringBulder -> String
            Console.WriteLine();

            sb2.Replace("text", "characters");  // Replaces "text" with "characters".
            Console.WriteLine(sb2.ToString());
            Console.WriteLine();

            sb2.Clear();
            Console.WriteLine(sb2.ToString());  // It's cleard! Therefore, it's blank.
            Console.WriteLine();

            sb2.Append("This text");
            Console.WriteLine("is \'{0}\' equal to \'{1}\'? : {2}.", sb, sb2, sb.Equals(sb2));     //It's false. Why?
            Console.WriteLine();

            sb2.Insert(4, " !interruption!");
            Console.WriteLine(sb2.ToString());  // To insert text in a string
            Console.WriteLine();

            sb2.Remove(6, 15);
            Console.WriteLine(sb2.ToString());   // It's back to normal
            Console.WriteLine();


                //Casting (converting)
            long number1 = 1234;
            int number2 = (int)number1;     // Converts the number from 64-bit to 32-bit. 'string -> number' does not work.
            Console.WriteLine("Original : {0}", number1.GetType());
            Console.WriteLine("Cast : {0}",  number2.GetType());
            Console.WriteLine();


            Console.ReadLine();
        }

        static void PrintArray(int[] intArray, string message)
        {
            foreach(int number in intArray)
            {
                Console.WriteLine("{0} : {1}", message, number);    // foreach layout
            }
        }
        
        private static bool GT10(int val)   // "Greater Than 10"
        {
            return val > 10;
        }
    }
}
