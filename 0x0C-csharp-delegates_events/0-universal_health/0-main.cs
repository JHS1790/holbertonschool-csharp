using System;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", 500f);
        Player player2 = new Player("Water Turtle");
        Player player3 = new Player("Steel Elephant", -10);

        player1.PrintHealth();
        player2.PrintHealth();
        player3.PrintHealth();
    }
}
