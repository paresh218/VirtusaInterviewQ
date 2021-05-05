using System;

namespace DSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Element Size : ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] arrayVal = new int[sizeArray];
            BusinessLayer blObj = new BusinessLayer();
            blObj.InputLogic(arrayVal);
            Console.ReadLine();
        }
    }

}
