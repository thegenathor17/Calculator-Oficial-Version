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
                Console.WriteLine("Choose an operation: 1 (Add), 2 (Subtract), 3 (Multiply), 4 (Divide), 5 (Fraction addition),6 (Fraction substraction), 7 (Multiply fraccion), 8 (Divide fraccions), 9 (Discover percentage), 10 (Raise a number), 11 (Add raised numbers), 12 (Subtract raised numbers), 13 (Multiply raised numbers), 14 (Divide raised numbers)");
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
                    case "10":
                        Console.WriteLine("Enter the base number: ");
                        string numero29 = Console.ReadLine();
                        Console.WriteLine("Enter the exponent: ");
                        string numero30 = Console.ReadLine();
                        int punto29 = numero29.IndexOf('.');
                        int punto30 = numero30.IndexOf('.');
                        if (punto29 == -1 && punto30 == -1)
                        {
                            int num29 = int.Parse(numero29);
                            int exponente = int.Parse(numero30);
                            double result10 = Math.Pow(num29, exponente);
                            Console.WriteLine("Your result is: {0}", result10);
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "11":
                        Console.WriteLine("Enter the first base number: ");
                        string numero31 = Console.ReadLine();
                        Console.WriteLine("Enter the first exponent: ");
                        string numero32 = Console.ReadLine();
                        int punto31 = numero31.IndexOf('.');
                        int punto32 = numero32.IndexOf('.');
                        Console.WriteLine("Enter the second base number: ");
                        string numero33 = Console.ReadLine();
                        Console.WriteLine("Enter the second exponent: ");
                        string numero34 = Console.ReadLine();
                        int punto33 = numero33.IndexOf('.');
                        int punto34 = numero34.IndexOf('.');
                        if (punto31 == -1 && punto32 == -1 && punto33 == -1 && punto34 == -1)
                        {
                            int num29 = int.Parse(numero31);
                            int exponente = int.Parse(numero32);
                            double resultB = Math.Pow(num29, exponente);
                            int num33 = int.Parse(numero31);
                            int num34 = int.Parse(numero32);
                            double resultA = Math.Pow(num33, num34);
                            double result11 = resultA + resultB;
                            Console.WriteLine("Your result is: {0}", result11);
                        }
                        break;
                    case "12":
                        Console.WriteLine("Enter the first base number: ");
                        string numero35 = Console.ReadLine();
                        Console.WriteLine("Enter the first exponent: ");
                        string numero36 = Console.ReadLine();
                        int punto35 = numero35.IndexOf('.');
                        int punto36 = numero36.IndexOf('.');
                        Console.WriteLine("Enter the second base number: ");
                        string numero37 = Console.ReadLine();
                        Console.WriteLine("Enter the second exponent: ");
                        string numero38 = Console.ReadLine();
                        int punto37 = numero37.IndexOf('.');
                        int punto38 = numero38.IndexOf('.');
                        if (punto37 == -1 && punto38 == -1 && punto36 == -1 && punto35 == -1)
                        {
                            int num35 = int.Parse(numero35);
                            int num36 = int.Parse(numero36);
                            double resultC = Math.Pow(num35, num36);
                            int num37 = int.Parse(numero37);
                            int num38 = int.Parse(numero38);
                            double resultD = Math.Pow(num37, num38);
                            double result12 = resultC - resultD;
                            Console.WriteLine("Your result is: {0}", result12);
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "13":
                        Console.WriteLine("Enter the first base number: ");
                        string numero39 = Console.ReadLine();
                        Console.WriteLine("Enter the first exponent: ");
                        string numero40 = Console.ReadLine();
                        int punto39 = numero39.IndexOf('.');
                        int punto40 = numero40.IndexOf('.');
                        Console.WriteLine("Enter the second base number: ");
                        string numero41 = Console.ReadLine();
                        Console.WriteLine("Enter the second exponent: ");
                        string numero42 = Console.ReadLine();
                        int punto41 = numero41.IndexOf('.');
                        int punto42 = numero42.IndexOf('.');
                        if (punto39 == -1 && punto40 == -1 && punto41 == -1 && punto42 == -1)
                        {
                            int num39 = int.Parse(numero39);
                            int num40 = int.Parse(numero40);
                            double resultF = Math.Pow(num39, num40);
                            int num41 = int.Parse(numero41);
                            int num42 = int.Parse(numero42);
                            double resultE = Math.Pow(num41, num42);
                            double result13 = resultF + resultE;
                            Console.WriteLine("Your result is: {0}", result13);
                        }
                        else
                        {
                            Console.WriteLine("ERROR 002, Please don't use points, if you want add a decimal number use commas");
                        }
                        break;
                    case "14":
                        Console.WriteLine("Enter the first base number: ");
                        string numero43 = Console.ReadLine();
                        Console.WriteLine("Enter the first exponent: ");
                        string numero44 = Console.ReadLine();
                        int punto43 = numero43.IndexOf('.');
                        int punto44 = numero44.IndexOf('.');
                        Console.WriteLine("Enter the second base number: ");
                        string numero45 = Console.ReadLine();
                        Console.WriteLine("Enter the second exponent: ");
                        string numero46 = Console.ReadLine();
                        int punto45 = numero45.IndexOf('.');
                        int punto46 = numero46.IndexOf('.');
                        if (punto44 == -1 && punto45 == -1 && punto43 == -1 && punto46 == -1)
                        {
                            int num43 = int.Parse(numero43);
                            int num44 = int.Parse(numero44);
                            double resultF = Math.Pow(num43, num44);
                            int num45 = int.Parse(numero45);
                            int num46 = int.Parse(numero46);
                            double resultE = Math.Pow(num45, num46);
                            double result13 = resultF / resultE;
                            Console.WriteLine("Your result is: {0}", result13);
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