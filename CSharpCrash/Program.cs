using System;

namespace CSharpCrash
{
    class Program
    {
        static void Main()
        {
            PrintToConsole();
            VariableAndDataTypes();
            MathOperators();
            ComparisonOperators();
            LogicalOperators();
            ConditionalStatements();
            Loops();
            Arrays();
            Collections();
            Methods();
            Classes();
            ExceptionHandling();
        }

        static void PrintToConsole()
        {
            Console.WriteLine("Hello, World!");
        }

        static void VariableAndDataTypes()
        {
            int age = 30;
            Console.WriteLine(age);

            float temperature = 20.4f;
            Console.WriteLine(temperature);

            double interest = 5.53;
            Console.WriteLine("Interest: " + interest);

            decimal stockPrice = 4.543456M;
            Console.WriteLine("Stock price: " + stockPrice);

            char grade = 'A';
            Console.WriteLine(grade);

            string name = "Anne";
            Console.WriteLine($"Name: {name}");

            bool isStudent = true;
            Console.WriteLine(isStudent);

            int quantity;
            string product;

            quantity = 5;
            product = "bananas";

            Console.WriteLine($"Product: {product}, Quantity: {quantity}");

            const double piValue = 3.14;
            Console.WriteLine(piValue);
        }

        static void MathOperators()
        {
            int num1 = 10;
            int num2 = 5;
            int num3 = 0;

            int addition = num1 + num2;
            Console.WriteLine(addition);

            int subtraction = num1 - num2;
            Console.WriteLine(subtraction);

            int multiplication = num1 * num2;
            Console.WriteLine(multiplication);

            int division = num1 / num2;
            Console.WriteLine(division);

            int modulus = 11 % 5;
            Console.WriteLine(modulus);

            try
            {
                int quotient = num2 / num3;
                Console.WriteLine(quotient);
;           }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }

            int num4 = 105;
            double num4AsDouble = (Double)num4;
            Console.WriteLine(num4AsDouble);
        }

        static void ComparisonOperators()
        {
            int a = 10;
            int b = 5;

            bool isEqual = (a == b);
            Console.WriteLine(isEqual);

            bool isNotEqual = (a != b);
            Console.WriteLine(isNotEqual);

            bool isGreater = (a > b);
            Console.WriteLine(isGreater);

            bool isLess = (a < b);
            Console.WriteLine(isLess);

            bool isGreaterThanOrEqual = (a >= b);
            Console.WriteLine(isGreaterThanOrEqual);

            bool isLessThanOrEqual = (a <= b);
            Console.WriteLine(isLessThanOrEqual);
        }

        static void LogicalOperators()
        {
            Console.WriteLine("Logical Operators");

            bool x = true;
            bool y = false;

            bool andResult = (x && y);
            Console.WriteLine(andResult);

            bool orResult = (x || y);
            Console.WriteLine(orResult);

            bool notResult1 = (x && !y);
            Console.WriteLine(notResult1);

            bool notResult2 = !x;
            Console.WriteLine(notResult2);
        }

        static void ConditionalStatements()
        {
            int age = 80;

            if (age < 18)
            {
                Console.WriteLine("You are a minor!");
            } else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Congratulations, you are an adult!");
            }
            else
            {
                Console.WriteLine("You are a senior.");
            }

            int day = 3;
            string dayName;

            switch (day)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                default:
                    dayName = "Weekend";
                    break;
            }

            Console.WriteLine("Today is " + dayName);
        }

        static void Loops()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Number: " + i);
            }

            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("While count: " + count);
                count++;
            }

            count = 0;
            do
            {
                Console.WriteLine("Do-while count: " + count);
                count++;
            } while (count < 10);

            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int number in numbers)
            {
                Console.WriteLine("Number in Array: " + number);
            }
        }

        static void Arrays()
        {
            string[] names = new string[3];
            names[0] = "Ron";
            names[1] = "Katie";
            names[2] = "Jack";

            Console.WriteLine(names.Length);
            Console.WriteLine(names[1]);
        }

        static void Collections()
        {
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Tokyo");
            cities.Add("Berlin");
            cities.Add("Sydney");

            Console.WriteLine(cities[2]);
            Console.WriteLine(cities.Count);

            foreach(string city in cities)
            {
                Console.WriteLine(city);
            }

            HashSet<string> countries = new HashSet<string>();
            countries.Add("Germany");
            countries.Add("USA");
            countries.Add("Japan");
            countries.Add("USA");

            Console.WriteLine("Countries count: " + countries.Count);

            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }

            Dictionary<string, int> ageDict = new Dictionary<string, int>();
            string dictKey = "Alice";
            ageDict[dictKey] = 30;
            ageDict["Bob"] = 75;
            ageDict["Tracy"] = 18;

            if (ageDict.ContainsKey(dictKey))
            {
                Console.WriteLine($"{dictKey}'s age: {ageDict[dictKey]}");
            }

            foreach(var entry in ageDict)
            {
                Console.WriteLine("Key: " + entry.Key);
                Console.WriteLine("Entry: " + entry.Value);
            }

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Last");

            while (queue.Count > 0)
            {
                string item = queue.Dequeue();
                Console.WriteLine("Queue item: " + item);
            }

            Stack<string> stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Last");

            while (stack.Count > 0)
            {
                string item = stack.Pop();
                Console.WriteLine("Stack item: " + item);
            }
        }

        static void Methods()
        {
            SayHello();

            int a = 10;
            int b = 20;
            int sum = Add(a, b);

            Console.WriteLine(sum);
        }

        private static void SayHello()
        {
            Console.WriteLine("Hellooo");
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static void Classes()
        {
            Person p = new Person("Jerry", 45);
            p.Greet();
        }

        static void ExceptionHandling()
        {
            int a = 10;
            int b = 0;

            try
            {
                int result = a / b;
            } catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            List<string> shapes = new List<string> { "square", "rectangle", "circle"};

            try
            {
                Console.WriteLine(shapes[10]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("This index does not exist: " + ex.Message);
            } finally
            {
                Console.WriteLine("It runss?");
            }

            bool isStudent = false;

            try
            {
                if (isStudent)
                {
                    Console.WriteLine("This is a student");
                } else
                {
                    throw new CustomExeption("You cannot enroll for this course");
                }
            }
            catch (CustomExeption ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

