using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HourlyEmployee : Employee
    {
        #region constructors
        public HourlyEmployee(string name, string surname, DateTime birthday, decimal hourlyRate, decimal hoursWorked) : base(name, surname, birthday)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }
        #endregion

        #region fields
        private decimal _hourlyRate;
        private decimal _hoursWorked;
        #endregion

        #region properties
        #region prop

        #endregion

        #region propfull
        public decimal HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }

        public decimal HoursWorked
        {
            get { return _hoursWorked; }
            set { _hoursWorked = value; }
        }
        #endregion
        #endregion

        #region methods
        #region abstract
        #endregion

        #region virtual

        #endregion

        #region override
        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Employee type: Hourly Employee");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Hourly Rate: {HourlyRate}");
            sb.AppendLine($"Hours Worked: {HoursWorked}");
            return sb.ToString();
        }
        #endregion
        #endregion
    }
}
