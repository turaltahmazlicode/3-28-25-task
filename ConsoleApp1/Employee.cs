using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Employee
    {
        #region constructors
        protected Employee()
        {
            _id = Guid.NewGuid();
        }

        public Employee(string name, string surname, DateTime birthday) : this()
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }
        #endregion

        #region fields
        private readonly Guid _id;
        private string _name;
        private string _surname;
        private DateTime _birthday;
        #endregion

        #region properties
        #region prop
        public Guid Id => _id;
        #endregion

        #region propfull
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        #endregion
        #endregion

        #region methods
        #region abstract
        public abstract decimal CalculateSalary();
        #endregion

        #region virtual
        public virtual void DisplayDetails()
        {
            Console.WriteLine(this);
        }
        #endregion

        #region override
        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nSurname: {Surname}\nBirthday: {Birthday}";
        } 
        #endregion
        #endregion
    }
}
