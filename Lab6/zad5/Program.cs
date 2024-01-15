using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using Lab6zad5;

class Program
{
    static void Main()
    {
        string filePath = "people.json";
        IPersonRepository personRepository = new FilePersonRepository(filePath);

        Person newPerson = new Person { FirstName = "Mateusz", LastName = "Jaworski", Age = 21 };
        personRepository.AddPerson(newPerson);

        List<Person> people = personRepository.GetPeople();

        Console.WriteLine("Lista osób:");
        foreach (var person in people)
        {
            Console.WriteLine($"Imię: {person.FirstName}, Nazwisko: {person.LastName}, Wiek: {person.Age}");
        }
    }
}
