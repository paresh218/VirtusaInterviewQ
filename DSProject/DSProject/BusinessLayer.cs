using System;
using System.Collections.Generic;
using System.Text;

namespace DSProject
{
    public class BusinessLayer
    {
        public bool InputLogic(int[] arrayValues)
        {
            try
            {
                Console.WriteLine("Press any key to continue ! \n Warning If you press 'e' then it will exit !");
                char exit = 'e';
                while (Convert.ToChar(Console.ReadLine()) != exit)
                {    
                    Console.WriteLine("Enter the array Elements : ");

                    for (int i = 0;i < arrayValues.Length; i++)
                    {
                        arrayValues[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Array limit is full, you Still want to Continue[y/n] ?");
                    Char response = Convert.ToChar(Console.ReadLine());
                    if(response == 'y')
                    {
                        for (int j = 0; j < arrayValues.Length; j++)
                        {
                            int newInput = Convert.ToInt32(Console.ReadLine());
                            if (newInput != arrayValues[j])
                            {
                                arrayValues[j] = newInput;
                            }
                            else
                            {
                                arrayValues[j] = arrayValues[j];
                            }
                        }
                    }
                    if(response == 'n')
                    {
                        break;
                    }                   
                }
                Console.WriteLine("Do you want to display element of array ? [y] \n else press any key to exit !");
                int displayInput = Convert.ToChar(Console.ReadLine());
                if (displayInput == 'y')
                {
                    DisplayLogic(arrayValues);
                }

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error - BusinessLayer -> InputLogic() -> "+ex.Message);
                return false;
            }
        }
        public void DisplayLogic(int[] arrayDisplay)
        {
            for (int j = 0; j < arrayDisplay.Length; j++)
            {
                Console.WriteLine(arrayDisplay[j]);
            }
        }
    }
}
