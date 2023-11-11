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
                Console.WriteLine("Choose an operation: 1 (Add), 2 (Subtract), 3 (Multiply), 4 (Divide), 5 (Fraction addition),6 (Fraction substraction), 7 (Multiply fraccion), 8 (Divide fraccions), 9 (Discover percentage), 10 (Raise a number), 11 (Add raised numbers), 12 (Subtract raised numbers), 13 (Multiply raised numbers), 14 (Divide raised numbers), 15 (Discover the Square Root), 16 (Discover the Cube Root), 17 (Conversions menu)");
                string operacion = Console.ReadLine();
                calculadora(operacion);
            }

        }

        static void calculadora(string operacion) //obtiene los numeros, hace las operaciones , 
        {
            string numero1;
            string numero2;
            string numero3;
            string numero4;
            try
            {
                switch (operacion)
                {
                    case "1": //suma
                        Console.WriteLine("Enter the first number: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        numero2 = Console.ReadLine();
                        if (punto(numero2) == -1 && punto(numero1) == -1)
                        {
                            Console.WriteLine("Your result is: {0}", parse(numero1) + parse(numero2));
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "2": //resta
                        Console.WriteLine("Enter the first number: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        numero2 = Console.ReadLine();
                        if (punto(numero2) == -1 && punto(numero1) == -1)
                        {
                            Console.WriteLine("Your result is: {0}", parse(numero1) - parse(numero2));
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "3": //multiplicacion
                        Console.WriteLine("Enter the first number: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        numero2 = Console.ReadLine();
                        if (punto(numero2) == -1 && punto(numero1) == -1)
                        {
                            decimal result1 = parse(numero1) * parse(numero2);
                            Console.WriteLine("Your result is: {0}", result1);
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "4": //division ☠
                        Console.WriteLine("Enter the first number: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the second number: ");
                        numero2 = Console.ReadLine();
                        if (punto(numero2) == -1 && punto(numero1) == -1)
                        {
                            Console.WriteLine("Your result is: {0}", parse(numero1) / parse(numero2));
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "5": //Suma de Fracciones
                        Console.WriteLine("Fine, write the numerator of the first fraction");
                        Console.WriteLine("Enter the numerator: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Now enter the denominator: ");
                        numero2 = Console.ReadLine();
                        Console.WriteLine("Fine, write the numerator of the second fraction");
                        Console.WriteLine("Enter the numerator: ");
                        numero3 = Console.ReadLine();
                        Console.WriteLine("Now enter the denominator: ");
                        numero4 = Console.ReadLine();
                        Console.WriteLine("Your result is: {0}", (parse(numero1) / parse(numero2)) + (parse(numero3) / parse(numero4)));
                        break;
                    case "6": //Resta de Fracciones
                        Console.WriteLine("Fine, write the numerator of the first fraction");
                        Console.WriteLine("Enter the numerator: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Now enter the denominator: ");
                        numero2 = Console.ReadLine();
                        Console.WriteLine("Fine, write the numerator of the second fraction");
                        Console.WriteLine("Enter the numerator: ");
                        numero3 = Console.ReadLine();
                        Console.WriteLine("Now enter the denominator: ");
                        numero4 = Console.ReadLine();
                        Console.WriteLine("Your result is: {0}", (parse(numero1) / parse(numero2)) - (parse(numero3) / parse(numero4)));
                        break;
                    case "7": //Multiplicacion de Fracciones
                        Console.WriteLine("Fine, write the numerator of the first fraction");
                        Console.WriteLine("Enter the numerator: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Now enter the denominator: ");
                        numero2 = Console.ReadLine();
                        Console.WriteLine("Fine, write the numerator of the second fraction");
                        Console.WriteLine("Enter the numerator: ");
                        numero3 = Console.ReadLine();
                        Console.WriteLine("Now enter the denominator: ");
                        numero4 = Console.ReadLine();
                        Console.WriteLine("Your result is: {0}", (parse(numero1) / parse(numero2)) * (parse(numero3) / parse(numero4)));
                        break;
                    case "8":  //Dividir Fracciones
                        Console.WriteLine("Fine, write the numerator of the first fraction");
                        Console.WriteLine("Enter the numerator: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Now enter the denominator: ");
                        numero2 = Console.ReadLine();
                        Console.WriteLine("Fine, write the numerator of the second fraction");
                        Console.WriteLine("Enter the numerator: ");
                        numero3 = Console.ReadLine();
                        Console.WriteLine("Now enter the denominator: ");
                        numero4 = Console.ReadLine();
                        Console.WriteLine("Your result is: {0}", (parse(numero1) / parse(numero2)) / (parse(numero3) / parse(numero4)));
                        break;
                    case "9": //Descubrir Porcentaje
                        decimal result9 = 0;
                        Console.WriteLine("Enter the initial number: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the percentage that you want to know: ");
                        numero2 = Console.ReadLine();
                        if (punto(numero1) == -1 && punto(numero2) == -1)
                        {
                            Console.WriteLine("Your result is: {0}", (parse(numero1) * parse(numero2)) / 100 );
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "10": //elevar un numero
                        Console.WriteLine("Enter the base number: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the exponent: ");
                        numero2 = Console.ReadLine();
                        if (punto(numero1) == -1 && punto(numero2) == -1)
                        {
                            Console.WriteLine("Your result is: {0}", Math.Pow(parseDouble(numero1), parseDouble(numero2)));
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "11": //Sumar numeros elevados
                        Console.WriteLine("Enter the first base number: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the first exponent: ");
                        numero2 = Console.ReadLine();
                        Console.WriteLine("Enter the second base number: ");
                        numero3 = Console.ReadLine();
                        Console.WriteLine("Enter the second exponent: ");
                        numero4 = Console.ReadLine();
                        if (punto(numero1) == -1 && punto(numero2) == -1 && punto(numero3) == -1 && punto(numero4) == -1)
                        {
                            Console.WriteLine("Your result is: {0}", Math.Pow(parseDouble(numero1), parseDouble(numero2)) + Math.Pow(parseDouble(numero3), parseDouble(numero4)));
                        }
                        break;
                    case "12": //Restar numeros elevados
                        Console.WriteLine("Enter the first base number: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the first exponent: ");
                        numero2 = Console.ReadLine();
                        Console.WriteLine("Enter the second base number: ");
                        numero3 = Console.ReadLine();
                        Console.WriteLine("Enter the second exponent: ");
                        numero4 = Console.ReadLine();
                        if (punto(numero1) == -1 && punto(numero2) == -1 && punto(numero3) == -1 && punto(numero4) == -1)
                        {
                            Console.WriteLine("Your result is: {0}", Math.Pow(parseDouble(numero1), parseDouble(numero2)) - Math.Pow(parseDouble(numero3), parseDouble(numero4)));
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "13": //Multiplicar numeros elevados
                        Console.WriteLine("Enter the first base number: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the first exponent: ");
                        numero2 = Console.ReadLine();
                        Console.WriteLine("Enter the second base number: ");
                        numero3 = Console.ReadLine();
                        Console.WriteLine("Enter the second exponent: ");
                        numero4 = Console.ReadLine();
                        if (punto(numero1) == -1 && punto(numero2) == -1 && punto(numero3) == -1 && punto(numero4) == -1)
                        {
                            Console.WriteLine("Your result is: {0}", Math.Pow(parseDouble(numero1), parseDouble(numero2)) * Math.Pow(parseDouble(numero3), parseDouble(numero4)));
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "14": //dividir numeros elevados
                        Console.WriteLine("Enter the first base number: ");
                        numero1 = Console.ReadLine();
                        Console.WriteLine("Enter the first exponent: ");
                        numero2 = Console.ReadLine();
                        Console.WriteLine("Enter the second base number: ");
                        numero3 = Console.ReadLine();
                        Console.WriteLine("Enter the second exponent: ");
                        numero4 = Console.ReadLine();
                        if (punto(numero1) == -1 && punto(numero2) == -1 && punto(numero3) == -1 && punto(numero4) == -1)
                        {
                            Console.WriteLine("Your result is: {0}", Math.Pow(parseDouble(numero1), parseDouble(numero2)) / Math.Pow(parseDouble(numero3), parseDouble(numero4)));
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "15": //encontrar raiz cuadrada
                        Console.WriteLine("Enter the number of which you want to know the square root: ");
                        numero1 = Console.ReadLine();
                        if (punto(numero1) == -1)
                        {
                            int numeroParseado = int.Parse(numero1);
                            Console.WriteLine("Your result is: {0}", Math.Sqrt(numeroParseado));
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "16": //encontrar raiz cubica
                        Console.WriteLine("Enter the number of which you want to know the square root: ");
                        numero1 = Console.ReadLine();
                        if (punto(numero1) == -1)
                        {
                            int numeroParseado1 = int.Parse(numero1);
                            Console.WriteLine("Your result is: {0}", Math.Cbrt(numeroParseado1));
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "17": //menu de conversiones
                        sbyte numeroWhile3 = 1;
                        while (numeroWhile3 == 1)
                        {
                            Console.WriteLine("Welcome to the conversions menu! 1 (Length), 2 (Weight), 3 (Pressure), 4 (Fuel Consumption), 5 (Energy), 6 (Frequency), 15 (Got to Main Menu): ");
                            Console.WriteLine("Soon!");
                            Console.WriteLine("7 (Data Size), 8 (Data Transmission Rate), 9 (Temperature), 10 (Time), 11 (Speed), 12 (Volume), 13 (Plane Angle), 14 (Area): ");
                            string operacion3 = Console.ReadLine();
                            switch (operacion3)
                            {
                                case "1":
                                    Console.WriteLine("Welcome to the length conversion menu! 1 (Centimeters to Inches), 2 (Inches to Centimeters), 3 (Centimeters to Feet), 4 (Feet to Centimeters), 5 (Meters to Yards), 6 (Yards to Meters), 7 (Kilometers to Miles), 8 (Miles to Kilometers), 9 (Kilometers to Nautical Miles), 10 (Nautical Miles to Kilometers), 11 (Miles to Nautical Miles), 12 (Nautical Miles to Miles), 13 (Go to Main Menu):");
                                    string operacionLongitud = Console.ReadLine();
                                    sbyte numeroWhile1 = 1;
                                    while (numeroWhile1 == 1)
                                    {
                                        switch (operacionLongitud)
                                        {
                                            case "1": //transforma centimetros en pulgadas
                                                Console.WriteLine("Enter the centimeters you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) / 2.54);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;

                                            case "2": //convierte pulgadas en centimetros
                                                Console.WriteLine("Enter the inches you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) * 2.54);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "3": //convierte centimetros  en pies
                                                Console.WriteLine("Enter the centimeters you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) / 30.48);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "4": //transforma pies en centimetros
                                                Console.WriteLine("Enter the feets you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) * 30.48);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "5": //transforma yardas en metros
                                                Console.WriteLine("Enter the meters you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) * 1.094);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "6": //transforma metros en yardas
                                                Console.WriteLine("Enter the meters you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) / 1.094);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "7": //transforma kilometros en millas
                                                Console.WriteLine("Enter the kilometers you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) / 1.609);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "8": //transforma millas en kilometros
                                                Console.WriteLine("Enter the miles you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) * 1.609);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "9": //transforma kilometros en millas nauticas
                                                Console.WriteLine("Enter the kilometers you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) / 1.852);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "10": //transforma millas nauticass en kilometros
                                                Console.WriteLine("Enter the nautic miles you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) * 1.852);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "11": //transforma millas en millas nauticas
                                                Console.WriteLine("Enter the miles you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) / 1.151);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "12": //transforma millas nauticas en millas
                                                Console.WriteLine("Enter the nautic miles you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) * 1.151);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "13":
                                                numeroWhile1++;
                                                break;
                                        }
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Welcome to the weight conversion menu! 1 (Gram to Ounce), 2 (Ounce to Gram), 3 (Gram to Pound), 4 (Pound to Gram), 5 (Kilogram to Stone), 6 (Stone to Kilogram), 7 (Go to converions menu) ");
                                    string operacionPeso = Console.ReadLine();
                                    sbyte numeroWhile2 = 1;
                                    while (numeroWhile2 != 0)
                                    {
                                        switch (operacionPeso)
                                        {
                                            case "1": //gramos onzas
                                                Console.WriteLine("Enter the grams you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) / 28.35);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "2": //onzas gramos 
                                                Console.WriteLine("Enter the ounces you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) * 28.35);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "3": //gramos libras
                                                Console.WriteLine("Enter the grams you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) / 453.6);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "4": //libras gramos
                                                Console.WriteLine("Enter the pounds you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) * 28.35);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "5": //kilo a stone
                                                Console.WriteLine("Enter the kilograms you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) / 6.35);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "6": //stone kilo
                                                Console.WriteLine("Enter the stones you want to convert: ");
                                                numero1 = Console.ReadLine();
                                                if (punto(numero1) == -1)
                                                {
                                                    Console.WriteLine(parseDouble(numero1) * 6.35);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                                                }
                                                break;
                                            case "7": //go back
                                                numeroWhile2 += 2;
                                                break;
                                        }
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Welcome to the pressure menu! 1 (Atmosphere to Bar) 2 (Bar to Atmosphere) 3 (Pound per square inch to Pascal) 4 (Pascal to Pound per square inch) 5 (Atmosphere to Torr) 6 (Torr to Atmosphere)");
                                    string operacion4 = Console.ReadLine();
                                    sbyte numeroWhile4 = 1;
                                    while (numeroWhile4 == 1)
                                    {
                                        switch (operacion4)
                                        {
                                            case "1":
                                                Console.WriteLine("Write the atmosphere you want to convert: ");

                                                break;
                                        }
                                    }
                                    break;
                                case "15":
                                    numeroWhile3 += 3;
                                    break; 
                            }
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
                if (operacion == "1703")
                {
                    Console.WriteLine("       ..          .                                                .                                                                                                                                                                         ..                                                            ");
                    Console.WriteLine("                                                                                                                                                                                                                                                                                                            ");
                    Console.WriteLine("                                                      .                                                                                                                                                                                                                                                     ");
                    Console.WriteLine("                                            .        .'                                                                             ..                                                                                                                             .                                     .. ");
                    Console.WriteLine(" ..                                                                                                                                 ..                                                                                                                                                                      ");
                    Console.WriteLine("                                                                                                                                                                              .                                                       '.                                                                    ");
                    Console.WriteLine("                                                                                                                                                        .                                                  .                                                                                                ");
                    Console.WriteLine("                                                .            .                                                             .                       .                                                                                                                                                        ");
                    Console.WriteLine("                                                                                                                                                                                                                                                                                                            ");
                    Console.WriteLine("                                        .                                                                                                                                                            ..                                                                       .  ...                        ");
                    Console.WriteLine("                                                                                ..                                                                .;.                                                ..                                                                          .                          ");
                    Console.WriteLine("                                                                                                                                                  .'.                          ..                                                                                                                           ");
                    Console.WriteLine("                                  .   ..                                                                                                                                                                                                                                                                    ");
                    Console.WriteLine("                                    ...                                                                                                                                                     .                       .                                                                                       ");
                    Console.WriteLine("                                                                                                                                                                                                                                                                                                            ");
                    Console.WriteLine("                                                                                         .c:.                                                                                                                                        .                   .                                                  ");
                    Console.WriteLine("                                                                                          '.              ..                                                                                                       .'.                                  .;.                                                 ");
                    Console.WriteLine("                                                        .',:ll:'.                                                                                                                                                  .,.                                                                                      ");
                    Console.WriteLine("                                                      .:xkxxKWWXO:.                                                                                                                                                                                               .                                         ");
                    Console.WriteLine("            ..                                       .dKKkkKXNNWWNo.                                                                                                                                                                                            ..                                          ");
                    Console.WriteLine("            ..                                       :XK0KXWWKOXWWO.                                                                                                                                                                                           .c'                                          ");
                    Console.WriteLine("                                                     'kKKO0NWX0KXXd.                                                                                                                                                                                                                                  ..    ");
                    Console.WriteLine("                     .                                ,k0Ok0NNNNKo.     .                              .                                                                         ..                .                                                                                                  ..    ");
                    Console.WriteLine("                  .;,.                                 .,clooool'                                      .                                                                         ..                                                                                                            .    .,.     ");
                    Console.WriteLine("                  .;,         .'.                                                                                                                                                                                                                        ..                            ..      .            ");
                    Console.WriteLine("                               .                .                           .                       .                                                                                                                                                                                                       ");
                    Console.WriteLine("                                                .      .                                                                                                                                                                                                                                                    ");
                    Console.WriteLine("                                                                                                                                                                                                                                                                                                            ");
                    Console.WriteLine("                             .',,,,'..  ..                                                    ..                                                                                                                                                                                                            ");
                    Console.WriteLine("                       ..,;:oooOXXOOKOddO0kd:'.                                               .                                                                                                                         ..                                                                                  ");
                    Console.WriteLine("                   .,cxOOkkxOKXK0KKXN0ddxkOxxkd:,.                                                                                                                                                                                     ...''.  ...''..                                                      ");
                    Console.WriteLine("                 .:k0XNX0Ok0NNNXK00kxxxxkxdodKNKkoc'                                  .                                                                                                                       .                  ..,cdxkxodxxoloodkxdlldxoc,.                                               ");
                    Console.WriteLine("               'ldkxx0XXK0kkKX0OOO00XKK00000k0WW0kKk:..                                                                                                                                                        .             .;;;lxkOOOkdoxOOkxxkOO0KNWNKKNXdodc..                                     .    ");
                    Console.WriteLine("             .:OKOkkOkkOXNKKXWWWKkk0XNKKN00X0xxkkxkOdlc.                                                                                                                                   .                              .;dKK0OkOOKNNK000OOO00OKWWWWWX0OOxkXXxx0k,.                                       ");
                    Console.WriteLine("            ,xKK0O0KXNXkOK0OOKNWXOOOOkxk0O0NWKkxO0Okkkxc.                                                                                                                                ..        .                   .:d0000KKOdxk0000000OO0KXXNX0OOOOOOOkkkkOXKkxkx:.                                    ");
                    Console.WriteLine("           ;KNK000XWNNNK0O00xlkNKKXXKOxkKKKNXkk0XWW00KOOd;.                                                                                                                             .c;       ...'.              .;dO0Okddk0Okkkk0KNWNXKK0OOkxxxkOOOOxddOXKOxdONK0XO:.                                  ");
                    Console.WriteLine("          .d0OkxdkKX0O0O00kk0K00OxdkXMXXNKOkkxOXWN0dlkOxxk:                                                      ..                         ..                              .                       .'.            .o0XKK0OOOO0KKKXXNWWWWWXKKKXKOkkkkkkO0KNWKOkOOkkOk00Okl'.                                ");
                    Console.WriteLine("         .o00Okxdk0NWNXO0W0doOKNWNXNWXOOKNWWXKNN0kdddkOKXOd'                                                                    .                                                                                 ;xOO0OOOOOOOKWMMMWWMWNNXK0OkkxdxOKNWWNXXNWNKOOxx0NWNOdddOk;.                              ");
                    Console.WriteLine("         ,kkxdok000K000XWWWXOkkkO0NMW0kOOKNKKWWNKOxdkX0k0OOo.                                                                                                                                                   .xNWWNNXXXXXXKNNXOkxxkOOkkOO0KNWWNKOO0000XWMWXKNWWWXkxxk0NWWNk'                            .");
                    Console.WriteLine("         :OOkkxOK0OO0OOKNK0KK0OOkOXK0kxOKXXOxkk0KKXXOOOxOxdo.                                                                                                                                                  ;0WX00XNXKXXK000Okdxk0XNWWWWMMWXK0OkkKNWWWMMMWWNKOkkxx0NWWWWWWWO,       ......'',,,,,',,,'',:");
                    Console.WriteLine("        .dXOO00000kocldkkxkkOkolkXWKdok0XX0O0xdkOOkk0K0dddxk'                              .               ..                                                                                                 'kNWWXXNWNNNNNNWWWWNXKOkxxOKXWMWWWWMMWWMWWWWXOxkkkO0XWMWWWWMWNWWWO'':,'',',,,'.........  .... ");
                    Console.WriteLine("        .dKxd00OOkxddoooloxO00xokXWN0kkXWWNOkddKN0OOXWOokK0k;                                              ..                                                                                                ,xkOOkOOOOOOOOOkkOOOkkkxkO0XWWMMMMMMMWWX0OOkkkxkXWWWWWWWWWWNNNWWXOddl,..........'........'''.',");
                    Console.WriteLine("        .dWNX0Okkxk0xxl:loxOkxlokOkONX0kdxkxkOOkxlokKWXKXOxo.                                                                                                                                               ;KWWWNXKKKKKKKKXXNNWWMWWMMMWWMMMWWNXOxdxkkO0XWWWWNK0KNNWWWWNNWNkoxOXW0;.......          .,;...,'");
                    Console.WriteLine("         cOkO0KOOOxdodcoxllxK0xx0NXOKXNNK0Oxk00KKkkOXWNKOkkd.                                                                                                                                              .xNWWWWWWWWMMMMWNNXXXXWWWWWNXK0kxkkkkkOKNWWWWXKK0KKKKNMMMMWNKkxkkONWNNXo.            .....'. ... ");
                    Console.WriteLine("         'kKxx0Ok00oclldOkdoxdddxk0K00KWNXXNNK0OkddkXWXkxxkc                                      ..                                                                                                       ckkxxxxOXWWWMMWWXKK000OxdddxkOOO0XWMMWWWNXOkO0KKXWWWWWWWN0ddxOKNWWWWKOOk;       ..',....   .   ..");
                    Console.WriteLine("         .o0Oxk0kk0kooxkKW0OOOkxOOxxOKWN0Ok0XWK0OxkO0K0OO0x.                                                                                                                                              .kNXK0KKKXNWWWWNXKK0O0OOO0KNWWWMWNNXKK0KK0KKKNMMMWWWNKOkkkkOXWWWXK000O0XWk'..........       ..',''");
                    Console.WriteLine("          'xKOO00KXkd00dxKOk0NXOKX000XWX0OOKXXKOkkxxOK0xxO:                                                                                                                                               ;0NNXXXXXXXNWWWMMMMMMMMMMWNXXXOkkO00KKXNWMMWWMWNXKkdoxOKNWMMWXKOkOKXWWWNKk:....        ..';;,'..  ");
                    Console.WriteLine("           ,OKOOOXN0kOOxO0OOOXNXXKOOK00KK0OOOOK0KXXXKKNNk,                                                                .'                         ...                                                  ;xkkkOO000OOOO0NMMMMMMMMMWNXXXXNWNXNWWMMWNK0OkOOkOOKNWMMWWWWWXKXX0kxlc;'.        ..''''''..       ");
                    Console.WriteLine("            .dXXKXXXNXkdOXXKXKO0NN00KOkkxkOddxOKWMN0kk00;                                                                ...                         'l,                                                  :KNKK000O0KKKXNWWWMWWMMMWNXK00OkxxOXWMMMWXKKKXNWWMWWMMMMWNX0kdc,..         ...',;;'..             ");
                    Console.WriteLine("             .lXNOo::cc:coolkOxkXXO0K0O0XOkO0KO0XKkOX0l.                                                                                                                                            ..,,,,lxkkO00KXXXXK000OOkkkkkkOOOkOO0KNWMMWNXXKKKKKXNWWWNKkxoc;'..        ..,:ldl,'...                  ");
                    Console.WriteLine("             .;;'.   ..',...,ldxxkxdkKKKXkodkOkOXX00d'                                                                                                                                         ..'';::;'..oNX0kdddddddddddxkOOKXNWWMMMMMMWWMMNKOkO0KK00Oxdl;'.          ...':oOXWWWNd.                      ");
                    Console.WriteLine("           .;,.     ..    .....;ONNX00OOOOOxkXXK0Oo'                          .                                                                                                          .';,,'','..'.....l0K0KKKXWWWWWMMMMWWWWMMMMMWMMMMMMWX0Oxdlc;'..          .,:::;:ldk0XNWMMWNNl                       ");
                    Console.WriteLine("          .:.             ...''.;kNN00KOkOOkK0dc;.                                                       ..                                                                          .',;::;.......''.    ;0KOkkk0NMMWMMWWNNXXKK0OOO0KOkxoc;..           ..';clodxkkkxx0NWWWMWWMMWXO,                       ");
                    Console.WriteLine("         .:'         ....''..... ,OX0kdoodol,.                                                            .                                                                     .,;;,,,'...'.....         .lOkxdddddxkOOOOxoc:;,''.....           .';cldk0K0OkOOOOOKNNXXNWWWWWXOkOk:                        ");
                    Console.WriteLine("         .:.      ..';,..'.....  .dd,..                                                                                                                                     ..,,:c,....',.'.               lXXOxolcclll::;'.            ...,;:lodOKNWWNX000kk0XNNXK0KK0XWNKOkOkkKNK:                        ");
                    Console.WriteLine("         .;,.....,,'..... ..   .';d;                                                                                                                                     ';;;;,'...'..;c..     ..'','......';;,'...              .,:codk0KXNWMMMMMMWWWNNNWWWXOO0K0KXNN0kkOOOKNWWN0c.                        ");
                    Console.WriteLine("         .::,....'...''..  ....'.,l,                                                                                                                                  ',;lc,',,...,:..','..'....',''.                ...',:cloxOOKWWWMMMMMMMMMMMMMMMWWXKK000OkKNNK0OOOkOXWWNK0000o.                         ");
                    Console.WriteLine("          :c''.';;,...  ..'......,;                                                                                                                                 .:;.';c:.';;.......                   ...';clodxkOKXNWWMMMMMWWMMMMMMMMMMWX0kkk00KKK0KNNNNOxO000XNWWXOkO00KXNO,                          ");
                    Console.WriteLine("          .ll,''.. ........     .;.                                                                                                                                 ,c....''........     ........''.''.'...'',:kKKKKXNNNNXXKKKKXNWMMMMMMMMMMWXK00KNWMWWMMMWWNKKNMWWMWXK000NNKOkl.                           ");
                    Console.WriteLine("           .,:,..''','..'..   .;,.                                                                                                                                   .,,;:::;;;;;;;;::;,'',''''.......         .d0K0KKKKK0KKKKXNNNXNNWWMMMMMMMMMWNNWMMWMMMMMMMMMMWWMMMWNKkxkO0o.                            ");
                    Console.WriteLine("             .,::;,..'';'...'''.                                                                                                                                          ..........                            .lKWMWMWWWNXXKKXKKXNNWMMMMMMWWMMMWWWWWWNNNNWWWMMWXK0OOOOOOKN0o.                             ");
                    Console.WriteLine("                .',;::::c:,..                                                                                                                                                                                     ,xKXNWWWWMMMMMMMWWNXXKK0OOkk0NMWWMWWWWNNNNK0Oxdxk0KXWWNXO:.                               ");
                    Console.WriteLine("              .                                                                                                                                                                                                     .:xOOOkkkkkkkOOOOkkOOOO0XNWWMWWNKK00OOOOOO0KNWMWXKKKOl'                                 ");
                    Console.WriteLine("              ..          .                                    .                                                                                                                                                     .;xXNXXXXXXXNWWWMMMMMMMMMMMWKkxk00KK0KK00XWWWXKKK0d;.                           .      ");
                    Console.WriteLine("                                                               .                                                                                                                                                        'lONWWNXXXXXNXNNWWMMMMMMWNWWWNKKKKKXNWWMWWNXkl'                                     ");
                    Console.WriteLine("                                                            .                                                                                                                                                              'lk0XXXXNNWMMWMMWWMMMWWWWXK00XNNWWMMWKko,                                        ");
                    Console.WriteLine("        ..                                                  ..                                                                                                                                                                .,;codxO0OOOOOOOOOOOOOOO00XWNKkdl;.                                           ");
                    Console.WriteLine("        ..                                                                                                                                                                                                                          .,::lddddxkOO0K00Okdoc;.                                                ");
                    Console.WriteLine("                                                                                                                                                                                                                                          ...........                                                       ");
                    Console.WriteLine("                                                                                                                                                                                                                                                                                                            ");
                    Console.WriteLine("                                                                            .                                                                                                                                                                                                                               ");
                    Console.WriteLine(".                                                                                                                                                                                       ..                                                                      .'.                            .      ..    ");
                    Console.WriteLine("                                                                                                                                                                                                                                                                ..                                          ");
                    Console.WriteLine("                                                                     .                                                                                                                                                                                                                                      ");
                    Console.WriteLine("                                          .'.                                                                                                                                                                                                                                                               ");
                    Console.WriteLine("                                           .                                                                  ..'',;:::::::::::::::::::cc:;,,'..                                                                               ...                                                                          ");
                    Console.WriteLine("                                                                                                     ...,:clooololc;,''....... .........'';:looool:,..                                                                                                                                                      ");
                    Console.WriteLine("                                                                                                .,ccccc::;'...                                 ..';:cccll;.                                                                                                                                                 ");
                    Console.WriteLine("                                                                                            .,codo:'.                                                 ..;odl;.                                                        .           .               ..                                                        ");
                    Console.WriteLine("                                                                                        ':lll:,.                                                          .,clc,                                                                                                                                            ");
                    Console.WriteLine("                   .                                                                .,clol,.                                                                 .:kd'                                                                                                                                          ");
                    Console.WriteLine("                  ..                                                             'llc:,.                                                                       .;dl.                                                                                                                            ..          ");
                    Console.WriteLine("                                                                              ':llc.                                                                             .ox:.                                                                        .,.                        ..                     .           ");
                    Console.WriteLine("                            .                                              .loc,.                                                                                  .lo,                                                                                                  ..                                 ");
                    Console.WriteLine("                         .,.                                             'col.                                                                                       ,do'                                                                                                             .                     ");
                    Console.WriteLine("                         .'.                                           ;dl,.                                                                                          .:xc                                                                                                            ..                    ");
                    Console.WriteLine("                                                                     'lo,                                                                                               .od,                                                                                                                                ");
                    Console.WriteLine("                                                                   .dx;                                                                                                   ;xl.                                               ..                                                   .                         ");
                    Console.WriteLine("                                                                  ;dc.                                                                                                     .ld,                                                                                                                             ");
                    Console.WriteLine("                                                                .od'                                                                                                         ;ko.                                                                                                                           ");
                    Console.WriteLine("                                                               ,dl.                                                                                                           .lo'                                                                                                                          ");
                    Console.WriteLine("                                                              ;x;                                                                                                              .o0c.                                                                                                                        ");
                    Console.WriteLine("                                                            .ld,                                                                                                               'OWNx'                                                                                                                       ");
                    Console.WriteLine("                                                           .oO,                                                                                                                '0WWW0,                                                                                                                      ");
                    Console.WriteLine("                                                           cx'                                                                                                                 .xWMMWKl.                                                                                    ..                              ");
                    Console.WriteLine("                                                          ,x,                                                                                  ,lddc,.                          ;KWWMWWx.                                                                                                                   ");
                    Console.WriteLine("                                                         .dc                                                                                  ;KMMWWN0xo'                        ;0WWMWWO'                                                                                                                  ");
                    Console.WriteLine("                                                         lx.                                                                                  cNMMMMMMMWKl.                       .dXWWWW0;                                                                                                                 ");
                    Console.WriteLine("   .                                                    ,Oc                                                                                   ;KMWMMMMMWWWx.                        ,xXWWWXl.                                                                                                               ");
                    Console.WriteLine("                                                        lO'                                                                                   .dWWWMMMMMMMNO,                         ':lloxl.                                                                                                              ");
                    Console.WriteLine("                                                       .dl                                                                                     .dNWMWWMMMMMW0'                             .dd.                                                                                                             ");
                    Console.WriteLine("                                                       'x;                                                                                      .dNMWWWWMMMMWo.                             .xx.                                                                                                            ");
                    Console.WriteLine("                                                       ,x,                                                                                       .lXWWMMMMMWMO.                              .od.                                                                                                        .,.");
                    Console.WriteLine("                                                       ;o.                                                                                         'oKWWMMWMWk.                               .lo.                                                                                                          ");
                    Console.WriteLine("                                                       ;o.                                                                                           .;ckKXXO,                                 .ok'                                                                                                         ");
                    Console.WriteLine("                                                       ;o.                                                                                               ....                                   .dx.                                                           .                                            ");
                    Console.WriteLine("    .                                                  ;x'                                                                                                                                       .od.                                                                                                       ");
                    Console.WriteLine("                                                       ,x;                                                                                                                                        .xo.                                                                                                     .");
                    Console.WriteLine("                                                       .x:                                                                                                                                         'Oo.                                                                                                     ");
                    Console.WriteLine("                                                       .dd.                                                                                                                                         :0l                             ..                                                                      ");
                    Console.WriteLine("                                                        c0,                                                                                                                                          :k,                            .'                                                                      ");
                    Console.WriteLine("                                                        'kc                                                                                                                                           ox.                                                                                                   ");
                    Console.WriteLine("                                                         ox.                                                                                                                                          'xc                                                                                                  .");
                    Console.WriteLine("                                                         .d:                                                                                                                                           cO,                 '.                                                                               ");
                    Console.WriteLine("                                                          cd.                                                                                                                                          .kx.                ..                                                                               ");
                    Console.WriteLine("                                                          .dc                                                                                                                                           l0;                                                                                                 ");
                    Console.WriteLine("                                                           ;x;                                                                                                                                          .xo                                        .'                                                .      ");
                    Console.WriteLine("                                                            oO,                                                                                                                                          ck'                                      ...                         ',                            ");
                    Console.WriteLine("                                                            .xd.                                                                                                                                         'x:                                      .                                        .                ");
                    Console.WriteLine("                                                             .dl.                                                                                                                                        .do                                                                               ..               ");
                    Console.WriteLine("                                                              .dl.                                                                                                                                        ld.                                                                               .               ");
                    Console.WriteLine("                                                               'kd.                                                                                                                                       ;x,                                                                                               ");
                    Console.WriteLine("                                                                .do.                                                                                                                                      .k:                     ..                                                                        ");
                    Console.WriteLine("                                        .                        .oo.                                                                                                                                     .do                                                                                               ");
                    Console.WriteLine("                                                                  .cx;                                                                                                                                     oO'                                                                                              ");
                    Console.WriteLine("                                                                    :xc.                                                                                                                                   cK:                                                                                              ");
                    Console.WriteLine("                                                                     .ld'                                                                                                                                  :K:                                                                                              ");
                    Console.WriteLine("                                                                       ckc.                                                                                                                                :Kc                                                                                     .        ");
                    Console.WriteLine("                       ';.                                              .cd,                                                                                                                               :Kc                                                                   ..                .        ");
                    Console.WriteLine("                       ',.                                                ,ol'                                                                                                                             cK:                                                                   ..                         ");
                    Console.WriteLine("                                                                           .;do'                                                                                                                           o0,                                                                                              ");
                    Console.WriteLine("                                                ..                           .:ol,                                                                                                                        .xl                                                                                               ");
                    Console.WriteLine("                                                                               .;od;                                                                                                                      :k'                                                                                               ");
                    Console.WriteLine("                                                                                  ,ll:.                                                                                                                  .xl                                                                                                ");
                    Console.WriteLine("                                       ..                                           .:xo'                                                                                                               .xd.                                                                                                ");
                    Console.WriteLine("                                       ..                                             .;ll:.                                                                                                           ,xd.                                                                                                 ");
                    Console.WriteLine("                                                                                         .cxl'                                                                                                       'ld,                                                                                                   ");
                    Console.WriteLine("                                                                                           .;ll:.                                                                                                .;cll;.                                                                                                    ");
                    Console.WriteLine("                                                                                              .cd:.                                                                                           .:odo;.                                                                                                       ");
                    Console.WriteLine("                                   .                                                            .:ol.                                                                                     .:::c:'.                                                                                                          ");
                    Console.WriteLine("                                                                                                  .:d:.                                                                                .,cl:.                                                                                                               ");
                    Console.WriteLine("       ..                                                                                           .cx:.                                                                            .cc;.                                                                                                                  ");
                    Console.WriteLine("                                                                                                      'dl.                                                                          ;l;.                                                                                                                    ");
                    Console.WriteLine("                                                                                                       .cd,                                                                       .cc.                                                                                                                      ");
                    Console.WriteLine("                                                                                                         ck:                                                                     .oc.                                                                                                                       ");
                    Console.WriteLine("                                                                                                          ;k;                                                                   .ol.                                                                                                                        ");
                    Console.WriteLine("                                                                                                           lx.                                                                  ;d'                                                                                                                         ");
                }//secretito

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
        static int punto(string numero)
        {
            int hayPunto = numero.IndexOf('.');
            return hayPunto;
        }
        static decimal parse(string numero)
        {
            decimal numeroParseado = decimal.Parse(numero);
            return numeroParseado;
        }
        static double parseDouble(string numero)
        {
            double numeroParseado = double.Parse(numero);
            return numeroParseado;
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
//thanks Hector Guedea https://hectorguedea.com