using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    interface IUseForEmployee
    {
        void InputinformationofEmployee();
        double FindSalary();
        void OutputinformationofEmployee();
    }
    class Employee : IUseForEmployee
    {
        protected string Name;
        protected string Id;
        protected double Birthyear;
        protected double _numberofworkday;
        protected double BaseSalary;
        protected double _salary;
        protected string _rank;
        public double Salary
        {
            get { return this._salary; }
            set { this._salary = value; }
        }
        public string ID
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
        public string NAME
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public double Numberofworkday
        {
            get { return this._numberofworkday; }
            set { this._numberofworkday = value; }
        }
        public string Rank
        {
            get { return this._rank; }
            set { this._rank = value; }
        }
        public Employee()
        {

        }
        public Employee(string name, string id, double birtyear, double numberofworkday, double basesalary, double salary)
        {
            this.Name = name;
            this.Id = id;
            this.Birthyear = birtyear;
            this._numberofworkday = numberofworkday;
            this.BaseSalary = basesalary;
            this._salary = salary;
        }
        public virtual void InputinformationofEmployee()
        {
            Console.WriteLine("Type the name of the employee");
            this.Name = Console.ReadLine();
            Console.WriteLine("Type the ID");
            this.Id = Console.ReadLine();
            Console.WriteLine("Type numberofworkday:");
            this._numberofworkday = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type the BirthYear");
            this.Birthyear = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type the BaseSalary");
            this.BaseSalary = Convert.ToDouble(Console.ReadLine());
        }
        public virtual double FindSalary()
        {
            return this.BaseSalary;
        }
        public virtual void OutputinformationofEmployee()
        {
            Console.WriteLine("Name of employee:" + this.Name);
            Console.WriteLine("ID:" + this.Id);
            Console.WriteLine("Numberofworkday:" + this._numberofworkday);
            Console.WriteLine("Birth Year:" + this.Birthyear);
            Console.WriteLine("BaseSalary:" + this.BaseSalary);
        }
    }
}
