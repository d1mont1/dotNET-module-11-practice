using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public struct Employee
    {
        public string Name;       // Поле для имени сотрудника
        public Vacancies Vacancy; // Поле для должности
        public int[] HireDate;    // Поле для даты приема на работу (год, месяц, день)
        public int Salary;        // Поле для зарплаты

        // Метод для вывода информации о сотруднике
        public override string ToString()
        {
            return $"Name: {Name}, Vacancy: {Vacancy}, Hire Date: {string.Join("-", HireDate)}, Salary: {Salary}";
        }
    }
}
