using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList shoppingList = new DynamicList();
            shoppingList.Add("Cucumber");
            shoppingList.Add("Meat");
            shoppingList.Add("Tomatoes");
            shoppingList.Add("Cabbage");
            shoppingList.Add("Milk");
            Console.WriteLine("Your shopping list is: ");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            Console.WriteLine("Now let's remove...");

            shoppingList.Remove("Milk");
            Console.WriteLine("Your shopping list now is: ");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            int meatIndex = shoppingList.IndexOf("Cucumber");
            if (meatIndex != -1)
            {
                shoppingList.Remove(meatIndex);
                Console.WriteLine("Your shopping list now is: ");
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    Console.WriteLine(shoppingList[i]);
                }
            }
            else
            {
                Console.WriteLine("Meat not found");
            }

            Console.WriteLine("Do we have Cabbage in the list? "+
                shoppingList.Contains("Cabbage"));
        }
    }
}
