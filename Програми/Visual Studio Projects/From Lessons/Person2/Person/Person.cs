using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        // declare some variables
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        // our constructor
        public Person(string firstName, string lastName, int age, double salary)
        {
            if (firstName.Count() < 3)
            {
                throw new ArgumentException("First name cannot be less than 3 symbols");
            }
            else
            {
                this.firstName = firstName;
            }

            if (lastName.Count() < 3)
            {
                throw new ArgumentException("Last name cannot be less than 3 symbols");
            }
            else
            {
                this.lastName = lastName;
            }

            if (age <= 0)
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }
            else
            {
                this.age = age;
            }

            if (salary < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva");
            }
            else
            {
                this.salary = salary;
            }
        }

        //public variables

        /*
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Count() < 3)
                {
                    throw new ArgumentException("First name cannot be less than 3 symbols");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Count() < 3)
                {
                    throw new ArgumentException("Last name cannot be less than 3 symbols");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or negative integer");
                }
                this.age = value;
            }
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva");
                }
                this.salary = value;
            }
        }
        */

        // methods
        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
        }

        public void IncreaseSalary(double bonus)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * bonus / 100;
            }
            else
            {
                this.salary += this.salary * bonus / 200;
            }
        }

    }
}
