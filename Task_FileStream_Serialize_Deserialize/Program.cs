
using Newtonsoft.Json;
using System;
using System.IO;

namespace Task_FileStream_Serialize_Deserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Country country = new Country { Id = 1, Name = "Azerbaijan", Capital = "Baku", Currency = "Manat", Language = "Azerbaycan dili", Population = "10 mln" };
            Country country1 = new Country { Id = 2, Name = "Turkey", Capital = "Ankara", Currency = "Lira", Language = "Turk dili", Population = "80 mln" };
            Country country2 = new Country { Id = 3, Name = "Rusiya", Capital = "Moskva", Currency = "Rubl", Language = "Rus dili", Population = "100 mln" };
            Country country3 = new Country { Id = 4, Name = "Norway", Capital = "Oslo", Currency = "Krone", Language = "Norwegian", Population = "2.5 mln" };
            Country country4 = new Country { Id = 5, Name = "iceland", Capital = "Reykjavík", Currency = "Icelandic króna", Language = " Icelandic", Population = "366.500" };
            Country country5 = new Country { Id = 6, Name = "Germany", Capital = "Berlin", Currency = "Euro", Language = "German language,", Population = "83.24 mln" };

            CountryName countryname = new CountryName  { Id = 1, Country = country };
            CountryName countryname1 = new CountryName { Id = 2, Country = country1 };
            CountryName countryname2 = new CountryName { Id = 3, Country = country2 };
            CountryName countryname3 = new CountryName { Id = 4, Country = country3 };
            CountryName countryname4 = new CountryName { Id = 5, Country = country4 };
            CountryName countryname5 = new CountryName { Id = 6, Country = country5 };

            CountryCapital countryCapital = new CountryCapital
            {
                Id = 1,
                CountryNames = new System.Collections.Generic.List<CountryName>()
                {
                    countryname,
                    countryname1,
                    countryname2,
                    countryname3,
                    countryname4,
                    countryname5
                }
            };
            var CountryStr = JsonConvert.SerializeObject(countryCapital);
            Console.WriteLine(CountryStr);
        }



    }
}
