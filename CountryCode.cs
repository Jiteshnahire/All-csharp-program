using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CountryCode
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countryDictionary = new Dictionary<string, string>();

            countryDictionary.Add("US", "United States");
            countryDictionary.Add("UK", "United Kingdom");
            countryDictionary.Add("CA", "Canada");
            countryDictionary.Add("AU", "Australia");
            countryDictionary.Add("IN", "India");

            foreach (KeyValuePair<string, string> country in countryDictionary)
            {
                Console.WriteLine("Country Code: " + country.Key);
                Console.WriteLine("Country Name: " + country.Value);
                Console.WriteLine();
            }
        }
    }
}