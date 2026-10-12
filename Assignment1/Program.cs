/*
 * Student ID : 1690701733z 
 * Name       : kitti keawpitool
 * Section    : 129B
 * No.        : 31
 * Course     : GI113 Computer Programming (GI)
 */


namespace acc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CharacterName = "NEON";
            const string GameTitle = "Cyber Guardian";

            var heroRank = 'S';
            var heroName = "Neon";
            int heroLevel = 25;
            float attackPower = 78.5f;
            double specialPower = 95.75;
            bool isUnlocked = true;

            Console.WriteLine("========================================");
            Console.WriteLine($"       {GameTitle} - STAT CARD");
            Console.WriteLine("========================================");
            Console.WriteLine($"  Character : {CharacterName}");
            Console.WriteLine($"  Hero Name : {heroName}");
            Console.WriteLine($"  Rank      : {heroRank}");
            Console.WriteLine($"  Level     : {heroLevel}");
            Console.WriteLine($"  Attack    : {attackPower}");
            Console.WriteLine($"  Special   : {specialPower}");
            Console.WriteLine($"  Unlocked  : {isUnlocked}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("  SPECIAL SKILL");
            Console.WriteLine("  Light Reflection");
            Console.WriteLine("  Creates a shield from surrounding light");
            Console.WriteLine("========================================");

            double heroLevelAsDouble = heroLevel;
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");

            int powerCast = (int)attackPower;
            int powerConvert = Convert.ToInt32(attackPower);

            Console.WriteLine($"Attack cast (truncates): {powerCast}");
            Console.WriteLine($"Attack Convert (rounds): {powerConvert}");
        }
    }
}