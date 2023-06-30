using System.Collections;
using System.Collections.Generic;

internal class Programm
{
    private static void Main(string[] args)
    {
        Stack stackList = new Stack();
        
        while (true)    
        {
            Console.WriteLine("Select :\n");
            Console.WriteLine("1 - Push \n");
            Console.WriteLine("2 - Pop :\n");
            Console.WriteLine("3 - Peek :\n");
            Console.WriteLine("4 - Exit :\n");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":

                    Console.WriteLine("Push item");
                    var item = Console.ReadLine();
                    stackList.Push(item);

                    break;

                case "2":
                    Console.WriteLine("Pop item");
                    stackList.Pop();

                    break;

                case "3":
                    Console.WriteLine("Print element");
                    Console.WriteLine(stackList.Peek());
                    break;
                case "4":
                    return;

                default:
                    Console.WriteLine("Error insert");
                    break;
            }
            Console.WriteLine();
        }
    }
 }
    

