
namespace KnightDragonHomework
{
    public class Dragon
    {
        private string _Name;
        private int _NumberOfHeads;
        private int _Strength;
        private int _Agility;
        private int _Armor;

        public int NumberOfHeads => _NumberOfHeads;

        public Dragon(string name, int headNumbers, int strength, int agility, int armor)
        {
            _Name = name;
            _NumberOfHeads = headNumbers;
            _Strength = strength;
            _Agility = agility;
            _Armor = armor;
        }
        public void DisplayDragonInfo()
        {
            Console.WriteLine($"Dragon: {_Name}");
            Console.WriteLine($"Number of heads: {_NumberOfHeads}");
            Console.WriteLine($"Strength: {_Strength}");
            Console.WriteLine($"Agility: {_Agility}");
            Console.WriteLine($"Armor: {_Armor}");
        }
        public void HitByKnight(Knight knight)
        {
            if (_NumberOfHeads > 0)
            {
                _NumberOfHeads--;

                if (_NumberOfHeads > 0)
                {
                    Console.WriteLine("Deathwing is shouting in pain : Where is my head!");
                }
                else
                {
                    Console.WriteLine($"Deathwing is defeated by mighty knight {knight.Name} {knight.LastName}...");
                }
            }
            else
            {
                Console.WriteLine("The dragon is already defeated!");
            }
        }
    }
}
