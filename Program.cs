using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueA, valueB;

            Console.WriteLine("Simple Calulator!");
            Console.WriteLine("Enter 2 values\n");

            valueA = GetValue();
            valueB = GetValue();

            Console.WriteLine(CalculateValues(valueA, valueB));

            Console.WriteLine("Values entered: {0} and {1}", valueA, valueB);
        }

        static public int GetValue()
        {
            bool validEntry = true;
            int valueInt = 0;

            while (validEntry)
            {
                Console.Write("Value: ");
                string value = Console.ReadLine();

                if (Int32.TryParse(value, out valueInt))
                {
                    validEntry = false;
                }
                else Console.WriteLine("Invalid entry try again");

            }
            return valueInt;
        }

        static public int CalculateValues(int valueA, int valueB)
        {

            bool validEntry = true;
            int operationIntValue = 0;
            int result = 0;

            while (validEntry)
            {
                Console.WriteLine("Detemine the operation:\n1 - ADD\n2 - SUBTRACT\n3 - MULTIPLY\n4 - DIVIDE\n");
                Console.Write("\nEnter operation selection: ");
                string operationStringValue = Console.ReadLine();

                if (Int32.TryParse(operationStringValue, out operationIntValue))
                {
                    if(operationIntValue >= 1 && operationIntValue <= 4)
                    {
                        validEntry = false;
                    }
                    else Console.WriteLine("Invalid operation!");
                }
                else Console.WriteLine("invalid entry, try again!");
            }

            switch (operationIntValue)
            {
                case 1: return result = valueA + valueB;
                case 2: return result = valueA - valueB;
                case 3: return result = valueA * valueB;
                case 4: return result = valueA / valueB;
            }

            return 0;
        }
    }
}
