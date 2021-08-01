using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Demo.Models
{
    public class Teacher
    {
        [Key]
        [Column(TypeName = "nvarchar(4)")]
        public string Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(3)")]
        public string Gender { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Addresss { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Phone { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Salary { get; set; }
    }
}
