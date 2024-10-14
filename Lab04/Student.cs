namespace Lab04
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentID { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        public decimal AverageScore { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        public int? FacultyID { get; set; }

        public virtual Faculty Faculty { get; set; }
    }
}
