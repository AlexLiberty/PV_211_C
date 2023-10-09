using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_7
{
    internal static class PersonExtensions
    {
        public static Person MinByAge(this IEnumerable<Person> people)
        {
            //var minAge = people.Min(p => p.Age);
            //return people.FirstOrDefault(p => p.Age == minAge);
            return people.OrderBy(p => p.Age).FirstOrDefault();
        }

        public static Person MaxByAge(this IEnumerable<Person> people)
        {
            return people.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public static double AverageAge(this IEnumerable<Person> people)
        {
            return people.Average(p => p.Age);
        }
    }
}
//робив не сам