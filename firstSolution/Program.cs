using System;

namespace firstSolution
{
    class Program
    {
        static void ifMethod()
        {
            int age;
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >= 20 && age <= 60)
            {
                Console.WriteLine("You can work.");
            }
            else if (age > 60)
            {
                Console.WriteLine("You can receive a pension.");
            }
            else
            {
                Console.WriteLine("You must studing.");
            }
        }
        static void switchMethod()
        {
            int age;
            string str = "Alcohol";
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            switch (str)
            {
                case "Alcohol" when age >= 18 && age <= 60:
                    Console.WriteLine("You can drink alcohol");
                    break;
                case "Alcohol" when age < 18:
                case "Milk":
                    Console.WriteLine("You mustn`t drink alcohol so dring milk");
                    break;
                default:
                    Console.WriteLine("You can receive a pension.");
                    break;
            }
        }
        static void cycleMehod()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("[ ]");
                }
                Console.WriteLine("");
            }

            bool isBoiled = false;
            int timer = 0;
            while (!isBoiled)
            {
                if (timer < 5)
                {
                    Console.Write("[ ]");
                }
                timer++;
                if (timer == 20)
                {
                    isBoiled = true;
                }
                if (timer == 15)
                {
                    break;
                }
                if (timer >= 5)
                {
                    Console.Write("[x]");
                    continue;
                }
            }

            bool success = false;
            do
            {
                Console.Write("Enter a number from 1 to 10: ");
                string answer = Console.ReadLine();
                success = int.TryParse(answer, out int value);
                if (value >= 1 && value <= 10)
                {
                    Console.WriteLine($"You entered {value}");
                }
                else
                {
                    Console.WriteLine("Wrong position!");
                }
            } while (!success);

            string str = "abcdefg";
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
        }
        static void massiveMethod()
        {

            //string[] names = new string[6];
            //names[0] = "Ivan";
            //names[1] = "Maks";
            //names[2] = "Anton";
            //names[3] = "Alex";
            //names[4] = "Roma";
            //Console.Write("Enter your name: ");
            //names[5] = Console.ReadLine();
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //int[] numbers = new int[10];
            //Random random = new Random();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next();
            //}
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //string[] names = new string[5];
            //Console.Write("Enter first name: ");
            //names[0] = Console.ReadLine();
            //Console.Write("Enter second name: ");
            //names[1] = Console.ReadLine();
            //Console.Write("Enter third name: ");
            //names[2] = Console.ReadLine();
            //Console.Write("Enter fourth name: ");
            //names[3] = Console.ReadLine();
            //Console.Write("Enter fifth name: ");
            //names[4] = Console.ReadLine();

            //Console.Write("You wrote ");
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.Write(names[i] + ", ");
            //}



        }
        static void Calculator()
        {
            bool a, b = false;

            Console.Write("Enter a: ");
            string a1 = Console.ReadLine();
            a = double.TryParse(a1, out double value1);

            Console.Write("Enter b: ");
            string b1 = Console.ReadLine();
            b = double.TryParse(b1, out double value2);

            if (a && b)
            {
                for (; ; )
                {
                    Console.Write("If you want to exit the program enter return. Choose your operation: ");
                    string str = Console.ReadLine();
                    switch (str)
                    {
                        case "+":
                            Console.WriteLine("Your +: " + (value1 + value2));
                            break;
                        case "-":
                            Console.WriteLine("Your -: " + (value1 - value2));
                            break;
                        case "*":
                            Console.WriteLine("Your *: " + (value1 * value2));
                            break;
                        case "/":
                            Console.WriteLine("Your /: " + (value1 / value2));
                            break;
                        case "return":
                            break;
                        case "clear":
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Wrong value");
                            break;
                    }
                }
            }
        }
        static void Notebook()
        {
            string[] names = new string[5];
            Console.Write("Enter first name: ");
            names[0] = Console.ReadLine();
            Console.Write("Enter second name: ");
            names[1] = Console.ReadLine();
            Console.Write("Enter third name: ");
            names[2] = Console.ReadLine();
            Console.Write("Enter fourth name: ");
            names[3] = Console.ReadLine();
            Console.Write("Enter fifth name: ");
            names[4] = Console.ReadLine();

            int[] num = new int[5];

            Console.Write("Enter number for first person: ");
            num[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number for second person: ");
            num[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number for third person: ");
            num[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number for forth person: ");
            num[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number for fifth person: ");
            num[4] = Convert.ToInt32(Console.ReadLine());


            Console.Write("You wrote ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + ", ");
            }

            Console.Write("And their phone numbers ");
            for (int j = 0; j < num.Length; j++)
            {
                Console.Write(num[j] + ", ");
            }

        }

        static void Main(string[] args)
        {
            //ifMethod();

            //switchMethod();

            //cycleMehod();

            //massiveMethod();

            //Calculator();

            Notebook();
        }
    }
}