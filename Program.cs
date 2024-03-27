using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string select = " ";
            string name;
            string surname;
            byte age;
            string departmentname;
            int salary;
            int minsalary;
            int maxsalary;
            Department department=new Department();

            do
            {

                Console.WriteLine("1.Employee elave et");
                Console.WriteLine("2.Butun ishcilere bax");
                Console.WriteLine("3.Maash araligina gore ishcileri axtarish et");
                Console.WriteLine("0.Proqrami bitir");
                Console.WriteLine("Seciminizi edin");
                select = Console.ReadLine();

                if (select == "1")
                {
                    Console.WriteLine("ishcinin adini yazin");
                    name = Console.ReadLine();
                    Console.WriteLine("ishcinin soyadini yazin");
                    surname = Console.ReadLine();
                    Console.WriteLine("ishcinin yashini yazin");
                    age = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("department adini yazin");
                    departmentname = Console.ReadLine();
                    Console.WriteLine("ishcinin maashini yazin");
                    salary = Convert.ToInt32(Console.ReadLine());

                    Employee employee = new Employee(name, surname, age, departmentname, salary);
                    department.AddEmployee(employee);


                }

                if (select == "2")
                {
                    department.ShowEmployeeInfo();
                }

                if (select == "3")
                {
                    Console.WriteLine("ishcinin min maashini yazin");
                    minsalary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ishcinin max maashi yazin");
                    maxsalary = Convert.ToInt32(Console.ReadLine());
                    department.GetAllEmployeesBySalary(minsalary, maxsalary);
                }

                if (select == "0")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("seciminiz yanlishdir");
                }

            }while(true);


        }
            }

    public class Employee : Department
    {

        public Employee() 
        {
                        
        }

        public Employee (string name, string surname, byte age, string departmentName, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentName = departmentName;
            Salary = salary;
        }


        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public int Salary;

    }


    public class Department
    {
        Employee[] employees = new Employee[] { };



        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
        }



        public void ShowEmployeeInfo()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i].Name + " " + employees[i].Surname + " " + employees[i].Age + " " + employees[i].DepartmentName + " " + employees[i].Salary);
            }

        }

        public Employee[] GetAllEmployees()
        {
          return employees;
        }

        public void GetAllEmployeesBySalary(int minSalary, int maxSalary)
        {
            for (int i = 0; i < employees.Length; i++)
            {


                if (employees[i].Salary >= minSalary && employees[i].Salary <= maxSalary)
                {
                    Console.WriteLine(employees[i].Name + " " + employees[i].Surname + " " + employees[i].Age + " " + employees[i].DepartmentName + " " + employees[i].Salary);
                }
            }
        }






    } 


}