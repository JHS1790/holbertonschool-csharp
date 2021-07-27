using System;

class Program
{
    static void Main(string[] args)
    {
        Decoration coffeeMug = new Decoration("Coffee Mug", 2);

        Console.WriteLine(coffeeMug.ToString());

        coffeeMug.Interact();
        coffeeMug.Break();
        coffeeMug.Break();
        coffeeMug.Interact();

        Console.WriteLine("\n----------------------------------\n");

        Decoration figurine = new Decoration(durability: 10, isQuestItem: true);

        Console.WriteLine(figurine.ToString());

        figurine.Interact();
        figurine.Break();
        figurine.Break();
        figurine.Interact();
        Console.WriteLine("isQuestItem: " + figurine.isQuestItem);
    }
}
