using lamda_practice.Data;
using System;
using System.Globalization;
using System.Linq;

namespace lambda_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new DatabaseContext())
            {
                var employees = ctx.Employees.ToList();

                foreach (var employee in employees)
                {
                    Console.WriteLine(employee.FirstName);
                }

                Console.WriteLine("===============================================");
                //1. Listar todos los empleados cuyo departamento tenga una sede en Chihuahua
                // var emps = ctx.Employees.Where(e => e.FirstName == "Juan").ToList();
                var chihuahua_employees = ctx.Employees.Where(e => e.City.Id.Equals(1)).ToList();

                foreach(var employee in chihuahua_employees)
                {
                    Console.WriteLine(employee.FirstName);
                }

                Console.WriteLine("===============================================");
                //2. Listar todos los departamentos y el numero de empleados que pertenezcan a cada departamento.
                var departments = ctx.Departments.ToList();

                foreach (var department in departments)
                {
                    // Get employees from that department
                    var department_employees = ctx.Employees.Where(e => e.DepartmentId.Equals(department.Id));
                    Console.WriteLine($"Department {department.Name} has a total of {department_employees.Count()} employees in the department.");
                }

                //3. Listar todos los empleados remotos. Estos son los empleados cuya ciudad no se encuentre entre las sedes de su departamento.


                //4. Listar todos los empleados cuyo aniversario de contratación sea el próximo mes.


                //Listar los 12 meses del año y el numero de empleados contratados por cada mes.


            }


            Console.Read();
        }
    }
}
