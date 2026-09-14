namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== >> GAME TITLE <<");
            Console.WriteLine("Hero vs. villain -- calculate Damage");
            
            // Hero stats
            Console.Write("Hero HP: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Villain stats
            Console.Write("\nVillain HP: ");
            bool vilHpOk = int.TryParse(Console.ReadLine(), out int vilHp);
            Console.Write("Villain Attack: ");
            bool vilAtkOk = int.TryParse(Console.ReadLine(), out int vilAtk);
            Console.Write("Villain Defense: ");
            bool vilDefOk = int.TryParse(Console.ReadLine(), out int vilDef);

            //check for vaild input
            bool heroInputValid = heroHpOk && heroAtkOk && heroDefOk;
            bool villainInputValid = vilHpOk && vilAtkOk && vilDefOk;
            Console.WriteLine($">> Hero stats Valid: {heroInputValid}");
            Console.WriteLine($">> Villain stats Valid: {villainInputValid}");
            Console.WriteLine($"[HERO]     HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[VILLAIN]  HP: {vilHp}, ATK: {vilAtk}, DEF: {vilDef}");

            // Hero Power Up before the fight ( compound assignment: += )
            int powerUp = 12;
            // heroHp = HeroHp + powerUp ผลคือ 112
            //heroHp += powerUp ผลคือ 112
            heroHp += powerUp; // Hero ชาร์ตพลัง
            Console .WriteLine($"\nHero Power Up: {powerUp} HP, New Hero HP: {heroHp}");

            int normalDamage = Math.Max(0, heroAtk - vilDef); // โจมตีปกติ โดยการ -
            Console.WriteLine($"Normal attack deals {normalDamage} DMG");

            int poweDamage = Math.Max(0, (heroAtk * 2) - vilDef); // โจมตีแบบพลัง โดยการ * 2
            Console.WriteLine($"Power attack deals: {poweDamage} DMG");

            int couterDamage = Math.Max(0, vilAtk - heroDef); // villain โจมตีสวนกลับ ไม่ต้องเปลี่ยนสูตร เปลี่ยนแค่ตัวแปร
            Console.WriteLine($"Counter attack deals: {couterDamage} DMG");

            Random randomSomething  = new Random();
            int roll = randomSomething.Next(1, 101); //สุ่ม 1 - 100 หรือค่าอื่นๆ ต้อง+1
            bool isCrit = roll <= 20; // โอกาส 20 ตัวใน 100 คือ 20%
            int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // ได้ค่า 1 หรือ 0 เป็นตัวกำหนดว่าจะได้คริ
            Console.WriteLine($"Crit Damage roll: {roll} (Crit?: {isCrit})");
            Console.WriteLine($"If critical, normal attack would deal: {critDamage} DMG");
        }
    }
}
