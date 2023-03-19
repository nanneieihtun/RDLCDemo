using System.Collections.Generic;
namespace RdlcDemo.Models
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string Email { get; set; }
        public string Township { get; set; }
        public decimal Amount { get; set; }
    }

    public class CustomerDao
    {
        public List<Customer> GetCustomers()
        {
            var customers=new List<Customer>();
            for (int i = 0; i < 1000; i++)
            {
                var customer = new Customer();

                customer.CustomerName ="Customer Name"+ i.ToString();
                customer.CustomerPhone ="Phone Number"+ i.ToString();
                customer.Email="email@gmail.com"+ i.ToString();
                customer.Amount = i;
                customers.Add(customer);
            }

            return customers;
        }
    }

}