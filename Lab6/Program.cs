using System.ComponentModel.Design;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 1; // ตัวแปรหลักเพื่อเช็ค
            if (lives <= 0) // ในวงเล็บคือเงื่อนไขที่จะต้องเป็นจริงๆ
            {
                // บล็อตของโค้ดที่จะทำงานเมื่อเงื่อนไขเป็นจริง
                Console.WriteLine("You are dead");
            }
            else
            {
                Console.WriteLine("You are alive");
            }

            // เมื่อเงื่อนไขทำงานเสร็จแล้ว หรือ เงื่อนไขไม่ตรงเลยโค้ดทำงานต่อ
            Console.WriteLine("continue to run");

            //int level = 4;

            bool isPoisioned = false;
            if (isPoisioned) { } //
            if (!isPoisioned) { } // 


            bool hasKey = false; // มีกุญแจ true/false
            Console.Write("your level (1-99): ");
            bool ok = int.TryParse(Console.ReadLine(), out int level);

            if (!ok || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid level Input)");
            }
            else if (level >= 10 && hasKey) // && และ กับ || และ
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5) // ต้องมีกุญแจ 5 ชิ้น
            {
                if (hasKey != true) // และต้องมีกุญแจ
                {
                    Console.WriteLine("The door opens.");
                }
                else // กุญแจเป็นเท็จ ไม่มีกุญแจ
                {
                    Console.WriteLine("Locked. Find the key");
                }
            }
            else
            {
                Console.WriteLine("The door stay shut.");
            }


            int heroHp = 100;
            int vilHp = 100;
            int heroAtk = 100;
            int powerUp = 50;

            Console.WriteLine("GAME  TITLE: HERO VS villain OF BRIAN");
            Console.WriteLine("HEO BRIAN ENCOUNTERED A VILLAIN");
            Console.WriteLine("ACTION 1:ATTACK");
            Console.WriteLine("ACTION 2:POWER UP");

            Console.Write("Choose your action (1 - 2): ");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (isInputValid == false || choice < 1 || choice > 2) // เช็คถ้าใส่ input ผิด
            {
                Console.WriteLine("Invalid input. Please choose 1 or 2.");
            }
            else if (choice == 1)
            {
                vilHp -= heroAtk;
                if (vilHp <= 0)
                {
                    Console.WriteLine($"Hero attacked the villain!!! with {heroAtk} DMG, villain is defeated"); // ชีวิตศัตรูเหลือ 0
                }
                else
                {
                    Console.WriteLine($"Hero attacked the villain!!! with {heroAtk} DMG, villain's HP is now {vilHp}"); // ศัตรูยังมีชีวิตอยู่
                }

            }
            else if (choice == 2)
            {
                heroHp += powerUp;
                Console.WriteLine($"Hero is Powered up!!! Hero's HP is now {heroHp}"); // เพิ่มพลังชีวิต
            }
        }
    }
}

            
            