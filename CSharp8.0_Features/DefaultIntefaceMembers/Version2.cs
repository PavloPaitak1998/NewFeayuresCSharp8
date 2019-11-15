using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefaultIntefaceMembers.Version2
{
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }

    public interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }

        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }

        public static void SetLoyaltyThresholds(
            TimeSpan ago,
            int minimumOrders = 10,
            decimal percentageDiscount = 0.10m)
        {
            length = ago;
            orderCount = minimumOrders;
            discountPercent = percentageDiscount;
        }
        private static TimeSpan length = new TimeSpan(365 * 2, 0, 0, 0); // two years
        private static int orderCount = 10;
        private static decimal discountPercent = 0.10m;

        public decimal ComputeLoyaltyDiscount()
        {
            DateTime start = DateTime.Now - length;

            if ((DateJoined < start) && (PreviousOrders.Count() > orderCount))
            {
                return discountPercent;
            }
            return 0;
        }
    }

    public class SampleCustomer : ICustomer
    {
        public SampleCustomer(string name, DateTime dateJoined) => (Name, DateJoined) = (name, dateJoined);

        private List<IOrder> allOrders = new List<IOrder>();

        public IEnumerable<IOrder> PreviousOrders => allOrders;

        public DateTime DateJoined { get; }

        public DateTime? LastOrder { get; private set; }

        public string Name { get; }

        private Dictionary<DateTime, string> reminders = new Dictionary<DateTime, string>();
        public IDictionary<DateTime, string> Reminders => reminders;

        public void AddOrder(IOrder order)
        {
            if (order.Purchased > (LastOrder ?? DateTime.MinValue))
                LastOrder = order.Purchased;
            allOrders.Add(order);
        }
    }

    public class SampleOrder : IOrder
    {
        public SampleOrder(DateTime purchase, decimal cost) =>
            (Purchased, Cost) = (purchase, cost);

        public DateTime Purchased { get; }

        public decimal Cost { get; }
    }
}
