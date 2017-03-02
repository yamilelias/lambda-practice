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

                //1. Listar todos los empleados cuyo departamento tenga una sede en Chihuahua
                // var emps = ctx.Employees.Where(e => e.FirstName == "Juan").ToList();
                var chihuahua_employees = ctx.Employees.Where(e => e.City.Id.Equals(1)).ToList();

                Console.WriteLine(chihuahua_employees);

                //2. Listar todos los departamentos y el numero de empleados que pertenezcan a cada departamento.


                //3. Listar todos los empleados remotos. Estos son los empleados cuya ciudad no se encuentre entre las sedes de su departamento.


                //4. Listar todos los empleados cuyo aniversario de contratación sea el próximo mes.


                //Listar los 12 meses del año y el numero de empleados contratados por cada mes.


            }


            Console.Read();
        }
    }
}
