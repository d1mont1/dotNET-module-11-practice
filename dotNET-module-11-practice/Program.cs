using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace dotNET_module_11_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1;
            emp1.Name = "Dinmukhammed Omirzak";
            emp1.Vacancy = Vacancies.Manager;
            emp1.HireDate = new int[] { 2023, 11, 16 };
            emp1.Salary = 50000;

            Console.WriteLine(emp1.ToString());
        }
    }
}
