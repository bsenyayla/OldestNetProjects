using AppLearn.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLearn.LINQ
{
    class FirstSample : Common.SamplePatternClass
    {
        public FirstSample(TextBox refText) : base(refText)
        {
            MsgTT("LINQ Samples.....");
        }

        public void Aggregate()
        {
            var numbers = new[] { 1, 2, 3 };

            MsgTT("Input =>" + String.Join(" ,", numbers));

            bool isExists = numbers.Contains(2);
            MsgTT("2 bu listede var mi:" + isExists.ToString());

            MsgTT("numbers.ElementAt(2):" + numbers.ElementAt(2).ToString());

            var result = numbers.Aggregate((x, y) => x + y);

            // (2 + 4) = 6, (6 + 6) = 12, (12 + 8) = 20, (20 + 10) = 30

            var sum = numbers.Sum();

            MsgTT("Toplam:" + sum.ToString());
        }


        public void WhereUsage()
        {
            var customers = new[] {
                new{
                        Name = "Vernon",
                        DateOfBirth = "1994-Jun-25",
                        Active = true,
                        Card = "MasterCard",
                        CardNumer = "*** 1142",
                        ExpiryYear = 2022,
                        ExpiryMonth = 7
                    },
                new {
                        Name = "Carrie",
                        DateOfBirth = "1986-Feb-01",
                        Active = false,
                        Card = "Visa",
                        CardNumer = "*** 2156",
                        ExpiryYear = 2015,
                        ExpiryMonth = 7
                    },
                new {
                        Name = "Joanna",
                        DateOfBirth = "1972/10/13",
                        Active = true,
                        Card = "Visa",
                        CardNumer = "*** 7683",
                        ExpiryYear = 2014,
                        ExpiryMonth = 3
                    },
                new {
                        Name = "Louis",
                        DateOfBirth = "1975/05/10",
                        Active = true,
                        Card = "Visa",
                        CardNumer = "*** 7683",
                        ExpiryYear = 2016,
                        ExpiryMonth = 2
                    }
            };

            var results = from c in customers
                          where c.ExpiryYear >= 2016
                          select c;

            var results1 = customers.Where(x => x.Name.Contains("Lo")).Select(x => new { x.Name, x.CardNumer });


            var results2 = customers.Where(
                                customer =>
                                    customer.Card == "Visa"
                                 && customer.ExpiryYear <= 2015
                                 );

            MsgTT("==============================================================================" + Environment.NewLine);
            foreach (var row in results)
            {
                MsgTT(@"Name:" + row.Name + Environment.NewLine +
                    "DOB:" + row.DateOfBirth + Environment.NewLine +
                    "Active:" + row.Active + Environment.NewLine +
                    "Card:" + row.Card + Environment.NewLine +
                    "CardNumber:" + row.CardNumer + Environment.NewLine +
                    "ExpiryYear:" + row.ExpiryYear + Environment.NewLine +
                    "ExpiryMonth:" + row.ExpiryMonth + Environment.NewLine
                    );
            }

        }


        public void GroupByUsage()
        {
            var people = new[] {    new            {  Name = "Vernon",  Gender = "Male",  },
                                    new            {  Name = "Carrie",  Gender = "Female" },
                                    new            {  Name = "Thomas",  Gender = "Male"   }};

            //Method 1:
            var peopleByGender = people.GroupBy(p => p.Gender)
                                       .Select(x => new { Gender = x.Key, People = x });

            MsgTT("==============================================================================" + Environment.NewLine);
            foreach (var row in peopleByGender)
            {
                MsgTT(@"Name:" + row.Gender + Environment.NewLine);

                foreach (var row2 in row.People)
                {
                    MsgTT(@"Name:" + row2.Name + "Gender:" + row2.Gender + Environment.NewLine);
                }
            }
        }



        public void InnerJoinUsage()
        {
            MsgTT("==[ LINQ Inner Join Kullanimi ] ======================================================================" + Environment.NewLine);
            var people = new[] {
                new { Name = "Vernon", Gender = "Male", CountryCode = "GB" },
                new { Name = "Carrie", Gender = "Female", CountryCode = "CA" },
                new { Name = "Joanna", Gender = "Female", CountryCode = "US" },
                new {Name = "Thomas", Gender = "Male", CountryCode = "ES" }
            };

            var countries = new[] {
                    new {CountryName = "United Kingdom", Code = "GB"},
                    new {CountryName = "United States", Code = "US"},
                    new {CountryName = "Canada", Code = "CA"},
                    new {CountryName = "France", Code = "FR"},
                    new {CountryName = "Spain", Code = "ES"}                };

            var results = from p in people
                          join c in countries
                          on p.CountryCode equals c.Code
                          select new { Name = p.Name, Country = c.CountryName };


            var result2 = from p in people
                          join c in countries
                          on p.CountryCode equals c.Code
                          select new { Name =p.Name , Country=c.CountryName};

            foreach (var row in result2) {
                MsgTT( @"Name:" + row.Name + Environment.NewLine +
                        "Country:" + row.Country + Environment.NewLine 
                        );
            }


            if (1 == 2) {

                throw new CustomException("ff","File",new Exception());
            }

        }


    }


}