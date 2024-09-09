using System;
using System.ComponentModel;
using System.Net;

namespace _2_Task__6_9__collecton_list
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> num = new List<int>() ;

           while (true) 
            {               
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find number in the list ");
                Console.WriteLine("C - Clear list");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");
                
                string Choice = Console.ReadLine();
                
                //nums for case A (add)
                int nums=0 ;

                switch (Choice)
                {

                    // P print
                    case "P" or "p":
                        if (num.Count != 0)
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < num.Count; i++)
                            {
                                Console.Write(num[i] + " ");
                            }
                            Console.WriteLine("]");
                            Console.WriteLine($"The list has [{num.Count - 1}] index");
                        }
                        else
                            Console.WriteLine("[] - the list is empty");
                        break;

                    // A add num
                    case "A" or "a":
                        Console.Write("Enter a number : ");
                        nums = int.Parse(Console.ReadLine());
                        if (num.Count >= 0)
                        
                            num.Add(nums);                            
                                Console.WriteLine($"{nums} added");
                                                   
                        break;
                    
                    // M : mean calcuation 
                    case "M" or "m":
                        if (num.Count != 0)
                        {
                            double mean = num.Sum() / (double)num.Count;
                            Console.WriteLine($"The mean is: {mean}");
                        }
                        else
                            Console.WriteLine("Unable to calculate the mean - no data");
                        break;

                    // S : smallest num
                    case "S" or "s":
                        if ( num.Count != 0)
                        {                          
                                int smallest = num[0];
                                for (int i = 0; i < num.Count; i++)
                                {
                                    if (num[i] < smallest)
                                    {
                                        smallest = num[i];
                                    }
                                }
                                Console.WriteLine($"The smallest number is: {smallest}");                            
                        }
                        else
                            Console.WriteLine("Unable to determine the smallest number - list is empty ");

                        break;

                        //L : largest num
                        case"L" or "l":
                        if(num.Count !=0)
                        {
                           int largest = num[0];
                            for(int i = 0;i < num.Count; i++)
                            {
                                if(num[i] > largest)
                                {
                                    largest = num[i];
                                }
                            }
                            Console.WriteLine($"The largest number is: {largest}");
                        }
                        else
                            Console.WriteLine("Unable to determine the largest number - list is empty ");
                            break;

                        //C : clear list
                    case "C" or "c":
                        if ( num.Count == 0)
                            Console.WriteLine("There's nothing in the list");
                        else 
                        num.Clear();
                        Console.WriteLine("The list has been cleared");
                        break;

                        // F : find number
                        case "F" or "f":
                            Console.Write("Enter the number you want to find its index: ");
                            nums = int.Parse(Console.ReadLine());
                        int index = 0;
                        while (index < num.Count)
                        {
                            if (num[index] == nums)
                            {
                                Console.WriteLine($"Number {nums} found in index[{index}]");
                                break;

                            }
                            index++;
                        }
                               if(index == num.Count)
                        {
                            Console.WriteLine($"Number {nums} not found in index");
                        }
                        break;
                        // Q : close list
                    case "Q" or "q":
                        Console.WriteLine("Goodbye");
                        return;

                         
                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;

                         
 
                    }
               
                }
           }
        }
    }

