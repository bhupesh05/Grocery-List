using System;
using System.Collections.Generic;

namespace Grocery
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> grocery = new List<string>();
           bool con=true;
           while(con)
           {
               Console.WriteLine("to add + item/items, to delete - item/items to clear -- clear ");
               string[] arg= Console.ReadLine().Split(' ');
               var len= arg.Length;
               Console.WriteLine($"There are {len-1} items found...");
               for(int i=0;i<len;i++)
               arg[i].Trim().ToLower();
               String command=arg[0];
               switch(command)
               {
                   case "exit": con=false; break;
                   case "+": { 
                                if(len>1)
                                 {
                                     for(int i=1;i<len;i++){
                                            Console.WriteLine($"Inserting {arg[i]} to list..");
                                            grocery.Add(arg[1]);
                                          }
                                          break;
                                 }
                                else{
                                    Console.WriteLine("Please add items");
                                    break;
                                    } 
                             }
                   case "-":{ 
                                if(len>1)
                                 {
                                     if(grocery.Contains(arg[1]))
                                     {
                                        Console.WriteLine($"deleting {arg[1]} from list..");
                                        grocery.Remove(arg[1]);
                                        break;
                                      }
                                      else{
                                          Console.WriteLine($"no such '{arg[1]}' found..");
                                          break;
                                      }
                                 }
                                else{
                                    Console.WriteLine("Please add items");
                                    break;
                                    } 
                             }
                   case "--": Console.WriteLine("Clear list...");
                              grocery.Clear();
                              break;
                   default: Console.WriteLine($"Invalid command....there is no such '{command}' keyword found....");
                   break;
               }
                                  
           }
        }
    }
}
