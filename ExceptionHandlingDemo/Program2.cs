using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace ExceptionHandlingDemo
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            List<Customer> overdueMovies = new List<Customer>();

            try
            {

                Movies movie = new Movies(1, "Movie A", "English");
                Customer customer = new Customer(101, DateTime.Now, 1);

                customer.BorrowMovie();

                if (customer.ReturnDate > customer.BorrowDate.AddDays(10))
                {
                    overdueMovies.Add(customer);
                    Console.WriteLine("Movie is overdue. Added to the overdue list.");
                    Console.WriteLine("Customer Id :"+customer.CustId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
