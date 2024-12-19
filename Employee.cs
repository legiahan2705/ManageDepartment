using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Employee
    {
        [Key, Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string Lastname { get; set; }

        [StringLength(20)]
        public string Firstname { get; set; }

        [Required]
        public int DeptId { get; set; }

        public virtual Department Department { get; set; }

}

