using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6zad5
{
    public interface IPersonRepository
    {
        void AddPerson(Person person);
        List<Person> GetPeople();
    }
}
