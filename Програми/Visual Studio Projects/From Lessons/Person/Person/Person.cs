using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public double Salary
        {
            get { return this.salary; }
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
        }

        public void IncreaseSalary(double bonus)
        {
            double multiplyer = 1.0 + (bonus / 100);
            this.salary *= multiplyer;
        }

    }
}
