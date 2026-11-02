using System.Collections.Generic;
using dz_13.models;

namespace dz_13.services
{
    public class ServiceListCompany
    {
        public List<Company> Companies { get; set; }

        public ServiceListCompany(List<Company> companies)
        {
            Companies = companies;
        }

        public void AddCompany(Company company)
        {
            Companies.Add(company);
        }
    }
}