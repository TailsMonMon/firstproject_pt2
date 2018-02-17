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

            var intVal = 1234;
            Console.WriteLine("intVal Type : {0}", intVal.GetType());   //To know what datatype it is.
            Console.WriteLine("");


                // Arrays (starts at 0)
            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("favNum 0 : {0}", favNums[0]);
            Console.WriteLine("");

            object[] randomArray = { "Anna", 23, 3.14 };    // Several datatypes in one array. String, int, double/decimal.
            Console.WriteLine("randomArray Anna : {0}", randomArray[0].GetType());
            Console.WriteLine("randomArray 23 : {0}", randomArray[1].GetType());
            Console.WriteLine("randomArray 3.14 : {0}", randomArray[2].GetType());
            Console.WriteLine("Array Size : {0}", randomArray.Length);

            for (int i = 0; i < randomArray.Length; i++)
            {
                Console.WriteLine("Array {0} : Value : {1}", i, randomArray[i]);
            }
            Console.WriteLine();

            string[] customers = { "Pelle", "Nemi", "Stig", "Berra" };
            var employees = new[] { "Ina", "Esbjörn", "My", "Eleonore" };


                // 2D Arrays
            String[,] array2D = new string[3, 4]
            {
                { " AA ", " AB ", " AC ", " AD " },
                { " BA ", " BB ", " BC ", " BD " },
                { " CA ", " CB ", " CC ", " CD " }
            };

            for (int i = 0; i < array2D.GetLength(0); i++)         // 
            {
                for (int j = 0; j < array2D.GetLength(0); j++)    //
                {
                    Console.Write(" {0} ", array2D[i, j]);         //
                }// Console.WriteLine... Will make ''break'' the table.
                Console.WriteLine();
            }
            Console.WriteLine("a value: {0}", array2D.GetValue(1, 1));   // AA = 00, AB = 01, AC = 02. BA = 10, BB = 11, BC = 12, etc. 
            Console.WriteLine();
            Console.WriteLine();
            // It is possible to make 3D arrays and even 4D arrays.


                // For each
            int[] randomNumbers = { 3, 5, 2, 1, 4 };    ///(0, 1, 2, 3, 4)
            PrintArray(randomNumbers, "ForEach");
            Console.WriteLine("1 at Index : {0}", Array.IndexOf(randomNumbers, 1));

            randomNumbers.SetValue(0, 1);   // 1 -> 0 aka 5 -> 0 (See line 64)
            Console.WriteLine();

            Array.Reverse(randomNumbers);
            PrintArray(randomNumbers, "Reverse");
            Console.WriteLine();

            Array.Sort(randomNumbers);
            PrintArray(randomNumbers, "Sort");
            Console.WriteLine();
            Console.WriteLine();


                // Copy arrays
            int[] sourceArray = { 1, 2, 3 };
            int[] destinationArray = new int[2];
            int startIndex = 0;
            int length = 2;
            Array.Copy(sourceArray, startIndex, destinationArray, startIndex, length);
            PrintArray(destinationArray, "Copy");
            Console.WriteLine();

            Array anotherArray = Array.CreateInstance(typeof(int), 10); // Creates and interger-array with a total of 10 spaces
            sourceArray.CopyTo(anotherArray, 2);    // Number of spaces before the copies

            foreach (int m in anotherArray)
            {
                Console.WriteLine("CopyAnother : {0}", m);
            }
            Console.WriteLine();


            int[] numArray = { 1, 11, 15, 22 };
            Console.WriteLine("First: 10 < {0}", Array.Find(numArray, GT10));    // Returns the first matching value
            //Console.WriteLine("All: 10 < {0}", Array.FindAll(numArray, GT10));    // Returns all matching value !NOT WORKING!
            Console.WriteLine("Index: 10 < x : {0}", Array.FindIndex(numArray, GT10));    // Returns an index of matching value
            Console.WriteLine();


                // String builder
            StringBuilder sb = new StringBuilder("Random Text");    //16 characters of space
            StringBuilder sb2 = new StringBuilder("More random text", 256); //Foced to have bigger capacity
            StringBuilder sb3 = new StringBuilder("Random Text that is longer than 16 characters.");    // When not forcing a bigger capacity, it automaticly gets bigger anyway.
            Console.WriteLine("Capacity sb : {0}", sb.Capacity);
            Console.WriteLine("Capacity sb2 : {0}", sb2.Capacity);
            Console.WriteLine("Capacity sb3 : {0}", sb3.Capacity);
            Console.WriteLine();

            //Givess the amout of assigned characters.
            Console.WriteLine("Length sb : {0}", sb.Length); 
            Console.WriteLine("Length sb2 : {0}", sb2.Length);
            Console.WriteLine("Length sb3 : {0}", sb3.Length);
            Console.WriteLine();

            sb2.AppendLine("\nEven more random text");  // Writes the original string and then the new string below.
            
            CultureInfo svSE = CultureInfo.CreateSpecificCulture("sv-SE");
            string bestCustomer = "Flask-Janne Jansson";
            sb2.AppendFormat(svSE, "Bästa kunden : {0}", bestCustomer);     // append = Lägg till
            Console.WriteLine(sb2.ToString());  // StringBulder -> String
            Console.WriteLine();

            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            Console.WriteLine();

            sb2.Clear();
            Console.WriteLine(sb2.ToString());  // It's cleard!
            Console.WriteLine();

            sb2.Append("Random Text");
            Console.WriteLine("is \'{0}\' equal to \'{1}\'? : {2}. But why?", sb, sb2, sb.Equals(sb2)); //It's false. Why?
            Console.WriteLine();

            sb2.Insert(6, " !interruption!");
            Console.WriteLine(sb2.ToString());  // To insert text in a string
            Console.WriteLine();

            sb2.Remove(6, 15);
            Console.WriteLine(sb2.ToString());  // It's back to normal
            Console.WriteLine();


                //Casting (converting)
            long number1 = 1234;
            int number2 = (int)number1;
            Console.WriteLine("Original : {0}", number1.GetType());
            Console.WriteLine("Cast : {0}",  number2.GetType());
            Console.WriteLine();


            Console.ReadLine();

        }

        static void PrintArray(int[] intArray, string message)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0} : {1}", message, k);
            }
        }
        
        private static bool GT10(int val) // "Greater than 10"
        {
            return val > 10;
        }
    }
}
