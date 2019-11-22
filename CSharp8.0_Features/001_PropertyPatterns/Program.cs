using System;
using System.Collections.Generic;

namespace _001_PropertyPatterns
{
    class PropertyPatterns
    {
        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            location switch
            {
                { State: "WA" } => salePrice * 0.06M,
                { State: "MN" } => salePrice * 0.75M,
                { State: "MI" } => salePrice * 0.05M,
                //{ } => 0M,
                //null => throw new NullReferenceException() ,
                _ => 0M
            };

        public IEnumerable<int> GetPhoneNumbersWithCode1(List<IPhone> phoneNumbers)
        {
            foreach (var pn in phoneNumbers)
            {
                if (pn is Phone { Code: 1 })
                    yield return pn.Number;
            }
        }

        public static void UsefulApplication(Person person)
        {
            var error = person switch
            {
                null => "Object missing",
                { PhoneNumber: null } => "Phone number missing entirely",
                { PhoneNumber: { Number: 0 } } => "Actual number missing",
                { PhoneNumber: { Code: var code } } when code < 0 => "WTF?",
                { } => null // no error
            };

            if (error != null)
                throw new ArgumentException(error);
        }
    }

    #region Types

    public class Address
    {
        public string State { get; set; }
    }

    public class Person
    {
        public Phone PhoneNumber { get; set; }
    }

    public interface IPhone
    {
        public int Number { get; set; }
    }

    public class Phone : IPhone
    {
        public int Number { get; set; }
        public int Code { get; set; }
    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
