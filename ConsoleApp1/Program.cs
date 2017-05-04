using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int menuChoice = 0;
        int numberToAdd = 0;
        int positionToAdd = 0;
        int positionToDisplay = 0;

        static void Main(string[] args)
        {
            Program program = new Program();
            IntegerTable integerTable = new IntegerTable();

            while (true)
            {
                System.Console.WriteLine("\n***MENU***\n");
                System.Console.WriteLine("1 - Add integer number to table");
                System.Console.WriteLine("2 - Display table");
                System.Console.WriteLine("3 - Exit program");

                program.menuChoice = Convert.ToInt32(Console.ReadLine());

                while (!(program.menuChoice != 1 || program.menuChoice != 2))
                {
                    System.Console.WriteLine("NOOO YOU CAN ONLY TAP 1 OR 2!\n");
                    System.Console.WriteLine("\n***MENU***\n");
                    System.Console.WriteLine("1 - Add integer number to table");
                    System.Console.WriteLine("2 - Display table");
                    System.Console.WriteLine("3 - Exit program");
                    program.menuChoice = Convert.ToInt32(Console.ReadLine());
                }


                switch (program.menuChoice)
                {
                    
                    case 1:
                        System.Console.WriteLine("\nInteger: ");
                        program.numberToAdd = Convert.ToInt32(Console.ReadLine());

                        System.Console.WriteLine("On position: ");
                        program.positionToAdd = Convert.ToInt32(Console.ReadLine());
                        integerTable[program.positionToAdd] = program.numberToAdd;

                        break;

                    case 2:
                        try
                        {
                            System.Console.WriteLine("\nPosition to display: ");
                            program.positionToDisplay = Convert.ToInt32(Console.ReadLine());

                            System.Console.WriteLine("table[" + program.positionToDisplay + "]: " + integerTable[program.positionToDisplay]);

                        }
                        catch (IndexOutOfRangeException)
                        {
                            System.Console.WriteLine("Sorry! Your index is out of boundary!");
                        }
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        System.Console.WriteLine("You tap sth different");
                        break;
                }

            }
        }

       /* public void AddNewNumberToArray(int newNumber)
        {
            
            table[index] = newNumber;
            index += 1;
        }

        public void DisplayTable()
        {
            for (int i = 0; i < table.Count(); i++)
            {
                System.Console.WriteLine(table[i] + " ");
            }
        }*/
    }
}
