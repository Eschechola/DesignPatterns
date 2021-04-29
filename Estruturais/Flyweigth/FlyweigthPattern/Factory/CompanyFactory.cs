using FlyweigthPattern.Entities;
using System;
using System.Collections.Generic;

namespace FlyweigthPattern.Factory
{
    public static class CompanyFactory
    {
        private static Dictionary<int, Company> _companies = new Dictionary<int, Company>();

        public static Company GetCompany(int companyKey)
        {
            if (_companies.ContainsKey(companyKey))
                return _companies[companyKey];

            Company company;

            switch (companyKey)
            {
                case 1:
                    company = new SoftwareCompany();
                break;

                case 2:
                    company = new FoodCompany();
                break;

                default:
                    throw new Exception("Key not found");
            }

            _companies.Add(companyKey, company);

            return company;
        }
    }
}
