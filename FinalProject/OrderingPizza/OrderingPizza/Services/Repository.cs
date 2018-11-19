using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderingPizza.Models;

namespace OrderingPizza.Services
{
    public class Repository : IRepository
    {
        private List<Customer> _customers = new List<Customer>();

        public Repository()
        {
            //fake temp data
            _customers.Add(new Customer() { Id=1, Name="John Doe" });
        }

        public List<Customer> Customers { get { return _customers; } }

        public void Add(Customer customer)
        {
            Customers.Add(customer);
        }

        //public Customer GetCustomer(Customer customer)
        //{
        //    return Customers.Remove
        //}
    }
}
