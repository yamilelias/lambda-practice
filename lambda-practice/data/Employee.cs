using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamda_practice.Data
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime HireDate { get; set; }
        
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }


        public int CityId {get;set;}

        [ForeignKey("CityId")]
        public virtual City City { get; set; }
    }
}
