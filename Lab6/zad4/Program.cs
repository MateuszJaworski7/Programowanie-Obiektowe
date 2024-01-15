using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {


        using (StreamReader reader = new StreamReader("db.json"))
        {
            string jsonData = reader.ReadToEnd();
            JArray data = JArray.Parse(jsonData);

            long populationIndia1970 = 0;
            long populationIndia2000 = 0;

            long populationUSA1965 = 0;
            long populationUSA2010 = 0;

            long populationChina1980 = 0;
            long populationChina2018 = 0;

            foreach (var item in data)
            {
                if (item["country"]["value"].ToString() == "India")
                {
                    if (item["date"].ToString() == "1970")
                    {
                        populationIndia1970 = item["value"].ToObject<long>();
                    }
                    else if (item["date"].ToString() == "2000")
                    {
                        populationIndia2000 = item["value"].ToObject<long>();
                    }
                }
                else if (item["country"]["value"].ToString() == "USA")
                {
                    if (item["date"].ToString() == "1965")
                    {
                        populationUSA1965 = item["value"].ToObject<long>();
                    }
                    else if (item["date"].ToString() == "2010")
                    {
                        populationUSA2010 = item["value"].ToObject<long>();
                    }
                }

                else if (item["country"]["value"].ToString() == "China")
                {
                    if (item["date"].ToString() == "1980")
                    {
                        populationChina1980 = item["value"].ToObject<long>();
                    }
                    else if (item["date"].ToString() == "2018")
                    {
                        populationChina2018 = item["value"].ToObject<long>();
                    }
                }
            }
            PopulationDifference(populationIndia2000, populationIndia1970, "Indie");
            PopulationDifference(populationUSA2010, populationUSA1965, "USA");
            PopulationDifference(populationChina2018, populationChina1980, "Chiny");

            static void PopulationDifference(long populationA, long populationB, string country)
            {
                if (populationA > 0 || populationB > 0)
                {
                    long difference = populationA - populationB;
                    Console.WriteLine($"Różnica populacji między {populationB} a {populationA} dla kraju {country} wynosi: {difference}");
                }
                else
                {
                    Console.WriteLine("Brak informacji");
                }
            }
            Console.WriteLine("Podanie roku i kraju z którego chciałbyś wyświetlić populację");
            Console.WriteLine("Podaj Rok:");
            string year = Console.ReadLine();
            Console.WriteLine("Podaj Kraj:");
            string countryName = Console.ReadLine();

            long population = 0;
            bool found = false;

            foreach (var item in data)
            {
                if (item["country"]["value"].ToString().Equals(countryName, StringComparison.OrdinalIgnoreCase) && item["date"].ToString() == year)
                {
                    population = item["value"].ToObject<long>();
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine($"Populacja dla kraju {countryName} w roku {year} wynosi: {population}");
            }
            else
            {
                Console.WriteLine("Nieznaleziono podanych danych");
            }

            Console.WriteLine("Podanie lat i kraju z którego chciałbyś obliczyć różnicę populacji");
            Console.WriteLine("Podaj kraj");
            string countryName2 = Console.ReadLine();
            Console.WriteLine("Podaj początkowy rok zakresu");
            string startYear = Console.ReadLine();
            Console.WriteLine("Podaj końcowy rok zakresu");
            string endYear = Console.ReadLine();
            bool startYearFound = false;
            bool endYearFound = false;
            long startYearPopulation = 0;
            long endYearPopulation = 0;

            foreach (var item in data)
            {
                if (item["country"]["value"].ToString().Equals(countryName2, StringComparison.OrdinalIgnoreCase))
                {
                    if (item["date"].ToString() == startYear)
                    {
                        startYearFound = true;
                        startYearPopulation = item["value"].ToObject<long>();
                    }
                    else if (item["date"].ToString().Equals(endYear, StringComparison.OrdinalIgnoreCase))
                    {
                        endYearFound = true;
                        endYearPopulation = item["value"].ToObject<long>();
                    }
                }
                if (startYearFound && endYearFound)
                {
                    break;
                }
            }

            if (startYearFound && endYearFound)
            {
                Console.WriteLine($"Różnica populacji w kraju {countryName2} w latach {startYear} - {endYear} wynosi: {endYearPopulation - startYearPopulation}");
            }
            else
            {
                Console.WriteLine("Nie znaleziono");
            }


            Console.WriteLine("Podaj rok, dla którego chcesz obliczyć wzrost");
            int targetYear = int.Parse(Console.ReadLine());

            var lastYearPopulation = new Dictionary<string, long>();
            var previousYearPopulation = new Dictionary<string, long>();
            try
            {
                foreach (var item in data)
                {
                    string country3 = item["country"]["value"].ToString();
                    int year3 = int.Parse(item["date"].ToString());
                    long population3 = item["value"].ToObject<long>();

                    if (year3 <= targetYear)
                    {
                        if (!previousYearPopulation.ContainsKey(country3) || year3 > int.Parse(previousYearPopulation[country3].ToString()))
                        {
                            if (lastYearPopulation.ContainsKey(country3))
                            {
                                previousYearPopulation[country3] = lastYearPopulation[country3];
                            }

                            lastYearPopulation[country3] = population3;
                        }
                    }
                }
                Console.WriteLine($"Procentowy wzrost populacji do roku {targetYear}:");
                foreach (var country in lastYearPopulation.Keys)
                {
                    if (previousYearPopulation.ContainsKey(country))
                    {
                        long lastPop = lastYearPopulation[country];
                        long previousPop = previousYearPopulation[country];

                        if (previousPop > 0)
                        {
                            double growth = ((double)(lastPop - previousPop) / previousPop) * 100;
                            Console.WriteLine($"{country}: {growth:F2}%");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }

        }
    }
}


            