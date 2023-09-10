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
                Console.WriteLine("Choose an operation: 1 (Add), 2 (Subtract), 3 (Multiply), 4 (Divide), 5 (Fraction addition),6 (Fraction substraction), 7 (Multiply fraccion), 8 (Divide fraccions), 9(Discover percentage)");
                string operacion = Console.ReadLine();
                calculadora(operacion);
            }

        }

        static void calculadora(string operacion) //obtiene los numeros, hace las operaciones , 
        {
            try
            {
                switch (operacion)
                {
                    case "1": //suma
                        Console.WriteLine("Enter the first number: ");
                        string numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        string numero2 = Console.ReadLine();
                        int punto1 = numero1.IndexOf('.');
                        int punto2 = numero2.IndexOf('.');
                        decimal result1 = 0;
                        if (punto1 == -1 && punto2 == -1)
                        {
                            int num1 = int.Parse(numero1);
                            int num2 = int.Parse(numero2);
                            result1 = num1 + num2;
                            Console.WriteLine("Your result is: {0}", result1);
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "2": //resta
                        Console.WriteLine("Enter the first number: ");
                        string numero3 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        string numero4 = Console.ReadLine();
                        int punto3 = numero3.IndexOf('.');
                        int punto4 = numero4.IndexOf('.');
                        decimal result2 = 0;
                        if (punto3 == -1 && punto4 == -1)
                        {
                            int num3 = int.Parse(numero3);
                            int num4 = int.Parse(numero4);
                            result2 = num3 - num4;
                            Console.WriteLine("Your result is: {0}", result2);
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "3": //multiplicacion
                        Console.WriteLine("Enter the first number: ");
                        string numero5 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        string numero6 = Console.ReadLine();
                        int punto5 = numero5.IndexOf('.');
                        int punto6 = numero6.IndexOf('.');
                        decimal result3 = 0;
                        if (punto5 == -1 && punto6 == -1)
                        {
                            int num5 = int.Parse(numero5);
                            int num6 = int.Parse(numero6);
                            result3 = num5 * num6;
                            Console.WriteLine("Your result is: {0}", result3);
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "4": //division ☠
                        Console.WriteLine("Enter the first number: ");
                        string numero7 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        string numero8 = Console.ReadLine();
                        int punto7 = numero7.IndexOf('.');
                        int punto8 = numero8.IndexOf('.');
                        decimal result4 = 0;
                        if (punto7 == -1 && punto8 == -1)
                        {
                            decimal num7 = int.Parse(numero7);
                            decimal num8 = int.Parse(numero8);
                            result4 = num7 / num8;
                            Console.WriteLine("Your result is: {0}", result4);
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "5":
                        decimal result5 = 0;
                        Console.WriteLine("Fine, write the numerator and denominator of the first fraction");
                        Console.WriteLine("Enter the numerator: ");
                        string numero11 = Console.ReadLine();
                        Console.WriteLine("Enter the denominator: ");
                        string numero12 = Console.ReadLine();
                        decimal num11 = decimal.Parse(numero11);
                        decimal num12 = decimal.Parse(numero12);
                        decimal firstF = num11 / num12;
                        Console.WriteLine("Fine, write the numerator and denominator of the second fraction");
                        Console.WriteLine("Enter the numerator: ");
                        string numero13 = Console.ReadLine();
                        Console.WriteLine("Enter the denominator: ");
                        string numero14 = Console.ReadLine();
                        decimal num13 = decimal.Parse(numero13);
                        decimal num14 = decimal.Parse(numero14);
                        decimal secondF = num13 / num14;
                        result5 = firstF + secondF;
                        Console.WriteLine("Your result is: {0}", result5);
                        break;
                    case "6":
                        decimal result6 = 0;
                        Console.WriteLine("Fine, write the numerator and denominator of the first fraction");
                        Console.WriteLine("Enter the numerator: ");
                        string numero15 = Console.ReadLine();
                        Console.WriteLine("Enter the denominator: ");
                        string numero16 = Console.ReadLine();
                        decimal num15 = decimal.Parse(numero15);
                        decimal num16 = decimal.Parse(numero16);
                        decimal firstFS = num15 / num16;
                        Console.WriteLine("Fine, write the numerator and denominator of the second fraction");
                        Console.WriteLine("Enter the numerator: ");
                        string numero17 = Console.ReadLine();
                        Console.WriteLine("Enter the denominator: ");
                        string numero18 = Console.ReadLine();
                        decimal num17 = decimal.Parse(numero17);
                        decimal num18 = decimal.Parse(numero18);
                        decimal secondFS = num17 / num18;
                        result6 = firstFS - secondFS;
                        Console.WriteLine("Your result is: {0}", result6);
                        break;
                    case "7":
                        decimal result7 = 0;
                        Console.WriteLine("Fine, write the numerator and denominator of the first fraction");
                        Console.WriteLine("Enter the numerator: ");
                        string numero19 = Console.ReadLine();
                        Console.WriteLine("Enter the denominator: ");
                        string numero20 = Console.ReadLine();
                        decimal num19 = decimal.Parse(numero19);
                        decimal num20 = decimal.Parse(numero20);
                        decimal firstFM = num19 / num20;
                        Console.WriteLine("Fine, write the numerator and denominator of the second fraction");
                        Console.WriteLine("Enter the numerator: ");
                        string numero21 = Console.ReadLine();
                        Console.WriteLine("Enter the denominator: ");
                        string numero22 = Console.ReadLine();
                        decimal num21 = decimal.Parse(numero21);
                        decimal num22 = decimal.Parse(numero22);
                        decimal secondFM = num21 / num22;
                        result7 = firstFM * secondFM;
                        Console.WriteLine("Your result is: {0}", result7);
                        break;
                    case "8":
                        decimal result8 = 0;
                        Console.WriteLine("Fine, write the numerator and denominator of the first fraction");
                        Console.WriteLine("Enter the numerator: ");
                        string numero23 = Console.ReadLine();
                        Console.WriteLine("Enter the denominator: ");
                        string numero24 = Console.ReadLine();
                        decimal num24 = decimal.Parse(numero24);
                        decimal num23 = decimal.Parse(numero23);
                        decimal firstFD = num23 / num24;
                        Console.WriteLine("Fine, write the numerator and denominator of the second fraction");
                        Console.WriteLine("Enter the numerator: ");
                        string numero25 = Console.ReadLine();
                        Console.WriteLine("Enter the denominator: ");
                        string numero26 = Console.ReadLine();
                        decimal num25 = decimal.Parse(numero25);
                        decimal num26 = decimal.Parse(numero26);
                        decimal secondFD = num25 / num26;
                        result8 = firstFD / secondFD;
                        Console.WriteLine("Your result is: {0}", result8);
                        break;
                    case "9":
                        decimal result9 = 0;
                        Console.WriteLine("Enter the initial number: ");
                        string numero27 = Console.ReadLine();
                        Console.WriteLine("Enter the percentage that you want to know: ");
                        string numero28 = Console.ReadLine();
                        int punto27 = numero27.IndexOf('.');
                        int punto28 = numero28.IndexOf('.');
                        if (punto27 == -1 && punto28 == -1)
                        {
                            decimal num27 = decimal.Parse(numero27);
                            decimal num28 = decimal.Parse(numero28);
                            decimal total = num27 * num28;
                            result9 = total / 100;
                            Console.WriteLine("Your result is: {0}", result9);
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
                        Console.WriteLine("Olivia... Much Beta Testing!!!");
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