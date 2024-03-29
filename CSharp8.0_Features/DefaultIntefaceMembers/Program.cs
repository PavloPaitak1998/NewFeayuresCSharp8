﻿using DefaultIntefaceMembers.Version1;
//using DefaultIntefaceMembers.Version2;
using System;

namespace DefaultIntefaceMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleCustomer c = new SampleCustomer("customer one", new DateTime(2010, 5, 31))
            {
                Reminders =
                {
                    { new DateTime(2010, 08, 12), "childs's birthday" },
                    { new DateTime(1012, 11, 15), "anniversary" }
                }
            };

            SampleOrder o = new SampleOrder(new DateTime(2012, 6, 1), 5m);
            c.AddOrder(o);

            o = new SampleOrder(new DateTime(2103, 7, 4), 25m);
            c.AddOrder(o);

            // Version1
            ICustomer theCustomer = c;
            Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");

            // Version2
            //ICustomer.SetLoyaltyThresholds(new TimeSpan(30, 0, 0, 0), 1, 0.25m);
            //Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");
        }
    }
}
