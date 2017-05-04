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

        int[] tabela = new int[10];

        static void Main(string[] args)
        {
            Program program = new Program();
            

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

                        if (program.positionToAdd > program.tabela.Length)
                        {
                            int newSize = program.positionToAdd;
                            Array.Resize(ref program.tabela, newSize);
                            program.tabela[program.positionToAdd - 1] = program.numberToAdd;
                        }
                        else
                            program.tabela[program.positionToAdd - 1] = program.numberToAdd;

                        break;

                    case 2:
                        try
                        {
                            System.Console.WriteLine("\nPosition to display: ");
                            program.positionToDisplay = Convert.ToInt32(Console.ReadLine());

                            System.Console.WriteLine("table[" + program.positionToDisplay + "]: " + program.tabela[program.positionToDisplay - 1]);

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
        public int this[int indeks]
        {
            get
            {
                return this.tabela[indeks];
            }
            set
            {
                this.tabela[indeks] = value;
            }
        }
    }
}
