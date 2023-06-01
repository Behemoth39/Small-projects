using System.Collections;

namespace Lists;

class Program
{
    static void Main(string[] args)
    {

        #region Bad ArrayList //Do not use ArrayList
        ArrayList items = new ArrayList {
            new Person{Name = "Oscar", Age = 33},
            new Vehicle{Make = "Volvo", Model = "740", ModelYear = 94}
         };

        foreach (var item in items)
        {
            var person = item as Person;
            if (person is not null)
            {
                Console.WriteLine("{0}", person.Name);
            }
            //Console.WriteLine("{0}", ((Person)item).Name);
        }

        #endregion
        #region Generic List //Use generic lists

        var vehicles = new List<Vehicle>
        {
            new Vehicle{Make = "Volvo", Model = "740", ModelYear = 94},
            new Vehicle{Make = "Audi", Model = "RS8", ModelYear = 21}
        };

        var persons = new List<Person>
        {
            new Person{Name = "Oscar", Age = 33}
        };

        foreach (var vehical in vehicles)
        {
            Console.WriteLine("{0}", vehical.Make);
        }

        #endregion
    }
}
