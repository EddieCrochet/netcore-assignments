using OrderingPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingPizza.Services
{
    public interface IRepository
    {
        void Add(Customer customer);
        List<Customer> Customers { get; }
    }
}
