//what are you doing here? 🤨🤨🤨🤨
namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ERROR002 = false;
            string Operacion;
            Console.WriteLine("Welcome to Nahum's calculator!!!");
            // I am going to ask you to use commas instead of points in case the numbers you are going to use are decimals, example: 123,123
            while (true)
            {
                Console.WriteLine("Choose what you want to do, mark 1 to add two numbers, mark 2 to subtract two numbers, mark 3 to multiply 2 numbers or mark 4 to divide two numbers");
                Operacion = Console.ReadLine();
                if (Operacion == "1") //Suma
                {
                    string num1;
                    string num2;
                    Console.WriteLine("Write the first number you want to add: ");
                    num1 = Console.ReadLine();
                    Console.WriteLine("Write the second number you want to add: ");
                    num2 = Console.ReadLine();
                    int Point2 = num2.IndexOf(',');
                    int Point1 = num1.IndexOf(',');
                    if (Point1 == -1)
                    {
                        Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                    }
                    else if (Point1 != -1)
                    {
                        decimal miInteger1 = decimal.Parse(num1);
                        decimal miInteger2 = decimal.Parse(num2);
                        decimal res = Sumar(miInteger1, miInteger2);
                        Console.WriteLine("Your result is: {0}", res);
                    }
                    if (Point2 == -1)
                    {
                        Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                    }
                    else if (Point2 != -1)
                    {
                        decimal miInteger1 = decimal.Parse(num1);
                        decimal miInteger2 = decimal.Parse(num2);
                        decimal res = Sumar(miInteger1, miInteger2);
                        Console.WriteLine("Your result is: {0}", res);
                    }



                }
                else if (Operacion == "2") //Resta
                {
                    string num1;
                    string num2;
                    Console.WriteLine("Write the first number: ");
                    num1 = Console.ReadLine();
                    Console.WriteLine("Write the number that you want to subtract: ");
                    num2 = Console.ReadLine();
                    int Point2 = num2.IndexOf(',');
                    int Point1 = num1.IndexOf(',');
                    if (Point1 == -1)
                    {
                        Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                    }
                    else if (Point1 != -1)
                    {
                        decimal miInteger1 = decimal.Parse(num1);
                        decimal miInteger2 = decimal.Parse(num2);
                        decimal res = Restar(miInteger1, miInteger2);
                        Console.WriteLine("Your result is: {0}", res);
                    }
                    if (Point2 == -1)
                    {
                        Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                    }
                    else if (Point2 != -1)
                    {
                        decimal miInteger1 = decimal.Parse(num1);
                        decimal miInteger2 = decimal.Parse(num2);
                        decimal res = Restar(miInteger1, miInteger2);
                        Console.WriteLine("Your result is: {0}", res);
                    }
                }
                else if (Operacion == "3") //Multiplicacion
                {
                    string num1;
                    string num2;
                    Console.WriteLine("Write the first number: ");
                    num1 = Console.ReadLine();
                    Console.WriteLine("Write the second number: ");
                    num2 = Console.ReadLine();
                    int Point2 = num2.IndexOf(',');
                    int Point1 = num1.IndexOf(',');
                    if (Point1 == -1)
                    {
                        Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                    }
                    else if (Point1 != -1)
                    {
                        decimal miInteger1 = decimal.Parse(num1);
                        decimal miInteger2 = decimal.Parse(num2);
                        decimal res = Multiplicar(miInteger1, miInteger2);
                        Console.WriteLine("Your result is: {0}", res);
                    }
                    if (Point2 == -1)
                    {
                        Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                    }
                    else if (Point2 != -1)
                    {
                        decimal miInteger1 = decimal.Parse(num1);
                        decimal miInteger2 = decimal.Parse(num2);
                        decimal res = Multiplicar(miInteger1, miInteger2);
                        Console.WriteLine("Your result is: {0}", res);
                    }
                }
                else if (Operacion == "4") //Division
                {
                    string num1;
                    string num2;
                    Console.WriteLine("Write the divisor: ");
                    num1 = Console.ReadLine();
                    Console.WriteLine("Write the dividend: ");
                    num2 = Console.ReadLine();
                    int Point2 = num2.IndexOf(',');
                    int Point1 = num1.IndexOf(',');
                    if (Point1 == -1)
                    {
                        Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                    }
                    else if (Point1 != -1)
                    {
                        decimal miInteger1 = decimal.Parse(num1);
                        decimal miInteger2 = decimal.Parse(num2);
                        decimal res = Dividir(miInteger1, miInteger2);
                        Console.WriteLine("Your result is: {0}", res);
                    }
                    if (Point2 == -1)
                    {
                        Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                    }
                    else if (Point2 != -1)
                    {
                        decimal miInteger1 = decimal.Parse(num1);
                        decimal miInteger2 = decimal.Parse(num2);
                        decimal res = Dividir(miInteger1, miInteger2);
                        Console.WriteLine("Your result is: {0}", res);
                    }

                }
                else if (ERROR002 == true)
                {
                    Console.WriteLine("ERROR 002, Please don't use points");
                }
                else if (Operacion == "17032010")
                {
                    Console.WriteLine("Nahum... Much Work!");
                }
                else if (Operacion == "02122002")
                {
                    Console.WriteLine("Ruth... Much Motivation!");
                }
                else if (Operacion == "26081976")
                {
                    Console.WriteLine("Feliz Cumple Olivia... Beta Tester!");
                }
                else if (Operacion == "10051999")
                {
                    Console.WriteLine("Isaac... Motivation!");
                }
                else
                {
                    Console.WriteLine("ERROR 001, Try again.");
                }

            }
            static decimal Sumar(decimal num1, decimal num2)
            {
                return num1 + num2;
            }
            static decimal Restar(decimal num1, decimal num2)
            {
                return num1 - num2;
            }
            static decimal Multiplicar(decimal num1, decimal num2)
            {
                return num1 * num2;
            }
            static decimal Dividir(decimal num1, decimal num2)
            {
                return num1 / num2;
            }
            //Nivel de acceso - (static) - Tipo de retorno - Nombre del metodo (Parametro 1, Parametro 2)
            //I have a little problem guys, i can't push with git to update the repository, but if you are reading it, I was finally able to push!!!
            //I was finally able to push :)!!!
            // I am going to ask you to use commas instead of points in case the numbers you are going to use are decimals, example: 123,123 FINALLY DELETED
            //Oficial version!!!
        }
    }
}
