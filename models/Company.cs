using System.Collections.Generic;

namespace dz_13.models
{
    public record Company(string Name, string BusinessProfile, List<Employee> Employees)
    {
        public override string ToString()
        {
            return $"Фірма: {Name} | Профіль: {BusinessProfile} | Працівників: {Employees.Count}";
        }
    }
}