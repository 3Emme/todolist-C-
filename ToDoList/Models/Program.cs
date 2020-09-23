using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  class Program
  {
    public static void CommandPrompt()
    {
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
      string userCommand = Console.ReadLine();
      if (userCommand == "Add" || userCommand == "add")
      {
        Console.WriteLine("Please enter the description for the new item.");
        string itemDesc = Console.ReadLine();
        Item newItem = new Item(itemDesc);
        List<Item> newList = new List<Item> { newItem };
        Console.WriteLine("'" + itemDesc + "' has been added to your list.");
        CommandPrompt();
      }
      else if (userCommand == "View" || userCommand == "view")
      {
        List<Item> result = Item.GetAll();
        int tally = 1;
        foreach (Item thisItem in result)
        {
          Console.WriteLine(tally + ". " + thisItem.Description);
          tally += 1;
        }
        CommandPrompt();
      }
      else
      {
        Console.WriteLine("I'm sorry, I didn't understand that. Please check your command and try entering it again.");
        CommandPrompt();
      }
    }
    public static void Main()
    {
      List<Item> newList = new List<Item> { };
      Console.WriteLine("Welcome to the To Do List.");
      CommandPrompt();
    }
  }
}











