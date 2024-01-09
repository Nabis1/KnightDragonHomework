
namespace KnightDragonHomework
{
    public class Knight
    {
        private string _Name;
        private string _LastName;
        private int _HitPoints;
        private int _Strength;
        private int _Agility;
        private int _Armor;
        public string Name => _Name;
        public string LastName => _LastName;
        public Knight(string name, string lastName, int hitPoints, int strength, int agility, int armor)
        {
            _Name = name;
            _LastName = lastName;
            _HitPoints = hitPoints;
            _Strength = strength;
            _Agility = agility;
            _Armor = armor;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Knight: {_Name} {_LastName}");
            Console.WriteLine($"Hit Points: {_HitPoints}");
            Console.WriteLine($"Strength: {_Strength}");
            Console.WriteLine($"Agility: {_Agility}");
            Console.WriteLine($"Armor: {_Armor}");
        }

        public void AttackDragon(Dragon numbersOfHeads)
        {
            while (numbersOfHeads.NumberOfHeads > 0)
            {
                Console.WriteLine($"Oooooo, mighty knight {_Name}, borned {_LastName}, is attacking the dragon!");
                numbersOfHeads.HitByKnight(this);
            }
        }

    }
}