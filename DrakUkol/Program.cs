namespace KnightDragonHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight myKnight = new Knight("John", "Chairsmasher", 100, 20, 15, 30);
            Dragon myDragon = new Dragon("Deathwing", 3, 90, 15, 30);
            myKnight.DisplayInfo();
            Console.WriteLine("______________________");
            myDragon.DisplayDragonInfo();
            Console.WriteLine("______________________");
            myKnight.AttackDragon(myDragon);
            myDragon.DisplayDragonInfo();
        }
    }
}
