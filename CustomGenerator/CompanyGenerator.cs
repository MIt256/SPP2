using System;
using System.Collections.Generic;
using Generator.SDK;

namespace CustomGenerator
{
    public class CompanyGenerator:IGenerator
    {
        public Type Type => typeof(string);
        
        private readonly Random _random = new();
        private readonly List<string> _companies;

        public CompanyGenerator()
        {
            _companies = new List<string>(){ "Apple Inc", "TOYOTA", "Microsoft", "Amazon", "Facebook", "Tesla", "Samsung", "Visa", "Alibaba Group", "Walmart",
            "Bank of America", "Mastercard", "The Walt Disney", "salesforce.com", "Oracle", "NIKE" };
        }
        
        public object Generate()
        {
            return _companies[_random.Next(_companies.Count)];
        }
    }
}