using System;
using System.Collections.Generic;
using System.Text;

namespace MorePatternsInMorePlaces
{
    class PropertyPatterns
    {
        public static decimal ComputeSalesTax(Address location, decimal salePrice) =>
            location switch
            {
            { State: "WA" } => salePrice * 0.06M,
            { State: "MN" } => salePrice * 0.75M,
            { State: "MI" } => salePrice * 0.05M,
            { } => 0M,
            //null => throw new NullReferenceException() ,
            _ => 0M
        };
    }

    public class Address
    {
        public string State { get; set; }
    }
}
