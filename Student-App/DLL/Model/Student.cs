using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLL.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Email { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
        public DateTime CreatedDate { get; internal set; }
    }
}