using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
		private int _EmpNo;

		public int EmpNo
        {
			get { return _EmpNo; }
			set 
			{
				if (value == 0) 
				{
					throw new ArgumentException("Employee No must be greater than 0");
				}
				else
				{
					_EmpNo = value;
				}
			}
		}
		private string _EmpName;

		public string EmpName
        {
			get { return _EmpName; }
			set 
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new NullReferenceException("Employee Name can't be empty");
				}
				else
				{
					_EmpName = value;
				}				 
			}
		}
		private decimal _Salary;

		public decimal Salary
		{
			get { return _Salary; }
			set { _Salary = value; }
		}
		private int _DeptNo;

		public int DeptNo
        {
			get { return _DeptNo; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Department No must be greater than 0");
                }
                else
                {
                    _DeptNo = value;
                }
            }
        }


	}
}
