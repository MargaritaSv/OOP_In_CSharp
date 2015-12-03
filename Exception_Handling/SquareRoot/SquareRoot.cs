using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Console.WriteLine("Enter the integer number: ");

            try
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentNullException("input", "Input canot be empty.");
                }
                int num = int.Parse(input);
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException("number", "The number must be positive");
                }
                Console.WriteLine("The sqare root of {0} is {1:F2}", num, Math.Sqrt(num));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Invalid number", ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number -the number cannot be letter for example", ex.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }

    }
}
