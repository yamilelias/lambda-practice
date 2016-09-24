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
                //1. Listar todos los empleados cuyo departamento tenga una sede en Chihuahua
               

                //2. Listar todos los departamentos y el numero de empleados que pertenezcan a cada departamento.
               

                //3. Listar todos los empleados remotos. Estos son los empleados cuya ciudad no se encuentre entre las sedes de su departamento.
             

                //4. Listar todos los empleados cuyo aniversario de contratación sea el próximo mes.
              

                //Listar los 12 meses del año y el numero de empleados contratados por cada mes.
              

            }


            Console.Read();
        }
    }
}
