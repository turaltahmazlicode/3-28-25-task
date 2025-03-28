using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SalariedEmployee : Employee
    {
        #region constructors
        public SalariedEmployee(string name, string surname, DateTime birthday, decimal monthlySalary) : base(name, surname, birthday)
        {
            MonthlySalary = monthlySalary;
        }
        #endregion

        #region fields
        private decimal _monthlySalary;
        #endregion

        #region properties
        #region prop

        #endregion

        #region propfull
        public decimal MonthlySalary
        {
            get { return _monthlySalary; }
            set { _monthlySalary = value; }
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
            return MonthlySalary;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Employee type: Hourly Employee");
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Monthly Salary: {_monthlySalary}");
            return sb.ToString();
        }
        #endregion
        #endregion

    }
}
