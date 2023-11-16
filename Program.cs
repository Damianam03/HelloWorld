using System.Xml.Schema;

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
            decimal square = 0;
            decimal circle = 0;
            decimal triangleHeight = 0;
            decimal triangleWidh = 0;
            ConsoleKeyInfo keyPressed = new ConsoleKeyInfo();
            bool repeatProgram = false;

            while (!repeatProgram)
            {
                Console.WriteLine("1. Display data type ranges");
                Console.WriteLine("2. Calculate square");
                Console.WriteLine("3. Calculate circle");
                Console.WriteLine("4. Calculate triangle");
                Console.WriteLine("\nPress ESC to close application");

                keyPressed = Console.ReadKey();
                //menuItemPicker = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (keyPressed.Key == ConsoleKey.D1)
                {
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
                }
                else if (keyPressed.Key == ConsoleKey.D2)
                {
                    Console.Write("Insert length: ");
                    square = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("The area of your square is " + square * 2);
                }
                else if (keyPressed.Key == ConsoleKey.D3)
                {
                    Console.Write("Insert radius: ");
                    circle = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("The area of your circle is " + Math.Pow(Convert.ToDouble(circle), 2) * Math.PI);
                }
                else if (keyPressed.Key == ConsoleKey.D4)
                    Console.Write("Insert width: ");
                    triangleWidh = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Insert height: ");
                    triangleHeight = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("The area of your triangle is " + ((triangleHeight * triangleWidh) / 2));
                }
                else if (keyPressed.Key == ConsoleKey.Escape)
                {
                    repeatProgram = true;
                }

                Console.WriteLine("\nPress any key to return to main menu boom");
                Console.ReadKey();
                Console.Clear();
            }
            //Console.Write("Insert integer: ");
            //intTest = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Insert Short: ");
            //shortTest = Convert.ToInt16(Console.ReadLine());

            //if (intTest >= 100 && intTest <= 200 || shortTest > 5)
            //{
            //    Console.WriteLine("Hello, World!!");
            //}
            //else if (intTest >= 300 && intTest <= 400)
            //{
            //    Console.WriteLine("Expression was false");
            //} 
        }
    }
}