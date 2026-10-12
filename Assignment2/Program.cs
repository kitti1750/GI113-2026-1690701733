namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  CONSTANTS 
            const string GameTitle = "THE FORGE";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const int MaxBatch = 1000;

            //  MATERIAL DATA
            var materialName = "Iron";
            var selectedMenu = 'S';

            int amount = 10;
            float bonusRate = 0.05f;
            double baseAmount = 125.75;
            bool isForgeReady = true;

            //  IMPLICIT CONVERSION 
            double amountAsDouble = amount;

            //  EXPLICIT CAST VS CONVERT 
            int castResult = (int)baseAmount;
            int convertResult = Convert.ToInt32(baseAmount);

            //  HEADER STAT CARD 
            Console.WriteLine("==================================================");
            Console.WriteLine($"              {GameTitle}");
            Console.WriteLine("          ORE SMELTING & BREAKDOWN");
            Console.WriteLine("==================================================");
            Console.WriteLine($" Material       : {materialName}");
            Console.WriteLine($" Smelt Rate     : {SmeltRate:F4}");
            Console.WriteLine($" Salvage Rate   : {SalvageRate:F4}");
            Console.WriteLine($" Bonus Rate     : {bonusRate:F2}");
            Console.WriteLine($" Forge Ready    : {isForgeReady}");
            Console.WriteLine("==================================================");

            Console.WriteLine();
            Console.WriteLine("[S] Smelt Ore -> Ingot");
            Console.WriteLine("[B] Breakdown Ingot -> Ore");
            Console.Write(" Select menu (S/B): ");

            string menuInput = Console.ReadLine() ?? "";
            bool validMenu = menuInput.Length == 1;

            if (validMenu)
            {
                selectedMenu = char.ToUpper(menuInput[0]);
            }

            if (!validMenu || (selectedMenu != 'S' && selectedMenu != 'B'))
            {
                Console.WriteLine();
                Console.WriteLine("[ERROR] Invalid menu. Please enter S or B.");
                return;
            }

            Console.Write(" Enter amount: ");
            string amountInput = Console.ReadLine() ?? "";

            bool validAmount = int.TryParse(amountInput, out amount);

            if (!validAmount || amount <= 0 || amount > MaxBatch)
            {
                Console.WriteLine();
                Console.WriteLine(
                    $"[ERROR] Amount must be between 1 and {MaxBatch}.");
                return;
            }

            //  PROCESSING 
            double result;
            string inputMaterial;
            string outputMaterial;
            string operationName;

            if (selectedMenu == 'S')
            {
                inputMaterial = "Ore";
                outputMaterial = "Ingot";
                operationName = "SMELTING";

                result = amount * SmeltRate;
            }
            else
            {
                inputMaterial = "Ingot";
                outputMaterial = "Ore";
                operationName = "BREAKDOWN";

                result = amount / SalvageRate;
            }

            //  RESULT STAT CARD 
            Console.WriteLine();
            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine($"|              {operationName,-24}|");
            Console.WriteLine("+------------------------------------------------+");
            Console.WriteLine($"| Material In   : {amount,10} {inputMaterial,-18}|");
            Console.WriteLine($"| Material Out  : {result,10:F4} {outputMaterial,-18}|");
            Console.WriteLine($"| Selected Menu : {selectedMenu,-29}|");
            Console.WriteLine("+------------------------------------------------+");

            //  TYPE CONVERSION DEMO 
            Console.WriteLine();
            Console.WriteLine("--------------- SYSTEM INFO ----------------");
            Console.WriteLine($"Amount as double (implicit): {amountAsDouble}");
            Console.WriteLine($"Explicit cast (truncates)  : {castResult}");
            Console.WriteLine($"Convert.ToInt32 (rounds)   : {convertResult}");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("Forge operation completed.");
        }
    }
}