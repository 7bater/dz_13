using System;
using dz_13.models;

namespace dz_13.utils
{
    public static class StudentGen
    {
        private static string[] firstNames = { "Олександр", "Марія", "Іван", "Анна", "Максим" };
        private static string[] lastNames = { "Brown", "Brooks", "Бондаренко", "Шевченко", "Brody" };
        private static string[] universities = { "Oxford", "KPI", "Shevchenko University", "Cambridge" };
        private const int MinAge = 17;
        private const int MaxAge = 25;
        private static Random rnd = new Random();

        public static Student GenerateRandomStudent()
        {
            string firstName = firstNames[rnd.Next(firstNames.Length)];
            string lastName = lastNames[rnd.Next(lastNames.Length)];
            int age = rnd.Next(MinAge, MaxAge);
            string university = universities[rnd.Next(universities.Length)];

            return new Student(firstName, lastName, age, university);
        }
    }
}