using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to the To-Do List program");
      Console.WriteLine("Would you like to add an item or view your list? (Add/View)");
      string userInput = Console.ReadLine();

      if (userInput.ToLower() == "add") {
        Console.WriteLine("Enter the description of your to-do list item:");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        Console.WriteLine(description + " has been added to your to-do list");
        Main();
      } else if (userInput.ToLower() == "view") {
        List<Item> result = Item.GetAll();
        for(int i=0; i<result.Count; i++)
        {
          Console.WriteLine((i+1) + ". " + result[i].Description);
        }
        Main();
      } else if (userInput.ToLower() == "quit") {
        Console.WriteLine("Thanks for using our to-do list ;)");
      } else {
        Console.WriteLine("I don't understand, please input \"add\" or \"view\"");
        Main();
      }
    }
  }
}