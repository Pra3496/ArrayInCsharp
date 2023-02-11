using System.Xml.Linq;

namespace Arrays_In_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declaration of arrays
            
            int[] myNum = { 1, 2, 3, 4 };
            float[] myNum2 = { 1.25F, 0.2F };
            double[] myNum3 = { 1.0234D, 5.69876D, 5.96321D };


            string[] myNam = { "pranav", "anil", "waghmare" };

            //Indexing of array

            Console.WriteLine(myNum[0]);
            myNum[0] = 77;
            Console.WriteLine(myNum[0]);

            Console.WriteLine(myNam[0]);

            

            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            object[] cars1 = new object[] {1,2,3,4,5};

            // Create an array of four elements without specifying the size 
            string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            Console.WriteLine(cars.Length);


            //Display Elements of Array

            for (int i = 0; i < cars1.Length; i++)
            {
                object o = cars1[i];

                Console.WriteLine();
            }


            
            foreach (var i in cars1)
            {
                Console.WriteLine(i);
            }
            */

            //

            int[] iArr = { 1, -1, 2, 5, 1 };

            Arrays obj = new Arrays(iArr);



            Console.Write("Elements of Array");
            obj.prntArr();
            Console.WriteLine("\n");

            Console.Write("\nLength of Array : ");
            Console.Write(obj.getLength());
            Console.WriteLine("\n");


            Console.Write("Maximum and Minimum of Array");
            obj.getMaxAndMin();
            Console.WriteLine("\n");

            Console.Write("Count of Digits of Element Array");
            obj.getDigitCnt();
            Console.WriteLine("\n");


            Console.Write("Negative Elements of Array");
            obj.getNegative();
            Console.WriteLine("\n");

            Console.Write("Sum of Array");
            obj.getSumOfArray();
            Console.WriteLine("\n");

            Console.Write("Sorted Array");
            obj.sortArray();
            Console.WriteLine("\n");






        }
    }
}