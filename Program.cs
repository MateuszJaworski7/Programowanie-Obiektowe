namespace Lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
            //Zadanie2();
            //Zadanie3();
            //Zadanie4();
            //Zadanie5();
            //Zadanie6();
            //Zadanie7();
        }

        static void Zadanie1()
        {
            double a = inputDouble();
            double b = inputDouble();
            double c = inputDouble();
            double delta, x1, x2;

            if (a != 0)
            {
                delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiazania");
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("x1 = " + x1);
                }
                else
                {
                    x1 = -b - Math.Sqrt(delta) / (2 * a);
                    x2 = -b + Math.Sqrt(delta) / (2 * a);
                    Console.WriteLine($"x1 = {x1} , x2 = {x2}");
                }
            }
            else Console.WriteLine("To nie jest równanie kwadratowe");
        }

        static void view()
        {
            Console.WriteLine("Wybierz operacje: ");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Roznica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potega");
            Console.WriteLine("6. Pierwiastek kwadratowy");
            Console.WriteLine("7. Trygonometria");
            Console.WriteLine("8. Wyjscie");
            Console.WriteLine("Twoj wybor");
        }

        static void viewzad3()
        {
            Console.WriteLine("Wybierz operacje");
            Console.WriteLine("1. Wyswietl tablice od poczatku");
            Console.WriteLine("2. Wyswietl tablice od konca");
            Console.WriteLine("3. Wyswietl elementy o nieparzystym indeksie");
            Console.WriteLine("4. Wyswietl elementy o parzystym indeksie");
            Console.WriteLine("5. Wyjdz");
        }
        static void Zadanie2()
        {
            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                view();
                int operacja = Convert.ToInt32(Console.ReadLine());


                switch (operacja)
                {
                    case 1:
                        Console.Clear();
                        double a = inputDouble();
                        double b = inputDouble();
                        suma(a, b);
                        break;
                    case 2:
                        double c = inputDouble();
                        double d = inputDouble();
                        roznica(c, d);
                        break;
                    case 3:
                        double e = inputDouble();
                        double f = inputDouble();
                        iloczyn(e, f);
                        break;
                    case 4:
                        double g = inputDouble();
                        double h = inputDouble();
                        iloraz(g, h);
                        break;
                    case 5:
                        double i = inputDouble();
                        potega(i);
                        break;
                    case 6:
                        double j = inputDouble();
                        pierwiastek(j);
                        break;
                    case 7:
                        double k = inputDouble();
                        trygonometria(k);
                        break;
                    case 8:
                        System.Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Domyslny"); break;

                }
            }
        }
        static void suma(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine($"Suma {a} + {b} = {sum}");
        }
        static void roznica(double a, double b)
        {
            double substraction = a - b;
            Console.WriteLine($"Różnica {a} - {b} = {substraction}");
        }
        static void iloczyn(double a, double b)
        {
            double multiplication = a * b;
            Console.WriteLine($"Iloczyn {a} * {b} = {multiplication}");
        }
        static void iloraz(double a, double b)
        {
            double division = a / b;
            Console.WriteLine($"Iloraz {a} oraz {b} = {division}");
        }
        static void potega(double a)
        {
            double exponentiation = Math.Pow(a, 2);
            Console.WriteLine($"{a} do potęgi 2 = {exponentiation}");
        }
        static void pierwiastek(double a)
        {
            double element = Math.Sqrt(a);
            Console.WriteLine($"pierwiastek z {a} = {element}");
        }
        static void trygonometria(double a)
        {
            double rad = a * Math.PI / 180;
            Console.WriteLine("Sinus kata " + a + " wynosi " + Math.Sin(rad));
            Console.WriteLine("Cosinus kata " + a + " wynosi " + Math.Cos(rad));
            Console.WriteLine("Tangens kata " + a + " wynosi " + Math.Tan(rad));

        }

        static double inputDouble()
        {
            Console.WriteLine("Podaj wartosc:");
            double a = Convert.ToDouble(Console.ReadLine());
            return a;

        }

        static void wyswietl(double[] tab)
        {
            //for (int i = 0; i < tab.Length; i++)
            //{
            //  Console.Write(tab[i] + " ");
            //
            //}
            foreach (int item in tab)
            {
                Console.Write(item + " ");
            }
        }

        static void wyswietlK(double[] tab)
        {
            for (int i = tab.Length - 1; i >= 0; i--)
            {
                Console.Write(tab[i] + " ");
            }
        }

        static void WyswietlNP(double[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 != 0)
                {
                    Console.Write(tab[i] + " ");
                }

            }

        }

        static void WyswietlP(double[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 0)
                {
                    Console.Write(tab[i] + " ");
                }

            }
        }

        static void Zadanie3()
        {
            double[] tab = new double[5];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = inputDouble();
            }
            while (true)
            {
                viewzad3();
                int wybor = Convert.ToInt32(Console.ReadLine());
                if (wybor == 1) { wyswietl(tab); }
                else if (wybor == 2) { wyswietlK(tab); }
                else if (wybor == 3) { WyswietlNP(tab); }
                else if (wybor == 4) { WyswietlP(tab); }
                else if (wybor == 5) { Environment.Exit(0); }
            }
        }
        static void Zadanie4()
        {
            double[] tablica = new double[10];
            for (int i = 0; i < 10; i++)
            {
                tablica[i] = inputDouble();
            }
            Suma_Iloczyn_Srednia(tablica);
            MinMax(tablica);
        }
        static double Suma_Iloczyn_Srednia(double[] tab)
        {
            double suma = 0;
            double mnozenie = 1;
            double srednia = 0;

            foreach (double item in tab)
            {
                suma += item;
                mnozenie = mnozenie * item;
            }
            srednia = suma / tab.Length;
            Console.WriteLine($"Suma elementow tablicy to: {suma}");
            Console.WriteLine($"Srednia elementow tablicy to: {srednia}");
            Console.WriteLine($"Iloczyn elmentow tablicy to: {mnozenie}");
            return suma;
        }

        static void MinMax(double[] tab)
        {
            double min = 0, max = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (i == 0)
                {
                    min = tab[i];
                    max = tab[i];
                }
                else
                {
                    if (tab[i] < min)
                    {
                        min = tab[i];
                    }
                    if (tab[i] > max)
                    {
                        max = tab[i];
                    }
                }

            }
            Console.WriteLine($"Najmniejsza wartość w tablicy:  {min} , Najwieksza wartość w tablicy: {max}");
        }
        static void Zadanie5()
        {
            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Zadanie6()
        {
            int x = new int();
            while (true)
            {
                Console.WriteLine("Podaj liczbe całkowitą: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0)
                {
                    break;
                }
            }
        }
        static void Zadanie7()
        {
            Console.WriteLine("Ile liczb chcesz wprowadzic: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] tablica = new double[n];
            for (int i = 0; i < n; i++)
            {
                tablica[i] = inputDouble();
            }
            Console.WriteLine("Tablica nieposortowana");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tablica[i]);
            }


            Bubblesort(tablica, n);
        }
        static void Bubblesort(double[] tab, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - (1 + i); j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        (tab[j + 1], tab[j]) = (tab[j], tab[j + 1]);
                    }
                }
            }
            Console.WriteLine("Tablica posortowana: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(tab[i]);
            }
        }
    }
}