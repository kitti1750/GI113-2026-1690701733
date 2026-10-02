namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("      ITEM SHOP      ");
            Console.WriteLine("+-------------------------+");
            Console.Write("How many potions? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantity}");
            Console.WriteLine($"Quantity: {quantity}");

            // 2 

            Console.WriteLine("+-------------------------+");
            Console.WriteLine("       CHARACTER CREATION      ");
            Console.WriteLine("+-------------------------+");
            Console.Write("Name your character:  ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool ClassOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck : {luck}");

            // 3
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("       SET VOLUME      ");
            Console.WriteLine("+-------------------------+");
            Console.Write("set volume (0.0-1.0): ");
            bool volumeok = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeok}");
            Console.WriteLine($"Volume: {volume}");


        }
    }
}
