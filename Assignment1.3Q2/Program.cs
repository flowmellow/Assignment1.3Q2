/*
2.Write a program in C# to read n number of values in an array and display it in reverse order.
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2
*/

namespace Assignment1._3Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //****Original Way I had****
            //int[] testDataNumbers = { 2, 5, 7 };

            //Console.WriteLine("The values store into the array are: ");
            //for (int i = 0; i < testDataNumbers.Length; i++)
            //{                
            //    Console.WriteLine(testDataNumbers[i]);
            //}

            //Array.Reverse(testDataNumbers);

            //Console.WriteLine("The values store into the array in reverse are: ");
            //foreach (int i in testDataNumbers)
            //{   
            //    Console.WriteLine(i);

            //}

            int[] practice = { 2, 5, 7};
            int pLength = practice.Length;
            int temp;

            Console.WriteLine("The values store into the array are: ");
            for (int i = 0; i < practice.Length; i++)
            {
                Console.WriteLine(practice[i]); 
            }

            Console.WriteLine("The values store into the array in reverse are: ");
            for (int i = 0;i < (pLength / 2); i++)
            {
                temp = practice[i]; 
                practice[i] = practice[pLength - 1 - i];                 
                practice[pLength - 1 - i] = temp;                
            }


            foreach (int i in practice)
            {
                Console.WriteLine(i);
            }


        }
    }
}
