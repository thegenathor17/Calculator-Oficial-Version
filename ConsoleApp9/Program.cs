//what are you doing here? 🤨🤨🤨🤨
using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Nahum's calculator!!!");
            while (true)
            {
                Console.WriteLine("Choose an operation: 1 (add), 2 (subtract), 3 (multiply), 4 (divide)");
                string operacion = Console.ReadLine();
                calculadora(operacion);
            }

        }

        static void calculadora(string operacion) //obtiene los numeros, hace las operaciones , 
        {
            Console.WriteLine("Enter the first number: ");
            string numero1 = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            string numero2 = Console.ReadLine();
            int punto1 = numero1.IndexOf('.');
            int punto2 = numero2.IndexOf('.');
            decimal result = 0;
            try
            {
                switch (operacion)
                {
                    case "1": //suma
                        if (punto1 == -1 && punto2 == -1)
                        {
                            int num1 = int.Parse(numero1);
                            int num2 = int.Parse(numero2);
                            result = num1 + num2;
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "2": //resta
                        if (punto1 == -1 && punto2 == -1)
                        {
                            int num1 = int.Parse(numero1);
                            int num2 = int.Parse(numero2);
                            result = num1 - num2;
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "3": //multiplicacion
                        if (punto1 == -1 && punto2 == -1)
                        {
                            int num1 = int.Parse(numero1);
                            int num2 = int.Parse(numero2);
                            result = num1 * num2;
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "4": //division ☠
                        if (punto1 == -1 && punto2 == -1)
                        {
                            int num1 = int.Parse(numero1);
                            int num2 = int.Parse(numero2);
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "17032010":
                        Console.WriteLine("Nahum... Much Development!!!");
                        break;
                    case "02122002":
                        Console.WriteLine("Ruth... Much Beta Testing!!!");
                        break;
                    case "26081976":
                        Console.WriteLine("Feliz cumplenios Olivia... Much Beta Testing!!!");
                        break;
                    case "10051999":
                        Console.WriteLine("Isaac... Much Moral Support");
                        break;
                    case "052020":
                        Console.WriteLine("Special thanks to chat gpt, they help me with ideas (they don't wrote any part of the code)");
                        break;
                    default:
                        Console.WriteLine("ERROR 001, Try again");
                        break;
                }

                Console.WriteLine("Your result is: {0}", result);
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("ERROR 006, To much numbers");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERROR 003, You can't divide by zero");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ERROR  004, Please write all the numbers needed");
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR 005, Something went wrong");
            }

        }
    }
}
//bool ERROR002 = false;

// I am going to ask you to use commas instead of points in case the numbers you are going to use are decimals, example: 123,123

//  else if (num1 == "0")
//  {
//      Console.WriteLine("ERROR 003, the division cannot contain a 0");
//  }
//  else if (num2 == "0")
//  {
//      Console.WriteLine("ERROR 003, the division cannot contain a 0");
//  }
//  else if (ERROR002 == true)
//  {
//      Console.WriteLine("ERROR 002, Please don't use points");
//  }

//Nivel de acceso - (static) - Tipo de retorno - Nombre del metodo (Parametro 1, Parametro 2)
//I have a little problem guys, i can't push with git to update the repository, but if you are reading it, I was finally able to push!!!
//I was finally able to push :)!!!
// I am going to ask you to use commas instead of points in case the numbers you are going to use are decimals, example: 123,123 FINALLY DELETED
//Oficial version!!!
//Bugs fixed
//thanks Chat GPT