using System;

namespace W0207
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////
            Console.WriteLine("Program01");
            int a = 5;
            int b = 5;
            if (a == b)
            {
                Console.WriteLine("The numbers are equal");
            }
            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram02");
            int c = 15;
            if (c % 2 == 0)
            {
                Console.WriteLine("liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("liczba jest nieparzysta");
            }

            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram03: Podaj liczbę dodatnią lub ujemną:");
            int d = int.Parse(Console.ReadLine());
            if (d > 0)
            {
                Console.WriteLine("Liczba dodatnia");
            }
            else
            {
                Console.WriteLine("Liczba ujemna");
            }

            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram04: Podaj rok:");
            int e = int.Parse(Console.ReadLine());
            int result2 = e % 4;
            int result3 = e % 100;
            int result4 = e % 400;
            if ((result2 == 0 && result3 != 0) || result4 == 0)
            {
                Console.WriteLine("rok przestępny");
            }
            else
            {
                Console.WriteLine("rok nie przestępny");
            }

            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram05: Podaj wiek:");
            int f = int.Parse(Console.ReadLine());
            if (f >= 21)
            {
                Console.WriteLine("Możesz zostać posłem");
            }
            if (f >= 30)
            {
                Console.WriteLine("Możesz zostać senatorem");
            }
            if (f >= 35)
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }
            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram06: podaj wzrost:");
            int g = int.Parse(Console.ReadLine());
            if (g <= 140)
            {
                Console.WriteLine("nie isteniejesz");
            }
            if (g > 140 && g <= 160)
            {
                Console.WriteLine("Jesteś niski");
            }
            if (g > 160 && g < 190)
            {
                Console.WriteLine("Jesteś wysoki");
            }
            if (g >= 190)
            {
                Console.WriteLine("Jesteś olbrzymem");
            }
            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram07: Podaj trzy liczby:");
            Console.WriteLine("liczba nr 1:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("liczba nr 2:");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("liczba nr 3:");
            int j = int.Parse(Console.ReadLine());
            if (h > i && h > j)
            {
                Console.WriteLine(h + " jest największa z podanych");
            }
            if (i > h && i > j)
            {
                Console.WriteLine(i + " jest największa z podanych");
            }
            if (j > i && j > i)
            {
                Console.WriteLine(j + " jest największa z podanych");
            }

            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram08: Wyniki z matury");
            int matematyka = 30;
            int fizyka = 71;
            int chemia = 0;
            int sumaPunktow = matematyka + fizyka + chemia;
            int matFiz = matematyka + fizyka;
            int matChem = matematyka + chemia;
            if ((matematyka > 70 && fizyka > 55 && chemia > 45 && sumaPunktow > 180) || ((matFiz > 150) || (matChem > 150)))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacj");
            }
            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram09: Odczyt temperatury. Podaj temperaturę:");
            int temperatura = int.Parse(Console.ReadLine());
            if (temperatura < 0)
            {
                Console.WriteLine("cholernie zimno");
            }
            if ((temperatura >= 0) && (temperatura <= 10))
            {
                Console.WriteLine("zimno");
            }
            if ((temperatura > 10) && (temperatura <= 20))
            {
                Console.WriteLine("chłodno");
            }
            if ((temperatura > 20) && (temperatura <= 30))
            {
                Console.WriteLine("w sam raz");
            }
            if ((temperatura > 30) && (temperatura <= 40))
            {
                Console.WriteLine("gorąco");
            }
            if ((temperatura > 40))
            {
                Console.WriteLine("wyprowadzam się na Alaskę");
            }
            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram 10: Trójkąt. Dane testowe: 40, 55, 65");
            int bok1 = 40;
            int bok2 = 55;
            int bok3 = 65;
            if ((bok1 + bok2) > bok3 && (bok1 + bok3) > bok2 && (bok2 + bok3) > bok1)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram 11: Podaj ocenę ucznia");
            int ocena = int.Parse(Console.ReadLine());
            switch (ocena)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
            }
            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram 12:  Podaj numer dnia tygodnia:");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
            }

            //////////////////////////////////////////////////
            Console.WriteLine("\nProgram 13: Podaj dwie liczby do wykonania działań");
            Console.WriteLine("Liczba 1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Liczba 2");
            int number2 = int.Parse(Console.ReadLine());
            int wynikDodawania = number1 + number2;
            int wynikOdejmowania = number1 - number2;
            int wynikMonozenia = number1 * number2;
            int wynikDzielenia = number1 / number2;

            Console.WriteLine("Wybierz działanie:\n(1) - dodawanie\n(2) - odejmowanie\n(3) - mnożenie\n(4) - dzielenie");
            int działanie = int.Parse(Console.ReadLine());
            if (działanie == 1)
            {
                Console.WriteLine("Wynik: " + number1 + " + " + number2 + " = " + wynikDodawania);
            }
            else if (działanie == 2)
            {
                Console.WriteLine("Wynik: " + number1 + " - " + number2 + " = " + wynikOdejmowania);
            }
            else if (działanie == 3)
            {
                Console.WriteLine("Wynik: " + number1 + " * " + number2 + " = " + wynikMonozenia);
            }
            else if (działanie == 4)
            {
                Console.WriteLine("Wynik: " + number1 + " / " + number2 + " = " + wynikDzielenia);
            }
        }
    }
}
