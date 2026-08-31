/*
 * Student ID : 1690701733
 * Name       : Lab02
 * Section    : 129B
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab02
{
    internal class Program
    {
        string bossName = "Kirin";
        char rank = 'S';
        int level = 7;
        int maxHp = 240;
        int currentHp = 175;
        float attackPower = 42.5f;
        double critMultiplier = 1.75;
        bool isBoss = true;
        static void Main(string[] args)
        {
         Console.WriteLine("===== BOSS STATUS: INITIAL =====");
         Console.WriteLine($"Name: {bossName}");
         Console.WriteLine($"Rank: {rank} ");
         Console.WriteLine($"HP: {currentHp}");
         Console.WriteLine($"Attack Power: {attackPower}");
         Console.WriteLine($"Crit Multiplie: {critMultiplier}");
         Console.WriteLine($"is Boss: {isBoss}");
         Console.WriteLine();

         int hpPercent = currentHp * 100 / maxHp; // คำนวณเปอร์เซนฆ
         Console.WriteLine($"HP Percent: {hpPercent}%");
         Console.WriteLine();

         Console.WriteLine($"Kirin takes 60 damage!");
         currentHp = currentHp - 60;
         Console.WriteLine();

         Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
         Console.WriteLine($"HP: {currentHp} / {maxHp}");
         hpPercent = currentHp * 100 / maxHp;
         Console.WriteLine($"HP Percent: {hpPercent}%");

            //PartB
            //----------Part B: My Own Game (SAMPLE ONLY - students design their won theme/values --------
            //เกณฑ์การตรวจ Part B: 4 ตัวละคร x 5 stat/ตัว, รวมกันครบ 6 ชนิดข้อมูล, มี label กำกับ, ใช้ $".." ทุกจุด
            //ธีมนี้ (ทีมนักผจญภัย 4 คน)
            
            // == ตัวละตรที่ 1 Neck ==
            string hero1Name = "Neck";
            int hero1Hp = 100;
            float hero1Atk = 16.5f;
            double hero1CritRate = 0.15;
            char hero1Rank = 'B';
            bool IsLeader = false;

            Console.WriteLine("====HERO 1 ====");
            Console.WriteLine($"NAME: {hero1Name}");
            Console.WriteLine($"HP: {hero1Hp}");
            Console.WriteLine($"ATK: {hero1Atk}");
            Console.WriteLine($"CRIT: {hero1CritRate * 100}%");
            Console.WriteLine($"RANK: {hero1Rank}");
            Console.WriteLine();

            // == ตัวละครที่ 2 Peter ==
            string hero2Name = "Peter";
            int hero2Hp = 150;
            float hero2Atk = 17.6f;
            double hero2CritRate = 0.21;
            char hero2Rank = 'S';
            bool IsLeader = true;

            Console.WriteLine("==== HERO 2 ====");
            Console.WriteLine($"NAME: {hero2Name}");
            Console.WriteLine($"HP: {hero2Hp}");
            Console.WriteLine($"ATK: {hero2Atk}");
            Console.WriteLine($"CRIT: {hero2CritRate * 100}%");
            Console.WriteLine($"RANK: {hero2Rank}");
            Console.WriteLine();

            // ==ตัวละตรที่ 3 Ael ==
            string hero3Name = "Peter";
            int hero3Hp = 100;
            float hero3Atk = 20.6f;
            double hero3CritRate = 0.30;
            char hero3Rank = 'S';
            bool IsLeader = false;

            Console.WriteLine("==== HERO 3 ====");
            Console.WriteLine($"NAME: {hero3Name}");
            Console.WriteLine($"HP: {hero3Hp}");
            Console.WriteLine($"ATK: {hero3Atk}");
            Console.WriteLine($"CRIT: {hero3CritRate * 100}%");
            Console.WriteLine($"RANK: {hero3Rank}");
            Console.WriteLine();

            // == ตัวละครที่ 4 farla ==
            string hero4Name = "Peter";
            int hero4Hp = 300;
            float hero4Atk = 10.3f;
            double hero4CritRate = 0.10;
            char hero4Rank = 'A';
            bool IsLeader = false;

            Console.WriteLine("==== HERO 4 ====");
            Console.WriteLine($"NAME: {hero4Name}");
            Console.WriteLine($"HP: {hero4Hp}");
            Console.WriteLine($"ATK: {hero4Atk}");
            Console.WriteLine($"CRIT: {hero4CritRate * 100}%");
            Console.WriteLine($"RANK: {hero4Rank}");
            Console.WriteLine();






        }
    }
}
