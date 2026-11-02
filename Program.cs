//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using static System.Console;

//namespace dz_13
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            List<int> numbers = new List<int> { 5, 14, 21, 8, 35, 42, 10, 56, 3, 16, 7, 24 };

//            WriteLine("Весь масив цілих:");
//            WriteLine(string.Join(", ", numbers));
//            WriteLine();

//            IEnumerable<int> evenNumbers = numbers.Where(n => n % 2 == 0);
//            WriteLine("Парні цілі числа:");
//            WriteLine(string.Join(", ", evenNumbers));
//            WriteLine();

//            IEnumerable<int> oddNumbers = numbers.Where(n => n % 2 != 0);
//            WriteLine("Непарні цілі числа:");
//            WriteLine(string.Join(", ", oddNumbers));
//            WriteLine();

//            int minRange = 10;
//            int maxRange = 40;
//            IEnumerable<int> rangeNumbers = numbers.Where(n => n >= minRange && n <= maxRange);
//            WriteLine($"Числа в заданому діапазоні від {minRange} до {maxRange}:");
//            WriteLine(string.Join(", ", rangeNumbers));
//            WriteLine();

//            IEnumerable<int> multOfSeven = numbers.Where(n => n % 7 == 0).OrderBy(n => n);
//            WriteLine("Числа, кратні семи (відсортовані):");
//            WriteLine(string.Join(", ", multOfSeven));
//            WriteLine();

//            IEnumerable<int> multOfEightDesc = numbers.Where(n => n % 8 == 0).OrderByDescending(n => n);
//            WriteLine("Числа, кратні восьми (відсортовані за спаданням):");
//            WriteLine(string.Join(", ", multOfEightDesc));

//            ReadKey();
//        }
//    }
//}

//exx2
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using static System.Console;

//namespace dz_13
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            string[] cities = { "Київ", "Львів", "Амстердам", "Рим", "Нью-Йорк", "Берлін", "Афіни", "Норфолк" };

//            WriteLine("Весь масив міст:");
//            WriteLine(string.Join(", ", cities));
//            WriteLine();

//            int targetLength = 5;
//            IEnumerable<string> lengthCities = cities.Where(c => c.Length == targetLength);
//            WriteLine($"Міста з довжиною назви {targetLength}:");
//            WriteLine(string.Join(", ", lengthCities));
//            WriteLine();

//            IEnumerable<string> startsWithA = cities.Where(c => c.StartsWith("А", StringComparison.OrdinalIgnoreCase));
//            WriteLine("Міста, назви яких починаються з літери 'А':");
//            WriteLine(string.Join(", ", startsWithA));
//            WriteLine();

//            IEnumerable<string> endsWithM = cities.Where(c => c.EndsWith("м", StringComparison.OrdinalIgnoreCase));
//            WriteLine("Міста, назви яких закінчуються літерою 'М':");
//            WriteLine(string.Join(", ", endsWithM));
//            WriteLine();

//            IEnumerable<string> startsWithNAndEndsWithK = cities.Where(c => c.StartsWith("Н", StringComparison.OrdinalIgnoreCase) && c.EndsWith("к", StringComparison.OrdinalIgnoreCase));
//            WriteLine("Міста, назви яких починаються з 'N' і закінчуються на 'K':");
//            WriteLine(string.Join(", ", startsWithNAndEndsWithK));

//            ReadKey();
//        }
//    }
//}


//exx3
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using static System.Console;
//using dz_13.models;
//using dz_13.utils;
//using dz_13.services;

//namespace dz_13
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            List<Student> initialStudents = new List<Student>();
//            ServiceListStudent service = new ServiceListStudent(initialStudents);

//            for (int i = 0; i < 6; i++)
//            {
//                service.AddStudent(StudentGen.GenerateRandomStudent());
//            }


//            WriteLine("Весь масив студентів:");
//            service.Students
//                .ForEach(s => WriteLine(s));
//            //foreach (var s in service.Students)
//            //{
//            //    WriteLine($"{s.FirstName} {s.LastName} | Вік: {s.Age} | ВНЗ: {s.University}");
//            //}
//            WriteLine();

//            IEnumerable<Student> lastNameBro = service.Students.Where(s => s.LastName.StartsWith("Bro", StringComparison.OrdinalIgnoreCase));
//            WriteLine("Студенти з прізвищем, що починається з 'Bro':");
//            foreach (var s in lastNameBro)
//            {
//                WriteLine(s);
//            }
//            WriteLine();

//            var olderThan19 = service
//                .Students
//                .Where(s => s.Age > 19)
//                .ToList();
//            WriteLine("Студенти старші за 19 років:");
//            foreach (var s in olderThan19)
//            {
//                WriteLine($"{s.FirstName} {s.LastName} | Вік: {s.Age} | ВНЗ: {s.University}");
//            }
//            WriteLine();

//            IEnumerable<Student> ageRange = service.Students.Where(s => s.Age > 20 && s.Age < 23);
//            WriteLine("Студенти старші за 20 і молодші за 23 роки:");
//            foreach (var s in ageRange)
//            {
//                WriteLine($"{s.FirstName} {s.LastName} | Вік: {s.Age} | ВНЗ: {s.University}");
//            }
//            WriteLine();

//            IEnumerable<Student> oxfordOlder18 = service.Students
//                .Where(s => s.University.Equals("Oxford", StringComparison.OrdinalIgnoreCase) && s.Age > 18)
//                .OrderByDescending(s => s.Age);
//            WriteLine("Студенти з Oxford старші за 18 років (відсортовані за віком спаданням):");
//            foreach (var s in oxfordOlder18)
//            {
//                WriteLine($"{s.FirstName} {s.LastName} | Вік: {s.Age} | ВНЗ: {s.University}");
//            }

//            ReadKey();
//        }
//    }
//}

//exx4
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using static System.Console;
//using dz_13.models;
//using dz_13.utils;
//using dz_13.services;

//namespace dz_13
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            List<Company> initialList = new List<Company>();
//            ServiceListCompany service = new ServiceListCompany(initialList);

//            for (int i = 0; i < 8; i++)
//            {
//                service.AddCompany(CompanyGen.GenerateRandomCompany());
//            }

//            WriteLine("Весь масив фірм:");
//            service.Companies.ForEach(c => WriteLine(c));
//            WriteLine();

//            WriteLine("Фірми, які мають у назві слово 'Food':");
//            service.Companies
//                .Where(c => c.Name.Contains("Food", StringComparison.OrdinalIgnoreCase))
//                .ToList()
//                .ForEach(c => WriteLine(c));
//            WriteLine();

//            WriteLine("Фірми, які працюють у галузі маркетингу:");
//            service.Companies
//                .Where(c => c.BusinessProfile.Equals("Marketing", StringComparison.OrdinalIgnoreCase))
//                .ToList()
//                .ForEach(c => WriteLine(c));
//            WriteLine();

//            WriteLine("Фірми, які працюють у галузі маркетингу або IT:");
//            service.Companies
//                .Where(c => c.BusinessProfile.Equals("Marketing", StringComparison.OrdinalIgnoreCase) || c.BusinessProfile.Equals("IT", StringComparison.OrdinalIgnoreCase))
//                .ToList()
//                .ForEach(c => WriteLine(c));
//            WriteLine();

//            WriteLine("Фірми з кількістю працівників більшою, ніж 100:");
//            service.Companies
//                .Where(c => c.EmployeesCount > 100)
//                .ToList()
//                .ForEach(c => WriteLine(c));
//            WriteLine();

//            WriteLine("Фірми з кількістю працівників у діапазоні від 100 до 300:");
//            service.Companies
//                .Where(c => c.EmployeesCount >= 100 && c.EmployeesCount <= 300)
//                .ToList()
//                .ForEach(c => WriteLine(c));
//            WriteLine();

//            WriteLine("Фірми, які знаходяться в Лондоні:");
//            service.Companies
//                .Where(c => c.Address.Contains("Лондон", StringComparison.OrdinalIgnoreCase))
//                .ToList()
//                .ForEach(c => WriteLine(c));
//            WriteLine();

//            WriteLine("Фірми, в яких прізвище директора White:");
//            service.Companies
//                .Where(c => c.DirectorFullName.Contains("White", StringComparison.OrdinalIgnoreCase))
//                .ToList()
//                .ForEach(c => WriteLine(c));
//            WriteLine();

//            WriteLine("Фірми, засновані більше двох років тому:");
//            service.Companies
//                .Where(c => (DateTime.Now - c.FoundationDate).TotalDays > 365 * 2)
//                .ToList()
//                .ForEach(c => WriteLine(c));
//            WriteLine();

//            WriteLine("Фірми, з дня заснування яких минуло 123 дні:");
//            service.Companies
//                .Where(c => (DateTime.Now - c.FoundationDate).TotalDays == 123)
//                .ToList()
//                .ForEach(c => WriteLine(c));
//            WriteLine();

//            WriteLine("Фірми, в яких прізвище директора Black і мають у назві слово 'White':");
//            service.Companies
//                .Where(c => c.DirectorFullName.Contains("Black", StringComparison.OrdinalIgnoreCase) && c.Name.Contains("White", StringComparison.OrdinalIgnoreCase))
//                .ToList()
//                .ForEach(c => WriteLine(c));

//            ReadKey();
//        }
//    }
//}


//exx5
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using static System.Console;

//namespace dz_13
//{
//    internal class Program
//    {
//        private static int GetDigitSum(int number)
//        {
//            int sum = 0;
//            number = Math.Abs(number);
//            while (number > 0)
//            {
//                sum += number % 10;
//                number /= 10;
//            }
//            return sum;
//        }

//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            List<int> numbers = new List<int> { 121, 75, 81, 45, 19, 33 };

//            WriteLine("Початковий масив чисел:");
//            numbers.ForEach(n => Write($"{n} "));
//            WriteLine("\n");

//            WriteLine("Сортування за сумою цифр (за зростанням):");
//            numbers
//                .OrderBy(n => GetDigitSum(n))
//                .ThenBy(n => n)
//                .ToList()
//                .ForEach(n => Write($"{n} (сума: {GetDigitSum(n)}) "));
//            WriteLine("\n");

//            WriteLine("Сортування за сумою цифр (за зменшенням):");
//            numbers
//                .OrderByDescending(n => GetDigitSum(n))
//                .ThenByDescending(n => n)
//                .ToList()
//                .ForEach(n => Write($"{n} (сума: {GetDigitSum(n)}) "));
//            WriteLine();

//            ReadKey();
//        }
//    }
//}


//exx6
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using static System.Console;

//namespace dz_13
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;

//            List<int> array1 = new List<int> { 1, 2, 2, 3, 4, 5, 6, 7 };
//            List<int> array2 = new List<int> { 4, 5, 6, 7, 8, 9, 10 };

//            WriteLine("Перший масив:");
//            array1.ForEach(n => Write($"{n} "));
//            WriteLine("\n");

//            WriteLine("Другий масив:");
//            array2.ForEach(n => Write($"{n} "));
//            WriteLine("\n");

//            WriteLine("Різниця двох масивів (елементи першого, яких немає у другому):");
//            array1
//                .Except(array2)
//                .ToList()
//                .ForEach(n => Write($"{n} "));
//            WriteLine("\n");

//            WriteLine("Перетин масивів (спільні елементи):");
//            array1
//                .Intersect(array2)
//                .ToList()
//                .ForEach(n => Write($"{n} "));
//            WriteLine("\n");

//            WriteLine("Об'єднання масивів (без дублікатів):");
//            array1
//                .Union(array2)
//                .ToList()
//                .ForEach(n => Write($"{n} "));
//            WriteLine("\n");

//            WriteLine("Вміст первого масиву без повторень:");
//            array1
//                .Distinct()
//                .ToList()
//                .ForEach(n => Write($"{n} "));
//            WriteLine();

//            ReadKey();
//        }
//    }
//}


//exx7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using dz_13.models;
using dz_13.utils;

namespace dz_13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;

            List<Company> companies = new List<Company>();
            for (int i = 0; i < 3; i++)
            {
                companies.Add(CompanyGen.GenerateRandomCompany());
            }

            WriteLine("Усі фірми та їх працівники:");
            companies.ForEach(c =>
            {
                WriteLine(c);
                c.Employees.ForEach(e => WriteLine($"   - {e}"));
            });
            WriteLine();

            string targetCompanyName = companies[0].Name;
            WriteLine($"Список усіх працівників певної фірми ('{targetCompanyName}'):");
            companies
                .Where(c => c.Name.Equals(targetCompanyName, StringComparison.OrdinalIgnoreCase))
                .SelectMany(c => c.Employees)
                .ToList()
                .ForEach(e => WriteLine(e));
            WriteLine();

            decimal targetSalary = 50000;
            WriteLine($"Працівники фірми '{targetCompanyName}', у яких зарплата більша за {targetSalary}:");
            companies
                .Where(c => c.Name.Equals(targetCompanyName, StringComparison.OrdinalIgnoreCase))
                .SelectMany(c => c.Employees)
                .Where(e => e.Salary > targetSalary)
                .ToList()
                .ForEach(e => WriteLine(e));
            WriteLine();

            WriteLine("Список працівників усіх фірм, у яких є посада 'Менеджер':");
            companies
                .SelectMany(c => c.Employees)
                .Where(e => e.Position.Equals("Менеджер", StringComparison.OrdinalIgnoreCase))
                .ToList()
                .ForEach(e => WriteLine(e));
            WriteLine();

            WriteLine("Список працівників, у яких телефон починається з '23':");
            companies
                .SelectMany(c => c.Employees)
                .Where(e => e.Phone.StartsWith("23"))
                .ToList()
                .ForEach(e => WriteLine(e));
            WriteLine();

            WriteLine("Працівники, у яких Email починається з 'di':");
            companies
                .SelectMany(c => c.Employees)
                .Where(e => e.Email.StartsWith("di", StringComparison.OrdinalIgnoreCase))
                .ToList()
                .ForEach(e => WriteLine(e));
            WriteLine();

            WriteLine("Список працівників з ім'ям 'Lionel':");
            companies
                .SelectMany(c => c.Employees)
                .Where(e => e.FullName.Contains("Lionel", StringComparison.OrdinalIgnoreCase))
                .ToList()
                .ForEach(e => WriteLine(e));

            ReadKey();
        }
    }
}