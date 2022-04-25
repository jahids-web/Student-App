using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLL.Model
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string Code { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
        public DateTime CreatedDate { get; internal set; }
    }
}
