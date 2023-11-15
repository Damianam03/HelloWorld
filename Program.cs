namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //formula to calc data type range: (2^bit)-1
            //example: Calculate unsigned short range (2 ^ 16) - 1 = 65535 -> ranges from 0 to 65535
            //example: Calculate signed short range - negative: (2 ^ 16) / 2 = 32768 -> ranges from -32768 to -1
            //                                        positive: ((2 ^ 16) / 2) - 1 = 32767 -> ranges from 0 to 32767
            int intTest = 0;
            decimal decimalTest = 0;
            float floatTest = 0;
            double doubleTest = 0;
            ulong longTest = 0;
            short shortTest = 0;

            Console.WriteLine("Signed data type ranges");
            Console.WriteLine("short: " + short.MinValue + " to " + short.MaxValue);
            Console.WriteLine("integer: " + int.MinValue + " to " + int.MaxValue);
            Console.WriteLine("long: " + long.MinValue + " to " + long.MaxValue);
            Console.WriteLine("float: " + float.MinValue + " to " + float.MaxValue);
            Console.WriteLine("double: " + double.MinValue + " to " + double.MaxValue);
            Console.WriteLine("decimal: " + decimal.MinValue + " to " + decimal.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Unsigned data type ranges");
            Console.WriteLine("short: " + ushort.MinValue + " to " + ushort.MaxValue);
            Console.WriteLine("integer: " + uint.MinValue + " to " + uint.MaxValue);
            Console.WriteLine("long: " + ulong.MinValue + " to " + ulong.MaxValue);
            Console.WriteLine();

            Console.Write("Insert integer: ");
            intTest = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert Short: ");
            shortTest = Convert.ToInt16(Console.ReadLine());

            if (intTest >= 100 && intTest <= 200 || shortTest > 5)
            {
                Console.WriteLine("Hello, World!!");
            }
            else if (intTest >= 300 && intTest <= 400)
            {
                Console.WriteLine("Expression was false");
            }

            Console.ReadLine();
        }
    }
}
