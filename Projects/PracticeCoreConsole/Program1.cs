using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
namespace PracticeCoreConsole.Practice
{

    class Program1
    {
        public void Test()
        {
            CustomerData objCustomer = new CustomerData();
            List<Customer> data = objCustomer.GetCustomer();

            CustomerData2 objCustomer2 = new CustomerData2();
            List<Customer2> data2 = objCustomer2.GetCustomer();

           

            Console.WriteLine("Pogramme 1");
            Console.ReadLine();
        }

    }



    #region Customer 1 to Profile 1

    //  Data
    class CustomerProfile
    {
        public Int32 IdProfile { get; set; }
    
    }

    class Customer
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
    }
    // Generate Data

    class CustomerData
    {
        public List<Customer> GetCustomer()
        {
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer { Id = 1, Name = "ABC" });
            customerList.Add(new Customer { Id = 2, Name = "BCD" });
            return customerList;
        }
    }

    #endregion

    #region Customer2 to Profile 2

    //  Data
    class Customer2Profile
    {
        public string DescriptionProfile { get; set; }

    }

    class Customer2
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    // Generate Data

    class CustomerData2
    {
        public List<Customer2> GetCustomer()
        {
            List<Customer2> customerList = new List<Customer2>();
            customerList.Add(new Customer2 { Id = 1, Name = "ABC", Description = "Test1"});
            customerList.Add(new Customer2 { Id = 2, Name = "BCD", Description = "Test2"});
            return customerList;
        }
    }

    #endregion

    // Read Data
    // Mapping Data/ Profile/Automapper
    // Polly Policy
    // Convert Data
    // Push Data
}
