using System;
using System.Text;


namespace ConsoleApp2
{
    class Program
    {
        private static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter number (4-29)");
                Console.WriteLine("0 to exit.");
                Console.Write("Your choice: ");


                string? choice = Console.ReadLine();


                if (!int.TryParse(choice, out int n))
                {
                    Console.WriteLine("Invalid input!");
                    Console.ReadLine();
                    continue;
                }


                if (n == 0)
                    return;


                Console.Clear();


                switch (n)
                {
                    case 4: Ex4(); break;
                    case 5: Ex5(); break;
                    case 6: Ex6(); break;
                    case 7: Ex7(); break;
                    case 8: Ex8(); break;
                    case 9: Ex9(); break;
                    case 10: Ex10(); break;
                    case 11: Ex11(); break;
                    case 12: Ex12(); break;
                    case 13: Ex13(); break;
                    case 14: Ex14(); break;
                    case 15: Ex15(); break;
                    case 16: Ex16(); break;
                    case 17: Ex17(); break;
                    case 18: Ex18(); break;
                    case 19: Ex19(); break;
                    case 20: Ex20(); break;
                    case 21: Ex21(); break;
                    case 22: Ex22(); break;
                    case 23: Ex23(); break;
                    case 24: Ex24(); break;
                    case 25: Ex25(); break;
                    case 26: Ex26(); break;
                    case 27: Ex27(); break;
                    case 28: Ex28(); break;
                    case 29: Ex29(); break;


                    default:
                        Console.WriteLine("Choose a number from 4 to 29.");
                        break;
                }


                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }


        private static void Ex4()
        {
            int grade = ReadInt("Enter grade: ");


            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Write valid grade b/n 0-100!");
                return;
            }


            if (grade >= 90)
                Console.WriteLine("A");
            else if (grade >= 80)
                Console.WriteLine("B");
            else if (grade >= 70)
                Console.WriteLine("C");
            else if (grade >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }


        private static void Ex5()
        {
            int digit = ReadInt("Digit (0-9): ");


            string[] w =
            {
                "Zero", "One", "Two", "Three", "Four",
                "Five", "Six", "Seven", "Eight", "Nine"
            };


            if (digit >= 0 && digit <= 9)
                Console.WriteLine(w[digit]);
            else
                Console.WriteLine("Invalid digit");
        }


        private static void Ex6()
        {
            int number = ReadInt("Enter number: ");


            if (number < 5)
                Console.WriteLine("Number is less than 5");
            else if (number < 10)
                Console.WriteLine("Number is less than 10");
            else
                Console.WriteLine("Number is equal to or greater than 10");
        }


        private static void Ex7()
        {
            int x = ReadInt("Start x: ");
            int y = ReadInt("End y: ");


            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }


            long sum = 0;


            for (long i = y; i >= x; i--)
            {
                Console.WriteLine(i);
                sum += i;
            }


            Console.WriteLine($"Sum = {sum}");
            Triangle(5);
        }


        private static void Ex8()
        {
            int sum = 0;


            for (int i = 1; i <= 10; i++)
                sum += i;


            Console.WriteLine("Sum from 1 to 10 = " + sum);
            Triangle(5);
        }


        private static void Ex9()
        {
            Console.WriteLine("Loop 1 prints 0 times because 10 < 5 is false.");
            Console.WriteLine("Loop 2 is infinite because i increases while i >= 1.");
            Console.WriteLine("Loop 3 is infinite because i never changes.");
        }


        private static void Ex10()
        {
            int number = ReadInt("Positive even number: ");


            while (number <= 0 || number % 2 != 0)
            {
                Console.WriteLine("Please enter a positive even number.");
                number = ReadInt("Try again: ");
            }


            int sum = 0;


            while (sum < number)
            {
                sum += 2;
                Console.WriteLine(sum);
            }
        }


        private static void Ex11()
        {
            int lines = ReadInt("Number of lines: ");


            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write($"{i * j,5}");


                Console.WriteLine();
            }
        }


        private static void Ex12()
        {
            int n = ReadInt("N (1-19): ");


            if (n < 1)
                n = 1;


            if (n > 19)
                n = 19;


            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= n; column++)
                    Console.Write($"{row * column,4}");


                Console.WriteLine();
            }
        }


        private static void Ex13()
        {
            int a = ReadInt("First int: ");
            int b = ReadInt("Second int: ");


            bool bothDivisible =
                (a % 2 == 0 && a % 3 == 0) &&
                (b % 2 == 0 && b % 3 == 0);


            if (bothDivisible)
                Console.WriteLine(a * b);
            else
                Console.WriteLine(a + b);
        }


        private static void Ex14()
        {
            int year = ReadInt("Year: ");


            bool leapYear =
                year % 400 == 0 ||
                (year % 4 == 0 && year % 100 != 0);


            Console.WriteLine(leapYear);
        }


        private static void Ex15()
        {
            for (int i = 2; i < 100; i += 2)
                Console.Write(i + " ");


            Console.WriteLine();
        }


        private static void Ex16()
        {
            long number = Math.Abs((long)ReadInt("Positive integer: "));
            bool found = false;


            do
            {
                if (number % 10 == 3)
                    found = true;


                number /= 10;
            } while (number > 0);


            Console.WriteLine(found);
        }


        private static void Ex17()
        {
            int number = Math.Abs(ReadInt("Non-negative number: "));
            int sum = 0;


            do
            {
                sum += number % 10;
                number /= 10;
            } while (number > 0);


            Console.WriteLine(sum);
        }


        private static void Ex18()
        {
            long number = Math.Abs((long)ReadInt("Number: "));
            long last = number % 10;
            long first = number;


            while (first >= 10)
                first /= 10;


            Console.WriteLine($"The first digit is: {first}");
            Console.WriteLine($"The last digit is: {last}");
        }


        private static void Ex19()
        {
            long number = Math.Abs((long)ReadInt("Positive integer: "));
            int count = 0;


            do
            {
                if ((number % 10) % 2 == 0)
                    count++;


                number /= 10;
            } while (number > 0);


            Console.WriteLine(count);
        }


        private static void Ex20()
        {
            long number = Math.Abs((long)ReadInt("Number: "));
            long original = number;
            long product = number == 0 ? 0 : 1;


            while (number > 0)
            {
                product *= number % 10;
                number /= 10;
            }


            Console.WriteLine($"The product of digits of {original} is: {product}");
        }


        private static void Ex21()
        {
            int[] numbers = ReadArray();


            bool result =
                numbers.Length == 3 &&
                numbers[0] <= numbers[1] &&
                numbers[1] <= numbers[2];


            Console.WriteLine(result);
        }


        private static void Ex22()
        {
            int[] numbers = ReadArray();


            for (int i = 0; i < numbers.Length; i++)
            {
                bool alreadyPrinted = false;


                for (int k = 0; k < i; k++)
                {
                    if (numbers[k] == numbers[i])
                    {
                        alreadyPrinted = true;
                        break;
                    }
                }


                if (alreadyPrinted)
                    continue;


                int count = 0;


                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                        count++;
                }


                Console.WriteLine($"{numbers[i]} occurs {count} times");
            }
        }


        private static void Ex23()
        {
            int[] numbers = ReadArray();
            int max = numbers[0];
            int min = numbers[0];


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];


                if (numbers[i] < min)
                    min = numbers[i];
            }


            Console.WriteLine($"Maximum element is: {max}");
            Console.WriteLine($"Minimum element is: {min}");
        }


        private static void Ex24()
        {
            int[] numbers = ReadArray();
            int even = 0;
            int odd = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }


            Console.WriteLine($"Even integers: {even}");
            Console.WriteLine($"Odd integers: {odd}");
        }


        private static void Ex25()
        {
            int[] numbers = ReadArray();
            int largest = int.MinValue;
            int? secondLargest = null;
            bool hasLargest = false;


            foreach (int number in numbers)
            {
                if (!hasLargest || number > largest)
                {
                    if (hasLargest)
                        secondLargest = largest;


                    largest = number;
                    hasLargest = true;
                }
                else if (number < largest &&
                         (!secondLargest.HasValue || number > secondLargest.Value))
                {
                    secondLargest = number;
                }
            }


            if (secondLargest.HasValue)
                Console.WriteLine($"Second largest element: {secondLargest.Value}");
            else
                Console.WriteLine("There is no second-largest distinct element.");
        }


        private static void Ex26()
        {
            string text = ReadText("Input the string: ");


            string[] words = text.Split(
                (char[])null,
                StringSplitOptions.RemoveEmptyEntries
            );


            Console.WriteLine("Total number of words in the string is: " + words.Length);
        }


        private static void Ex27()
        {
            string text = ReadText("Input the string: ");


            Console.Write("The characters of the string in reverse are: ");


            for (int i = text.Length - 1; i >= 0; i--)
                Console.Write(text[i] + " ");


            Console.WriteLine();
        }


        private static void Ex28()
        {
            string text = ReadText("Input the string: ");
            StringBuilder result = new StringBuilder();
            bool startOfWord = true;


            foreach (char character in text)
            {
                if (startOfWord)
                    result.Append(char.ToUpper(character));
                else
                    result.Append(character);


                startOfWord = char.IsWhiteSpace(character);
            }


            Console.WriteLine("Input with first letter uppercase: " + result);
        }


        private static void Ex29()
        {
            string text = ReadText("Input a string: ");
            StringBuilder normalized = new StringBuilder();


            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetterOrDigit(text[i]))
                    normalized.Append(char.ToLowerInvariant(text[i]));
            }


            string normalizedText = normalized.ToString();
            bool palindrome = true;


            for (int i = 0; i < normalizedText.Length / 2; i++)
            {
                if (normalizedText[i] != normalizedText[normalizedText.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }


            Console.WriteLine(palindrome ? "Palindrome" : "Not a palindrome");
        }


        private static int ReadInt(string prompt)
        {
            Console.Write(prompt);


            int number;


            while (!int.TryParse(Console.ReadLine(), out number))
                Console.Write("Enter a valid integer: ");


            return number;
        }


        private static string ReadText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? "";
        }


        private static int[] ReadArray()
        {
            while (true)
            {
                Console.Write("Enter integers separated by spaces: ");


                string[] parts = (Console.ReadLine() ?? "").Split(
                    (char[])null,
                    StringSplitOptions.RemoveEmptyEntries
                );


                if (parts.Length == 0)
                {
                    Console.WriteLine("Please enter at least one integer.");
                    continue;
                }


                int[] values = new int[parts.Length];
                bool valid = true;


                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i], out values[i]))
                    {
                        valid = false;
                        break;
                    }
                }


                if (valid)
                    return values;


                Console.WriteLine("Invalid input! Enter integers only.");
            }
        }


        private static void Triangle(int rows)
        {
            for (int row = 1; row <= rows; row++)
            {
                for (int column = 1; column <= row; column++)
                    Console.Write("* ");


                Console.WriteLine();
            }
        }
    }
}