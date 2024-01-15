using Lab4zad2;

class Program
{
    static void Main()
    {
        Uczen uczen1 = new Uczen();
        uczen1.SetFirstName("Anna");
        uczen1.SetLastName("Nowak");
        uczen1.SetPesel("15211543727");
        uczen1.SetSchool("3A");
        uczen1.SetCanGoHomeAlone(false);

        Uczen uczen2 = new Uczen();
        uczen2.SetFirstName("Jan");
        uczen2.SetLastName("Kowalski");
        uczen2.SetPesel("03261051312");
        uczen2.SetSchool("4B");
        uczen2.SetCanGoHomeAlone(true);

        Nauczyciel nauczyciel = new Nauczyciel();
        nauczyciel.SetFirstName("Adam");
        nauczyciel.SetLastName("Wiśniewski");
        nauczyciel.SetPesel("72112924378");
        nauczyciel.SetTytulNaukowy("Mgr");
        nauczyciel.AddPodwladny(uczen1);
        nauczyciel.AddPodwladny(uczen2);

        Console.WriteLine($"{nauczyciel.GetFullName()}, Wiek: {nauczyciel.GetAge()}, Płeć: {nauczyciel.GetGender()}, Tytuł: {nauczyciel.TytulNaukowy}");
        Console.WriteLine(nauczyciel.GetEducationInfo());

        nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);
    }

}