using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Customer
    {
        public int CustId { get; set; }
        public DateTime BorrowDate { get; set; }
        public int MovieId { get; set; }
        public DateTime ReturnDate { get; set; }

        public Customer(int custId, DateTime borrowDate, int movieId)
        {
            CustId = custId;
            BorrowDate = borrowDate;
            MovieId = movieId;
        }

        public void BorrowMovie()
        {
            if (CustId <= 0)
            {
                throw new InvalidOperationException("CustomerId cannot be less than or equal to zero.");
            }
            if (BorrowDate == DateTime.MinValue)
            {
                throw new InvalidOperationException("BorrowDate cannot be null.");
            }

            if (MovieId <= 0)
            {
                throw new InvalidOperationException("MovieId cannot be less than or equal to zero.");
            }

            ReturnDate = BorrowDate.AddDays(10);
            Console.WriteLine("Movie CD borrowed...");
        }
    }
}
