using System;
using dz_13.models;

namespace dz_13.utils
{
    public static class CompanyGen
    {
        private static string[] names = { "FastFood UA", "IT Solutions", "Global Marketing", "Tech Hub", "Food Service Group" };
        private static string[] profiles = { "Food", "IT", "Marketing", "Logistics" };
        private static string[] directors = { "John White", "Alice Black", "Michael White", "Robert Smith" };
        private static string[] addresses = { "Лондон, Велика вулиця, 10", "Київ, Хрещатик, 5", "Лондон, Бейкер-стріт, 221" };

        private static Random rnd = new Random();

        public static Company GenerateRandomCompany()
        {
            string name = names[rnd.Next(names.Length)];
            DateTime foundationDate = DateTime.Now.AddDays(-rnd.Next(50, 1500));
            string profile = profiles[rnd.Next(profiles.Length)];
            string director = directors[rnd.Next(directors.Length)];
            int employees = rnd.Next(20, 350);
            string address = addresses[rnd.Next(addresses.Length)];

            return new Company(name, foundationDate, profile, director, employees, address);
        }
    }
}