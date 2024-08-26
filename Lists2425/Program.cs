using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists2425
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a list of strings
            List<string> shoppingList = new List<string>();
            Console.WriteLine(shoppingList.Count);

            // Add items to my shopping list
            shoppingList.Add("Banana Nut Bread");
            shoppingList.Add("Candy");
            shoppingList.Add("Butter");
            shoppingList.Add("Donuts");
            shoppingList.Add("Steak");

            // Display all items in a list
            Console.WriteLine("Shopping List:");
            foreach (var item in shoppingList)
            {
                Console.WriteLine(item);    
            }

            // Accessing an item by index
            Console.WriteLine($"Item at index 1: {shoppingList[1]}");
            
            // Displays number of items in the shoppingList
            Console.WriteLine(shoppingList.Count);


            // Removing Item from List
            //shoppingList.Remove($"Item at index 1: {shoppingList[1]}");
            shoppingList.Remove("Candy");
            // Print List
            foreach (var item in shoppingList)
            {
                Console.WriteLine($"List Item: {item}");
            }



            Console.WriteLine($"There are {shoppingList.Count} items in your list.");
            Console.ReadLine();
        }
    }
}


// Notes: https://www.simplilearn.com/tutorials/asp-dot-net-tutorial/c-sharp-list