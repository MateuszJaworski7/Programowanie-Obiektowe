using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6zad5
{
    public class FilePersonRepository : IPersonRepository
    {
        private readonly string filePath;

        public FilePersonRepository(string filePath)
        {
            this.filePath = filePath;
        }

        public void AddPerson(Person person)
        {
            // Wczytaj istniejące dane
            var people = GetPeople();

            // Dodaj nową osobę
            people.Add(person);

            // Zapisz dane z powrotem do pliku
            SavePeople(people);
        }

        public List<Person> GetPeople()
        {
            // Sprawdź, czy plik istnieje
            if (!File.Exists(filePath))
            {
                // Jeśli nie, zwróć pustą listę
                return new List<Person>();
            }

            // Wczytaj dane z pliku
            string jsonData = File.ReadAllText(filePath);

            // Deserializuj dane do listy osób
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(jsonData);

            return people ?? new List<Person>();
        }

        private void SavePeople(List<Person> people)
        {
            // Serializuj listę osób do formatu JSON
            string jsonData = JsonConvert.SerializeObject(people);

            // Zapisz dane do pliku
            File.WriteAllText(filePath, jsonData);
        }
    }
}
