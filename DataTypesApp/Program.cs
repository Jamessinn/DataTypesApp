namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int applePieces = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total of price of: " + applePieces +  " apple(s): ");
            double applePrices = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price of " + applePieces + " apple(s) " + "is: " + applePrices);
            Console.WriteLine("The value of converted price is: " + (int)applePrices);
            Console.WriteLine("Press any key to exit...........");
            Console.ReadKey();

        }
    }
}